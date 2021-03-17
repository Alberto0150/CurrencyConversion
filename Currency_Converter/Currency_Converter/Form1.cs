using System;
using System.Windows.Forms;

namespace Currency_Converter
{
    public partial class Aplikasi : Form
    {
        public Aplikasi()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            ConvertCurrency();
        }

        private void ConvertCurrency()

        {
            var originalAmount = double.Parse(this.Rupiah.Text);
            var convertedAmount = originalAmount;
            if (this.comboBox2.SelectedItem.ToString() == "EUR")
            {
                convertedAmount = originalAmount / 17262;
            }
            else if (this.comboBox2.SelectedItem.ToString() == "USD")
            {
                convertedAmount = originalAmount / 14498;
            }
            this.Hasil.Text = Math.Round(convertedAmount, 2) + " " + this.comboBox2.SelectedItem;
        }
    }

}
