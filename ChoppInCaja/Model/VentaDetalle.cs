namespace ChoppInCaja.Model
{
    public class VentaDetalle
    {
        public int IdVenta { get; set; }
        public int IdProducto { get; set; }
        public string Producto { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }
        public double Diferencia { get; set; }
        public Equipo Autoriza { get; set; }
        public string Motivo { get; set; }
    }
}
