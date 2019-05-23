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
	public partial class Splash : Form
	{
		public List<Mesa> Mesas { get; private set; }
		public List<Producto> Productos { get; private set; }

		public Splash()
		{
			InitializeComponent();
		}

		private void Splash_Shown(object sender, EventArgs e)
		{
			Thread.Sleep(10);
			using (var context = new ChoppinEntities())
			{
				Mesas = (from mesa in context.Mesas
						select mesa
						).ToList();
				Productos = (from producto in context.Productos
							 select producto
						).ToList();
			}
			Close();
		}
	}
}
