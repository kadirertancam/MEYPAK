namespace MEYPAK.PRL.KASA
{
    partial class FKasaList
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
            this.GCKasa = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.GCKasa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GCKasa
            // 
            this.GCKasa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GCKasa.Location = new System.Drawing.Point(0, 0);
            this.GCKasa.MainView = this.gridView1;
            this.GCKasa.Name = "GCKasa";
            this.GCKasa.Size = new System.Drawing.Size(800, 450);
            this.GCKasa.TabIndex = 0;
            this.GCKasa.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.GCKasa.DoubleClick += new System.EventHandler(this.GCKasa_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.GCKasa;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // FKasaList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GCKasa);
            this.Name = "FKasaList";
            this.Text = "FKasaList";
            this.Load += new System.EventHandler(this.FKasaList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GCKasa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GCKasa;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}