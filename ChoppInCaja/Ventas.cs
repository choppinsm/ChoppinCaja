using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChoppInCaja
{
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
            gridMesas.AutoGenerateColumns = true;
            gridMesaDetalle.AutoGenerateColumns = true;
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            using (var context = new ChoppinEntities())
            {
                var mesas = from mesa in context.Mesas
                             select mesa;
                gridMesas.DataSource = mesas.ToList(); ;
            }
        }

        private int ultimaIdMesaSeleccionada = -1;
        private void gridMesas_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            var mesa = (Mesa)gridMesas.Rows[e.RowIndex].DataBoundItem;
            if(mesa.IdMesa == ultimaIdMesaSeleccionada)
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
                    BeginInvoke((Action)(() =>
                    {
                        AgregarVenta(mesa.IdMesa);
                    }));
                }
                else {
                    RefrescarMesa(ventaAbierta.IdVenta);
                }
            }
        }

        private void RefrescarMesa(int idVenta)
        {
            using (var context = new ChoppinEntities())
            {
                var venta = from items in context.VentasDetalles
                            where items.IdVenta == idVenta
                            select items;
                var registros = venta.ToList();
                if(registros.Count == 0)
                {
                    registros.Add(nuevoItem(idVenta));
                }
                gridMesaDetalle.DataSource = registros;
            }
        }

        private static VentasDetalle nuevoItem(int idVenta)
        {
            return new VentasDetalle
            {
                IdVenta = idVenta,
                Cantidad = 1,
                DiferenciaIdAplica = 0,
                Diferencia = 0,
                Precio = 0
            };
        }

        private void AgregarVenta(int idMesa)
        {
            var confirmResult = MessageBox.Show(this, "¿Abrir la mesa?", "Confirm Delete!!", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                var ventaAbierta = new Venta
                {
                    Apertura = DateTime.Now,
                    IdMesa = idMesa
                };
                using (var context = new ChoppinEntities())
                {
                    context.Ventas.Add(ventaAbierta);
                    context.SaveChanges();
                }
                RefrescarMesa(ventaAbierta.IdVenta);
            }
        }

        private void btnAgregarItem_Click(object sender, EventArgs e)
        {
            var idVenta = gridMesaDetalle.DataSource[
                        ((VentasDetalle)gridMesaDetalle[0, 0]).IdVenta)
                    ]
            ((List<VentasDetalle>)gridMesaDetalle.DataSource).Add(nuevoItem(1));
        }
    }
}
