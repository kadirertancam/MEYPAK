namespace MEYPAK.PRL.PERSONEL
{
    partial class FPersonelList
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
            this.DGPersonelList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGPersonelList)).BeginInit();
            this.SuspendLayout();
            // 
            // DGPersonelList
            // 
            this.DGPersonelList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGPersonelList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGPersonelList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGPersonelList.Location = new System.Drawing.Point(0, 0);
            this.DGPersonelList.Name = "DGPersonelList";
            this.DGPersonelList.RowTemplate.Height = 25;
            this.DGPersonelList.Size = new System.Drawing.Size(800, 450);
            this.DGPersonelList.TabIndex = 0;
            this.DGPersonelList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // FPersonelList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DGPersonelList);
            this.Name = "FPersonelList";
            this.Text = "FPersonelList";
            this.Load += new System.EventHandler(this.FPersonelList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGPersonelList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView DGPersonelList;
    }
}