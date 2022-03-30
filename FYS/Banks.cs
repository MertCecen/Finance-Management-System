using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FYS
{
    public partial class Banks : Form
    {
        SqlConnection con;
        public Banks()
        {
            InitializeComponent();
            
            try
            {
                string current = Directory.GetCurrentDirectory();
                string parent = Directory.GetParent(current).ToString();
                string parent2 = Directory.GetParent(parent).ToString();
                string parent3 = Directory.GetParent(parent2).ToString();
                string path = parent3 + "\\Database\\FinansDB.mdf";

                con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path + ";Integrated Security=True;Connect Timeout=30");

            }
            catch (Exception e)
            {

                    string current = Directory.GetCurrentDirectory();
                    string path = current + "\\FinansDB.mdf";
                    con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path + ";Integrated Security=True;Connect Timeout=30");

                
            }
            
            populate();
        }

        
        private void populate()
        {
            con.Open();
            string query = "select * from BankTable order by Id ASC";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView.DataSource = ds.Tables[0];
            
            dataGridView.Columns[3].DefaultCellStyle.Format = "N2";
            dataGridView.Columns[4].DefaultCellStyle.Format = "N2";
            dataGridView.Columns[5].DefaultCellStyle.Format = "N2";
            dataGridView.Columns[6].DefaultCellStyle.Format = "N2";
            
            dataGridView.Columns[0].Width = 45;
            dataGridView.Columns[1].Width = 276;
            dataGridView.Columns[2].Width = 128;
            dataGridView.Columns[3].Width = 187;
            dataGridView.Columns[4].Width = 187;
            dataGridView.Columns[5].Width = 187;
            dataGridView.Columns[6].Width = 187;
            
            dataGridView.Columns[1].HeaderText = "BANKA ADI";
            dataGridView.Columns[2].HeaderText = "FIRMA";
            dataGridView.Columns[3].HeaderText = "TL";
            dataGridView.Columns[4].HeaderText = "USD";
            dataGridView.Columns[5].HeaderText = "EURO";
            dataGridView.Columns[6].HeaderText = "GBP";

            con.Close();
        }
        double usd_tl_val;
        double euro_tl_val;
        double gbp_tl_val;
        static HtmlWeb web = new HtmlWeb();
        
        private void calculateExchangeRates()
        {
            HtmlAgilityPack.HtmlDocument doc = web.Load("https://bigpara.hurriyet.com.tr/doviz/");
            //usd
            var xpathUSD_TL = "//*[@id=\"content\"]/div[2]/div/div[6]/div/div[1]/div[2]/ul[1]/li[4]";
            var spanUSD = doc.DocumentNode.SelectSingleNode(xpathUSD_TL);
            var usd_tl = spanUSD.InnerText;
            //usd_tl = usd_tl.Replace(",", ".");
            usd_tl_val = Convert.ToDouble(usd_tl);
            //euro
            var xpathEURO_TL = "//*[@id=\"content\"]/div[2]/div/div[6]/div/div[1]/div[2]/ul[2]/li[4]";
            var spanEURO = doc.DocumentNode.SelectSingleNode(xpathEURO_TL);
            var euro_tl = spanEURO.InnerText;
            //euro_tl = euro_tl.Replace(",", ".");
            euro_tl_val = Convert.ToDouble(euro_tl);
            //gbp
            var xpathGBP_TL = "//*[@id=\"content\"]/div[2]/div/div[6]/div/div[1]/div[2]/ul[3]/li[4]";
            var spanGBP = doc.DocumentNode.SelectSingleNode(xpathGBP_TL);
            var gbp_tl = spanGBP.InnerText;
            //gbp_tl = gbp_tl.Replace(",", ".");
            gbp_tl_val = Convert.ToDouble(gbp_tl);
            
        }

        private void dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            double tl = 0.0;
            double usd = 0.0;
            double euro = 0.0;
            double gbp = 0.0;
            double toplam = 0.0;

            calculateExchangeRates();
            
            for (int ii = 0; ii < 13; ii++)
            {
                tl += Convert.ToDouble(dataGridView.Rows[ii].Cells[3].Value.ToString());
                usd += Convert.ToDouble(dataGridView.Rows[ii].Cells[4].Value.ToString());
                euro += Convert.ToDouble(dataGridView.Rows[ii].Cells[5].Value.ToString());
                gbp += Convert.ToDouble(dataGridView.Rows[ii].Cells[6].Value.ToString());

            }
            toplam = tl + (usd * usd_tl_val) + (euro * euro_tl_val) + (gbp * gbp_tl_val);
            labelTL.Text = "Toplam TL:    " + String.Format("{0:0.00}", tl);
            labelUSD.Text = "Toplam USD:   " + String.Format("{0:0.00}", usd) + "$ = " + String.Format("{0:0.00}", usd * usd_tl_val) + " TL";
            labelEURO.Text = "Toplam EURO:  " + String.Format("{0:0.00}", euro) + "€ = " + String.Format("{0:0.00}" ,euro * euro_tl_val) + "TL";
            labelGBP.Text = "Toplam GBP:   " + String.Format("{0:0.00}", gbp) + "£ = " + String.Format("{0:0.00}" , gbp * gbp_tl_val) + " TL";
            labelGenelToplam.Text = "Genel Toplam: " + String.Format("{0:0.00}", toplam) + " TL";
        }

        private void dataGridView_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            
            con.Open();
            int i = dataGridView.CurrentCell.RowIndex;
            string query = "update BankTable set bank_name = '" + dataGridView.Rows[i].Cells[1].Value.ToString() + "', firm_name='" + dataGridView.Rows[i].Cells[2].Value.ToString() + "', TL = '" + dataGridView.Rows[i].Cells[3].Value.ToString() + "', USD = '" + dataGridView.Rows[i].Cells[4].Value.ToString() + "', EURO = '"+ dataGridView.Rows[i].Cells[5].Value.ToString() + "', GBP = '" + dataGridView.Rows[i].Cells[6].Value.ToString() + "' where Id = '" + dataGridView.CurrentCell.RowIndex + "' ";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            
        }

        private void buttonWriteToExcel_Click(object sender, EventArgs e)
        {
            dataGridView.SelectAll();
            DataObject copydata = dataGridView.GetClipboardContent();
            if (copydata != null) Clipboard.SetDataObject(copydata);
            Microsoft.Office.Interop.Excel.Application xlapp = new Microsoft.Office.Interop.Excel.Application();
            xlapp.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook xlWbook;
            Microsoft.Office.Interop.Excel.Worksheet xlsheet;
            object misseddata = System.Reflection.Missing.Value;
            xlWbook = xlapp.Workbooks.Add(misseddata);

            xlsheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWbook.Worksheets.get_Item(1);
            
            Microsoft.Office.Interop.Excel.Range xlr = (Microsoft.Office.Interop.Excel.Range)xlsheet.Cells[1, 1];
            xlr.Select();
            xlsheet.PasteSpecial(xlr, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }
    }
}
