using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FYS
{
    public partial class MasterForm : Form
    {
        public MasterForm()
        {
            InitializeComponent();
            hideSubMenusAtStart();
            makeAllButtonsDefault();
            showExchangeRates();
            openChildForm(new MainForm());
        }

        
        

        private void hideSubMenusAtStart()
        {
            panelİslemler.Visible = false;
            panelKrediSubMenu.Visible = false;
        }
        /*
        private void hideSubMenuİslemler()
        {
            if (panelİslemler.Visible == true)
            { panelİslemler.Visible = false; }

            
        }

        private void hideSubMenuKrediHesap()
        {
            if (panelKrediSubMenu.Visible == true)
            {
                panelKrediSubMenu.Visible = false;
            }
        }
        */
        private void showSubMenu(Panel subMenu)
        {
            
             if (subMenu.Visible == false)
                {
                 subMenu.Visible = true;
                }
             else
                {
                 subMenu.Visible = false;
                }
           
            
        }

        private void buttonİslemler_Click(object sender, EventArgs e)
        {
            showSubMenu(panelİslemler);
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void makeAllButtonsDefault()
        {
            buttonMainMenu.BackColor = Color.FromArgb(51, 51, 76);
            buttonİslemler.BackColor = Color.FromArgb(51, 51, 76);
            buttonKredi.BackColor = Color.FromArgb(66, 66, 84);
            buttonCek.BackColor = Color.FromArgb(66, 66, 84);
            buttonKrediKartı.BackColor = Color.FromArgb(66, 66, 84);
            buttonDigerOdemeler.BackColor = Color.FromArgb(66, 66, 84);
            buttonBankalar.BackColor = Color.FromArgb(66, 66, 84);
            buttonBCH.BackColor = Color.FromArgb(66, 66, 84);
            buttonİskonto.BackColor = Color.FromArgb(66, 66, 84);
            buttonTicari.BackColor = Color.FromArgb(66, 66, 84);
        }

        private void buttonKredi_Click(object sender, EventArgs e)
        {
            makeAllButtonsDefault();
            openChildForm(new Kredi());
            buttonKredi.BackColor = Color.SeaGreen;
        }

        private void buttonCek_Click(object sender, EventArgs e)
        {
            makeAllButtonsDefault();
            openChildForm(new Check());
            buttonCek.BackColor = Color.Tomato;
        }

        private void buttonKrediKartı_Click(object sender, EventArgs e)
        {
            makeAllButtonsDefault();
            openChildForm(new CreditCart());
            buttonKrediKartı.BackColor = Color.MediumTurquoise;

        }

        private void buttonDigerOdemeler_Click(object sender, EventArgs e)
        {
            makeAllButtonsDefault();
            openChildForm(new OtherPayments());
            buttonDigerOdemeler.BackColor = Color.FromArgb(222,24,61);
        }

        private void buttonBankalar_Click(object sender, EventArgs e)
        {
            makeAllButtonsDefault();
            openChildForm(new Banks());
            buttonBankalar.BackColor = Color.MediumPurple;
        }

        private void buttonMainMenu_Click(object sender, EventArgs e)
        {
            makeAllButtonsDefault();
            openChildForm(new MainForm());
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void showExchangeRates()
        {
            HtmlWeb web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load("https://bigpara.hurriyet.com.tr/doviz/");
            //usd
            var xpathUSD_TL = "//*[@id=\"content\"]/div[2]/div/div[6]/div/div[1]/div[2]/ul[1]/li[4]";
            var spanUSD = doc.DocumentNode.SelectSingleNode(xpathUSD_TL);
            var usd_tl = spanUSD.InnerText;
            usd_tl_value.Text = usd_tl;
            //euro
            var xpathEURO_TL = "//*[@id=\"content\"]/div[2]/div/div[6]/div/div[1]/div[2]/ul[2]/li[4]";
            var spanEURO = doc.DocumentNode.SelectSingleNode(xpathEURO_TL);
            var euro_tl = spanEURO.InnerText;
            euro_tl_value.Text = euro_tl;
            //gbp
            var xpathGBP_TL = "//*[@id=\"content\"]/div[2]/div/div[6]/div/div[1]/div[2]/ul[3]/li[4]";
            var spanGBP = doc.DocumentNode.SelectSingleNode(xpathGBP_TL);
            var gbp_tl = spanGBP.InnerText;
            gbp_tl_value.Text = gbp_tl;
            //gram altın
            HtmlAgilityPack.HtmlDocument doc_gold = web.Load("https://bigpara.hurriyet.com.tr/altin/");
            var xpath_altın = "//*[@id=\"content\"]/div[2]/div/div[4]/div/div/div[2]/ul[1]/li[3]";
            var span_altın = doc_gold.DocumentNode.SelectSingleNode(xpath_altın);
            var gram_altın = span_altın.InnerText;
            altın_value.Text = gram_altın;
            // gümüş ons
            HtmlAgilityPack.HtmlDocument doc_silver = web.Load("https://bigpara.hurriyet.com.tr/kobi/dunya-emtia-borsalari/xagusd-gumus/");
            var xpath_silver = "//*[@id=\"content\"]/div[2]/div[5]/div/div/div[2]/ul[3]/li[2]";
            var span_silver = doc_silver.DocumentNode.SelectSingleNode(xpath_silver);
            var ons_silver = span_silver.InnerText;
            gumus_value.Text = ons_silver;
        }

        


        

        private void timerExchangeRate_Tick(object sender, EventArgs e)
        {
            showExchangeRates();
            
        }

        

        private void MasterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void buttonKrediHesaplama_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelKrediSubMenu);
        }

        private void buttonBCH_Click(object sender, EventArgs e)
        {
            makeAllButtonsDefault();
            openChildForm(new BCH());
            buttonBCH.BackColor = Color.DarkMagenta;
        }

        private void buttonTicari_Click(object sender, EventArgs e)
        {
            makeAllButtonsDefault();
            openChildForm(new TicariTaksit());
            buttonTicari.BackColor = Color.DarkMagenta;
        }

        private void buttonİskonto_Click(object sender, EventArgs e)
        {
            makeAllButtonsDefault();
            openChildForm(new İskonto());
            buttonİskonto.BackColor = Color.DarkMagenta;
        }
    }
}
