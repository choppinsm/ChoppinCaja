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
                context.CajasCerradas.Add(new CajasCerradas
                {
                    IdVenta = context.Ventas.Max(v => v.IdVenta)
                });
                context.SaveChanges();
            }
        }

        private void FormCaja_Shown(object sender, EventArgs e)
        {
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
                LblEfectivo.Text = efectivo.ToString("C2", new CultureInfo("es-AR"));
                LblTarjeta.Text = tarjeta.ToString("C2", new CultureInfo("es-AR"));
                LblTotal.Text = total.ToString("C2", new CultureInfo("es-AR"));
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
