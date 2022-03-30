using HtmlAgilityPack;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            showHisse();
        }

        private void showHisse()
        {
            try
            {
                HtmlWeb web = new HtmlWeb();
                HtmlAgilityPack.HtmlDocument doc = web.Load("https://uzmanpara.milliyet.com.tr/canli-borsa/bist-TUM-hisseleri/");
                // Şişecam
                var xpath_SISE = "//*[@id=\"h_td_fiyat_id_SISE\"]";
                var element1 = doc.DocumentNode.SelectSingleNode(xpath_SISE);
                labelSISE.Text = element1.InnerText;
                var path_SISE = "//*[@id=\"h_td_yon_id_SISE\"]";
                var e1 = doc.DocumentNode.SelectSingleNode(path_SISE);
                string s1 = e1.OuterHtml.Substring(20, 1);
                if (s1.Equals("u"))
                {
                    pictureBoxSISEup.Visible = true;
                    pictureBoxSISEdown.Visible = false;
                }
                else
                {
                    pictureBoxSISEup.Visible = false;
                    pictureBoxSISEdown.Visible = true;
                }
                // Yapı Kredi
                var xpath_YKBNK = "//*[@id=\"h_td_fiyat_id_YKBNK\"]";
                var element2 = doc.DocumentNode.SelectSingleNode(xpath_YKBNK);
                labelYKBNK.Text = element2.InnerText;
                var path_YKBNK = "//*[@id=\"h_td_yon_id_YKBNK\"]";
                var e2 = doc.DocumentNode.SelectSingleNode(path_YKBNK);
                string s2 = e2.OuterHtml.Substring(20, 1);
                if (s2.Equals("u"))
                {
                    pictureBoxYKBNKup.Visible = true;
                    pictureBoxYKBNKdown.Visible = false;
                }
                else
                {
                    pictureBoxYKBNKup.Visible = false;
                    pictureBoxYKBNKdown.Visible = true;
                }
                // Aselsan
                var xpath_ASELS = "//*[@id=\"h_td_fiyat_id_ASELS\"]";
                var element3 = doc.DocumentNode.SelectSingleNode(xpath_ASELS);
                labelASELS.Text = element3.InnerText;
                var path_ASELS = "//*[@id=\"h_td_yon_id_ASELS\"]";
                var e3 = doc.DocumentNode.SelectSingleNode(path_ASELS);
                string s3 = e3.OuterHtml.Substring(20, 1);
                if (s3.Equals("u"))
                {
                    pictureBoxASELSup.Visible = true;
                    pictureBoxASELSdown.Visible = false;
                }
                else
                {
                    pictureBoxASELSup.Visible = false;
                    pictureBoxASELSdown.Visible = true;
                }
                // THY
                var xpath_THYAO = "//*[@id=\"h_td_fiyat_id_THYAO\"]";
                var element4 = doc.DocumentNode.SelectSingleNode(xpath_THYAO);
                labelTHYAO.Text = element4.InnerText;
                var path_THYAO = "//*[@id=\"h_td_yon_id_THYAO\"]";
                var e4 = doc.DocumentNode.SelectSingleNode(path_THYAO);
                string s4 = e4.OuterHtml.Substring(20, 1);
                if (s4.Equals("u"))
                {
                    pictureBoxTHYAOup.Visible = true;
                    pictureBoxTHYAOdown.Visible = false;
                }
                else
                {
                    pictureBoxTHYAOup.Visible = false;
                    pictureBoxTHYAOdown.Visible = true;
                }
                // Ereğli
                var xpath_EREGL = "//*[@id=\"h_td_fiyat_id_EREGL\"]";
                var element5 = doc.DocumentNode.SelectSingleNode(xpath_EREGL);
                labelEREGL.Text = element5.InnerText;
                var path_EREGL = "//*[@id=\"h_td_yon_id_EREGL\"]";
                var e5 = doc.DocumentNode.SelectSingleNode(path_EREGL);
                string s5 = e5.OuterHtml.Substring(20, 1);
                if (s5.Equals("u"))
                {
                    pictureBoxEREGLup.Visible = true;
                    pictureBoxEREGLdown.Visible = false;
                }
                else
                {
                    pictureBoxEREGLup.Visible = false;
                    pictureBoxEREGLdown.Visible = true;
                }
                // Kardelen
                var xpath_KRDMD = "//*[@id=\"h_td_fiyat_id_KRDMD\"]";
                var element6 = doc.DocumentNode.SelectSingleNode(xpath_KRDMD);
                labelKRDMD.Text = element6.InnerText;
                var path_KRDMD = "//*[@id=\"h_td_yon_id_KRDMD\"]";
                var e6 = doc.DocumentNode.SelectSingleNode(path_KRDMD);
                string s6 = e6.OuterHtml.Substring(20, 1);
                if (s6.Equals("u"))
                {
                    pictureBoxKRDMDup.Visible = true;
                    pictureBoxKRDMDdown.Visible = false;
                }
                else
                {
                    pictureBoxKRDMDup.Visible = false;
                    pictureBoxKRDMDdown.Visible = true;
                }
                // Kordsa
                var xpath_KORDS = "//*[@id=\"h_td_fiyat_id_KORDS\"]";
                var element7 = doc.DocumentNode.SelectSingleNode(xpath_KORDS);
                labelKORDS.Text = element7.InnerText;
                var path_KORDS = "//*[@id=\"h_td_yon_id_KORDS\"]";
                var e7 = doc.DocumentNode.SelectSingleNode(path_KORDS);
                string s7 = e7.OuterHtml.Substring(20, 1);
                if (s7.Equals("u"))
                {
                    pictureBoxKORDSup.Visible = true;
                    pictureBoxKORDSdown.Visible = false;
                }
                else
                {
                    pictureBoxKORDSup.Visible = false;
                    pictureBoxKORDSdown.Visible = true;
                }
                // Vestel
                var xpath_VESTL = "//*[@id=\"h_td_fiyat_id_VESTL\"]";
                var element8 = doc.DocumentNode.SelectSingleNode(xpath_VESTL);
                labelVESTL.Text = element8.InnerText;
                var path_VESTL = "//*[@id=\"h_td_yon_id_VESTL\"]";
                var e8 = doc.DocumentNode.SelectSingleNode(path_VESTL);
                string s8 = e8.OuterHtml.Substring(20, 1);
                if (s8.Equals("u"))
                {
                    pictureBoxVESTLup.Visible = true;
                    pictureBoxVESTLdown.Visible = false;
                }
                else
                {
                    pictureBoxVESTLup.Visible = false;
                    pictureBoxVESTLdown.Visible = true;
                }
                // Aksa
                var xpath_AKSA = "//*[@id=\"h_td_fiyat_id_AKSA\"]";
                var element9 = doc.DocumentNode.SelectSingleNode(xpath_AKSA);
                labelAKSA.Text = element9.InnerText;
                var path_AKSA = "//*[@id=\"h_td_yon_id_AKSA\"]";
                var e9 = doc.DocumentNode.SelectSingleNode(path_AKSA);
                string s9 = e9.OuterHtml.Substring(20, 1);
                if (s9.Equals("u"))
                {
                    pictureBoxAKSAup.Visible = true;
                    pictureBoxAKSAdown.Visible = false;
                }
                else
                {
                    pictureBoxAKSAup.Visible = false;
                    pictureBoxAKSAdown.Visible = true;
                }
                // Ford
                var xpath_FROTO = "//*[@id=\"h_td_fiyat_id_FROTO\"]";
                var element10 = doc.DocumentNode.SelectSingleNode(xpath_FROTO);
                labelFROTO.Text = element10.InnerText;
                var path_FROTO = "//*[@id=\"h_td_yon_id_FROTO\"]";
                var e10 = doc.DocumentNode.SelectSingleNode(path_FROTO);
                string s10 = e10.OuterHtml.Substring(20, 1);
                if (s10.Equals("u"))
                {
                    pictureBoxFROTOup.Visible = true;
                    pictureBoxFROTOdown.Visible = false;
                }
                else
                {
                    pictureBoxFROTOup.Visible = false;
                    pictureBoxFROTOdown.Visible = true;
                }
                // Tofaş
                var xpath_TOASO = "//*[@id=\"h_td_fiyat_id_TOASO\"]";
                var element11 = doc.DocumentNode.SelectSingleNode(xpath_TOASO);
                labelTOASO.Text = element11.InnerText;
                var path_TOASO = "//*[@id=\"h_td_yon_id_TOASO\"]";
                var e11 = doc.DocumentNode.SelectSingleNode(path_TOASO);
                string s11 = e11.OuterHtml.Substring(20, 1);
                if (s11.Equals("u"))
                {
                    pictureBoxTOASOup.Visible = true;
                    pictureBoxTOASOdown.Visible = false;
                }
                else
                {
                    pictureBoxTOASOup.Visible = false;
                    pictureBoxTOASOdown.Visible = true;
                }
                // Tav
                var xpath_TAVHL = "//*[@id=\"h_td_fiyat_id_TAVHL\"]";
                var element12 = doc.DocumentNode.SelectSingleNode(xpath_TAVHL);
                labelTAVHL.Text = element12.InnerText;
                var path_TAVHL = "//*[@id=\"h_td_yon_id_TAVHL\"]";
                var e12 = doc.DocumentNode.SelectSingleNode(path_TAVHL);
                string s12 = e12.OuterHtml.Substring(20, 1);
                if (s12.Equals("u"))
                {
                    pictureBoxTAVHLup.Visible = true;
                    pictureBoxTAVHLdown.Visible = false;
                }
                else
                {
                    pictureBoxTAVHLup.Visible = false;
                    pictureBoxTAVHLdown.Visible = true;
                }
                // Cemtaş
                var xpath_CEMTS = "//*[@id=\"h_td_fiyat_id_CEMTS\"]";
                var element13 = doc.DocumentNode.SelectSingleNode(xpath_CEMTS);
                labelCEMTS.Text = element13.InnerText;
                var path_CEMTS = "//*[@id=\"h_td_yon_id_CEMTS\"]";
                var e13 = doc.DocumentNode.SelectSingleNode(path_CEMTS);
                string s13 = e13.OuterHtml.Substring(20, 1);
                if (s13.Equals("u"))
                {
                    pictureBoxCEMTSup.Visible = true;
                    pictureBoxCEMTSdown.Visible = false;
                }
                else
                {
                    pictureBoxCEMTSup.Visible = false;
                    pictureBoxCEMTSdown.Visible = true;
                }
                // SASA
                var xpath_SASA = "//*[@id=\"h_td_fiyat_id_SASA\"]";
                var element14 = doc.DocumentNode.SelectSingleNode(xpath_SASA);
                labelSASA.Text = element14.InnerText;
                var path_SASA = "//*[@id=\"h_td_yon_id_SASA\"]";
                var e14 = doc.DocumentNode.SelectSingleNode(path_SASA);
                string s14 = e14.OuterHtml.Substring(20, 1);
                if (s14.Equals("u"))
                {
                    pictureBoxSASAup.Visible = true;
                    pictureBoxSASAdown.Visible = false;
                }
                else
                {
                    pictureBoxSASAup.Visible = false;
                    pictureBoxSASAdown.Visible = true;
                }
                // Yükselen Çeik
                var xpath_YKSLN = "//*[@id=\"h_td_fiyat_id_YKSLN\"]";
                var element15 = doc.DocumentNode.SelectSingleNode(xpath_YKSLN);
                labelYKSLN.Text = element15.InnerText;
                var path_YKSLN = "//*[@id=\"h_td_yon_id_YKSLN\"]";
                var e15 = doc.DocumentNode.SelectSingleNode(path_YKSLN);
                string s15 = e15.OuterHtml.Substring(20, 1);
                if (s15.Equals("u"))
                {
                    pictureBoxYKSLNup.Visible = true;
                    pictureBoxYKSLNdown.Visible = false;
                }
                else
                {
                    pictureBoxYKSLNup.Visible = false;
                    pictureBoxYKSLNdown.Visible = true;
                }
                // Hektaş
                var xpath_HEKTS = "//*[@id=\"h_td_fiyat_id_HEKTS\"]";
                var element16 = doc.DocumentNode.SelectSingleNode(xpath_HEKTS);
                labelHEKTS.Text = element16.InnerText;
                var path_HEKTS = "//*[@id=\"h_td_yon_id_HEKTS\"]";
                var e16 = doc.DocumentNode.SelectSingleNode(path_HEKTS);
                string s16 = e16.OuterHtml.Substring(20, 1);
                if (s16.Equals("u"))
                {
                    pictureBoxHEKTSup.Visible = true;
                    pictureBoxHEKTSdown.Visible = false;
                }
                else
                {
                    pictureBoxHEKTSup.Visible = false;
                    pictureBoxHEKTSdown.Visible = true;
                }
                // Alkım
                var xpath_ALKIM = "//*[@id=\"h_td_fiyat_id_ALKIM\"]";
                var element17 = doc.DocumentNode.SelectSingleNode(xpath_ALKIM);
                labelALKIM.Text = element17.InnerText;
                var path_ALKIM = "//*[@id=\"h_td_yon_id_ALKIM\"]";
                var e17 = doc.DocumentNode.SelectSingleNode(path_ALKIM);
                string s17 = e17.OuterHtml.Substring(20, 1);
                if (s17.Equals("u"))
                {
                    pictureBoxALKIMup.Visible = true;
                    pictureBoxALKIMdown.Visible = false;
                }
                else
                {
                    pictureBoxALKIMup.Visible = false;
                    pictureBoxALKIMdown.Visible = true;
                }
                // Çimsa
                var xpath_CIMSA = "//*[@id=\"h_td_fiyat_id_CIMSA\"]";
                var element18 = doc.DocumentNode.SelectSingleNode(xpath_CIMSA);
                labelCIMSA.Text = element18.InnerText;
                var path_CIMSA = "//*[@id=\"h_td_yon_id_CIMSA\"]";
                var e18 = doc.DocumentNode.SelectSingleNode(path_CIMSA);
                string s18 = e18.OuterHtml.Substring(20, 1);
                if (s18.Equals("u"))
                {
                    pictureBoxCIMSAup.Visible = true;
                    pictureBoxCIMSAdown.Visible = false;
                }
                else
                {
                    pictureBoxCIMSAup.Visible = false;
                    pictureBoxCIMSAdown.Visible = true;
                }
                // Oyak Çimento
                var xpath_OYAKC = "//*[@id=\"h_td_fiyat_id_OYAKC\"]";
                var element19 = doc.DocumentNode.SelectSingleNode(xpath_OYAKC);
                labelOYAKC.Text = element19.InnerText;
                var path_OYAKC = "//*[@id=\"h_td_yon_id_OYAKC\"]";
                var e19 = doc.DocumentNode.SelectSingleNode(path_OYAKC);
                string s19 = e19.OuterHtml.Substring(20, 1);
                if (s19.Equals("u"))
                {
                    pictureBoxOYAKCup.Visible = true;
                    pictureBoxOYAKCdown.Visible = false;
                }
                else
                {
                    pictureBoxOYAKCup.Visible = false;
                    pictureBoxOYAKCdown.Visible = true;
                }
                // Parsan
                var xpath_PARSN = "//*[@id=\"h_td_fiyat_id_PARSN\"]";
                var element20 = doc.DocumentNode.SelectSingleNode(xpath_PARSN);
                labelPARSN.Text = element20.InnerText;
                var path_PARSN = "//*[@id=\"h_td_yon_id_PARSN\"]";
                var e20 = doc.DocumentNode.SelectSingleNode(path_PARSN);
                string s20 = e20.OuterHtml.Substring(20, 1);
                if (s20.Equals("u"))
                {
                    pictureBoxPARSNup.Visible = true;
                    pictureBoxPARSNdown.Visible = false;
                }
                else
                {
                    pictureBoxPARSNup.Visible = false;
                    pictureBoxPARSNdown.Visible = true;
                }
            }
            catch (Exception e)
            {

            }

        }

        private void timerHisse_Tick(object sender, EventArgs e)
        {
            showHisse();
        }
    }
}
