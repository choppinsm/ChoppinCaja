using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoppInCaja.Model
{
    public class ProductoVM
    {
        public int IdProducto { get; set; }
        public string Categoria { get; set; }
        public string Marca { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public bool EstaSeleccionado { get; set; }
        public bool Visible { get; set; }
        public bool filtraCategoria { get; set; }
        public bool filtraMarca { get; set; }
        public bool filtraNombre { get; set; }
    }
}
