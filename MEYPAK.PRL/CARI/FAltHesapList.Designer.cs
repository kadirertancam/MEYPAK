namespace MEYPAK.PRL.CARI
{
    partial class FAltHesapList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAltHesapList));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.DGAltHesap = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TSStokList = new System.Windows.Forms.ToolStrip();
            this.TSDuzenle = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSEkle = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGAltHesap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.TSStokList.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.DGAltHesap);
            this.panelControl1.Controls.Add(this.TSStokList);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(686, 390);
            this.panelControl1.TabIndex = 0;
            // 
            // DGAltHesap
            // 
            this.DGAltHesap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGAltHesap.Location = new System.Drawing.Point(2, 27);
            this.DGAltHesap.MainView = this.gridView1;
            this.DGAltHesap.Name = "DGAltHesap";
            this.DGAltHesap.Size = new System.Drawing.Size(682, 361);
            this.DGAltHesap.TabIndex = 3;
            this.DGAltHesap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.DGAltHesap.DoubleClick += new System.EventHandler(this.DGAltHesap_CellDoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 303;
            this.gridView1.GridControl = this.DGAltHesap;
            this.gridView1.Name = "gridView1";
            // 
            // TSStokList
            // 
            this.TSStokList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSDuzenle,
            this.toolStripSeparator1,
            this.TSEkle});
            this.TSStokList.Location = new System.Drawing.Point(2, 2);
            this.TSStokList.Name = "TSStokList";
            this.TSStokList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TSStokList.Size = new System.Drawing.Size(682, 25);
            this.TSStokList.TabIndex = 2;
            this.TSStokList.Text = "toolStrip1";
            // 
            // TSDuzenle
            // 
            this.TSDuzenle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSDuzenle.Image = ((System.Drawing.Image)(resources.GetObject("TSDuzenle.Image")));
            this.TSDuzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSDuzenle.Name = "TSDuzenle";
            this.TSDuzenle.Size = new System.Drawing.Size(23, 22);
            this.TSDuzenle.Text = "toolStripButton1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // TSEkle
            // 
            this.TSEkle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSEkle.Image = ((System.Drawing.Image)(resources.GetObject("TSEkle.Image")));
            this.TSEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSEkle.Name = "TSEkle";
            this.TSEkle.Size = new System.Drawing.Size(23, 22);
            this.TSEkle.Text = "toolStripButton2";
            // 
            // FAltHesapList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FAltHesapList";
            this.Text = "FAltHesapList";
            this.Load += new System.EventHandler(this.FAltHesapList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGAltHesap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.TSStokList.ResumeLayout(false);
            this.TSStokList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private ToolStrip TSStokList;
        private ToolStripButton TSDuzenle;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton TSEkle;
        private DevExpress.XtraGrid.GridControl DGAltHesap;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}