namespace MEYPAK.PRL.STOK
{
    partial class FStokKasaList2
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
            DevExpress.XtraEditors.PanelControl panelControl1;
            this.DGStokKasaList = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(panelControl1)).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGStokKasaList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(this.DGStokKasaList);
            panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            panelControl1.Location = new System.Drawing.Point(0, 0);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new System.Drawing.Size(1201, 732);
            panelControl1.TabIndex = 0;
            // 
            // DGStokKasaList
            // 
            this.DGStokKasaList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGStokKasaList.Location = new System.Drawing.Point(2, 2);
            this.DGStokKasaList.MainView = this.gridView1;
            this.DGStokKasaList.Name = "DGStokKasaList";
            this.DGStokKasaList.Size = new System.Drawing.Size(1197, 728);
            this.DGStokKasaList.TabIndex = 0;
            this.DGStokKasaList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.DGStokKasaList;
            this.gridView1.Name = "gridView1";
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // FStokKasaList2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 732);
            this.Controls.Add(panelControl1);
            this.Name = "FStokKasaList2";
            this.Text = "FStokKasaListesi";
            this.Load += new System.EventHandler(this.FStokKasaList2_Load);
            ((System.ComponentModel.ISupportInitialize)(panelControl1)).EndInit();
            panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGStokKasaList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl DGStokKasaList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}