using System;
using System.Windows.Forms;

namespace ChoppInCaja
{
    public partial class FormSplash : Form
	{
		public bool IrABM { get; internal set; }

		public FormSplash()
		{
			InitializeComponent();
		}

		private void Splash_Shown(object sender, EventArgs e)
		{
			Application.DoEvents();
            Program.ActualizarTablas();
			Application.DoEvents();
			Close();
		}

		private void FormSplash_KeyDown(object sender, KeyEventArgs e)
		{
			IrABM |= e.KeyCode == Keys.F12;
		}
	}
}
