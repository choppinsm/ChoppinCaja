using ChoppInCaja.Model;
using System.Windows.Forms;
using System.Linq;
using System;
using System.Globalization;
using System.Collections.Generic;

namespace ChoppInCaja
{
    public partial class FormProducto : Form
    {
        public FormProducto(VentaDetalleVM item)
        {
            InitializeComponent();
            this.item = item;
            var producto = Program.Productos.Single(p => p.IdProducto == item.IdProducto);
            this.item.Producto = $"{producto.Categoria.Nombre} {producto.Marca.Nombre} {producto.Nombre}";
        }

        public FormProducto(int idVenta, int idProducto)
        {
            InitializeComponent();
            var producto = Program.Productos.Single(p => p.IdProducto == idProducto);
            item = new VentaDetalleVM
            {
                IdVentaDetalle = 0,
                IdVenta = idVenta,
                IdProducto = idProducto,
                Precio = producto.Precio,
                Producto = $"{producto.Categoria.Nombre} {producto.Marca.Nombre} {producto.Nombre}",
                Fecha = DateTime.Now,
                Cantidad = 1,
            };
        }

        private void FormProducto_Load(object sender, EventArgs e)
        {
            BackColor = Estilo.Instance.ColorVentas;
            var equipo = new List<Equipo>((Equipo[])Enum.GetValues(typeof(Equipo)))
                .Select(value => new { Display = value.ToString(), Value = (int?)value })
                .ToList();
            equipo.Insert(0, new { Display = "", Value = (int?)null });
            CboAplica.DisplayMember = "Display";
            CboAplica.ValueMember = "Value";
            CboAplica.DataSource = equipo;
            LblProducto.Text = item.Producto;
            LblPrecio.Text = item.Precio.ToString("C2", new CultureInfo("es-AR"));
            TxtMotivo.Text = item.Motivo;
            CtrCantidad.Value = item.Cantidad;
            CboAplica.SelectedItem = equipo.Single(p => p.Value.Equals((int?)item.AplicaDiferencia));
            CtrDiferencia.Value = item.Diferencia;
            CtrDiferencia.Focus();
        }

        private VentaDetalleVM item;
        public VentaDetalleVM Item { get; private set; } = null;

        private void ActualizarItem()
        {
            item.Motivo = TxtMotivo.Text;
            item.Cantidad = (int)CtrCantidad.Value;
            if (CboAplica.SelectedValue != null)
            {
                item.AplicaDiferencia = (Equipo)CboAplica.SelectedValue;
            }
            else
            {
                item.AplicaDiferencia = null;

            }
            item.Diferencia = CtrDiferencia.Value;
            LblImporte.Text = item.Importe.ToString("C2", new CultureInfo("es-AR"));
        }

        private void BtnAceptar_Click(object sender, System.EventArgs e)
        {
            ActualizarItem();
            Item = item;
            try
            {
                this.Close();
            }
            catch{ }
        }

        private void BtnCancel_Click(object sender, System.EventArgs e)
        {
            Item = null;
            try
            {
                this.Close();
            }
            catch { }
        }

        private void CboAplica_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboAplica.SelectedValue != null)
            {
                TxtMotivo.Text = "Motivo de la diferencia";
                CtrDiferencia.Value = 999;
                TxtMotivo.Visible = CtrDiferencia.Visible = true;
                TxtMotivo.SelectAll();
                TxtMotivo.Focus();
            }
            else
            {
                TxtMotivo.Visible = CtrDiferencia.Visible = false;
            }
        }
    }
}
