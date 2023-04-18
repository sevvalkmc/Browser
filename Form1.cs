using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gecko; // Gecko yu using olarak ekledik


namespace Browser
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            Xpcom.Initialize("Firefox"); 
        }
        
        string anasayfam = "https://www.google.com.tr"; 
        GeckoWebBrowser gwb; 

        void yeniSekme() 
        {
            gwb = new GeckoWebBrowser(); 
            TabPage sekme = new TabPage(); 
            tabControl1.TabPages.Add(sekme); 
            sekme.Controls.Add(gwb); 
            tabControl1.SelectTab(sekme); 
            gwb.Navigate(anasayfam); 
            gwb.Dock = DockStyle.Fill; 
            gwb.Navigated += Geckowb_Navigated; 
        }

        void sekmesil() 
        {
            if (tabControl1.TabCount != 1) 
            {
                tabControl1.TabPages.Remove(tabControl1.SelectedTab);
                tabControl1.SelectTab(tabControl1.TabPages.Count - 1);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.Font = new Font("Georgia", 17); 
            yeniSekme(); 
        }
        string[] uzantilar = { "http://", "https://", "www.", "tr-tr.", ".com.tr", ".com", ".tr", ".org",
            ".org.tr",".gov",".gov.tr",".net",".edu.tr",".edu",".info",".biz",".kim",".io","accounts.",".blogspot" };
        private void Geckowb_Navigated(object sender, GeckoNavigatedEventArgs e) 
        {
            gwb = sender as GeckoWebBrowser; 
            TabPage sekme = gwb.Parent as TabPage; 
            ekle();
            sekme.Text = gwb.Url.ToString();
            comboBox1.Text = gwb.Url.ToString(); 
            foreach (string item in uzantilar) 
            {
                sekme.Text = sekme.Text.Replace(item,"");
            }
            int slashBul = sekme.Text.IndexOf('/');  
            if (slashBul != -1) sekme.Text = sekme.Text.Remove(slashBul);
            sekme.Text = sekme.Text.Substring(0, 1).ToUpper() + sekme.Text.Substring(1, sekme.Text.Length-1); 
            
        }
        /// <summary>
        /// Geçmişe ve eski gidilen siteleri comboboxa ekle
        /// </summary>
        void ekle()
        {
            listBox1.Items.Add(gwb.Url.ToString()); 
            toolStripStatusLabel_GidilenSite.Text = gwb.Url.ToString(); 
            comboBox1.Items.Add(gwb.Url.ToString());
            AutoCompleteStringCollection veri = new AutoCompleteStringCollection(); 
            foreach (string item in comboBox1.Items) 
            {
                veri.Add(item); 
            }
            comboBox1.AutoCompleteCustomSource = veri; 
        }
        int say = 0;
        void git() 
        {
            foreach (var item in uzantilar) 
            {
                if (comboBox1.Text.Contains(item))
                {
                    say++; // say ı bir arttır
                }
            }
            if (say >= 2) 
            {
                ((GeckoWebBrowser)(this.tabControl1.SelectedTab.Controls[0])).Navigate(comboBox1.Text);
                say = 0;
            }
            else if (say < 2) 
                ((GeckoWebBrowser)(this.tabControl1.SelectedTab.Controls[0])).Navigate("www.google.com/search?q=" + comboBox1.Text);

        }
        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                git();
            }
        }
        private void pictureBox_refresh_Click(object sender, EventArgs e)
        {
            ((GeckoWebBrowser)(this.tabControl1.SelectedTab.Controls[0])).Refresh(); 
        }

        private void pictureBox_home_Click(object sender, EventArgs e)
        {
            ((GeckoWebBrowser)(this.tabControl1.SelectedTab.Controls[0])).Navigate(anasayfam); 

        }

        private void pictureBox_forward_Click(object sender, EventArgs e)
        {
            ((GeckoWebBrowser)(this.tabControl1.SelectedTab.Controls[0])).GoForward(); 
        }

        private void pictureBox_back_Click(object sender, EventArgs e)
        {
            ((GeckoWebBrowser)(this.tabControl1.SelectedTab.Controls[0])).GoBack(); 
        }

        private void pictureBox_go_Click(object sender, EventArgs e)
        {
            git(); 
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ((GeckoWebBrowser)(this.tabControl1.SelectedTab.Controls[0])).Navigate(listBox1.SelectedItem.ToString()); 
        }

        int gecmis_sayac = 0;
        void gecmisAc() 
        {
            switch (gecmis_sayac)
            {
                case 0:
                    panel_gecmis.Visible = true; 
                    gecmis_sayac++; break;
                case 1:
                    panel_gecmis.Visible = false; 
                    gecmis_sayac = 0; break;
                default: break;
            }
        }
        private void pictureBox_gecmis_Click(object sender, EventArgs e) 
        {
            gecmisAc(); 
        }

        
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) 
        {
            if (keyData == (Keys.Control | Keys.T)) 
            {
                yeniSekme();
                return true;
            }

            if (keyData == (Keys.Control | Keys.W)) 
            {
                sekmesil();
                return true;
            }
            if (keyData == (Keys.Control | Keys.H))
            {
                gecmisAc();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void Mouse_Hover(object sender, EventArgs e)
        {
            PictureBox p = sender as PictureBox; 
            p.BorderStyle = BorderStyle.Fixed3D; 
        }
        private void Mouse_Leave(object sender, EventArgs e)
        {
            PictureBox p = sender as PictureBox; 
            p.BorderStyle = BorderStyle.None; 
        }

        private void AraclarYeniSekmeClick(object sender, EventArgs e) 
        {
            yeniSekme();
        }

        private void tümSekmeleriKapatClick(object sender, EventArgs e) 
        {
            tabControl1.TabPages.Clear();
            yeniSekme();
        }
        private void anasayfaOlsunClick(object sender, EventArgs e) 
        {
            anasayfam = gwb.Url.ToString();
        }

        private void araçlarKutusuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kisayol kisayol = new kisayol();
            kisayol.Show();
        }
    }
}

