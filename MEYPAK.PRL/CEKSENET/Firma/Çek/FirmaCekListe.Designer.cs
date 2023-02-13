namespace MEYPAK.PRL.CEKSENET.Firma.Çek
{
    partial class FirmaCekListe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirmaCekListe));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.tileView1 = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tileView2 = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.CariAdi = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.CekNo = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.CekTarih = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.LBYaklasanCek = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl4);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(960, 460);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.gridControl2);
            this.panelControl4.Controls.Add(this.labelControl1);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl4.Location = new System.Drawing.Point(641, 2);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(317, 456);
            this.panelControl4.TabIndex = 1;
            // 
            // gridControl2
            // 
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(2, 21);
            this.gridControl2.MainView = this.tileView1;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(313, 433);
            this.gridControl2.TabIndex = 0;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tileView1});
            // 
            // tileView1
            // 
            this.tileView1.DetailHeight = 303;
            this.tileView1.GridControl = this.gridControl2;
            this.tileView1.Name = "tileView1";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl1.Location = new System.Drawing.Point(2, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(124, 19);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "GEÇEN ÇEKLER";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gridControl1);
            this.panelControl2.Controls.Add(this.LBYaklasanCek);
            this.panelControl2.Location = new System.Drawing.Point(2, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(635, 456);
            this.panelControl2.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 21);
            this.gridControl1.MainView = this.tileView2;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(631, 433);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tileView2});
            // 
            // tileView2
            // 
            this.tileView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CariAdi,
            this.CekNo,
            this.CekTarih});
            this.tileView2.DetailHeight = 303;
            this.tileView2.GridControl = this.gridControl1;
            this.tileView2.Name = "tileView2";
            // 
            // 
            // 
            this.tileView2.TileHtmlTemplate.Styles = resources.GetString("tileView2.TileHtmlTemplate.Styles");
            this.tileView2.TileHtmlTemplate.Template = resources.GetString("tileView2.TileHtmlTemplate.Template");
            // 
            // CariAdi
            // 
            this.CariAdi.AccessibleName = "CariAdi";
            this.CariAdi.Caption = "CariAdi";
            this.CariAdi.FieldName = "CariAdi";
            this.CariAdi.MinWidth = 17;
            this.CariAdi.Name = "CariAdi";
            this.CariAdi.Visible = true;
            this.CariAdi.VisibleIndex = 0;
            this.CariAdi.Width = 64;
            // 
            // CekNo
            // 
            this.CekNo.AccessibleName = "CekNo";
            this.CekNo.Caption = "CekNo";
            this.CekNo.FieldName = "CekNo";
            this.CekNo.MinWidth = 17;
            this.CekNo.Name = "CekNo";
            this.CekNo.Visible = true;
            this.CekNo.VisibleIndex = 1;
            this.CekNo.Width = 64;
            // 
            // CekTarih
            // 
            this.CekTarih.AccessibleName = "CekTarih";
            this.CekTarih.Caption = "CekTarih";
            this.CekTarih.FieldName = "CekTarih";
            this.CekTarih.MinWidth = 17;
            this.CekTarih.Name = "CekTarih";
            this.CekTarih.Visible = true;
            this.CekTarih.VisibleIndex = 2;
            this.CekTarih.Width = 64;
            // 
            // LBYaklasanCek
            // 
            this.LBYaklasanCek.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBYaklasanCek.Appearance.Options.UseFont = true;
            this.LBYaklasanCek.Dock = System.Windows.Forms.DockStyle.Top;
            this.LBYaklasanCek.Location = new System.Drawing.Point(2, 2);
            this.LBYaklasanCek.Name = "LBYaklasanCek";
            this.LBYaklasanCek.Size = new System.Drawing.Size(158, 19);
            this.LBYaklasanCek.TabIndex = 0;
            this.LBYaklasanCek.Text = "YAKLAŞAN ÇEKLER";
            // 
            // FirmaCekListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 460);
            this.Controls.Add(this.panelControl1);
            this.Name = "FirmaCekListe";
            this.Text = "FirmaCekListe";
            this.Load += new System.EventHandler(this.FirmaCekListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Tile.TileView tileView1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Tile.TileView tileView2;
        private DevExpress.XtraEditors.LabelControl LBYaklasanCek;
        private DevExpress.XtraGrid.Columns.TileViewColumn CariAdi;
        private DevExpress.XtraGrid.Columns.TileViewColumn CekNo;
        private DevExpress.XtraGrid.Columns.TileViewColumn CekTarih;
    }
}