using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FYS
{
    public partial class İskonto : Form
    {
        public İskonto()
        {
            InitializeComponent();
        }

        private void mcButtonHesapla_Click(object sender, EventArgs e)
        {
            double result;
            double kredi_tutarı = Convert.ToDouble(mcTextBoxAnaPara.Text);
            double faiz = Convert.ToDouble(mcTextBoxFaizOranı.Text);
            int vade = Convert.ToInt32(mcTextBoxGün.Text);

            result = kredi_tutarı * (1 - faiz * 1.05 * vade / 36000);
            result = Math.Round(result, 2, MidpointRounding.ToEven);
            double maliyet = kredi_tutarı - result;
            labelMaliyet.Text = "Maliyet: " + String.Format("{0:0.00}", maliyet);
            labelResult.Text = "Net Ödenen: " + String.Format("{0:0.00}", result);
        }
    }
}
