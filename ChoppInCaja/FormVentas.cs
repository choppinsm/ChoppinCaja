using ChoppInCaja.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace ChoppInCaja
{
	public partial class FormVentas : Form
	{
		public FormVentas(List<Mesa> mesas, List<Producto> productos)
		{
            refrescarMesas();
            this.productos = productos;
			InitializeComponent();

			CboVentas.ValueMember = "IdVenta";
			CboVentas.DisplayMember = "IdVenta";
			RefrescarCboVentas();
			CboVentas.SelectedItem = null;
			CboVentas.Text = "";

			GridMesas.AutoGenerateColumns = false;
			var columns = GridMesas.Columns;
			var column = new DataGridViewTextBoxColumn();
			column.HeaderText = column.Name = "Id";
			column.DataPropertyName = "IdMesa";
			column.ReadOnly = true;
			column.Width = 50;
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            columns.Add(column);
			column = new DataGridViewTextBoxColumn();
			column.HeaderText = column.Name = "Mesa";
			column.DataPropertyName = "Nombre";
			column.ReadOnly = true;
			column.Width = 150;
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            columns.Add(column);

			gridMesaDetalle.AutoGenerateColumns = false;
			gridMesaDetalle.EnableHeadersVisualStyles = false;
			columns = gridMesaDetalle.Columns;
			column = new DataGridViewTextBoxColumn();
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
			cmb.DataSource = productos;
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
            cmb.DataPropertyName = "IdProducto";
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
            ActualizarMesas();
		}

        private void ActualizarMesas()
        {   
            var margen = new Size(10, 10); // Margen entre mesas
            var location = new Point(margen);// Posicion de la mesa

            foreach (var mesa in mesas)
            {
                var btn = new Button();
                btn.Name = $"btnMesa{mesa.IdMesa}";
                btn.Tag = mesa.IdMesa;
                btn.Click += BtnMesa_Click;
                btn.Font = new Font("Consolas", 18, FontStyle.Bold);
                btn.Text = mesa.Nombre;
                btn.AutoSize = true;
                btn.Location = location;
                btn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                Controls.Add(btn);
                location.X += btn.Size.Width;
                if(location.X + margen.Width * 3 > Width)
                {
                    location.X = margen.Width;
                    location.Y += margen.Height + btn.Height;
                }
            }
        }

        private void BtnMesa_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, ((Button)sender).Tag.ToString());
        }

        private int ultimaIdMesaSeleccionada = -1;
		private List<MesaVM> mesas;
		private List<Producto> productos;

		private void GridMesas_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			var mesa = (MesaVM)GridMesas.Rows[e.RowIndex].DataBoundItem;
			if (mesa.IdMesa == ultimaIdMesaSeleccionada)
			{
				return;
			}
            ultimaIdMesaSeleccionada = mesa.IdMesa;
			using (var context = new ChoppinEntities())
			{
				var ventaAbierta = (from venta in context.Ventas
									where venta.IdMesa == mesa.IdMesa && venta.Cierre == null
									select venta
								   ).FirstOrDefault();
				if (ventaAbierta == null)
				{
                    btnAbrirCerrarMesa.Text = "Abrir mesa";
                    btnAbrirCerrarMesa.Tag = true;
                    OcultarDetalle();
                }
				else
				{
                    RefrescarVenta(ventaAbierta.IdVenta, true);
				}
			}
            btnAbrirCerrarMesa.Visible = true;
        }

        private void RefrescarVenta(int idVenta, bool agregarItem)
		{
			lblEstado.Text = $"IdVenta = {idVenta}";
			using (var context = new ChoppinEntities())
			{
				var venta = from item in context.VentasDetalles
							where item.IdVenta == idVenta
							select new VentaDetalleVM
							{
								IdVentaDetalle = item.IdVentaDetalle,
								IdVenta = item.IdVenta,
								IdProducto = item.IdProducto,
								Precio = item.Precio,
								Cantidad = item.Cantidad,
								Diferencia = item.Diferencia,
								AplicaDiferencia = (Equipo?)item.DiferenciaIdAplica,
								Motivo = item.DiferenciaMotivo,
								Fecha = item.Fecha
							};
				var registros = venta.ToList();
                if (agregarItem)
                {
                    registros.Add(NuevoItem(idVenta));
                }
                gridMesaDetalle.AutoGenerateColumns = false;

                gridMesaDetalle.DataSource = registros;
				MostrarDetalle();

                var selectedRows = GridMesas.SelectedRows;
                btnAbrirCerrarMesa.Text = "Cerrar mesa";
                btnAbrirCerrarMesa.Tag = false;
            }
        }

		private static VentaDetalleVM NuevoItem(int idVenta)
		{
			return new VentaDetalleVM
			{
				IdVenta = idVenta,
				Cantidad = 0,
				IdProducto = 0,
				Diferencia = 0,
				Precio = 0,
				Fecha = DateTime.Now
			};
		}

		private void ConsultaAbrirMesa(int idMesa)
		{
            var confirmResult = MessageBox.Show(this, "¿Abrir la mesa?", "Confirm Delete!!", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                var ventaAbierta = new Venta
                {
                    Apertura = DateTime.Now,
                    IdMesa = idMesa
                };
                AgregarVenta(ventaAbierta);
                GridMesas.Rows[GridMesas.SelectedRows[0].Index].DefaultCellStyle.BackColor = Color.Yellow;
            }
        }

        private void AgregarVenta(VentaDetalleVM ventaVM)
        {
            var venta = new Venta
            {
                IdMesa = ultimaIdMesaSeleccionada,
                Apertura = ventaVM.Fecha
            };
            AgregarVenta(venta);
            ventaVM.IdVenta = venta.IdVenta;
        }

        private void AgregarVenta(Venta venta)
        {
            using (var context = new ChoppinEntities())
            {
                context.Ventas.Add(venta);
                context.SaveChanges();
                RefrescarCboVentas();
                CboVentas.SelectedItem = null;
                CboVentas.Text = "";
            }
            RefrescarVenta(venta.IdVenta, true);
        }

        private void ActualizarVentaDetalle(VentaDetalleVM ventaVM)
        {
            using (var context = new ChoppinEntities())
            {
                var ventaDetalle = ventaVM.IdVentaDetalle > 0
                    ? context.VentasDetalles.Single(v => v.IdVentaDetalle == ventaVM.IdVentaDetalle)
                    : context.VentasDetalles.Add(new VentaDetalle
                    {
                        IdVenta = ventaVM.IdVenta,
                        IdProducto = ventaVM.IdProducto,
                        Cantidad = ventaVM.Cantidad,
                        Precio = ventaVM.Precio,
                        Diferencia = ventaVM.Diferencia,
                        DiferenciaIdAplica = (int?)ventaVM.AplicaDiferencia,
                        DiferenciaMotivo = ventaVM.Motivo,
                        Fecha = DateTime.Now
                    });
                context.SaveChanges();
            }
        }

        FormPago formPago = new FormPago();
        private void CerrarVenta()
        {
            var items = ((List<VentaDetalleVM>)gridMesaDetalle.DataSource);
            formPago.Total = items.Sum(i => i.Importe);
            formPago.Pagado = false;
            formPago.FormClosing += FormPago_FormClosing;
            formPago.Show(this);
        }

        private void FormPago_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!formPago.Visible)
                return;
            e.Cancel = true;
            formPago.Hide();
            if (formPago.Pagado)
            {
                var idVenta = ((VentaDetalleVM)gridMesaDetalle.Rows[0].DataBoundItem).IdVenta;
                using (var context = new ChoppinEntities())
                {
                    try
                    {
                        context.Database.BeginTransaction();
                        var venta = context.Ventas
                            .Single(v => v.IdVenta == idVenta)
                            .Cierre = DateTime.Now;
                        if (formPago.Efectivo > 0)
                        {
                            context.Pagos.Add(new Pago
                            {
                                IdMedioPago = (int)MediosDePago.Efectivo,
                                IdVenta = ((VentaDetalleVM)gridMesaDetalle.Rows[0].DataBoundItem).IdVenta,
                                Importe = formPago.Efectivo
                            });
                        }
                        if (formPago.Tarjeta > 0)
                        {
                            context.Pagos.Add(new Pago
                            {
                                IdMedioPago = (int)MediosDePago.Tarjeta,
                                IdVenta = ((VentaDetalleVM)gridMesaDetalle.Rows[0].DataBoundItem).IdVenta,
                                Importe = formPago.Tarjeta
                            });
                        }
                        context.SaveChanges();
                        RefrescarCboVentas();
                        OcultarDetalle();
                        GridMesas.ClearSelection();
                        btnAbrirCerrarMesa.Visible = false;
                        ultimaIdMesaSeleccionada = -1;
                        context.Database.CurrentTransaction.Commit();
                    }
                    catch {
                        context.Database.CurrentTransaction.Rollback();
                    }
                }
            }
        }

        private void OcultarDetalle()
		{
			gridMesaDetalle.Hide();
			lblEstado.Text = "";
			lblTotal.Text = "$";
		}

		private void MostrarDetalle()
		{
			gridMesaDetalle.Show();
			RefrescarDetalle();
            gridMesaDetalle.Enabled = ultimaIdMesaSeleccionada > 0;
		}

		private void gridMesaDetalle_DataError(object sender, DataGridViewDataErrorEventArgs e)
		{

		}

		private void gridMesaDetalle_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
		{
			if (gridMesaDetalle.CurrentCell.ColumnIndex == 2)
			{
				var cmbox = e.Control as DataGridViewComboBoxEditingControl;
				try {
					cmbox.SelectedValueChanged -= GridMesaDetalle_CboProducto_SelectedValueChanged;
				}
				catch { }
				try {
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
			var producto = productos[idxProducto];
			var idxItem = gridMesaDetalle.SelectedCells[0].RowIndex;
            var item = ((VentaDetalleVM)gridMesaDetalle.Rows[idxItem].DataBoundItem);
            item.Precio = producto.Precio;
            //var idMesa = ((List<MesaVM>)GridMesas.DataSource)[GridMesas.SelectedRows[0].Index].IdMesa;
            //AgregarVenta(idMesa);
		}

		private void gridMesaDetalle_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{

        }

        private void RefrescarDetalle()
		{
			gridMesaDetalle.Refresh();
			var items = ((List<VentaDetalleVM>)gridMesaDetalle.DataSource);
            lblTotal.Text = items.Any()
                    ? items.Sum(i => i.Importe).ToString("C2", new CultureInfo("es-AR"))
                    : "";
			lblEstado.Text = items.Any()
                    ? $"IdVenta:{items[0].IdVenta}, diferencia: {items.Sum(i => i.Diferencia).ToString("C2", new CultureInfo("es-AR"))}"
                    : "";
        }

		private void GridMesas_DataError(object sender, DataGridViewDataErrorEventArgs e)
		{

		}

		private void btnAbrirCerrarMesa_Click(object sender, EventArgs e)
        {
            if ((bool)btnAbrirCerrarMesa.Tag)
            {
                ConsultaAbrirMesa(ultimaIdMesaSeleccionada);
            }
            else
            {
                CerrarVenta();
            }
        }
        
        private void RefrescarCboVentas()
		{
            using (var context = new ChoppinEntities())
			{
				var ventas = context.Ventas.ToList();
				ventas.Insert(0, new Venta
				{
					IdVenta = 0
				});
				CboVentas.DataSource = ventas.ToList();
				RefrescarVenta(0, false);
			}
		}

		private void CboVentas_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (CboVentas.SelectedItem != null)
			{
                btnAbrirCerrarMesa.Visible = false;
                var venta = (Venta)CboVentas.SelectedItem;
                var idVenta = venta.IdVenta;
                if(venta.Cierre != null)
                {
                    ultimaIdMesaSeleccionada = -1;
                    GridMesas.ClearSelection();
                    btnAbrirCerrarMesa.Visible = false;
                }
                RefrescarVenta(idVenta, false);
				MostrarDetalle();
            }
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
            ActualizarMesas();
            this.productos = Program.Productos;
        }

        private void refrescarMesas()
        {
            using (var context = new ChoppinEntities())
            {
                mesas = (from m in context.Mesas
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
        }

        private void BtnCerrarCaja_Click(object sender, EventArgs e)
        {
            new FormCaja().Show();
        }

        private void GridMesas_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (mesas[e.RowIndex].IdVenta > 0)
            {
                GridMesas.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
            }
        }

        private void gridMesaDetalle_DataSourceChanged(object sender, EventArgs e)
        {

        }

        private void gridMesaDetalle_NewRowNeeded(object sender, DataGridViewRowEventArgs e)
        {

        }

        private void gridMesaDetalle_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var ventaVM = ((List<VentaDetalleVM>)gridMesaDetalle.DataSource)[e.RowIndex];
            if (ventaVM.IdVenta == 0)
            {
                AgregarVenta(ventaVM);
            }
            try
            {
                ActualizarVentaDetalle(ventaVM);
                RefrescarVenta(ventaVM.IdVenta, true);
            }
            catch { }
        }
    }
}
