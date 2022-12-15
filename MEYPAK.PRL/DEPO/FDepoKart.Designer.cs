namespace MEYPAK.PRL.DEPO
{
    partial class FDepoKart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FDepoKart));
            this.GCDepoKart = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BTDepoTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.BTDepoKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.BTDepoKartSil = new DevExpress.XtraEditors.SimpleButton();
            this.GCGenelBilgi = new DevExpress.XtraEditors.GroupControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.TBAciklama = new DevExpress.XtraEditors.MemoEdit();
            this.TBAdi = new DevExpress.XtraEditors.TextEdit();
            this.TBKod = new DevExpress.XtraEditors.TextEdit();
            this.CBAktif = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.LBDepoKartSubeler = new DevExpress.XtraEditors.LabelControl();
            this.CLBSubeler = new System.Windows.Forms.CheckedListBox();
            this.LBDepoKartAdi = new DevExpress.XtraEditors.LabelControl();
            this.LBDepoKartAciklama = new DevExpress.XtraEditors.LabelControl();
            this.LBDepoKartKod = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.GCDepoKart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GCGenelBilgi)).BeginInit();
            this.GCGenelBilgi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TBAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBKod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CBAktif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GCDepoKart
            // 
            this.GCDepoKart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GCDepoKart.Location = new System.Drawing.Point(2, 2);
            this.GCDepoKart.MainView = this.gridView1;
            this.GCDepoKart.Name = "GCDepoKart";
            this.GCDepoKart.Size = new System.Drawing.Size(1122, 705);
            this.GCDepoKart.TabIndex = 1;
            this.GCDepoKart.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.GCDepoKart.DoubleClick += new System.EventHandler(this.GCDepoKart_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 303;
            this.gridView1.GridControl = this.GCDepoKart;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridView1_RowStyle);
            // 
            // BTDepoTemizle
            // 
            this.BTDepoTemizle.Appearance.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTDepoTemizle.Appearance.Options.UseBackColor = true;
            this.BTDepoTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTDepoTemizle.ImageOptions.Image")));
            this.BTDepoTemizle.Location = new System.Drawing.Point(200, 3);
            this.BTDepoTemizle.Name = "BTDepoTemizle";
            this.BTDepoTemizle.Size = new System.Drawing.Size(95, 40);
            this.BTDepoTemizle.TabIndex = 65;
            this.BTDepoTemizle.Text = "&Temizle";
            this.BTDepoTemizle.Click += new System.EventHandler(this.BTDepoTemizle_Click);
            // 
            // BTDepoKaydet
            // 
            this.BTDepoKaydet.Appearance.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTDepoKaydet.Appearance.Options.UseBackColor = true;
            this.BTDepoKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTDepoKaydet.ImageOptions.Image")));
            this.BTDepoKaydet.Location = new System.Drawing.Point(3, 3);
            this.BTDepoKaydet.Name = "BTDepoKaydet";
            this.BTDepoKaydet.Size = new System.Drawing.Size(95, 40);
            this.BTDepoKaydet.TabIndex = 64;
            this.BTDepoKaydet.Text = "&Kaydet";
            this.BTDepoKaydet.Click += new System.EventHandler(this.BTDepoKartEkle_Click);
            // 
            // BTDepoKartSil
            // 
            this.BTDepoKartSil.Appearance.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTDepoKartSil.Appearance.Options.UseBackColor = true;
            this.BTDepoKartSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTDepoKartSil.ImageOptions.Image")));
            this.BTDepoKartSil.Location = new System.Drawing.Point(102, 3);
            this.BTDepoKartSil.Name = "BTDepoKartSil";
            this.BTDepoKartSil.Size = new System.Drawing.Size(95, 40);
            this.BTDepoKartSil.TabIndex = 47;
            this.BTDepoKartSil.Text = "&Sil";
            this.BTDepoKartSil.Click += new System.EventHandler(this.BTDepoKartSil_Click);
            // 
            // GCGenelBilgi
            // 
            this.GCGenelBilgi.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("GCGenelBilgi.CaptionImageOptions.Image")));
            this.GCGenelBilgi.Controls.Add(this.panelControl3);
            this.GCGenelBilgi.Controls.Add(this.TBAciklama);
            this.GCGenelBilgi.Controls.Add(this.TBAdi);
            this.GCGenelBilgi.Controls.Add(this.TBKod);
            this.GCGenelBilgi.Controls.Add(this.CBAktif);
            this.GCGenelBilgi.Controls.Add(this.LBDepoKartSubeler);
            this.GCGenelBilgi.Controls.Add(this.CLBSubeler);
            this.GCGenelBilgi.Controls.Add(this.LBDepoKartAdi);
            this.GCGenelBilgi.Controls.Add(this.LBDepoKartAciklama);
            this.GCGenelBilgi.Controls.Add(this.LBDepoKartKod);
            this.GCGenelBilgi.Dock = System.Windows.Forms.DockStyle.Top;
            this.GCGenelBilgi.Location = new System.Drawing.Point(2, 2);
            this.GCGenelBilgi.Name = "GCGenelBilgi";
            this.GCGenelBilgi.Size = new System.Drawing.Size(1122, 211);
            this.GCGenelBilgi.TabIndex = 1;
            this.GCGenelBilgi.Text = "Depo Tanım";
            // 
            // panelControl3
            // 
            this.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl3.Controls.Add(this.BTDepoKartSil);
            this.panelControl3.Controls.Add(this.BTDepoTemizle);
            this.panelControl3.Controls.Add(this.BTDepoKaydet);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl3.Location = new System.Drawing.Point(821, 23);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(299, 186);
            this.panelControl3.TabIndex = 2;
            // 
            // TBAciklama
            // 
            this.TBAciklama.Location = new System.Drawing.Point(118, 108);
            this.TBAciklama.Name = "TBAciklama";
            this.TBAciklama.Properties.Appearance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TBAciklama.Properties.Appearance.Options.UseForeColor = true;
            this.TBAciklama.Size = new System.Drawing.Size(297, 69);
            this.TBAciklama.TabIndex = 66;
            // 
            // TBAdi
            // 
            this.TBAdi.Location = new System.Drawing.Point(118, 82);
            this.TBAdi.Name = "TBAdi";
            this.TBAdi.Size = new System.Drawing.Size(297, 20);
            this.TBAdi.TabIndex = 60;
            // 
            // TBKod
            // 
            this.TBKod.Location = new System.Drawing.Point(118, 56);
            this.TBKod.Name = "TBKod";
            this.TBKod.Size = new System.Drawing.Size(297, 20);
            this.TBKod.TabIndex = 59;
            // 
            // CBAktif
            // 
            this.CBAktif.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.CBAktif.Appearance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CBAktif.Appearance.Options.UseBackColor = true;
            this.CBAktif.Appearance.Options.UseFont = true;
            this.CBAktif.Appearance.Options.UseForeColor = true;
            this.CBAktif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CBAktif.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.CBAktif.CheckOnClick = true;
            this.CBAktif.IncrementalSearch = true;
            this.CBAktif.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(true, "Aktif", System.Windows.Forms.CheckState.Indeterminate)});
            this.CBAktif.Location = new System.Drawing.Point(511, 150);
            this.CBAktif.Name = "CBAktif";
            this.CBAktif.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.CBAktif.Size = new System.Drawing.Size(81, 27);
            this.CBAktif.TabIndex = 58;
            // 
            // LBDepoKartSubeler
            // 
            this.LBDepoKartSubeler.Appearance.Options.UseFont = true;
            this.LBDepoKartSubeler.Location = new System.Drawing.Point(469, 59);
            this.LBDepoKartSubeler.Name = "LBDepoKartSubeler";
            this.LBDepoKartSubeler.Size = new System.Drawing.Size(36, 13);
            this.LBDepoKartSubeler.TabIndex = 57;
            this.LBDepoKartSubeler.Text = "Şubeler";
            // 
            // CLBSubeler
            // 
            this.CLBSubeler.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CLBSubeler.FormattingEnabled = true;
            this.CLBSubeler.Location = new System.Drawing.Point(511, 59);
            this.CLBSubeler.Name = "CLBSubeler";
            this.CLBSubeler.Size = new System.Drawing.Size(169, 82);
            this.CLBSubeler.TabIndex = 5;
            // 
            // LBDepoKartAdi
            // 
            this.LBDepoKartAdi.Location = new System.Drawing.Point(83, 85);
            this.LBDepoKartAdi.Name = "LBDepoKartAdi";
            this.LBDepoKartAdi.Size = new System.Drawing.Size(15, 13);
            this.LBDepoKartAdi.TabIndex = 4;
            this.LBDepoKartAdi.Text = "Adı";
            // 
            // LBDepoKartAciklama
            // 
            this.LBDepoKartAciklama.Location = new System.Drawing.Point(57, 109);
            this.LBDepoKartAciklama.Name = "LBDepoKartAciklama";
            this.LBDepoKartAciklama.Size = new System.Drawing.Size(41, 13);
            this.LBDepoKartAciklama.TabIndex = 5;
            this.LBDepoKartAciklama.Text = "Açıklama";
            // 
            // LBDepoKartKod
            // 
            this.LBDepoKartKod.Location = new System.Drawing.Point(80, 59);
            this.LBDepoKartKod.Name = "LBDepoKartKod";
            this.LBDepoKartKod.Size = new System.Drawing.Size(18, 13);
            this.LBDepoKartKod.TabIndex = 3;
            this.LBDepoKartKod.Text = "Kod";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl4);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1130, 930);
            this.panelControl1.TabIndex = 1;
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.GCDepoKart);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl4.Location = new System.Drawing.Point(2, 219);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(1126, 709);
            this.panelControl4.TabIndex = 3;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.GCGenelBilgi);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(2, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1126, 217);
            this.panelControl2.TabIndex = 2;
            // 
            // FDepoKart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 930);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FDepoKart";
            this.Text = "FDepoKart";
            this.Load += new System.EventHandler(this.FDepoKart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GCDepoKart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GCGenelBilgi)).EndInit();
            this.GCGenelBilgi.ResumeLayout(false);
            this.GCGenelBilgi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TBAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBKod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CBAktif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private CheckedListBox CLBSubeler;
        private DevExpress.XtraEditors.GroupControl GCGenelBilgi;
        private DevExpress.XtraEditors.LabelControl LBDepoKartKod;
        private DevExpress.XtraEditors.LabelControl LBDepoKartAdi;
        private DevExpress.XtraEditors.LabelControl LBDepoKartAciklama;
        private DevExpress.XtraEditors.LabelControl LBDepoKartSubeler;
        private DevExpress.XtraEditors.CheckedListBoxControl CBAktif;
        private DevExpress.XtraEditors.SimpleButton BTDepoKartSil;
        private DevExpress.XtraGrid.GridControl GCDepoKart;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit TBKod;
        private DevExpress.XtraEditors.TextEdit TBAdi;
        private DevExpress.XtraEditors.SimpleButton BTDepoKaydet;
        private DevExpress.XtraEditors.SimpleButton BTDepoTemizle;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.MemoEdit TBAciklama;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.PanelControl panelControl3;
    }
}