using System;

namespace ChoppInCaja.Model
{
    public class Ventas
    {
        public int IdVenta { get; set; }
        public Mesas IdMesa { get; set; }
        public DateTime Apertura { get; set; }
        public DateTime Cierre { get; set; }
    }
}
