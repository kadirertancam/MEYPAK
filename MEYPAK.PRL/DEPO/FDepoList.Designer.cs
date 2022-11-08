namespace MEYPAK.PRL.DEPO
{
    partial class FDepoList
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
            this.DGDepoList = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGDepoList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DGDepoList
            // 
            this.DGDepoList.Location = new System.Drawing.Point(1, 2);
            this.DGDepoList.MainView = this.gridView1;
            this.DGDepoList.Name = "DGDepoList";
            this.DGDepoList.Size = new System.Drawing.Size(796, 445);
            this.DGDepoList.TabIndex = 0;
            this.DGDepoList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.DGDepoList;
            this.gridView1.Name = "gridView1";
            // 
            // FDepoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DGDepoList);
            this.Name = "FDepoList";
            this.Text = "FDepoList";
            this.Load += new System.EventHandler(this.FDepoList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGDepoList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl DGDepoList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}