using System.Globalization;
using System.Windows.Forms;

namespace ChoppInCaja
{
    public partial class FormPago : Form
    {
        public FormPago()
        {
            InitializeComponent();
        }

        public bool Pagado { get; set; }
        private decimal total;
        public decimal Total { get
            {
                return total;
            }
            set{
                total = value;
                lblTotal.Text = $"Total: {total.ToString("C2", new CultureInfo("es-AR"))}";
                ActualizarEfectivo();
            }
        }

        private void ChkTarjeta_CheckedChanged(object sender, System.EventArgs e)
        {
            if (ChkTarjeta.Checked)
            {
                Tarjeta = total;
                TxtTarjeta.Visible = true;
            }
            else
            {
                Tarjeta = 0;
                TxtTarjeta.Visible = false;
            }
            TxtTarjeta.Text = Tarjeta.ToString("$0000.00");
            ActualizarEfectivo();
        }

        private void ActualizarEfectivo()
        {
            Efectivo = total - Tarjeta;
            LblEfectivo.Text = $"Efectivo: {Efectivo.ToString("C2", new CultureInfo("es-AR"))}";
            LblTarjeta.Text = $"Tarjeta: {Tarjeta.ToString("C2", new CultureInfo("es-AR"))}";
            BtnPagado.Visible = Efectivo >= 0 && Tarjeta >= 0 && Total - Tarjeta - Efectivo == 0 && Total > 0;
        }
        public decimal Efectivo { get; private set; }
        public decimal Tarjeta { get; private set; }

        private void TxtTarjeta_Validated(object sender, System.EventArgs e)
        {
        }

        private void FormPago_Shown(object sender, System.EventArgs e)
        {
            Tarjeta = 0;
            ChkTarjeta.Checked = false;
            TxtTarjeta.Visible = false;
            TxtTarjeta.Text = Tarjeta.ToString("$0000.00");
        }

        private void TxtTarjeta_TextChanged(object sender, System.EventArgs e)
        {
            try
            {
                Tarjeta = decimal.Parse(TxtTarjeta.Text, NumberStyles.Currency);
                ActualizarEfectivo();
            }
            catch{ }
        }

        private void BtnPagado_Click(object sender, System.EventArgs e)
        {
            Pagado = true;
            this.Close();
        }
    }
}
