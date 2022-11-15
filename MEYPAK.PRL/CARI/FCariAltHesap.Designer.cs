namespace MEYPAK.PRL.CARI
{
    partial class FCariAltHesap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FCariAltHesap));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.CBAktif1 = new DevExpress.XtraEditors.CheckEdit();
            this.BTSil = new DevExpress.XtraEditors.SimpleButton();
            this.TBKodu = new DevExpress.XtraEditors.TextEdit();
            this.LBKodu = new DevExpress.XtraEditors.LabelControl();
            this.BTKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.CBDoviz = new DevExpress.XtraEditors.LookUpEdit();
            this.LBAdi = new DevExpress.XtraEditors.LabelControl();
            this.LBDoviz = new DevExpress.XtraEditors.LabelControl();
            this.TBAdi = new DevExpress.XtraEditors.TextEdit();
            this.DGAltHesap = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CBAktif1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CBDoviz.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGAltHesap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1303, 138);
            this.panelControl1.TabIndex = 3;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.CBAktif1);
            this.groupControl1.Controls.Add(this.BTSil);
            this.groupControl1.Controls.Add(this.TBKodu);
            this.groupControl1.Controls.Add(this.LBKodu);
            this.groupControl1.Controls.Add(this.BTKaydet);
            this.groupControl1.Controls.Add(this.CBDoviz);
            this.groupControl1.Controls.Add(this.LBAdi);
            this.groupControl1.Controls.Add(this.LBDoviz);
            this.groupControl1.Controls.Add(this.TBAdi);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl1.Location = new System.Drawing.Point(2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1299, 132);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Alt Hesap";
            // 
            // CBAktif1
            // 
            this.CBAktif1.Location = new System.Drawing.Point(230, 90);
            this.CBAktif1.Name = "CBAktif1";
            this.CBAktif1.Properties.Caption = "Aktif";
            this.CBAktif1.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.CBAktif1.Size = new System.Drawing.Size(75, 20);
            this.CBAktif1.TabIndex = 6;
            // 
            // BTSil
            // 
            this.BTSil.Appearance.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTSil.Appearance.Options.UseBackColor = true;
            this.BTSil.Appearance.Options.UseFont = true;
            this.BTSil.AppearanceDisabled.Options.UseImage = true;
            this.BTSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTSil.ImageOptions.Image")));
            this.BTSil.Location = new System.Drawing.Point(429, 41);
            this.BTSil.Name = "BTSil";
            this.BTSil.Size = new System.Drawing.Size(82, 39);
            this.BTSil.TabIndex = 2;
            this.BTSil.Text = "&Sil";
            this.BTSil.Click += new System.EventHandler(this.BTSil_Click);
            // 
            // TBKodu
            // 
            this.TBKodu.Location = new System.Drawing.Point(144, 38);
            this.TBKodu.Name = "TBKodu";
            this.TBKodu.Size = new System.Drawing.Size(161, 20);
            this.TBKodu.TabIndex = 5;
            // 
            // LBKodu
            // 
            this.LBKodu.Appearance.Options.UseFont = true;
            this.LBKodu.Location = new System.Drawing.Point(52, 41);
            this.LBKodu.Name = "LBKodu";
            this.LBKodu.Size = new System.Drawing.Size(73, 13);
            this.LBKodu.TabIndex = 4;
            this.LBKodu.Text = "Alt Hesap Kodu";
            // 
            // BTKaydet
            // 
            this.BTKaydet.Appearance.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTKaydet.Appearance.Options.UseBackColor = true;
            this.BTKaydet.Appearance.Options.UseFont = true;
            this.BTKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTKaydet.ImageOptions.Image")));
            this.BTKaydet.Location = new System.Drawing.Point(341, 41);
            this.BTKaydet.Name = "BTKaydet";
            this.BTKaydet.Size = new System.Drawing.Size(82, 39);
            this.BTKaydet.TabIndex = 1;
            this.BTKaydet.Text = "&Kaydet";
            this.BTKaydet.Click += new System.EventHandler(this.BTKaydet_Click);
            // 
            // CBDoviz
            // 
            this.CBDoviz.Location = new System.Drawing.Point(144, 90);
            this.CBDoviz.Name = "CBDoviz";
            this.CBDoviz.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CBDoviz.Properties.NullText = "";
            this.CBDoviz.Size = new System.Drawing.Size(67, 20);
            this.CBDoviz.TabIndex = 3;
            // 
            // LBAdi
            // 
            this.LBAdi.Location = new System.Drawing.Point(61, 67);
            this.LBAdi.Name = "LBAdi";
            this.LBAdi.Size = new System.Drawing.Size(64, 13);
            this.LBAdi.TabIndex = 0;
            this.LBAdi.Text = "Alt Hesap Adı";
            // 
            // LBDoviz
            // 
            this.LBDoviz.Location = new System.Drawing.Point(99, 93);
            this.LBDoviz.Name = "LBDoviz";
            this.LBDoviz.Size = new System.Drawing.Size(26, 13);
            this.LBDoviz.TabIndex = 1;
            this.LBDoviz.Text = "Döviz";
            // 
            // TBAdi
            // 
            this.TBAdi.Location = new System.Drawing.Point(144, 64);
            this.TBAdi.Name = "TBAdi";
            this.TBAdi.Size = new System.Drawing.Size(161, 20);
            this.TBAdi.TabIndex = 2;
            // 
            // DGAltHesap
            // 
            this.DGAltHesap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGAltHesap.Location = new System.Drawing.Point(2, 2);
            this.DGAltHesap.MainView = this.gridView1;
            this.DGAltHesap.Name = "DGAltHesap";
            this.DGAltHesap.Size = new System.Drawing.Size(1299, 545);
            this.DGAltHesap.TabIndex = 0;
            this.DGAltHesap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.DGAltHesap.Load += new System.EventHandler(this.FCariAltHesap_Load);
            
            this.DGAltHesap.DoubleClick += new System.EventHandler(this.DGAltHesap_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.DGAltHesap;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsPrint.PrintFilterInfo = true;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.DGAltHesap);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 138);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1303, 549);
            this.panelControl2.TabIndex = 4;
            // 
            // FCariAltHesap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 687);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FCariAltHesap";
            this.Text = "FCariAltHesap";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CBAktif1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CBDoviz.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGAltHesap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.CheckEdit CBAktif;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl DGAltHesap;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.CheckEdit CBAktif1;
        private DevExpress.XtraEditors.SimpleButton BTSil;
        private DevExpress.XtraEditors.TextEdit TBKodu;
        private DevExpress.XtraEditors.LabelControl LBKodu;
        private DevExpress.XtraEditors.SimpleButton BTKaydet;
        private DevExpress.XtraEditors.LookUpEdit CBDoviz;
        private DevExpress.XtraEditors.LabelControl LBAdi;
        private DevExpress.XtraEditors.LabelControl LBDoviz;
        private DevExpress.XtraEditors.TextEdit TBAdi;
    }
}