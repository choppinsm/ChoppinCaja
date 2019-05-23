using System;

namespace ChoppInCaja.Model
{
    public class _VentaVM
    {
        public int IdVenta { get; set; }
        public MesaVM Mesa { get; set; }
        public DateTime Apertura { get; set; }
        public DateTime Cierre { get; set; }
    }
}
