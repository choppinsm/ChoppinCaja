using System;
using System.Windows.Forms;

namespace ChoppInCaja
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			var splash = new Splash();
			Application.Run(splash);
			var formVentas = new FormVentas(splash.Mesas, splash.Productos);
			Application.Run(formVentas);
		}
	}
}
