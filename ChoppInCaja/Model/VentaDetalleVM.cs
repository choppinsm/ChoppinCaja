using System;

namespace ChoppInCaja.Model
{
    public class VentaDetalleVM
    {
		public int IdVentaDetalle { get; set; }
		public int IdVenta { get; set; }
		public int Cantidad { get; set; }
		public int IdProducto { get; set; }
        public string Producto { get; set; }
        public decimal Precio { get; set; }
        public decimal Diferencia { get; set; }
		public Equipo? AplicaDiferencia { get; set; }
		public string Motivo { get; set; }
		public DateTime Fecha { get; set; }
		public decimal PxC => Precio * Cantidad;
		public decimal Importe => PxC + Diferencia;
	}
}
