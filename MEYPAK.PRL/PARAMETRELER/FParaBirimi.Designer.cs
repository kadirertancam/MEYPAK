namespace MEYPAK.PRL.PARAMETRELER
{
    partial class FParaBirimi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FParaBirimi));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.DGParaBrm = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.BTSil = new DevExpress.XtraEditors.SimpleButton();
            this.BTKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.TBParaBrm = new DevExpress.XtraEditors.TextEdit();
            this.TBKisaltma = new DevExpress.XtraEditors.TextEdit();
            this.LBParaBirimi = new DevExpress.XtraEditors.LabelControl();
            this.LBKisa = new DevExpress.XtraEditors.LabelControl();
            this.CBAktif = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGParaBrm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TBParaBrm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBKisaltma.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CBAktif.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(800, 450);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.DGParaBrm);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(2, 131);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(796, 317);
            this.panelControl3.TabIndex = 1;
            // 
            // DGParaBrm
            // 
            this.DGParaBrm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGParaBrm.Location = new System.Drawing.Point(2, 2);
            this.DGParaBrm.MainView = this.gridView1;
            this.DGParaBrm.Name = "DGParaBrm";
            this.DGParaBrm.Size = new System.Drawing.Size(792, 313);
            this.DGParaBrm.TabIndex = 0;
            this.DGParaBrm.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.DGParaBrm;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.groupControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(2, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(796, 129);
            this.panelControl2.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.BTSil);
            this.groupControl1.Controls.Add(this.BTKaydet);
            this.groupControl1.Controls.Add(this.TBParaBrm);
            this.groupControl1.Controls.Add(this.TBKisaltma);
            this.groupControl1.Controls.Add(this.LBParaBirimi);
            this.groupControl1.Controls.Add(this.LBKisa);
            this.groupControl1.Controls.Add(this.CBAktif);
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl1.Location = new System.Drawing.Point(5, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(786, 108);
            this.groupControl1.TabIndex = 78;
            this.groupControl1.Text = "Para Birimi";
            // 
            // BTSil
            // 
            this.BTSil.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.BTSil.Appearance.Options.UseBackColor = true;
            this.BTSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTSil.ImageOptions.Image")));
            this.BTSil.Location = new System.Drawing.Point(356, 32);
            this.BTSil.Name = "BTSil";
            this.BTSil.Size = new System.Drawing.Size(82, 39);
            this.BTSil.TabIndex = 80;
            this.BTSil.Text = "&Sil";
            this.BTSil.Click += new System.EventHandler(this.BTSil_Click);
            // 
            // BTKaydet
            // 
            this.BTKaydet.Appearance.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTKaydet.Appearance.Options.UseBackColor = true;
            this.BTKaydet.Appearance.Options.UseFont = true;
            this.BTKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTKaydet.ImageOptions.Image")));
            this.BTKaydet.Location = new System.Drawing.Point(268, 32);
            this.BTKaydet.Name = "BTKaydet";
            this.BTKaydet.Size = new System.Drawing.Size(82, 39);
            this.BTKaydet.TabIndex = 79;
            this.BTKaydet.Text = "&Kaydet";
            this.BTKaydet.Click += new System.EventHandler(this.BTKaydet_Click);
            // 
            // TBParaBrm
            // 
            this.TBParaBrm.Location = new System.Drawing.Point(99, 29);
            this.TBParaBrm.Name = "TBParaBrm";
            this.TBParaBrm.Size = new System.Drawing.Size(129, 20);
            this.TBParaBrm.TabIndex = 76;
            // 
            // TBKisaltma
            // 
            this.TBKisaltma.Location = new System.Drawing.Point(99, 54);
            this.TBKisaltma.Name = "TBKisaltma";
            this.TBKisaltma.Size = new System.Drawing.Size(129, 20);
            this.TBKisaltma.TabIndex = 77;
            // 
            // LBParaBirimi
            // 
            this.LBParaBirimi.Location = new System.Drawing.Point(36, 32);
            this.LBParaBirimi.Name = "LBParaBirimi";
            this.LBParaBirimi.Size = new System.Drawing.Size(49, 13);
            this.LBParaBirimi.TabIndex = 6;
            this.LBParaBirimi.Text = "Para Birimi";
            // 
            // LBKisa
            // 
            this.LBKisa.Location = new System.Drawing.Point(46, 56);
            this.LBKisa.Name = "LBKisa";
            this.LBKisa.Size = new System.Drawing.Size(39, 13);
            this.LBKisa.TabIndex = 7;
            this.LBKisa.Text = "Kısaltma";
            // 
            // CBAktif
            // 
            this.CBAktif.Location = new System.Drawing.Point(109, 80);
            this.CBAktif.Name = "CBAktif";
            this.CBAktif.Properties.Appearance.Options.UseFont = true;
            this.CBAktif.Properties.Caption = "Aktif";
            this.CBAktif.Size = new System.Drawing.Size(75, 20);
            this.CBAktif.TabIndex = 22;
            // 
            // FParaBirimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelControl1);
            this.Name = "FParaBirimi";
            this.Text = "FParaBirimi";
            this.Load += new System.EventHandler(this.FParaBirimi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGParaBrm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TBParaBrm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBKisaltma.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CBAktif.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl DGParaBrm;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl LBParaBirimi;
        private DevExpress.XtraEditors.LabelControl LBKisa;
        private DevExpress.XtraEditors.CheckEdit CBAktif;
        private DevExpress.XtraEditors.TextEdit TBParaBrm;
        private DevExpress.XtraEditors.TextEdit TBKisaltma;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton BTKaydet;
        private DevExpress.XtraEditors.SimpleButton BTSil;
    }
}