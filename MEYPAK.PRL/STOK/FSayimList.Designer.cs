namespace MEYPAK.PRL.STOK
{
    partial class FSayimList
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
            this.DGSayimList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGSayimList)).BeginInit();
            this.SuspendLayout();
            // 
            // DGSayimList
            // 
            this.DGSayimList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGSayimList.Location = new System.Drawing.Point(3, 2);
            this.DGSayimList.Name = "DGSayimList";
            this.DGSayimList.RowTemplate.Height = 25;
            this.DGSayimList.Size = new System.Drawing.Size(1019, 448);
            this.DGSayimList.TabIndex = 0;
            // 
            // FSayimList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 452);
            this.Controls.Add(this.DGSayimList);
            this.Name = "FSayimList";
            this.Text = "FSayimList";
            this.Load += new System.EventHandler(this.FSayimList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGSayimList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView DGSayimList;
    }
}