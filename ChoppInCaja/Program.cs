using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ChoppInCaja
{
	static class Program
    {
        static public List<Mesa> Mesas { get; private set; }
        static List<Producto> productos;
        static public List<Producto> Productos { get
            {
                return productos;
            }
            private set
            {
                value.Sort((a, b) => a.Nombre.CompareTo(b.Nombre));
                productos = value;
            }
        }
        static public List<string> Tablas { get; private set; }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			var formSplash = new FormSplash();
			Application.Run(formSplash);
			if(formSplash.IrABM)
			{
				var formABM = new FormABM(Tablas);
				Application.Run(formABM);
			}
			else{
				var formVentas = new FormVentas(Mesas, Productos);
				Application.Run(formVentas);
			}
		}

        static public void ActualizarTablas()
        {
            using (var context = new ChoppinEntities())
            {
                Mesas = (from mesa in context.Mesas
                         select mesa
                        ).ToList();
                Productos = (from producto in context.Productos
                             select producto
                        ).ToList();
                Tablas = context.Database
                            .SqlQuery<string>("select name as Tabla from sys.objects where type = 'U'")
                            .ToList();
            }
        }
    }
}
