using ChoppInCaja.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoppInCaja
{
    public class Manager
    {
        private Manager() { }
        private static Manager instance = null;
        public static Manager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Manager();
                }
                return instance;
            }
        }
        public int AgregarVenta(Venta venta)
        {
            using (var context = new ChoppinEntities())
            {
                context.Ventas.Add(venta);
                return context.SaveChanges();
            }
        }

        public List<VentaDetalleVM> GetVentaDetalle(int idVenta)
        {
            using (var context = new ChoppinEntities())
            {
                return (from item in context.VentasDetalles
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
                            }
                            ).ToList();
            }
        }

        public Venta GetVenta(int idVenta)
        {
            using (var context = new ChoppinEntities())
            {
                return context.Ventas.Single(v => v.IdVenta == idVenta);
            }
        }

        public void AgregarItem(VentaDetalleVM item)
        {
            using (var context = new ChoppinEntities())
            {
                context.VentasDetalles.Add(new VentaDetalle
                {
                    IdVenta = item.IdVenta,
                    IdProducto = item.IdProducto,
                    Cantidad = item.Cantidad,
                    Precio = item.Precio,
                    Diferencia = item.Diferencia,
                    DiferenciaIdAplica = (int?)item.AplicaDiferencia,
                    DiferenciaMotivo = item.Motivo,
                    Fecha = DateTime.Now
                });
                context.SaveChanges();
            }
        }

        public void ActualizarItem(VentaDetalleVM item)
        {
            using (var context = new ChoppinEntities())
            {
                var itemActual = context.VentasDetalles
                    .Single(i => i.IdVentaDetalle == item.IdVentaDetalle);

                itemActual.IdProducto = item.IdProducto;
                itemActual.Cantidad = item.Cantidad;
                itemActual.Precio = item.Precio;
                itemActual.Diferencia = item.Diferencia;
                itemActual.DiferenciaIdAplica = (int?)item.AplicaDiferencia;
                itemActual.DiferenciaMotivo = item.Motivo;
                itemActual.Fecha = DateTime.Now;
                context.SaveChanges();
            }
        }

        public void PagarVenta(int idVenta, decimal efectivo, decimal tarjeta)
        {
            using (var context = new ChoppinEntities())
            {
                try
                {
                    context.Database.BeginTransaction();
                    var venta = context.Ventas
                        .Single(v => v.IdVenta == idVenta)
                        .Cierre = DateTime.Now;
                    if (efectivo > 0)
                    {
                        context.Pagos.Add(new Pago
                        {
                            IdMedioPago = (int)MediosDePago.Efectivo,
                            IdVenta = idVenta,
                            Importe = efectivo
                        });
                    }
                    if (tarjeta > 0)
                    {
                        context.Pagos.Add(new Pago
                        {
                            IdMedioPago = (int)MediosDePago.Tarjeta,
                            IdVenta = idVenta,
                            Importe = tarjeta
                        });
                    }
                    context.SaveChanges();
                    context.Database.CurrentTransaction.Commit();
                }
                catch
                {
                    context.Database.CurrentTransaction.Rollback();
                }
            }
        }
    }
}
