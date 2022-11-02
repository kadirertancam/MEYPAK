namespace MEYPAK.PRL.STOK
{
    partial class FStokOlcuBrList
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
            this.GCStokOlcuList = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.GCStokOlcuList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GCStokOlcuList
            // 
            this.GCStokOlcuList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GCStokOlcuList.Location = new System.Drawing.Point(0, 0);
            this.GCStokOlcuList.MainView = this.gridView1;
            this.GCStokOlcuList.Name = "GCStokOlcuList";
            this.GCStokOlcuList.Size = new System.Drawing.Size(376, 340);
            this.GCStokOlcuList.TabIndex = 0;
            this.GCStokOlcuList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView1.GridControl = this.GCStokOlcuList;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // FStokOlcuBrList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 340);
            this.Controls.Add(this.GCStokOlcuList);
            this.Name = "FStokOlcuBrList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FStokOlcuBrList";
            this.Load += new System.EventHandler(this.FStokOlcuBrList_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.GCStokOlcuList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GCStokOlcuList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}