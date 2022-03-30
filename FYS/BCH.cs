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
    public partial class BCH : Form
    {
        public BCH()
        {
            InitializeComponent();
        }

        private void mcButtonHesapla_Click(object sender, EventArgs e)
        {
            int ana_para = Convert.ToInt32(mcTextBoxAnaPara.Text);
            int gün = Convert.ToInt32(mcTextBoxGün.Text);
            double faizOranı = Convert.ToDouble(mcTextBoxFaizOranı.Text);

            double result = (ana_para * gün * faizOranı / 36000) * 1.05;
            labelResult.Text = "= " + Math.Round(result, 2, MidpointRounding.ToEven);

        }
    }
}
