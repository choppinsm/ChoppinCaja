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
			var formSplash = new FormSplash();
			Application.Run(formSplash);
			if(formSplash.IrABM)
			{
				var formABM = new FormABM(formSplash.Tablas);
				Application.Run(formABM);
			}
			else{
				var formVentas = new FormVentas(formSplash.Mesas, formSplash.Productos);
				Application.Run(formVentas);
			}
		}
	}
}
