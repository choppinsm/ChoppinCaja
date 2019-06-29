using ChoppInCaja.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChoppInCaja
{
    public partial class FormCaja : Form
    {
        public FormCaja()
        {
            InitializeComponent();
        }

        private void BtnCerrarCaja_Click(object sender, EventArgs e)
        {
            using (var context = new ChoppinEntities())
            {
                context.CajasCerradas.Add(new CajaCerrada
                {
                    IdVenta = context.Ventas.Max(v => v.IdVenta)
                });
                context.SaveChanges();
            }
            MessageBox.Show(this, "Caja cerrada");
            Close();
        }

        private void FormCaja_Shown(object sender, EventArgs e)
        {
            LblEfectivo.Text = "Efectivo: ";
            LblTarjeta.Text = "Tarjeta: ";
            LblTotal.Text = "Total: ";
            using (var context = new ChoppinEntities())
            {
                var idVentaDesdeNoInclusive = context.CajasCerradas.Max(v => v.IdVenta);
                var pagos = (from p in context.Pagos
                             where p.IdVenta > idVentaDesdeNoInclusive
                             group p.Importe by p.IdMedioPago into gp
                             select new {
                                 Medio = (MediosDePago)gp.Key,
                                 SubTotal = gp.Sum(sp => sp)
                             }
                            ).ToList();
                var efectivo = pagos.SingleOrDefault(p => p.Medio == MediosDePago.Efectivo)?.SubTotal ?? 0;
                var tarjeta = pagos.SingleOrDefault(p => p.Medio == MediosDePago.Tarjeta)?.SubTotal ?? 0;
                var total = efectivo + tarjeta;
                if(total == 0)
                {
                    MessageBox.Show(this, "Para cerrar la caja primero se debe cobrar algo");
                    Close();
                    return;
                }
                //Controla el total de pagos sea igual al total de ventas detalle
                var controlVentasDetalle = (from v in context.VentasDetalles
                                            where v.IdVenta > idVentaDesdeNoInclusive
                                            select v.Precio * v.Cantidad + v.Diferencia
                                            ).Sum(i => i);
                if (total != controlVentasDetalle)
                {
                    MessageBox.Show(this, "Para cerrar la caja todas las mesas deben estar pagas");
                    Close();
                }
                LblEfectivo.Text += efectivo.ToString("C2", new CultureInfo("es-AR"));
                LblTarjeta.Text += tarjeta.ToString("C2", new CultureInfo("es-AR"));
                LblTotal.Text += total.ToString("C2", new CultureInfo("es-AR"));
                if(total == 0)
                {
                    BtnCerrarCaja.Visible = false;
                }
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
