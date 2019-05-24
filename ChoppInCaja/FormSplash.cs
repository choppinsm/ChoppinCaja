using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChoppInCaja
{
	public partial class FormSplash : Form
	{
		public List<Mesa> Mesas { get; private set; }
		public List<Producto> Productos { get; private set; }
		public List<string> Tablas { get; private set; }
		public bool IrABM { get; internal set; }

		public FormSplash()
		{
			InitializeComponent();
		}

		private void Splash_Shown(object sender, EventArgs e)
		{
			Application.DoEvents();
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
			Application.DoEvents();
			Close();
		}

		private void FormSplash_KeyDown(object sender, KeyEventArgs e)
		{
			IrABM |= e.KeyCode == Keys.F12;
		}
	}
}
