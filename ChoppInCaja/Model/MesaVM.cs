﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoppInCaja.Model
{
    public class MesaVM
    {
        public int IdMesa { get; set; }
        public string Nombre { get; set; }
        public int IdVenta => MesaVenta?.IdVenta ?? 0;
        public Venta MesaVenta;
        public bool EstaSeleccionada { get; set; }
    }
}
