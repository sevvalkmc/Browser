namespace Browser
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.araçlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AraclarYeniSekme = new System.Windows.Forms.ToolStripMenuItem();
            this.tümSekmeleriKapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anasayfaOlsunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox_back = new System.Windows.Forms.PictureBox();
            this.pictureBox_forward = new System.Windows.Forms.PictureBox();
            this.pictureBox_home = new System.Windows.Forms.PictureBox();
            this.pictureBox_refresh = new System.Windows.Forms.PictureBox();
            this.pictureBox_gecmis = new System.Windows.Forms.PictureBox();
            this.pictureBox_go = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.panel_gecmis = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_GidilenSite = new System.Windows.Forms.ToolStripStatusLabel();
            this.araçlarKutusuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_forward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_refresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gecmis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_go)).BeginInit();
            this.panel_gecmis.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.araçlarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1084, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // araçlarToolStripMenuItem
            // 
            this.araçlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AraclarYeniSekme,
            this.tümSekmeleriKapatToolStripMenuItem,
            this.anasayfaOlsunToolStripMenuItem,
            this.araçlarKutusuToolStripMenuItem});
            this.araçlarToolStripMenuItem.Name = "araçlarToolStripMenuItem";
            this.araçlarToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.araçlarToolStripMenuItem.Text = "Araçlar";
            // 
            // AraclarYeniSekme
            // 
            this.AraclarYeniSekme.Name = "AraclarYeniSekme";
            this.AraclarYeniSekme.Size = new System.Drawing.Size(233, 26);
            this.AraclarYeniSekme.Text = "Yeni Sekme";
            this.AraclarYeniSekme.Click += new System.EventHandler(this.AraclarYeniSekmeClick);
            // 
            // tümSekmeleriKapatToolStripMenuItem
            // 
            this.tümSekmeleriKapatToolStripMenuItem.Name = "tümSekmeleriKapatToolStripMenuItem";
            this.tümSekmeleriKapatToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.tümSekmeleriKapatToolStripMenuItem.Text = "Tüm Sekmeleri Kapat";
            this.tümSekmeleriKapatToolStripMenuItem.Click += new System.EventHandler(this.tümSekmeleriKapatClick);
            // 
            // anasayfaOlsunToolStripMenuItem
            // 
            this.anasayfaOlsunToolStripMenuItem.Name = "anasayfaOlsunToolStripMenuItem";
            this.anasayfaOlsunToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.anasayfaOlsunToolStripMenuItem.Text = "Anasayfa Olsun";
            this.anasayfaOlsunToolStripMenuItem.Click += new System.EventHandler(this.anasayfaOlsunClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.CausesValidation = false;
            this.panel1.Controls.Add(this.pictureBox_back);
            this.panel1.Controls.Add(this.pictureBox_forward);
            this.panel1.Controls.Add(this.pictureBox_home);
            this.panel1.Controls.Add(this.pictureBox_refresh);
            this.panel1.Controls.Add(this.pictureBox_gecmis);
            this.panel1.Controls.Add(this.pictureBox_go);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 49);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox_back
            // 
            this.pictureBox_back.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_back.BackgroundImage")));
            this.pictureBox_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_back.Location = new System.Drawing.Point(4, 2);
            this.pictureBox_back.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox_back.Name = "pictureBox_back";
            this.pictureBox_back.Size = new System.Drawing.Size(51, 47);
            this.pictureBox_back.TabIndex = 7;
            this.pictureBox_back.TabStop = false;
            this.pictureBox_back.Click += new System.EventHandler(this.pictureBox_back_Click);
            this.pictureBox_back.MouseLeave += new System.EventHandler(this.Mouse_Leave);
            this.pictureBox_back.MouseHover += new System.EventHandler(this.Mouse_Hover);
            // 
            // pictureBox_forward
            // 
            this.pictureBox_forward.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_forward.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_forward.BackgroundImage")));
            this.pictureBox_forward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_forward.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_forward.Location = new System.Drawing.Point(60, 2);
            this.pictureBox_forward.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox_forward.Name = "pictureBox_forward";
            this.pictureBox_forward.Size = new System.Drawing.Size(51, 47);
            this.pictureBox_forward.TabIndex = 7;
            this.pictureBox_forward.TabStop = false;
            this.pictureBox_forward.Click += new System.EventHandler(this.pictureBox_forward_Click);
            this.pictureBox_forward.MouseLeave += new System.EventHandler(this.Mouse_Leave);
            this.pictureBox_forward.MouseHover += new System.EventHandler(this.Mouse_Hover);
            // 
            // pictureBox_home
            // 
            this.pictureBox_home.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_home.BackgroundImage")));
            this.pictureBox_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_home.Location = new System.Drawing.Point(115, 1);
            this.pictureBox_home.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox_home.Name = "pictureBox_home";
            this.pictureBox_home.Size = new System.Drawing.Size(51, 47);
            this.pictureBox_home.TabIndex = 7;
            this.pictureBox_home.TabStop = false;
            this.pictureBox_home.Click += new System.EventHandler(this.pictureBox_home_Click);
            this.pictureBox_home.MouseLeave += new System.EventHandler(this.Mouse_Leave);
            this.pictureBox_home.MouseHover += new System.EventHandler(this.Mouse_Hover);
            // 
            // pictureBox_refresh
            // 
            this.pictureBox_refresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_refresh.BackgroundImage")));
            this.pictureBox_refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_refresh.Location = new System.Drawing.Point(167, 2);
            this.pictureBox_refresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox_refresh.Name = "pictureBox_refresh";
            this.pictureBox_refresh.Size = new System.Drawing.Size(51, 47);
            this.pictureBox_refresh.TabIndex = 7;
            this.pictureBox_refresh.TabStop = false;
            this.pictureBox_refresh.Click += new System.EventHandler(this.pictureBox_refresh_Click);
            this.pictureBox_refresh.MouseLeave += new System.EventHandler(this.Mouse_Leave);
            this.pictureBox_refresh.MouseHover += new System.EventHandler(this.Mouse_Hover);
            // 
            // pictureBox_gecmis
            // 
            this.pictureBox_gecmis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_gecmis.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_gecmis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_gecmis.BackgroundImage")));
            this.pictureBox_gecmis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_gecmis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_gecmis.Location = new System.Drawing.Point(1029, 4);
            this.pictureBox_gecmis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox_gecmis.Name = "pictureBox_gecmis";
            this.pictureBox_gecmis.Size = new System.Drawing.Size(51, 47);
            this.pictureBox_gecmis.TabIndex = 7;
            this.pictureBox_gecmis.TabStop = false;
            this.pictureBox_gecmis.Click += new System.EventHandler(this.pictureBox_gecmis_Click);
            this.pictureBox_gecmis.MouseLeave += new System.EventHandler(this.Mouse_Leave);
            this.pictureBox_gecmis.MouseHover += new System.EventHandler(this.Mouse_Hover);
            // 
            // pictureBox_go
            // 
            this.pictureBox_go.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_go.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_go.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_go.BackgroundImage")));
            this.pictureBox_go.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_go.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_go.Location = new System.Drawing.Point(976, 2);
            this.pictureBox_go.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox_go.Name = "pictureBox_go";
            this.pictureBox_go.Size = new System.Drawing.Size(51, 46);
            this.pictureBox_go.TabIndex = 7;
            this.pictureBox_go.TabStop = false;
            this.pictureBox_go.Click += new System.EventHandler(this.pictureBox_go_Click);
            this.pictureBox_go.MouseLeave += new System.EventHandler(this.Mouse_Leave);
            this.pictureBox_go.MouseHover += new System.EventHandler(this.Mouse_Hover);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.ItemHeight = 31;
            this.comboBox1.Location = new System.Drawing.Point(228, 4);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(739, 39);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox1_KeyDown);
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 77);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1084, 589);
            this.tabControl1.TabIndex = 3;
            // 
            // panel_gecmis
            // 
            this.panel_gecmis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_gecmis.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel_gecmis.Controls.Add(this.listBox1);
            this.panel_gecmis.Location = new System.Drawing.Point(771, 76);
            this.panel_gecmis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_gecmis.Name = "panel_gecmis";
            this.panel_gecmis.Size = new System.Drawing.Size(313, 554);
            this.panel_gecmis.TabIndex = 4;
            this.panel_gecmis.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(313, 554);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_GidilenSite});
            this.statusStrip1.Location = new System.Drawing.Point(0, 640);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1084, 26);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_GidilenSite
            // 
            this.toolStripStatusLabel_GidilenSite.Name = "toolStripStatusLabel_GidilenSite";
            this.toolStripStatusLabel_GidilenSite.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel_GidilenSite.Text = "toolStripStatusLabel1";
            // 
            // araçlarKutusuToolStripMenuItem
            // 
            this.araçlarKutusuToolStripMenuItem.Name = "araçlarKutusuToolStripMenuItem";
            this.araçlarKutusuToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.araçlarKutusuToolStripMenuItem.Text = "Kısayollar";
            this.araçlarKutusuToolStripMenuItem.Click += new System.EventHandler(this.araçlarKutusuToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1084, 666);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel_gecmis);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BROWSER";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_forward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_refresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gecmis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_go)).EndInit();
            this.panel_gecmis.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem araçlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AraclarYeniSekme;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ToolStripMenuItem tümSekmeleriKapatToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ToolStripMenuItem anasayfaOlsunToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox_back;
        private System.Windows.Forms.PictureBox pictureBox_forward;
        private System.Windows.Forms.PictureBox pictureBox_home;
        private System.Windows.Forms.PictureBox pictureBox_refresh;
        private System.Windows.Forms.PictureBox pictureBox_go;
        private System.Windows.Forms.PictureBox pictureBox_gecmis;
        private System.Windows.Forms.Panel panel_gecmis;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_GidilenSite;
        private System.Windows.Forms.ToolStripMenuItem araçlarKutusuToolStripMenuItem;
    }
}

