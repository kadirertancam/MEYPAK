namespace MEYPAK.PRL.KULLANICI
{
    partial class FKullaniciYonetim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FKullaniciYonetim));
            this.panel1 = new System.Windows.Forms.Panel();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.XTPSifre = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.BTNPersonelKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.TBParolaTekrar = new DevExpress.XtraEditors.TextEdit();
            this.TBYeniParola = new DevExpress.XtraEditors.TextEdit();
            this.TBMevcutParola = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LBUserAd = new DevExpress.XtraEditors.LabelControl();
            this.hyperlinkLabelControl1 = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.LBUser = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.XTPSifre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TBParolaTekrar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBYeniParola.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBMevcutParola.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.xtraTabControl1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1075, 538);
            this.panel1.TabIndex = 0;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(214, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.XTPSifre;
            this.xtraTabControl1.Size = new System.Drawing.Size(861, 538);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.XTPSifre,
            this.xtraTabPage2});
            // 
            // XTPSifre
            // 
            this.XTPSifre.Controls.Add(this.labelControl8);
            this.XTPSifre.Controls.Add(this.BTNPersonelKaydet);
            this.XTPSifre.Controls.Add(this.TBParolaTekrar);
            this.XTPSifre.Controls.Add(this.TBYeniParola);
            this.XTPSifre.Controls.Add(this.TBMevcutParola);
            this.XTPSifre.Controls.Add(this.labelControl3);
            this.XTPSifre.Controls.Add(this.labelControl2);
            this.XTPSifre.Controls.Add(this.labelControl1);
            this.XTPSifre.Name = "XTPSifre";
            this.XTPSifre.PageVisible = false;
            this.XTPSifre.Size = new System.Drawing.Size(859, 513);
            this.XTPSifre.Text = "Şifre Değiştir";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Appearance.Options.UseForeColor = true;
            this.labelControl8.Location = new System.Drawing.Point(153, 106);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(107, 11);
            this.labelControl8.TabIndex = 64;
            this.labelControl8.Text = "5 Karakterden az olamaz !";
            // 
            // BTNPersonelKaydet
            // 
            this.BTNPersonelKaydet.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.BTNPersonelKaydet.Appearance.Options.UseBackColor = true;
            this.BTNPersonelKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTNPersonelKaydet.ImageOptions.Image")));
            this.BTNPersonelKaydet.Location = new System.Drawing.Point(153, 175);
            this.BTNPersonelKaydet.Name = "BTNPersonelKaydet";
            this.BTNPersonelKaydet.Size = new System.Drawing.Size(133, 42);
            this.BTNPersonelKaydet.TabIndex = 63;
            this.BTNPersonelKaydet.Text = "&Kaydet";
            this.BTNPersonelKaydet.Click += new System.EventHandler(this.BTNPersonelKaydet_Click);
            // 
            // TBParolaTekrar
            // 
            this.TBParolaTekrar.Location = new System.Drawing.Point(153, 122);
            this.TBParolaTekrar.Name = "TBParolaTekrar";
            this.TBParolaTekrar.Size = new System.Drawing.Size(133, 20);
            this.TBParolaTekrar.TabIndex = 5;
            // 
            // TBYeniParola
            // 
            this.TBYeniParola.Location = new System.Drawing.Point(153, 80);
            this.TBYeniParola.Name = "TBYeniParola";
            this.TBYeniParola.Size = new System.Drawing.Size(133, 20);
            this.TBYeniParola.TabIndex = 4;
            // 
            // TBMevcutParola
            // 
            this.TBMevcutParola.Location = new System.Drawing.Point(153, 43);
            this.TBMevcutParola.Name = "TBMevcutParola";
            this.TBMevcutParola.Size = new System.Drawing.Size(133, 20);
            this.TBMevcutParola.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(63, 125);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(66, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Parola Tekrarı";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(63, 83);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(53, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Yeni Parola";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(63, 46);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(68, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mevcut Parola";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.PageVisible = false;
            this.xtraTabPage2.Size = new System.Drawing.Size(859, 513);
            this.xtraTabPage2.Text = "xtraTabPage2";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LBUserAd);
            this.panel2.Controls.Add(this.hyperlinkLabelControl1);
            this.panel2.Controls.Add(this.LBUser);
            this.panel2.Controls.Add(this.pictureEdit1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(214, 538);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // LBUserAd
            // 
            this.LBUserAd.Location = new System.Drawing.Point(70, 174);
            this.LBUserAd.Name = "LBUserAd";
            this.LBUserAd.Size = new System.Drawing.Size(4, 13);
            this.LBUserAd.TabIndex = 3;
            this.LBUserAd.Text = "|";
            // 
            // hyperlinkLabelControl1
            // 
            this.hyperlinkLabelControl1.Location = new System.Drawing.Point(70, 279);
            this.hyperlinkLabelControl1.Name = "hyperlinkLabelControl1";
            this.hyperlinkLabelControl1.Size = new System.Drawing.Size(64, 13);
            this.hyperlinkLabelControl1.TabIndex = 2;
            this.hyperlinkLabelControl1.Text = "Şifre İşlemleri";
            this.hyperlinkLabelControl1.Click += new System.EventHandler(this.hyperlinkLabelControl1_Click);
            // 
            // LBUser
            // 
            this.LBUser.Location = new System.Drawing.Point(38, 199);
            this.LBUser.Name = "LBUser";
            this.LBUser.Size = new System.Drawing.Size(4, 13);
            this.LBUser.TabIndex = 1;
            this.LBUser.Text = "|";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(58, 37);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(101, 131);
            this.pictureEdit1.TabIndex = 0;
            // 
            // FKullaniciYonetim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 538);
            this.Controls.Add(this.panel1);
            this.Name = "FKullaniciYonetim";
            this.Text = "FKullaniciYonetim";
            this.Load += new System.EventHandler(this.FKullaniciYonetim_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.XTPSifre.ResumeLayout(false);
            this.XTPSifre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TBParolaTekrar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBYeniParola.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBMevcutParola.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DevExpress.XtraEditors.LabelControl LBUser;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage XTPSifre;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.HyperlinkLabelControl hyperlinkLabelControl1;
        private DevExpress.XtraEditors.TextEdit TBParolaTekrar;
        private DevExpress.XtraEditors.TextEdit TBYeniParola;
        private DevExpress.XtraEditors.TextEdit TBMevcutParola;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton BTNPersonelKaydet;
        private DevExpress.XtraEditors.LabelControl LBUserAd;
        private DevExpress.XtraEditors.LabelControl labelControl8;
    }
}