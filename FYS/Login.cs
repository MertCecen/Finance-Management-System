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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            makeUnseen();

        }

        private void makeUnseen()
        {
            labelEmpty.Visible = false;
            labelWrong.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textboxUserName.Text == "" || textboxPassword.Text == "")
            {
                labelWrong.Visible = false;
                labelEmpty.Visible = true;
            }

            else if (textboxUserName.Text.Equals("btcecen") && textboxPassword.Text.Equals("BT202020bt"))
            {
                MasterForm mf = new MasterForm();
                this.Hide();
                mf.Show();
            }

            else
            {
                labelEmpty.Visible = false;
                labelWrong.Visible = true;
            }
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (textboxPassword.PasswordChar == true)
            {
                textboxPassword.PasswordChar = false;
            }
            else
            {
                textboxPassword.PasswordChar = true;
            }
            
        }
    }
}
