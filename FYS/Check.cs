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
    public partial class Check : Form
    {
        SqlConnection con;
        public Check()
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
            catch 
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
            string query = "select * from CheckTable order by date_of_payment ASC";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridViewCredi.DataSource = ds.Tables[0];
            dataGridViewCredi.Columns[1].HeaderText = "Tarih";
            dataGridViewCredi.Columns[2].HeaderText = "Ödeme Türü";
            dataGridViewCredi.Columns[3].HeaderText = "Banka Adı";
            dataGridViewCredi.Columns[4].HeaderText = "Açıklama";
            dataGridViewCredi.Columns[5].HeaderText = "Firma Adı";
            dataGridViewCredi.Columns[6].HeaderText = "Tutar";
            dataGridViewCredi.Columns[7].HeaderText = "Dolar - TL";
            con.Close();
        }
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        string para_birimi;
        private void buttonCekEkle_Click(object sender, EventArgs e)
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
                if (radioButtonDolar.Checked == true)
                {
                    para_birimi = "Dolar";
                }
                else if (radioButtonTL.Checked == true)
                {
                    para_birimi = "TL";
                }
                try
                {
                    
                    string query = "insert into CheckTable values('" + ddate + "','" + "Çek" + "','" + comboBoxBankName.SelectedItem.ToString() + "','" + textBoxExplanation.Text + "','" + comboBoxFirmName.SelectedItem.ToString() + "','" + textBoxCost.Text.ToString() + "','" + para_birimi + "')";
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

        int key = 0;
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBoxBankName.SelectedItem = dataGridViewCredi.SelectedRows[0].Cells[3].Value.ToString();
            textBoxExplanation.Text = dataGridViewCredi.SelectedRows[0].Cells[4].Value.ToString();
            comboBoxFirmName.SelectedItem = dataGridViewCredi.SelectedRows[0].Cells[5].Value.ToString();
            textBoxCost.Text = dataGridViewCredi.SelectedRows[0].Cells[6].Value.ToString();
            string usd_or_tl = dataGridViewCredi.SelectedRows[0].Cells[7].Value.ToString();
            if (usd_or_tl.Equals("Dolar"))
            {
                radioButtonDolar.Checked = true;
                radioButtonTL.Checked = false;
            }
            else
            {
                radioButtonDolar.Checked = false;
                radioButtonTL.Checked = true;
            }
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

        private void back_Click(object sender, EventArgs e)
        {
            MasterForm master = new MasterForm();
            master.Show();
            this.Hide();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "delete from CheckTable where id = "+key+" ";
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
            radioButtonDolar.Checked = false;
            radioButtonTL.Checked = false;
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

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string usd_or_tl = "";
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
                if (radioButtonDolar.Checked == true)
                {
                    usd_or_tl = "Dolar";
                }
                else
                {
                    usd_or_tl = "TL";
                }

                try
                {
                    con.Open();
                    string query = "update CheckTable set date_of_payment='" + ddate + "',type='"+ "Çek"+"',  bank_name='" + comboBoxBankName.SelectedItem.ToString() + "',explanation= '" + textBoxExplanation.Text + "', firm_name= '" + comboBoxFirmName.SelectedItem.ToString() + "', cost = '" + textBoxCost.Text + "',usd_tl='"+ usd_or_tl +"' where Id=" + key + "";
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
            string query = "select * from CheckTable where date_of_payment between '" + dateStart + "' and '" + dateEnd + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridViewCopy.DataSource = ds.Tables[0];
            dataGridViewCopy.Columns[1].HeaderText = "Tarih";
            dataGridViewCopy.Columns[2].HeaderText = "Ödeme Türü";
            dataGridViewCopy.Columns[3].HeaderText = "Banka Adı";
            dataGridViewCopy.Columns[4].HeaderText = "Açıklama";
            dataGridViewCopy.Columns[5].HeaderText = "Firma Adı";
            dataGridViewCopy.Columns[6].HeaderText = "Tutar";
            dataGridViewCopy.Columns[7].HeaderText = "Dolar - TL";
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
