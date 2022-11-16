namespace MEYPAK.PRL.STOK
{
    partial class FStokKasaPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FStokKasaPanel));
            this.LBAdi = new DevExpress.XtraEditors.LabelControl();
            this.LBKod = new DevExpress.XtraEditors.LabelControl();
            this.LBAciklama = new DevExpress.XtraEditors.LabelControl();
            this.TBKod = new DevExpress.XtraEditors.TextEdit();
            this.TBAdi = new DevExpress.XtraEditors.TextEdit();
            this.TBAciklama = new DevExpress.XtraEditors.MemoEdit();
            this.BTKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.BTSil = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.DGKasaPanel = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.TBKod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGKasaPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBAdi
            // 
            this.LBAdi.Location = new System.Drawing.Point(50, 57);
            this.LBAdi.Name = "LBAdi";
            this.LBAdi.Size = new System.Drawing.Size(41, 13);
            this.LBAdi.TabIndex = 20;
            this.LBAdi.Text = "Kasa Adı";
            // 
            // LBKod
            // 
            this.LBKod.Location = new System.Drawing.Point(41, 32);
            this.LBKod.Name = "LBKod";
            this.LBKod.Size = new System.Drawing.Size(50, 13);
            this.LBKod.TabIndex = 21;
            this.LBKod.Text = "Kasa Kodu";
            // 
            // LBAciklama
            // 
            this.LBAciklama.Appearance.Options.UseFont = true;
            this.LBAciklama.Location = new System.Drawing.Point(330, 32);
            this.LBAciklama.Name = "LBAciklama";
            this.LBAciklama.Size = new System.Drawing.Size(41, 13);
            this.LBAciklama.TabIndex = 37;
            this.LBAciklama.Text = "Açıklama";
            // 
            // TBKod
            // 
            this.TBKod.Location = new System.Drawing.Point(113, 29);
            this.TBKod.Name = "TBKod";
            this.TBKod.Size = new System.Drawing.Size(180, 20);
            this.TBKod.TabIndex = 80;
            // 
            // TBAdi
            // 
            this.TBAdi.Location = new System.Drawing.Point(113, 55);
            this.TBAdi.Name = "TBAdi";
            this.TBAdi.Size = new System.Drawing.Size(180, 20);
            this.TBAdi.TabIndex = 81;
            // 
            // TBAciklama
            // 
            this.TBAciklama.Location = new System.Drawing.Point(387, 30);
            this.TBAciklama.Name = "TBAciklama";
            this.TBAciklama.Size = new System.Drawing.Size(173, 64);
            this.TBAciklama.TabIndex = 82;
            // 
            // BTKaydet
            // 
            this.BTKaydet.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.BTKaydet.Appearance.Options.UseBackColor = true;
            this.BTKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTKaydet.ImageOptions.Image")));
            this.BTKaydet.Location = new System.Drawing.Point(585, 45);
            this.BTKaydet.Name = "BTKaydet";
            this.BTKaydet.Size = new System.Drawing.Size(82, 39);
            this.BTKaydet.TabIndex = 83;
            this.BTKaydet.Text = "&Kaydet";
            this.BTKaydet.Click += new System.EventHandler(this.BTKaydet_Click);
            // 
            // BTSil
            // 
            this.BTSil.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.BTSil.Appearance.Options.UseBackColor = true;
            this.BTSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTSil.ImageOptions.Image")));
            this.BTSil.Location = new System.Drawing.Point(673, 45);
            this.BTSil.Name = "BTSil";
            this.BTSil.Size = new System.Drawing.Size(82, 39);
            this.BTSil.TabIndex = 84;
            this.BTSil.Text = "&Sil";
            this.BTSil.Click += new System.EventHandler(this.BTSil_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.groupControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(2, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1076, 117);
            this.panelControl2.TabIndex = 13;
            // 
            // DGKasaPanel
            // 
            this.DGKasaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGKasaPanel.Location = new System.Drawing.Point(2, 2);
            this.DGKasaPanel.MainView = this.gridView1;
            this.DGKasaPanel.Name = "DGKasaPanel";
            this.DGKasaPanel.Size = new System.Drawing.Size(1072, 365);
            this.DGKasaPanel.TabIndex = 0;
            this.DGKasaPanel.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.DGKasaPanel;
            this.gridView1.Name = "gridView1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.BTSil);
            this.groupControl1.Controls.Add(this.TBAciklama);
            this.groupControl1.Controls.Add(this.BTKaydet);
            this.groupControl1.Controls.Add(this.LBAdi);
            this.groupControl1.Controls.Add(this.LBKod);
            this.groupControl1.Controls.Add(this.TBAdi);
            this.groupControl1.Controls.Add(this.LBAciklama);
            this.groupControl1.Controls.Add(this.TBKod);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl1.Location = new System.Drawing.Point(2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1072, 113);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Kasa Ekle";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1080, 490);
            this.panelControl1.TabIndex = 14;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.DGKasaPanel);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(2, 119);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1076, 369);
            this.panelControl3.TabIndex = 14;
            // 
            // FStokKasaPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 488);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FStokKasaPanel";
            this.Text = "FKasaPanel";
            this.Load += new System.EventHandler(this.FKasaPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TBKod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGKasaPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl LBAdi;
        private DevExpress.XtraEditors.LabelControl LBKod;
        private DevExpress.XtraEditors.LabelControl LBAciklama;
        private DevExpress.XtraEditors.TextEdit TBKod;
        private DevExpress.XtraEditors.TextEdit TBAdi;
        private DevExpress.XtraEditors.MemoEdit TBAciklama;
        private DevExpress.XtraEditors.SimpleButton BTKaydet;
        private DevExpress.XtraEditors.SimpleButton BTSil;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl DGKasaPanel;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
    }
}