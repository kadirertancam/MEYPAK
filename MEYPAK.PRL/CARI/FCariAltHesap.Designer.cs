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
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.BTKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.BTSil = new DevExpress.XtraEditors.SimpleButton();
            this.CHBAktif = new DevExpress.XtraEditors.CheckEdit();
            this.TBKodu = new DevExpress.XtraEditors.TextEdit();
            this.LBKodu = new DevExpress.XtraEditors.LabelControl();
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
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CHBAktif.Properties)).BeginInit();
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
            this.panelControl1.Size = new System.Drawing.Size(1117, 120);
            this.panelControl1.TabIndex = 3;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.panelControl3);
            this.groupControl1.Controls.Add(this.CHBAktif);
            this.groupControl1.Controls.Add(this.TBKodu);
            this.groupControl1.Controls.Add(this.LBKodu);
            this.groupControl1.Controls.Add(this.CBDoviz);
            this.groupControl1.Controls.Add(this.LBAdi);
            this.groupControl1.Controls.Add(this.LBDoviz);
            this.groupControl1.Controls.Add(this.TBAdi);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl1.Location = new System.Drawing.Point(2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1113, 114);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Alt Hesap";
            // 
            // panelControl3
            // 
            this.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl3.Controls.Add(this.BTKaydet);
            this.panelControl3.Controls.Add(this.BTSil);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl3.Location = new System.Drawing.Point(892, 23);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(219, 89);
            this.panelControl3.TabIndex = 7;
            // 
            // BTKaydet
            // 
            this.BTKaydet.Appearance.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTKaydet.Appearance.Options.UseBackColor = true;
            this.BTKaydet.Appearance.Options.UseFont = true;
            this.BTKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTKaydet.ImageOptions.Image")));
            this.BTKaydet.Location = new System.Drawing.Point(5, 5);
            this.BTKaydet.Name = "BTKaydet";
            this.BTKaydet.Size = new System.Drawing.Size(95, 40);
            this.BTKaydet.TabIndex = 1;
            this.BTKaydet.Text = "&KAYDET";
            this.BTKaydet.Click += new System.EventHandler(this.BTKaydet_Click);
            // 
            // BTSil
            // 
            this.BTSil.Appearance.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTSil.Appearance.Options.UseBackColor = true;
            this.BTSil.Appearance.Options.UseFont = true;
            this.BTSil.AppearanceDisabled.Options.UseImage = true;
            this.BTSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTSil.ImageOptions.Image")));
            this.BTSil.Location = new System.Drawing.Point(106, 5);
            this.BTSil.Name = "BTSil";
            this.BTSil.Size = new System.Drawing.Size(95, 40);
            this.BTSil.TabIndex = 2;
            this.BTSil.Text = "&Sil";
            this.BTSil.Click += new System.EventHandler(this.BTSil_Click);
            // 
            // CHBAktif
            // 
            this.CHBAktif.Location = new System.Drawing.Point(257, 81);
            this.CHBAktif.Name = "CHBAktif";
            this.CHBAktif.Properties.Caption = "Aktif";
            this.CHBAktif.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.CHBAktif.Size = new System.Drawing.Size(64, 20);
            this.CHBAktif.TabIndex = 6;
            // 
            // TBKodu
            // 
            this.TBKodu.Location = new System.Drawing.Point(141, 29);
            this.TBKodu.Name = "TBKodu";
            this.TBKodu.Size = new System.Drawing.Size(180, 20);
            this.TBKodu.TabIndex = 5;
            // 
            // LBKodu
            // 
            this.LBKodu.Appearance.Options.UseFont = true;
            this.LBKodu.Location = new System.Drawing.Point(43, 32);
            this.LBKodu.Name = "LBKodu";
            this.LBKodu.Size = new System.Drawing.Size(73, 13);
            this.LBKodu.TabIndex = 4;
            this.LBKodu.Text = "Alt Hesap Kodu";
            // 
            // CBDoviz
            // 
            this.CBDoviz.Location = new System.Drawing.Point(141, 81);
            this.CBDoviz.Name = "CBDoviz";
            this.CBDoviz.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CBDoviz.Properties.NullText = "";
            this.CBDoviz.Size = new System.Drawing.Size(87, 20);
            this.CBDoviz.TabIndex = 3;
            // 
            // LBAdi
            // 
            this.LBAdi.Location = new System.Drawing.Point(52, 58);
            this.LBAdi.Name = "LBAdi";
            this.LBAdi.Size = new System.Drawing.Size(64, 13);
            this.LBAdi.TabIndex = 0;
            this.LBAdi.Text = "Alt Hesap Adı";
            // 
            // LBDoviz
            // 
            this.LBDoviz.Location = new System.Drawing.Point(90, 84);
            this.LBDoviz.Name = "LBDoviz";
            this.LBDoviz.Size = new System.Drawing.Size(26, 13);
            this.LBDoviz.TabIndex = 1;
            this.LBDoviz.Text = "Döviz";
            // 
            // TBAdi
            // 
            this.TBAdi.Location = new System.Drawing.Point(141, 55);
            this.TBAdi.Name = "TBAdi";
            this.TBAdi.Size = new System.Drawing.Size(180, 20);
            this.TBAdi.TabIndex = 2;
            // 
            // DGAltHesap
            // 
            this.DGAltHesap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGAltHesap.Location = new System.Drawing.Point(2, 2);
            this.DGAltHesap.MainView = this.gridView1;
            this.DGAltHesap.Name = "DGAltHesap";
            this.DGAltHesap.Size = new System.Drawing.Size(1113, 471);
            this.DGAltHesap.TabIndex = 0;
            this.DGAltHesap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.DGAltHesap.Load += new System.EventHandler(this.FCariAltHesap_Load);
            this.DGAltHesap.DoubleClick += new System.EventHandler(this.DGAltHesap_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 303;
            this.gridView1.GridControl = this.DGAltHesap;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsPrint.PrintFilterInfo = true;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.DGAltHesap);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 120);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1117, 475);
            this.panelControl2.TabIndex = 4;
            // 
            // FCariAltHesap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 595);
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
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CHBAktif.Properties)).EndInit();
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
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl DGAltHesap;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.CheckEdit CHBAktif;
        private DevExpress.XtraEditors.SimpleButton BTSil;
        private DevExpress.XtraEditors.TextEdit TBKodu;
        private DevExpress.XtraEditors.LabelControl LBKodu;
        private DevExpress.XtraEditors.SimpleButton BTKaydet;
        private DevExpress.XtraEditors.LookUpEdit CBDoviz;
        private DevExpress.XtraEditors.LabelControl LBAdi;
        private DevExpress.XtraEditors.LabelControl LBDoviz;
        private DevExpress.XtraEditors.TextEdit TBAdi;
        private DevExpress.XtraEditors.PanelControl panelControl3;
    }
}