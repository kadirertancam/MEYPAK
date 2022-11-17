namespace MEYPAK.PRL.STOK
{
    partial class FStokList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FStokList));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DGStok = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TSStokList = new System.Windows.Forms.ToolStrip();
            this.TSDuzenle = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSEkle = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.TSStokList.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.TSStokList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1064, 564);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DGStok);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1064, 539);
            this.panel2.TabIndex = 2;
            // 
            // DGStok
            // 
            this.DGStok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGStok.Location = new System.Drawing.Point(0, 0);
            this.DGStok.MainView = this.gridView1;
            this.DGStok.Name = "DGStok";
            this.DGStok.Size = new System.Drawing.Size(1064, 539);
            this.DGStok.TabIndex = 0;
            this.DGStok.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView1.GridControl = this.DGStok;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // TSStokList
            // 
            this.TSStokList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSDuzenle,
            this.toolStripSeparator1,
            this.TSEkle});
            this.TSStokList.Location = new System.Drawing.Point(0, 0);
            this.TSStokList.Name = "TSStokList";
            this.TSStokList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TSStokList.Size = new System.Drawing.Size(1064, 25);
            this.TSStokList.TabIndex = 1;
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
            // FStokList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 564);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FStokList";
            this.Text = "FStokList";
            this.Load += new System.EventHandler(this.FStokList_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.TSStokList.ResumeLayout(false);
            this.TSStokList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private ToolStrip TSStokList;
        private ToolStripButton TSDuzenle;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton TSEkle;
        private DevExpress.XtraGrid.GridControl DGStok;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}