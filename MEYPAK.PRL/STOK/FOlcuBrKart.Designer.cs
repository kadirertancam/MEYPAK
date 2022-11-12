namespace MEYPAK.PRL.STOK
{
    partial class FOlcuBrKart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FOlcuBrKart));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.BTKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.BTSil = new DevExpress.XtraEditors.SimpleButton();
            this.TBOlcuBirim = new DevExpress.XtraEditors.TextEdit();
            this.TBAdi = new DevExpress.XtraEditors.TextEdit();
            this.LBOlcuBirimAdi = new DevExpress.XtraEditors.LabelControl();
            this.LBOlcuBirim = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.DGOlcuBirim = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TBOlcuBirim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGOlcuBirim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.BTKaydet);
            this.groupControl1.Controls.Add(this.BTSil);
            this.groupControl1.Controls.Add(this.TBOlcuBirim);
            this.groupControl1.Controls.Add(this.TBAdi);
            this.groupControl1.Controls.Add(this.LBOlcuBirimAdi);
            this.groupControl1.Controls.Add(this.LBOlcuBirim);
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl1.Location = new System.Drawing.Point(5, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(793, 97);
            this.groupControl1.TabIndex = 81;
            this.groupControl1.Text = "Ölçü Birim";
            // 
            // BTKaydet
            // 
            this.BTKaydet.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.BTKaydet.Appearance.Options.UseBackColor = true;
            this.BTKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTKaydet.ImageOptions.Image")));
            this.BTKaydet.Location = new System.Drawing.Point(288, 34);
            this.BTKaydet.Name = "BTKaydet";
            this.BTKaydet.Size = new System.Drawing.Size(82, 39);
            this.BTKaydet.TabIndex = 77;
            this.BTKaydet.Text = "&Kaydet";
            this.BTKaydet.Click += new System.EventHandler(this.BTKaydet_Click);
            // 
            // BTSil
            // 
            this.BTSil.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.BTSil.Appearance.Options.UseBackColor = true;
            this.BTSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTSil.ImageOptions.Image")));
            this.BTSil.Location = new System.Drawing.Point(376, 34);
            this.BTSil.Name = "BTSil";
            this.BTSil.Size = new System.Drawing.Size(82, 39);
            this.BTSil.TabIndex = 78;
            this.BTSil.Text = "&Sil";
            this.BTSil.Click += new System.EventHandler(this.BTSil_Click);
            // 
            // TBOlcuBirim
            // 
            this.TBOlcuBirim.Location = new System.Drawing.Point(124, 58);
            this.TBOlcuBirim.Name = "TBOlcuBirim";
            this.TBOlcuBirim.Size = new System.Drawing.Size(132, 20);
            this.TBOlcuBirim.TabIndex = 83;
            // 
            // TBAdi
            // 
            this.TBAdi.Location = new System.Drawing.Point(124, 32);
            this.TBAdi.Name = "TBAdi";
            this.TBAdi.Size = new System.Drawing.Size(132, 20);
            this.TBAdi.TabIndex = 82;
            // 
            // LBOlcuBirimAdi
            // 
            this.LBOlcuBirimAdi.Location = new System.Drawing.Point(42, 35);
            this.LBOlcuBirimAdi.Name = "LBOlcuBirimAdi";
            this.LBOlcuBirimAdi.Size = new System.Drawing.Size(64, 13);
            this.LBOlcuBirimAdi.TabIndex = 10;
            this.LBOlcuBirimAdi.Text = "Ölçü Birim Adı";
            // 
            // LBOlcuBirim
            // 
            this.LBOlcuBirim.Location = new System.Drawing.Point(84, 61);
            this.LBOlcuBirim.Name = "LBOlcuBirim";
            this.LBOlcuBirim.Size = new System.Drawing.Size(22, 13);
            this.LBOlcuBirim.TabIndex = 11;
            this.LBOlcuBirim.Text = "Birim";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(800, 101);
            this.panelControl1.TabIndex = 83;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.DGOlcuBirim);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 101);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(800, 349);
            this.panelControl2.TabIndex = 84;
            // 
            // DGOlcuBirim
            // 
            this.DGOlcuBirim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGOlcuBirim.Location = new System.Drawing.Point(2, 2);
            this.DGOlcuBirim.MainView = this.gridView1;
            this.DGOlcuBirim.Name = "DGOlcuBirim";
            this.DGOlcuBirim.Size = new System.Drawing.Size(796, 345);
            this.DGOlcuBirim.TabIndex = 80;
            this.DGOlcuBirim.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.DGOlcuBirim.Load += new System.EventHandler(this.FStokOlcuBrKart_Load);
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView1.GridControl = this.DGOlcuBirim;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // FOlcuBrKart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FOlcuBrKart";
            this.Text = "b";
            this.Load += new System.EventHandler(this.FStokOlcuBrKart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TBOlcuBirim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGOlcuBirim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl LBOlcuBirimAdi;
        private DevExpress.XtraEditors.LabelControl LBOlcuBirim;
        private DevExpress.XtraEditors.SimpleButton BTSil;
        private DevExpress.XtraEditors.SimpleButton BTKaydet;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl DGOlcuBirim;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit TBAdi;
        private DevExpress.XtraEditors.TextEdit TBOlcuBirim;
    }
}