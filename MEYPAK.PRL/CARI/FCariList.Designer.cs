namespace MEYPAK.PRL.CARI
{
    partial class FCariList
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
            this.DGCariList = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DGCariList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGCariList
            // 
            this.DGCariList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGCariList.Location = new System.Drawing.Point(0, 0);
            this.DGCariList.MainView = this.gridView1;
            this.DGCariList.Name = "DGCariList";
            this.DGCariList.Size = new System.Drawing.Size(1275, 693);
            this.DGCariList.TabIndex = 0;
            this.DGCariList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.DGCariList.Load += new System.EventHandler(this.DGCariList_Load);
            this.DGCariList.DoubleClick += new System.EventHandler(this.DGCariList_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 303;
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView1.GridControl = this.DGCariList;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DGCariList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1275, 693);
            this.panel1.TabIndex = 1;
            // 
            // FCariList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 693);
            this.Controls.Add(this.panel1);
            this.Name = "FCariList";
            this.Text = "FCariList";
            this.Load += new System.EventHandler(this.DGCariList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGCariList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl DGCariList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private Panel panel1;
    }
}