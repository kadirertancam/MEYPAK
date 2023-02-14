namespace MEYPAK.PRL.CEKSENET.Firma.Çek
{
    partial class FFirmaCekListe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FFirmaCekListe));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tileView2 = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.Tutar = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.CariAdi = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.CekNo = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.CekTarih = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.tileView2;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(960, 460);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tileView2});
            // 
            // tileView2
            // 
            this.tileView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Tutar,
            this.CariAdi,
            this.CekNo,
            this.CekTarih});
            this.tileView2.DetailHeight = 303;
            this.tileView2.GridControl = this.gridControl1;
            this.tileView2.Name = "tileView2";
            this.tileView2.OptionsTiles.ColumnCount = 3;
            this.tileView2.OptionsTiles.GroupTextPadding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.tileView2.OptionsTiles.IndentBetweenGroups = 0;
            this.tileView2.OptionsTiles.IndentBetweenItems = 0;
            this.tileView2.OptionsTiles.ItemPadding = new System.Windows.Forms.Padding(21);
            this.tileView2.OptionsTiles.LayoutMode = DevExpress.XtraGrid.Views.Tile.TileViewLayoutMode.List;
            this.tileView2.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tileView2.OptionsTiles.Padding = new System.Windows.Forms.Padding(0);
            this.tileView2.OptionsTiles.RowCount = 0;
            // 
            // 
            // 
            this.tileView2.TileHtmlTemplate.Styles = resources.GetString("tileView2.TileHtmlTemplate.Styles");
            this.tileView2.TileHtmlTemplate.Template = resources.GetString("tileView2.TileHtmlTemplate.Template");
            // 
            // Tutar
            // 
            this.Tutar.AccessibleName = "Tutar";
            this.Tutar.Caption = "Tutar";
            this.Tutar.FieldName = "Tutar";
            this.Tutar.Name = "Tutar";
            this.Tutar.Visible = true;
            this.Tutar.VisibleIndex = 0;
            // 
            // CariAdi
            // 
            this.CariAdi.AccessibleName = "CariAdi";
            this.CariAdi.Caption = "CariAdi";
            this.CariAdi.FieldName = "CariAdi";
            this.CariAdi.MinWidth = 17;
            this.CariAdi.Name = "CariAdi";
            this.CariAdi.Visible = true;
            this.CariAdi.VisibleIndex = 1;
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
            this.CekNo.VisibleIndex = 2;
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
            this.CekTarih.VisibleIndex = 3;
            this.CekTarih.Width = 64;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 460);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gridControl1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(960, 460);
            this.panel3.TabIndex = 3;
            // 
            // FFirmaCekListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 460);
            this.Controls.Add(this.panel1);
            this.Name = "FFirmaCekListe";
            this.Text = "FirmaCekListe";
            this.Load += new System.EventHandler(this.FirmaCekListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Tile.TileView tileView2;
        private DevExpress.XtraGrid.Columns.TileViewColumn CariAdi;
        private DevExpress.XtraGrid.Columns.TileViewColumn CekNo;
        private DevExpress.XtraGrid.Columns.TileViewColumn CekTarih;
        private DevExpress.XtraGrid.Columns.TileViewColumn Tutar;
        private Panel panel1;
        private Panel panel3;
    }
}