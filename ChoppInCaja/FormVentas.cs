using ChoppInCaja.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ChoppInCaja
{
    public partial class FormVentas : Form
    {
        private List<MesaVM> mesasVM = null;
        private List<ProductoVM> productosVM;
        private SelectablePanel LstProductos = new SelectablePanel();
        private int GetProductosPorFila => LstProductos.Width / (Estilo.Instance.ProductoAncho + Estilo.Instance.MargenProductoAncho);
        private MesaVM MesaSeleccionada
        {
            get
            {
                return mesasVM.SingleOrDefault(m => m.EstaSeleccionada);
            }
            set
            {
                if (MesaSeleccionada != null)
                {
                    MesaSeleccionada.EstaSeleccionada = false;
                }
                if (value != null)
                {
                    value.EstaSeleccionada = true;
                }
            }
        }

        public FormVentas()
        {
            refrescarMesas();
            refrescarProductos();
            InitializeComponent();
            Controls.Add(LstProductos);
            LstProductos.PreviewKeyDown += LstProductos_PreviewKeyDown;

            this.BackColor = Estilo.Instance.ColorVentas;

            gridMesaDetalle.Visible = false;
            gridMesaDetalle.AutoGenerateColumns = false;
            gridMesaDetalle.EnableHeadersVisualStyles = false;
            var columns = gridMesaDetalle.Columns;
            var column = new DataGridViewTextBoxColumn();
            column.HeaderText = column.Name = "Id";
            column.DataPropertyName = "IdVentaDetalle";
            column.ReadOnly = true;
            column.Width = 50;
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.HeaderText = column.Name = "Cant";
            column.DataPropertyName = "Cantidad";
            column.ValueType = typeof(int);
            column.Width = 100;
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            columns.Add(column);

            var cmb = new DataGridViewComboBoxColumn();
            cmb.HeaderText = "Producto";
            cmb.ValueMember = "IdProducto";
            cmb.DisplayMember = "Nombre";
            cmb.DataPropertyName = "IdProducto";
            cmb.MaxDropDownItems = 5;
            cmb.DataSource = productosVM;
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            columns.Add(cmb);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = column.HeaderText = column.Name = "Importe";
            column.ValueType = typeof(decimal);
            column.DefaultCellStyle.Format = "C2";
            column.DefaultCellStyle.FormatProvider = new CultureInfo("es-AR");
            column.ReadOnly = true;
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = column.HeaderText = column.Name = "Precio";
            column.ValueType = typeof(decimal);
            column.DefaultCellStyle.Format = "C2";
            column.DefaultCellStyle.FormatProvider = new CultureInfo("es-AR");
            column.ReadOnly = true;
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = column.HeaderText = column.Name = "PxC";
            column.ValueType = typeof(decimal);
            column.DefaultCellStyle.Format = "C2";
            column.DefaultCellStyle.FormatProvider = new CultureInfo("es-AR");
            column.ReadOnly = true;
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = column.HeaderText = column.Name = "Diferencia";
            column.ValueType = typeof(decimal);
            column.DefaultCellStyle.Format = "C2";
            column.DefaultCellStyle.FormatProvider = new CultureInfo("es-AR");
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            columns.Add(column);


            cmb = new DataGridViewComboBoxColumn();
            cmb.HeaderText = "AplicaDiferencia";
            cmb.ValueMember = "Value";
            cmb.DisplayMember = "Display";
            cmb.DataPropertyName = "AplicaDiferencia";
            cmb.DataSource = new List<Equipo>((Equipo[])Enum.GetValues(typeof(Equipo)))
                .Select(value => new { Display = value.ToString(), Value = (int)value })
                .ToList();
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            columns.Add(cmb);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = column.HeaderText = column.Name = "Motivo";
            column.ValueType = typeof(decimal);
            column.DefaultCellStyle.Format = "C2";
            column.DefaultCellStyle.FormatProvider = new CultureInfo("es-AR");
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            column.Width = 150;
            columns.Add(column);
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            AcomodarControles();
        }
        private void FormVentas_SizeChanged(object sender, EventArgs e)
        {
            ActualizarProductos();
        }
        
        private void ImgProducto_Click(object sender, EventArgs e)
        {
            LstProductos.Focus();
            var productoSeleccionado = LstProductos.Controls.Cast<Control>()
                .Select(c => (ProductoVM)c.Tag)
                .SingleOrDefault(p => p.EstaSeleccionado);
            if (productoSeleccionado != null)
            {
                productoSeleccionado.EstaSeleccionado = false;
            }
            ((ProductoVM)((PictureBox)sender).Tag).EstaSeleccionado = true;
            LstProductos.Update();
            LstProductos.Refresh();
        }
        private void ImgProducto_Paint(object sender, PaintEventArgs e)
        {
            var imgProducto = (PictureBox)sender;
            var producto = (ProductoVM)imgProducto.Tag;
            if (imgProducto.Image == null && (imgProducto.ImageLocation?.Length ?? 0) == 0)
            {
                e.Graphics.Clear(Estilo.Instance.ColorProductoFondo);
                using (Font myFont = new Font(Estilo.Instance.FuenteProductoLetra, Estilo.Instance.TamañoProductoLetra))
                {
                    e.Graphics.DrawString($"{producto.Categoria}", myFont, Estilo.Instance.ColorProductoLetra, new Point(5, 5));
                    e.Graphics.DrawString($"{producto.Marca}", myFont, Estilo.Instance.ColorProductoLetra, new Point(5, myFont.Height + 10));
                    var nombre1 = producto.Nombre.Trim();
                    var nomMax = Estilo.Instance.ProductoLargoNombreMaximo;
                    nombre1 = nombre1.Substring(0, nombre1.Length > nomMax ? nomMax : nombre1.Length);
                    var nombre2 = producto.Nombre.Length > nomMax
                            ? producto.Nombre.Substring(nomMax).Trim()
                            : "";
                    e.Graphics.DrawString($"{nombre1}", myFont, Estilo.Instance.ColorProductoLetra, new Point(5, myFont.Height * 2 + 15));
                    e.Graphics.DrawString($"{nombre2}", myFont, Estilo.Instance.ColorProductoLetra, new Point(5, myFont.Height * 3 + 20));
                    //imgProducto.BorderStyle = BorderStyle.FixedSingle;
                }
            }
            if (producto.EstaSeleccionado)
            {
                e.Graphics.DrawRectangle(new Pen(Estilo.Instance.ColorProductoBorde, 5), new Rectangle(Estilo.Instance.ProductoBordeAncho / 2, Estilo.Instance.ProductoBordeAncho / 2, imgProducto.Size.Width - Estilo.Instance.ProductoBordeAncho, imgProducto.Size.Height - Estilo.Instance.ProductoBordeAncho));
            }
        }
        private void BtnMesa_Click(object sender, EventArgs e)
        {
            SeleccionarMesaPorBoton(sender);
        }
        private void Btn_GotFocus(object sender, EventArgs e)
        {
            SeleccionarMesaPorBoton(sender);
        }
        private void BtnABM_Click(object sender, EventArgs e)
        {
            Program.ActualizarTablas();
            var formABM = new FormABM(Program.Tablas);
            formABM.FormClosed += FormABM_FormClosed;
            formABM.Show(this);
        }
        private void FormABM_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.ActualizarTablas();
            refrescarMesas();
            AcomodarControles();
            refrescarProductos();
        }
        private void TxtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = e.KeyChar.ToString().ToUpper()[0];
        }
        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {

            ActualizarProductos();
        }
        private void LstProductos_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (new[] { Keys.Enter, Keys.Up, Keys.Down, Keys.Left, Keys.Right }.Contains(e.KeyCode))
            {
                MoverSeleccionarProducto(e.KeyCode);
            }
        }
        private void gridMesaDetalle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridMesaDetalle.SelectedRows.Count > 0)
            {
                var item = (VentaDetalleVM)gridMesaDetalle.SelectedRows[0].DataBoundItem;
                var formProducto = new FormProducto(item);
                formProducto.FormClosing += FormProducto_FormClosing;
                formProducto.ShowDialog(this);
            }
        }
        private void FormProducto_FormClosing(object sender, FormClosingEventArgs e)
        {
            var formProducto = (FormProducto)sender;
            if (formProducto.Item != null)
            {
                if (formProducto.Item.IdVentaDetalle == 0)
                {
                    Manager.Instance.AgregarItem(formProducto.Item);
                }
                else
                {
                    Manager.Instance.ActualizarItem(formProducto.Item);
                }
                ActualizarVenta();
            }
        }
        private void gridMesaDetalle_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void refrescarMesas()
        {
            using (var context = new ChoppinEntities())
            {
                if (mesasVM == null)
                {
                    mesasVM = (from m in context.Mesas
                                   join v in context.Ventas.Where(v => v.Cierre == null)
                                   on m.IdMesa equals v.IdMesa into mv
                                   from mesaVenta in mv.DefaultIfEmpty()
                                   select new MesaVM
                                   {
                                       IdMesa = m.IdMesa,
                                       Nombre = m.Nombre,
                                       MesaVenta = mesaVenta
                                   }
                            ).ToList();
                }
                else
                {
                    foreach (var mesa in mesasVM)
                    {
                        mesa.MesaVenta = context.Ventas.SingleOrDefault(v => v.IdMesa == mesa.IdMesa && v.Cierre == null);

                    }
                }
            }
        }
        private void refrescarProductos()
        {
            productosVM = (from p in Program.Productos
                           select new ProductoVM
                           {
                               IdProducto = p.IdProducto,
                               Nombre = p.Nombre,
                               Categoria = p.Categoria.Nombre,
                               Marca = p.Marca.Nombre,
                               Precio = p.Precio
                           }
                                ).ToList();
        }
        private void SetLocation(Control control, ref Point location, Size margen)
        {
            if (location.X + margen.Width + control.Size.Width > control.Parent.Width)
            {
                location.X = margen.Width;
                location.Y += margen.Height + control.Height;
            }
            control.Location = location;
            location.X += control.Size.Width + margen.Width;
        }
        private void AcomodarControles()
        {
            var margen = new Size(Estilo.Instance.MargenMesaAncho, Estilo.Instance.MargenMesaAlto);
            var location = new Point(margen);// Posicion de la mesa
            foreach (var mesa in mesasVM)
            {
                var btn = new Button();
                btn.Name = $"btnMesa{mesa.IdMesa}";
                btn.Tag = mesa;
                btn.Click += BtnMesa_Click;
                btn.GotFocus += Btn_GotFocus;
                btn.TabStop = false;
                btn.Font = new Font("Consolas", 14, FontStyle.Bold);
                btn.Text = mesa.Nombre;
                btn.AutoSize = true;
                btn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                btn.FlatStyle = FlatStyle.Flat;

                Controls.Add(btn);
                SetLocation(btn, ref location, margen);
            }
            SetLocation(BtnAbrirCerrarMesa, ref location, margen);
            SetLocation(BtnCerrarCaja, ref location, margen);
            SetLocation(BtnABM, ref location, margen);

            location.X = Width;
            SetLocation(TxtBusqueda, ref location, margen);
            location.Y += margen.Height + TxtBusqueda.Height;
            location.X = margen.Width;
            SetLocation(LstProductos, ref location, margen);
            LstProductos.Height = gridMesaDetalle.Top - margen.Height - LstProductos.Top;
            LstProductos.Width = gridMesaDetalle.Width;
            LstProductos.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            BtnAbrirCerrarMesa.BackColor = Estilo.Instance.ColorAbrirCerrarMesa;
            BtnCerrarCaja.BackColor = Estilo.Instance.ColorCerrarCaja;
            BtnABM.BackColor = Estilo.Instance.ColorABM;
            LblTotal.ForeColor = Estilo.Instance.ColorTotal;
            LblEstado.ForeColor = Estilo.Instance.ColorEstado;
            StatusBar.BackColor = Estilo.Instance.ColorBarraEstado;

            LstProductos.VerticalScroll.Enabled = true;
            LstProductos.HorizontalScroll.Enabled = false;
            LstProductos.AutoScroll = true;
            CrearProductos();
            ActualizarProductos();
            ActualizarMesas();
        }
        private void CrearProductos()
        {
            foreach (var producto in productosVM)
            {
                var imgProducto = new PictureBox();
                imgProducto.Click += ImgProducto_Click;
                imgProducto.Tag = producto;
                imgProducto.BackColor = Estilo.Instance.ColorProductoFondo;
                var rutaImagen = $@"{Application.StartupPath}\Imagenes\Productos\{producto.IdProducto}.jpeg";
                imgProducto.Paint += ImgProducto_Paint;
                if (File.Exists(rutaImagen))
                {
                    imgProducto.ImageLocation = rutaImagen;
                }
                imgProducto.Width = Estilo.Instance.ProductoAncho;
                imgProducto.Height = Estilo.Instance.ProductoAlto;
                imgProducto.SizeMode = PictureBoxSizeMode.Zoom;
                LstProductos.Controls.Add(imgProducto);
            }
        }
        private void ActualizarProductos()
        {
            var margen = new Size(Estilo.Instance.MargenProductoAncho, Estilo.Instance.MargenProductoAlto);
            var location = new Point(margen);// Posicion del producto
            var filtro = TxtBusqueda.Text;
            foreach (Control imgProducto in LstProductos.Controls)
            {
                var producto = (ProductoVM)imgProducto.Tag;

                producto.filtraCategoria = producto.filtraMarca = producto.filtraNombre = filtro.Length == 0;

                if (filtro.Length > 0)
                {
                    producto.filtraCategoria = filtro[0] == producto.Categoria.ToUpper()[0];

                    producto.filtraMarca = producto.Marca.Length == 0 || filtro.Length < 2 || filtro[1] == producto.Marca.ToUpper()[0];

                    producto.filtraNombre = producto.Nombre.Length == 0 ||
                        filtro.Length == 1 ||
                        (filtro.Length == 2 && (producto.Marca.Length > 0 || filtro[1] == producto.Nombre.ToUpper()[0])) ||
                        (filtro.Length == 3 && filtro[2] == producto.Nombre.ToUpper()[0]);
                }
                imgProducto.Visible = producto.Visible = producto.filtraCategoria && producto.filtraMarca && producto.filtraNombre;
                if (imgProducto.Visible)
                {
                    SetLocation(imgProducto, ref location, margen);
                }
            }

            var productos = LstProductos.Controls.Cast<Control>()
                .Select(c => (ProductoVM)c.Tag)
                .ToList();
            var idxSeleccionado = productos.FindIndex(p => p.EstaSeleccionado);
            if (idxSeleccionado < 0 || !productos[idxSeleccionado].Visible)
            {
                if (idxSeleccionado >= 0)
                {
                    productos[idxSeleccionado].EstaSeleccionado = false;
                }
                var productosVisible = LstProductos.Controls.Cast<Control>()
                    .Select(c => (ProductoVM)c.Tag)
                    .Where(p => p.Visible)
                    .FirstOrDefault();
                if (productosVisible != null)
                {
                    productosVisible.EstaSeleccionado = true;
                }
            }
            LstProductos.Refresh();
            LstProductos.Update();
        }
        private void ActualizarMesas()
        {
            foreach (var mesa in mesasVM)
            {
                var btnMesa = (Button)Controls.Cast<Control>()
                    .Single(c => c.Name.StartsWith("btnMesa") && (MesaVM)c.Tag == mesa);
                btnMesa.BackColor = mesa.IdVenta > 0
                    ? Estilo.Instance.ColorMesaAbierta
                    : Estilo.Instance.ColorMesaCerrada;
                if (mesa.Equals(MesaSeleccionada))
                {
                    btnMesa.BackColor = Color.FromArgb(btnMesa.BackColor.A, (int)(btnMesa.BackColor.R * 0.8), (int)(btnMesa.BackColor.G * 0.8), (int)(btnMesa.BackColor.B * 0.8));
                }
            }
            if (MesaSeleccionada != null)
            {
                BtnAbrirCerrarMesa.Text = MesaSeleccionada.IdVenta > 0
                        ? "CERRAR MESA"
                        : "ABRIR MESA";
                LblEstado.Text = $"IdVenta:{MesaSeleccionada.IdVenta}";
            }
            else
            {
                LblEstado.Text = "";
            }
            BtnAbrirCerrarMesa.Visible = MesaSeleccionada != null;
            ActualizarVenta();
        }
        private void ActualizarVenta()
        {
            if (MesaSeleccionada != null && MesaSeleccionada.IdVenta > 0)
            {
                LstProductos.Visible = true;
                TxtBusqueda.SelectAll();
                LblEstado.Text = $"IdVenta = {MesaSeleccionada.IdVenta}";
                var items = Manager.Instance
                    .GetVentaDetalle(MesaSeleccionada.IdVenta)
                    .OrderByDescending(i => i.IdVentaDetalle)
                    .ToArray();
                gridMesaDetalle.AutoGenerateColumns = false;
                gridMesaDetalle.DataSource = items;
                gridMesaDetalle.Show();
                gridMesaDetalle.ClearSelection();
                LblTotal.Text = items.Any()
                        ? items.Sum(i => i.Importe).ToString("C2", new CultureInfo("es-AR"))
                        : "";
                LblEstado.Text = items.Any()
                        ? $"IdVenta:{items[0].IdVenta}, diferencia: {items.Sum(i => i.Diferencia).ToString("C2", new CultureInfo("es-AR"))}"
                        : "";
            }
            else {
                LstProductos.Visible = false;
                LblTotal.Text = "";
                gridMesaDetalle.Hide();
            }
        }
        private void SeleccionarMesaPorBoton(object sender)
        {
            var btnMesa = ((Button)sender);
            var mesa = (MesaVM)btnMesa.Tag;
            if (mesa.Equals(MesaSeleccionada))
            {
                return;
            }
            MesaSeleccionada = mesa;
            ActualizarMesas();
        }
        private void MoverSeleccionarProducto(Keys keyCode)
        {
            if (LstProductos.Controls.Count <= 1)
            {
                return;
            }
            var productosVisibles = LstProductos.Controls.Cast<Control>()
                .Select(c => (ProductoVM)c.Tag)
                .Where(p => p.Visible)
                .ToList();
            var idxSeleccionado = productosVisibles.FindIndex(p => p.EstaSeleccionado);
            var mover = 0;
            switch (keyCode)
            {
                case Keys.Enter:
                    if (MesaSeleccionada != null && MesaSeleccionada.IdVenta > 0)
                    {
                        IniciaAgregarProducto(productosVisibles[idxSeleccionado]);
                    }
                    break;
                case Keys.Left:
                    if (idxSeleccionado > 0)
                    {
                        mover = -1;
                    }
                    break;
                case Keys.Right:
                    if (productosVisibles.Count > idxSeleccionado + 1)
                    {
                        mover = 1;
                    }
                    break;
                case Keys.Up:
                    if (idxSeleccionado - GetProductosPorFila >= 0)
                    {
                        mover = GetProductosPorFila * -1;
                    }
                    break;
                case Keys.Down:
                    if (productosVisibles.Count > idxSeleccionado + GetProductosPorFila)
                    {
                        mover = GetProductosPorFila;
                    }
                    break;
            }
            if (mover != 0)
            {
                productosVisibles[idxSeleccionado].EstaSeleccionado = false;
                productosVisibles[idxSeleccionado + mover].EstaSeleccionado = true;
            }
            LstProductos.Update();
            LstProductos.Refresh();
        }
        private void ConsultaAbrirMesa(MesaVM mesa)
        {
            var confirmResult = MessageBox.Show(this, "¿Abrir la mesa?", "Confirm Delete!!", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                var ventaAbierta = new Venta
                {
                    Apertura = DateTime.Now,
                    IdMesa = mesa.IdMesa
                };
                var idVenta = Manager.Instance.AgregarVenta(ventaAbierta);
                mesa.MesaVenta = Manager.Instance.GetVenta(idVenta);
                ActualizarMesas();
                ActualizarVenta();
            }
        }
        private void IniciaAgregarProducto(ProductoVM productoVM)
        {
            var formProducto = new FormProducto(MesaSeleccionada.IdVenta, productoVM.IdProducto);
            formProducto.FormClosing += FormProducto_FormClosing;
            formProducto.ShowDialog(this);
        }


        /// TRABAJANDO
        private void btnAbrirCerrarMesa_Click(object sender, EventArgs e)
        {
            if (MesaSeleccionada.IdVenta == 0)
            {
                ConsultaAbrirMesa(MesaSeleccionada);
            }
            else
            {
                CerrarVenta();
            }
        }
        private void CerrarVenta()
        {
            var items = ((VentaDetalleVM[])gridMesaDetalle.DataSource);
            var formPago = new FormPago();
            formPago.Total = items.Sum(i => i.Importe);
            formPago.Pagado = false;
            formPago.FormClosing += FormPago_FormClosing;
            formPago.Show(this);
        }

        private void FormPago_FormClosing(object sender, FormClosingEventArgs e)
        {
            var formPago = (FormPago)sender;
            if (formPago.Pagado)
            {
                var efectivo = formPago.Efectivo;
                var tarjeta = formPago.Tarjeta;
                var idVenta = ((VentaDetalleVM)gridMesaDetalle.Rows[0].DataBoundItem).IdVenta;
                Manager.Instance.PagarVenta(idVenta, efectivo, tarjeta);
                refrescarMesas();
                ActualizarMesas();
            }
        }


        private void gridMesaDetalle_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (gridMesaDetalle.CurrentCell.ColumnIndex == 2)
            {
                var cmbox = e.Control as DataGridViewComboBoxEditingControl;
                try
                {
                    cmbox.SelectedValueChanged -= GridMesaDetalle_CboProducto_SelectedValueChanged;
                }
                catch { }
                try
                {
                    cmbox.SelectedValueChanged += GridMesaDetalle_CboProducto_SelectedValueChanged;
                }
                catch { }
                cmbox.DropDownStyle = ComboBoxStyle.DropDown;
                cmbox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            }
        }
        private void GridMesaDetalle_CboProducto_SelectedValueChanged(object sender, EventArgs e)
        {
            var idxProducto = ((DataGridViewComboBoxEditingControl)sender).SelectedIndex;
            if (idxProducto < 0)
                return;
            var producto = productosVM[idxProducto];
            var idxItem = gridMesaDetalle.SelectedCells[0].RowIndex;
            var item = ((VentaDetalleVM)gridMesaDetalle.Rows[idxItem].DataBoundItem);
            item.Precio = producto.Precio;
            //var idMesa = ((List<MesaVM>)GridMesas.DataSource)[GridMesas.SelectedRows[0].Index].IdMesa;
            //AgregarVenta(idMesa);
        }
        

        private void BtnCerrarCaja_Click(object sender, EventArgs e)
        {
            new FormCaja().Show();
        }
    }
}
