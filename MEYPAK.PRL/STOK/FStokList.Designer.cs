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
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.DGStokList = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.yeniTextEdit1 = new MEYPAK.PRL.Assets.YeniTextEdit();
            this.TSStokList = new System.Windows.Forms.ToolStrip();
            this.TSDuzenle = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSEkle = new System.Windows.Forms.ToolStripButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGStokList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yeniTextEdit1.Properties)).BeginInit();
            this.TSStokList.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.TSStokList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(998, 568);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelControl2);
            this.panel2.Controls.Add(this.panelControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(998, 543);
            this.panel2.TabIndex = 2;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.DGStokList);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(213, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1185, 793);
            this.panelControl2.TabIndex = 2;
            // 
            // DGStokList
            // 
            this.DGStokList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGStokList.Location = new System.Drawing.Point(2, 2);
            this.DGStokList.MainView = this.gridView1;
            this.DGStokList.Name = "DGStokList";
            this.DGStokList.Size = new System.Drawing.Size(998, 543);
            this.DGStokList.TabIndex = 0;
            this.DGStokList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.DGStokList.DoubleClick += new System.EventHandler(this.DGStok_CellDoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 303;
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView1.GridControl = this.DGStokList;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gridView1_KeyPress);
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.panel3);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(213, 793);
            this.panelControl1.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(10, 19);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(31, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Arama";
            // 
            // yeniTextEdit1
            // 
            this.yeniTextEdit1.Location = new System.Drawing.Point(10, 38);
            this.yeniTextEdit1.Name = "yeniTextEdit1";
            this.yeniTextEdit1.Size = new System.Drawing.Size(182, 20);
            this.yeniTextEdit1.TabIndex = 0;
            this.yeniTextEdit1.EditValueChanged += new System.EventHandler(this.yeniTextEdit1_EditValueChanged);
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
            this.TSStokList.Size = new System.Drawing.Size(998, 25);
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
            // panel3
            // 
            this.panel3.Controls.Add(this.yeniTextEdit1);
            this.panel3.Controls.Add(this.labelControl1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(209, 789);
            this.panel3.TabIndex = 2;
            // 
            // FStokList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 568);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FStokList";
            this.Text = "FStokList";
            this.Load += new System.EventHandler(this.FStokList_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGStokList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.yeniTextEdit1.Properties)).EndInit();
            this.TSStokList.ResumeLayout(false);
            this.TSStokList.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private ToolStrip TSStokList;
        private ToolStripButton TSDuzenle;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton TSEkle;
        private DevExpress.XtraGrid.GridControl DGStokList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Assets.YeniTextEdit yeniTextEdit1;
        private Panel panel3;
    }
}