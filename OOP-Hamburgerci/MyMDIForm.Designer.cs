namespace OOP_Hamburgerci
{
    partial class MyMDIForm
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
            this.msHamburgerMenu = new System.Windows.Forms.MenuStrip();
            this.tsmSiparisYönetimi = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSiparisOlustur = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTumSiparisler = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUrunYonetimi = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMenuEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEkstraEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msHamburgerMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // msHamburgerMenu
            // 
            this.msHamburgerMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msHamburgerMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSiparisYönetimi,
            this.tsmUrunYonetimi});
            this.msHamburgerMenu.Location = new System.Drawing.Point(0, 0);
            this.msHamburgerMenu.Name = "msHamburgerMenu";
            this.msHamburgerMenu.Size = new System.Drawing.Size(750, 28);
            this.msHamburgerMenu.TabIndex = 0;
            this.msHamburgerMenu.Text = "menuStrip1";
            // 
            // tsmSiparisYönetimi
            // 
            this.tsmSiparisYönetimi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSiparisOlustur,
            this.tsmTumSiparisler});
            this.tsmSiparisYönetimi.Name = "tsmSiparisYönetimi";
            this.tsmSiparisYönetimi.Size = new System.Drawing.Size(127, 24);
            this.tsmSiparisYönetimi.Text = "Sipariş İşlemleri";
            // 
            // tsmSiparisOlustur
            // 
            this.tsmSiparisOlustur.Name = "tsmSiparisOlustur";
            this.tsmSiparisOlustur.Size = new System.Drawing.Size(224, 26);
            this.tsmSiparisOlustur.Text = "Sipariş Oluştur";
            this.tsmSiparisOlustur.Click += new System.EventHandler(this.tsmSiparisOlustur_Click);
            // 
            // tsmTumSiparisler
            // 
            this.tsmTumSiparisler.Name = "tsmTumSiparisler";
            this.tsmTumSiparisler.Size = new System.Drawing.Size(224, 26);
            this.tsmTumSiparisler.Text = "Tüm Siparişleri Gör";
            this.tsmTumSiparisler.Click += new System.EventHandler(this.tsmTumSiparisler_Click);
            // 
            // tsmUrunYonetimi
            // 
            this.tsmUrunYonetimi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmMenuEkle,
            this.tsmEkstraEkle,
            this.ürünYönetimiToolStripMenuItem});
            this.tsmUrunYonetimi.Name = "tsmUrunYonetimi";
            this.tsmUrunYonetimi.Size = new System.Drawing.Size(116, 24);
            this.tsmUrunYonetimi.Text = "Ürün Yönetimi";
            // 
            // tsmMenuEkle
            // 
            this.tsmMenuEkle.Name = "tsmMenuEkle";
            this.tsmMenuEkle.Size = new System.Drawing.Size(227, 26);
            this.tsmMenuEkle.Text = "Menü Ekle";
            this.tsmMenuEkle.Click += new System.EventHandler(this.tsmMenuEkle_Click);
            // 
            // tsmEkstraEkle
            // 
            this.tsmEkstraEkle.Name = "tsmEkstraEkle";
            this.tsmEkstraEkle.Size = new System.Drawing.Size(227, 26);
            this.tsmEkstraEkle.Text = "Ekstra Malzeme Ekle";
            this.tsmEkstraEkle.Click += new System.EventHandler(this.tsmEkstraEkle_Click);
            // 
            // ürünYönetimiToolStripMenuItem
            // 
            this.ürünYönetimiToolStripMenuItem.Enabled = false;
            this.ürünYönetimiToolStripMenuItem.Name = "ürünYönetimiToolStripMenuItem";
            this.ürünYönetimiToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.ürünYönetimiToolStripMenuItem.Text = "Ürün Yönetimi";
            this.ürünYönetimiToolStripMenuItem.Click += new System.EventHandler(this.ürünYönetimiToolStripMenuItem_Click);
            // 
            // MyMDIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 482);
            this.Controls.Add(this.msHamburgerMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msHamburgerMenu;
            this.Name = "MyMDIForm";
            this.Text = "MyMDIForm";
            this.msHamburgerMenu.ResumeLayout(false);
            this.msHamburgerMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip msHamburgerMenu;
        private ToolStripMenuItem tsmSiparisYönetimi;
        private ToolStripMenuItem tsmSiparisOlustur;
        private ToolStripMenuItem tsmTumSiparisler;
        private ToolStripMenuItem tsmUrunYonetimi;
        private ToolStripMenuItem tsmMenuEkle;
        private ToolStripMenuItem tsmEkstraEkle;
        private ToolStripMenuItem ürünYönetimiToolStripMenuItem;
    }
}