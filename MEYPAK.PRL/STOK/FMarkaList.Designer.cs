namespace MEYPAK.PRL.STOK
{
    partial class FMarkaList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMarkaList));
            this.DGMarkaList = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TSBSil = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TSBDuzenle = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSBEkle = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.DGMarkaList)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGMarkaList
            // 
            this.DGMarkaList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGMarkaList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGMarkaList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DGMarkaList.Location = new System.Drawing.Point(0, 28);
            this.DGMarkaList.Name = "DGMarkaList";
            this.DGMarkaList.ReadOnly = true;
            this.DGMarkaList.RowTemplate.Height = 25;
            this.DGMarkaList.Size = new System.Drawing.Size(544, 291);
            this.DGMarkaList.TabIndex = 0;
            this.DGMarkaList.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSBSil,
            this.toolStripSeparator2,
            this.TSBDuzenle,
            this.toolStripSeparator1,
            this.TSBEkle});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(544, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TSBSil
            // 
            this.TSBSil.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBSil.Image = ((System.Drawing.Image)(resources.GetObject("TSBSil.Image")));
            this.TSBSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBSil.Name = "TSBSil";
            this.TSBSil.Size = new System.Drawing.Size(23, 22);
            this.TSBSil.Text = "toolStripButton1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // TSBDuzenle
            // 
            this.TSBDuzenle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBDuzenle.Image = ((System.Drawing.Image)(resources.GetObject("TSBDuzenle.Image")));
            this.TSBDuzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBDuzenle.Name = "TSBDuzenle";
            this.TSBDuzenle.Size = new System.Drawing.Size(23, 22);
            this.TSBDuzenle.Text = "Düzenle";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // TSBEkle
            // 
            this.TSBEkle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBEkle.Image = ((System.Drawing.Image)(resources.GetObject("TSBEkle.Image")));
            this.TSBEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBEkle.Name = "TSBEkle";
            this.TSBEkle.Size = new System.Drawing.Size(23, 22);
            this.TSBEkle.Text = "Yeni Kayıt";
            this.TSBEkle.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // FMarkaList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 319);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.DGMarkaList);
            this.Name = "FMarkaList";
            this.Text = "FMarkaList";
            this.Load += new System.EventHandler(this.FMarkaKart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGMarkaList)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView DGMarkaList;
        private ToolStrip toolStrip1;
        private ToolStripButton TSBDuzenle;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton TSBEkle;
        private ToolStripButton TSBSil;
        private ToolStripSeparator toolStripSeparator2;
    }
}