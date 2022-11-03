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
            this.DGMusteriSiparis = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGMusteriSiparis)).BeginInit();
            this.SuspendLayout();
            // 
            // DGMusteriSiparis
            // 
            this.DGMusteriSiparis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGMusteriSiparis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGMusteriSiparis.Location = new System.Drawing.Point(0, 0);
            this.DGMusteriSiparis.Name = "DGMusteriSiparis";
            this.DGMusteriSiparis.ReadOnly = true;
            this.DGMusteriSiparis.RowTemplate.Height = 25;
            this.DGMusteriSiparis.Size = new System.Drawing.Size(800, 450);
            this.DGMusteriSiparis.TabIndex = 2;
            this.DGMusteriSiparis.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // FMusteriSiparisList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DGMusteriSiparis);
            this.Name = "FMusteriSiparisList";
            this.Text = "FMusteriSiparisList";
            this.Load += new System.EventHandler(this.FMusteriSiparisList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGMusteriSiparis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView DGMusteriSiparis;
    }
}