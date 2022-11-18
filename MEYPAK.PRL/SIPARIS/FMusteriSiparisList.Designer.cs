namespace MEYPAK.PRL.SIPARIS
{
    partial class FMusteriSiparisList
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
            this.GCMusteriSiparisList = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.GCMusteriSiparisList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GCMusteriSiparisList
            // 
            this.GCMusteriSiparisList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GCMusteriSiparisList.Location = new System.Drawing.Point(0, 0);
            this.GCMusteriSiparisList.MainView = this.gridView1;
            this.GCMusteriSiparisList.Name = "GCMusteriSiparisList";
            this.GCMusteriSiparisList.Size = new System.Drawing.Size(800, 450);
            this.GCMusteriSiparisList.TabIndex = 0;
            this.GCMusteriSiparisList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.GCMusteriSiparisList;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // FMusteriSiparisList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GCMusteriSiparisList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FMusteriSiparisList";
            this.Text = "FMusteriSiparisList";
            this.Load += new System.EventHandler(this.FMusteriSiparisList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GCMusteriSiparisList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GCMusteriSiparis;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl GCMusteriSiparisList;
    }
}