using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FYS
{
    public partial class OtherPayments : Form
    {
        SqlConnection con;
        public OtherPayments()
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
            reset();
        }
        

        private void populate()
        {
            con.Open();
            string query = "select * from OtherPaymentsTable order by date_of_payment ASC";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridViewCredi.DataSource = ds.Tables[0];
            dataGridViewCredi.Columns[1].HeaderText = "Tarih";
            dataGridViewCredi.Columns[2].HeaderText = "Banka Adı";
            dataGridViewCredi.Columns[3].HeaderText = "Açıklama";
            dataGridViewCredi.Columns[4].HeaderText = "Firma Adı";
            dataGridViewCredi.Columns[5].HeaderText = "Tutar";
            con.Close();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            if (textBoxCost.Text == "" || textBoxExplanation.Text == "" || comboBoxBankName.SelectedIndex == -1 || comboBoxFirmName.SelectedIndex == -1)
            {
                MessageBox.Show("Eksik bilgi girdiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                con.Open();

                string year = dateTimePicker1.Value.Year.ToString();
                string month = dateTimePicker1.Value.Month.ToString();
                string day = dateTimePicker1.Value.Day.ToString();
                string ddate = year + "-" + month + "-" + day;
                try
                {
                    string query = "insert into OtherPaymentsTable values('" + ddate + "','" + comboBoxBankName.SelectedItem.ToString() + "','" + textBoxExplanation.Text + "','" + comboBoxFirmName.SelectedItem.ToString() + "','" + textBoxCost.Text.ToString() + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
                con.Close();
                populate();
            }
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "delete from OtherPaymentsTable where id ="+key+" ";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            populate();
        }

        private void reset()
        {
            dateTimePicker1.Value = DateTime.Today;
            comboBoxBankName.SelectedIndex = -1;
            textBoxExplanation.Text = "";
            comboBoxFirmName.SelectedIndex = -1;
            textBoxCost.Text = "";
        }
        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void textBoxCost_TextChanged(object sender, EventArgs e)
        {
            int count = textBoxCost.Text.Length;
            labelBasamakSayısı.Text = count + " basamaklı";
        }

        int key = 0;
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBoxBankName.SelectedItem = dataGridViewCredi.SelectedRows[0].Cells[2].Value.ToString();
            textBoxExplanation.Text = dataGridViewCredi.SelectedRows[0].Cells[3].Value.ToString();
            comboBoxFirmName.SelectedItem = dataGridViewCredi.SelectedRows[0].Cells[4].Value.ToString();
            textBoxCost.Text = dataGridViewCredi.SelectedRows[0].Cells[5].Value.ToString();

            if (comboBoxBankName.SelectedIndex == -1)
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(dataGridViewCredi.SelectedRows[0].Cells[0].Value.ToString());
                // cell 0 for id
            }
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string year = dateTimePicker1.Value.Year.ToString();
            string month = dateTimePicker1.Value.Month.ToString();
            string day = dateTimePicker1.Value.Day.ToString();
            string ddate = year + "-" + month + "-" + day;

            if (textBoxCost.Text == "" || textBoxExplanation.Text == "" || comboBoxBankName.SelectedIndex == -1 || comboBoxFirmName.SelectedIndex == -1)
            {
                MessageBox.Show("Eksik bilgi girdiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                try
                {
                    con.Open();
                    string query = "update OtherPaymentsTable set date_of_payment='" + ddate + "',bank_name='" + comboBoxBankName.SelectedItem.ToString() + "',explanation= '" + textBoxExplanation.Text + "', firm_name= '" + comboBoxFirmName.SelectedItem.ToString() + "', cost = '" + textBoxCost.Text + "' where Id=" + key + "";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    reset();
                    populate();
                    reset();
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void buttonWriteToExcel_Click(object sender, EventArgs e)
        {
            // start date
            string yearS = dateTimePickerStart.Value.Year.ToString();
            string monthS = dateTimePickerStart.Value.Month.ToString();
            string dayS = dateTimePickerStart.Value.Day.ToString();
            string dateStart = yearS + "-" + monthS + "-" + dayS;
            // end date
            string yearE = dateTimePickerEnd.Value.Year.ToString();
            string monthE = dateTimePickerEnd.Value.Month.ToString();
            string dayE = dateTimePickerEnd.Value.Day.ToString();
            string dateEnd = yearE + "-" + monthE + "-" + dayE;
            con.Open();
            string query = "select * from OtherPaymentsTable where date_of_payment between '" + dateStart + "' and '" + dateEnd + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridViewCopy.DataSource = ds.Tables[0];
            dataGridViewCredi.Columns[1].HeaderText = "Tarih";
            dataGridViewCredi.Columns[2].HeaderText = "Banka Adı";
            dataGridViewCredi.Columns[3].HeaderText = "Açıklama";
            dataGridViewCredi.Columns[4].HeaderText = "Firma Adı";
            dataGridViewCredi.Columns[5].HeaderText = "Tutar";
            con.Close();
            // excel
            dataGridViewCopy.SelectAll();
            DataObject copydata = dataGridViewCopy.GetClipboardContent();
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
