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
    public partial class TicariTaksit : Form
    {
        DataTable dt = new DataTable();
        public TicariTaksit()
        {
            InitializeComponent();
            populateColumns();
            labelError.Visible = false;
        }

        double BSMV = 0.05;

        private void mcButtonHesapla_Click(object sender, EventArgs e)
        {
            if (dataGridViewCredi.RowCount > 1)
            {
                dt.Rows.Clear();
                dataGridViewCredi.Refresh();
            }


            if (mcTextBoxFaiz.Text != "" && mcTextBoxKrediTutarı.Text != "" && mcTextBoxVade.Text != "")
            {
                double taksit_tutarı = 0;
                double kredi_tutar = Convert.ToDouble(mcTextBoxKrediTutarı.Text);
                int vade = Convert.ToInt32(mcTextBoxVade.Text);
                double faiz = Convert.ToDouble(mcTextBoxFaiz.Text);
                faiz /= 100;
                taksit_tutarı = calculate(kredi_tutar, vade, faiz);
                labelAylıkTaksitTutarı.Text = "Aylık Taksit Tutarı : " + String.Format("{0:0.00}", taksit_tutarı);


                for (int i = 1; i < vade + 1; i++)
                {
                    var row = dt.NewRow();

                    double taksit_icindeki_faiz = Math.Round(kredi_tutar * faiz, 2, MidpointRounding.ToEven);
                    double bsmv_val = Math.Round(taksit_icindeki_faiz * BSMV, 2, MidpointRounding.ToEven);
                    double taksit_icindeki_ana_para = taksit_tutarı - bsmv_val - taksit_icindeki_faiz;
                    kredi_tutar = kredi_tutar - taksit_icindeki_ana_para;

                    row[0] = i;
                    row[1] = DateTime.Today.AddMonths(i).ToShortDateString();
                    row[2] = String.Format("{0:0.00}", taksit_icindeki_ana_para);
                    row[3] = String.Format("{0:0.00}", taksit_icindeki_faiz);
                    row[4] = 0.00;
                    row[5] = String.Format("{0:0.00}", bsmv_val);
                    row[6] = String.Format("{0:0.00}", taksit_tutarı);
                    row[7] = String.Format("{0:0.00}", kredi_tutar);
                    dt.Rows.Add(row);

                    taksit_tutarı = calculate(kredi_tutar, vade - i, faiz);
                }
                dataGridViewCredi.DataSource = dt;
            }
            
            else
            {
                labelError.Visible = true;
            }

        }
        private double calculate(double kredi, int vade, double faiz)
        {
            
            double taksit_tutarı = (kredi * (1.05 * faiz) * Math.Pow(1 + (faiz * 1.05), vade)) / (Math.Pow(1 + (faiz * 1.05), vade) - 1);

            return taksit_tutarı;
        }

        private void populateColumns()
        {

            dt.Columns.Add("Taksit No");
            dt.Columns.Add("Taksit Tarihi");
            dt.Columns.Add("Taksit İçindeki Ana Para");
            dt.Columns.Add("Taksit İçindeki Faiz");
            dt.Columns.Add("KKDF");
            dt.Columns.Add("BSMV");
            dt.Columns.Add("Taksit Tutarı");
            dt.Columns.Add("Kalan Ana Para");

            dataGridViewCredi.DataSource = dt;
        }
    }
}
