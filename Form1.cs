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
            Xpcom.Initialize("Firefox"); // Geckoyu başlatıcak firefox klasörünü belirttik. Projemizin içerisinde mevcut bu
        }
        
        string anasayfam = "https://www.google.com.tr"; // Anasayfa belirledik
        GeckoWebBrowser gwb; // Geckowebbroserı gwb değişkenine atadık

        void yeniSekme() //  Yeni sekme oluşturma fonksiyonumuz
        {
            gwb = new GeckoWebBrowser(); // yeni bir tarayıcı oluşturduk
            TabPage sekme = new TabPage(); // tabcontrol için yeni bir tabpage oluşturduk
            tabControl1.TabPages.Add(sekme); // tabcontrole yeni sekmeyi ekledik
            sekme.Controls.Add(gwb); // Sekmeye tarayıcımızı ekliyoruz
            tabControl1.SelectTab(sekme); // Seçili tabı sekme olarak yapıyoruz yani her ctrl + t yapınca yeni sekmeyi gösteriyor
            gwb.Navigate(anasayfam); // Anasayfaya git artık gwb de anasayfa görüntülenecek
            gwb.Dock = DockStyle.Fill; // gwb yi sekmeye full sığdırdık
            gwb.Navigated += Geckowb_Navigated; // gittiği anda fonksiyonu oluşturduk
        }

        void sekmesil() // Sekme silme fonksiyonumuz
        {
            if (tabControl1.TabCount != 1) // Sekme sayısı 1 den farklıysa yani 2-3-4 se sekmeleri silebiliriz
            {
                tabControl1.TabPages.Remove(tabControl1.SelectedTab); // seçili sekmeyi sil
                tabControl1.SelectTab(tabControl1.TabPages.Count - 1); // sekme silindikten sonra son sekmeye geç
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.Font = new Font("Georgia", 17); // tabcontrolün fontunu değiştirdik
            yeniSekme(); // Yeni sekme oluştur
        }
        string[] uzantilar = { "http://", "https://", "www.", "tr-tr.", ".com.tr", ".com", ".tr", ".org",
            ".org.tr",".gov",".gov.tr",".net",".edu.tr",".edu",".info",".biz",".kim",".io","accounts.",".blogspot" }; // Web sitelerin uzantılarını diziye ekledik
        private void Geckowb_Navigated(object sender, GeckoNavigatedEventArgs e) 
        {
            gwb = sender as GeckoWebBrowser; // Hangi tarayıcıda olduğumuzu bulduk
            TabPage sekme = gwb.Parent as TabPage; // sekmeyi tarayıcının atası olan tabpageye attık
            ekle(); // ekle fonksiyonuyla gidilecek siteye ekledik
            sekme.Text = gwb.Url.ToString(); // sekme.text e gidilen url atandı
            comboBox1.Text = gwb.Url.ToString(); // sekme.text e gidilen url atandı
            foreach (string item in uzantilar) // uzantılar dizisinin tek tek taradık
            {
                sekme.Text = sekme.Text.Replace(item,""); // uzantıları boşla değiştirdik.
            }
            int slashBul = sekme.Text.IndexOf('/'); // Elimizde slash kaldı 
            if (slashBul != -1) sekme.Text = sekme.Text.Remove(slashBul); // ve ilk slashtan sonra sildik diğer kalanları yani artık elimizde google var www.google.com.tr/ falan yok
            sekme.Text = sekme.Text.Substring(0, 1).ToUpper() + sekme.Text.Substring(1, sekme.Text.Length-1); 
            // baş harfi büyük yaptık ve yanına baş harften sonraki karakterleri ekledik
        }
        /// <summary>
        /// Geçmişe ve eski gidilen siteleri comboboxa ekle
        /// </summary>
        void ekle()
        {
            listBox1.Items.Add(gwb.Url.ToString()); // Geçmiş listboxa ekleme yaptıktemizledik
            toolStripStatusLabel_GidilenSite.Text = gwb.Url.ToString(); // asağıya gidilen siteyi gösteriyoruz.
            comboBox1.Items.Add(gwb.Url.ToString()); // gidilen siteyi comboboxa  ekliyoruz
            AutoCompleteStringCollection veri = new AutoCompleteStringCollection(); // comboboxa otomatik tamamlama özelliği veriyoruz.
            foreach (string item in comboBox1.Items) // Comboboxtaki bütün elemanları 
            {
                veri.Add(item); // otomatik tamamlama için veri ye ekliyoruz
            }
            comboBox1.AutoCompleteCustomSource = veri; // otomatik tamamlamanın kaynağını veri yapıyoruz
        }
        int say = 0;
        void git() // comboboxta entera basıldığında ve git butonuna basıldığında
        {
            foreach (var item in uzantilar) // eğer comboboxın içerisinde uzantılardan varsa
            {
                if (comboBox1.Text.Contains(item))
                {
                    say++; // say ı bir arttır
                }
            }
            if (say >= 2) // eğer say 2 taneyse atıyorum wwww.google.com www. de var .com da var direk siteye git
            {
                ((GeckoWebBrowser)(this.tabControl1.SelectedTab.Controls[0])).Navigate(comboBox1.Text);
                say = 0;
            }
            else if (say < 2) // eğer www. var .com yoksa veya tam tersi googlede ara
                ((GeckoWebBrowser)(this.tabControl1.SelectedTab.Controls[0])).Navigate("www.google.com/search?q=" + comboBox1.Text);

        }
        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // entera basıldığında git çalışssın
            {
                git();
            }
        }
        private void pictureBox_refresh_Click(object sender, EventArgs e)
        {
            ((GeckoWebBrowser)(this.tabControl1.SelectedTab.Controls[0])).Refresh(); // Yenile butonu
        }

        private void pictureBox_home_Click(object sender, EventArgs e)
        {
            ((GeckoWebBrowser)(this.tabControl1.SelectedTab.Controls[0])).Navigate(anasayfam); // Anasayfa yapıyorz

        }

        private void pictureBox_forward_Click(object sender, EventArgs e)
        {
            ((GeckoWebBrowser)(this.tabControl1.SelectedTab.Controls[0])).GoForward(); // İleri git
        }

        private void pictureBox_back_Click(object sender, EventArgs e)
        {
            ((GeckoWebBrowser)(this.tabControl1.SelectedTab.Controls[0])).GoBack(); // Geri git
        }

        private void pictureBox_go_Click(object sender, EventArgs e)
        {
            git(); // git e basılınca
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ((GeckoWebBrowser)(this.tabControl1.SelectedTab.Controls[0])).Navigate(listBox1.SelectedItem.ToString()); // geçmişten bir nesne seçtiğimizde direk o siteye git
        }

        int gecmis_sayac = 0;
        void gecmisAc() // ctrl + h ve geçmiş butonu için ortak kod
        {
            switch (gecmis_sayac)
            {
                case 0:
                    panel_gecmis.Visible = true; // sayac 0 sa gecmiş paneli görünsün yani tıklandıysa
                    gecmis_sayac++; break;
                case 1:
                    panel_gecmis.Visible = false; // tekrar tıklandıysa gizlensin
                    gecmis_sayac = 0; break;
                default: break;
            }
        }
        private void pictureBox_gecmis_Click(object sender, EventArgs e) /// geçmiş panelini aç kapa
        {
            gecmisAc(); 
        }

        
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) // Bu ProcessCmdKey her türlü ihtimalde klavyeden tuşa basıldığında çalışır.
        {
            if (keyData == (Keys.Control | Keys.T)) // CTRL + T ye  yeni sekme
            {
                yeniSekme();
                return true;
            }

            if (keyData == (Keys.Control | Keys.W)) // CTRL + W ye basılınca sekmeyi sil
            {
                sekmesil();
                return true;
            }
            if (keyData == (Keys.Control | Keys.H)) // CTRL + H ye basılınca geçmiş aç
            {
                gecmisAc();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void Mouse_Hover(object sender, EventArgs e)// Butonların üstüne gelince efekt veriyoruz
        {
            PictureBox p = sender as PictureBox; // Hangi butona gelindiğini tespit et
            p.BorderStyle = BorderStyle.Fixed3D; // butonun borderını Fixed3d yap
        }
        private void Mouse_Leave(object sender, EventArgs e) // Butonların üstünden gidince 
        {
            PictureBox p = sender as PictureBox; // Hangi butona gelindiğini tespit et
            p.BorderStyle = BorderStyle.None; // butonun borderını kapat
        }

        private void AraclarYeniSekmeClick(object sender, EventArgs e) // Araçlar kutusu yenisekme açma
        {
            yeniSekme();
        }

        private void tümSekmeleriKapatClick(object sender, EventArgs e) // Araçlar kutusu sekme kapatma
        {
            tabControl1.TabPages.Clear();
            yeniSekme();
        }
        private void anasayfaOlsunClick(object sender, EventArgs e) // Araçlar kutusu anasayfa ayarlama
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

