//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ChoppInCaja
{
    using System;
    using System.Collections.Generic;
    
    public partial class Venta
    {
        public int IdVenta { get; set; }
        public int IdMesa { get; set; }
        public System.DateTime Apertura { get; set; }
        public Nullable<System.DateTime> Cierre { get; set; }
    
        public virtual Mesa Mesa { get; set; }
        public virtual VentasDetalle VentasDetalle { get; set; }
    }
}
