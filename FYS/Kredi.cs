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
    public partial class Kredi : Form
    {
        SqlConnection con;
        public Kredi()
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
            string query = "select * from CrediTable order by date_of_payment ASC";
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
            dataGridViewCredi.Columns[7].HeaderText = "Taksit";
            con.Close();
        }

        private void buttonKrediEkle_Click(object sender, EventArgs e)
        {
            int taksit = 0;

            if (textBoxCost.Text == "" || comboBoxBankName.SelectedIndex == -1 || comboBoxFirmName.SelectedIndex == -1 || comboBoxOdemeTuru.SelectedIndex == -1 || comboBoxTaksit.SelectedIndex == -1)
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

                taksit = Int32.Parse(comboBoxTaksit.SelectedItem.ToString());
                List<string> dates = new List<string>();
                string date = dateTimePicker1.Value.ToShortDateString(); // 19.01.2022

                dates.Add(ddate);
                int count = 0;

                while (taksit != 0)
                {

                    taksit -= 1;
                    if (taksit == 0)
                    {
                        break;
                    }


                    date = dateTimePicker1.Value.AddMonths(1 + count).ToShortDateString();

                    DateTime date_prime = Convert.ToDateTime(date);

                    if (date_prime.DayOfWeek == DayOfWeek.Saturday)
                    {
                        date = date_prime.AddDays(2).ToShortDateString();
                    }
                    else if (date_prime.DayOfWeek == DayOfWeek.Sunday)
                    {
                        date = date_prime.AddDays(1).ToShortDateString();
                    }
                    DateTime cdate = Convert.ToDateTime(date);

                    year = cdate.Year.ToString();
                    month = cdate.Month.ToString();
                    day = cdate.Day.ToString();
                    string strdate = year + "-" + month + "-" + day;

                    dates.Add(strdate);
                    count += 1;
                }
                try
                {
                    foreach (string d in dates)
                    {
                        string query = "insert into CrediTable values('" + d + "','" + comboBoxOdemeTuru.SelectedItem.ToString() + "','" + comboBoxBankName.SelectedItem.ToString() + "','" + textBoxExplanation.Text + "','" + comboBoxFirmName.SelectedItem.ToString() + "','" + textBoxCost.Text.ToString() + "','" + comboBoxTaksit.SelectedItem.ToString() + "')";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


                con.Close();
                populate();
            }


        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_Click(object sender, EventArgs e)
        {
            MasterForm master = new MasterForm();
            master.Show();
            this.Hide();
        }

        private void buttonDeleteAll_Click(object sender, EventArgs e)
        {

            con.Open();
            string query = "delete from CrediTable where id = "+key+"";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            populate();

        }
        private void reset()
        {
            dateTimePicker1.Value = DateTime.Today;
            comboBoxOdemeTuru.SelectedIndex = -1;
            comboBoxBankName.SelectedIndex = -1;
            textBoxExplanation.Text = "";
            comboBoxFirmName.SelectedIndex = -1;
            textBoxCost.Text = "";
            comboBoxTaksit.SelectedIndex = -1;
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
            comboBoxOdemeTuru.SelectedItem = dataGridViewCredi.SelectedRows[0].Cells[2].Value.ToString();
            comboBoxBankName.SelectedItem = dataGridViewCredi.SelectedRows[0].Cells[3].Value.ToString();
            textBoxExplanation.Text = dataGridViewCredi.SelectedRows[0].Cells[4].Value.ToString();
            comboBoxFirmName.SelectedItem = dataGridViewCredi.SelectedRows[0].Cells[5].Value.ToString();
            textBoxCost.Text = dataGridViewCredi.SelectedRows[0].Cells[6].Value.ToString();
            comboBoxTaksit.SelectedItem = dataGridViewCredi.SelectedRows[0].Cells[7].Value.ToString();
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

            if (textBoxCost.Text == "" || textBoxExplanation.Text == "" || comboBoxBankName.SelectedIndex == -1 || comboBoxFirmName.SelectedIndex == -1 || comboBoxOdemeTuru.SelectedIndex == -1 || comboBoxTaksit.SelectedIndex == -1)
            {
                MessageBox.Show("Eksik bilgi girdiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                
                try
                {
                    con.Open();
                    string query = "update CrediTable set date_of_payment='" + ddate + "',type_of_payment='" + comboBoxOdemeTuru.SelectedItem.ToString() + "',bank_name='" + comboBoxBankName.SelectedItem.ToString() + "',explanation= '" + textBoxExplanation.Text + "', firm_name= '" + comboBoxFirmName.SelectedItem.ToString() + "', cost = '" + textBoxCost.Text + "',taksit='" + comboBoxTaksit.SelectedItem.ToString() + "' where Id=" + key + "";
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
            string query = "select * from CrediTable where date_of_payment between '" + dateStart + "' and '" + dateEnd + "'";
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
            dataGridViewCopy.Columns[7].HeaderText = "Taksit";
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
