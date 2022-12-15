namespace MEYPAK.PRL.STOK
{
    partial class FMarkaKart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMarkaKart));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.LBMarkaAdi = new DevExpress.XtraEditors.LabelControl();
            this.LBMarkaAciklama = new DevExpress.XtraEditors.LabelControl();
            this.TBMarkaAdi = new DevExpress.XtraEditors.TextEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.TBAciklama = new DevExpress.XtraEditors.MemoEdit();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.BTSil = new DevExpress.XtraEditors.SimpleButton();
            this.BTMarkaKartKaydet = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBMarkaAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TBAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1120, 714);
            this.gridControl1.TabIndex = 81;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 303;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // LBMarkaAdi
            // 
            this.LBMarkaAdi.Location = new System.Drawing.Point(79, 61);
            this.LBMarkaAdi.Name = "LBMarkaAdi";
            this.LBMarkaAdi.Size = new System.Drawing.Size(47, 13);
            this.LBMarkaAdi.TabIndex = 12;
            this.LBMarkaAdi.Text = "Marka Adı";
            // 
            // LBMarkaAciklama
            // 
            this.LBMarkaAciklama.Location = new System.Drawing.Point(85, 85);
            this.LBMarkaAciklama.Name = "LBMarkaAciklama";
            this.LBMarkaAciklama.Size = new System.Drawing.Size(41, 13);
            this.LBMarkaAciklama.TabIndex = 13;
            this.LBMarkaAciklama.Text = "Açıklama";
            // 
            // TBMarkaAdi
            // 
            this.TBMarkaAdi.Location = new System.Drawing.Point(147, 58);
            this.TBMarkaAdi.Name = "TBMarkaAdi";
            this.TBMarkaAdi.Size = new System.Drawing.Size(297, 20);
            this.TBMarkaAdi.TabIndex = 81;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1128, 898);
            this.panelControl1.TabIndex = 2;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.gridControl1);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(2, 178);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1124, 718);
            this.panelControl3.TabIndex = 82;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.groupControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(2, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1124, 176);
            this.panelControl2.TabIndex = 2;
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.groupControl1.Controls.Add(this.TBAciklama);
            this.groupControl1.Controls.Add(this.panelControl4);
            this.groupControl1.Controls.Add(this.TBMarkaAdi);
            this.groupControl1.Controls.Add(this.LBMarkaAciklama);
            this.groupControl1.Controls.Add(this.LBMarkaAdi);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1120, 168);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Marka Tanım";
            // 
            // TBAciklama
            // 
            this.TBAciklama.Location = new System.Drawing.Point(147, 83);
            this.TBAciklama.Name = "TBAciklama";
            this.TBAciklama.Size = new System.Drawing.Size(297, 60);
            this.TBAciklama.TabIndex = 84;
            // 
            // panelControl4
            // 
            this.panelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl4.Controls.Add(this.BTSil);
            this.panelControl4.Controls.Add(this.BTMarkaKartKaydet);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl4.Location = new System.Drawing.Point(913, 33);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(205, 133);
            this.panelControl4.TabIndex = 83;
            // 
            // BTSil
            // 
            this.BTSil.Appearance.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTSil.Appearance.Options.UseBackColor = true;
            this.BTSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTSil.ImageOptions.Image")));
            this.BTSil.Location = new System.Drawing.Point(104, 3);
            this.BTSil.Name = "BTSil";
            this.BTSil.Size = new System.Drawing.Size(95, 40);
            this.BTSil.TabIndex = 83;
            this.BTSil.Text = "&Sil";
            this.BTSil.Click += new System.EventHandler(this.BTSil_Click);
            // 
            // BTMarkaKartKaydet
            // 
            this.BTMarkaKartKaydet.Appearance.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTMarkaKartKaydet.Appearance.Options.UseBackColor = true;
            this.BTMarkaKartKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTMarkaKartKaydet.ImageOptions.Image")));
            this.BTMarkaKartKaydet.Location = new System.Drawing.Point(3, 3);
            this.BTMarkaKartKaydet.Name = "BTMarkaKartKaydet";
            this.BTMarkaKartKaydet.Size = new System.Drawing.Size(95, 40);
            this.BTMarkaKartKaydet.TabIndex = 82;
            this.BTMarkaKartKaydet.Text = "&KAYDET";
            this.BTMarkaKartKaydet.Click += new System.EventHandler(this.BTMarkaKartKaydet_Click);
            // 
            // FMarkaKart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 898);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FMarkaKart";
            this.Text = "FMarkaKart";
            this.Load += new System.EventHandler(this.FMarkaKart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBMarkaAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TBAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl LBMarkaAdi;
        private DevExpress.XtraEditors.LabelControl LBMarkaAciklama;
        private DevExpress.XtraEditors.TextEdit TBMarkaAdi;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton BTMarkaKartKaydet;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.SimpleButton BTSil;
        private DevExpress.XtraEditors.MemoEdit TBAciklama;
    }
}