namespace MEYPAK.PRL.STOK
{
    partial class FKategoriList
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BTNAltKategoriEkle = new System.Windows.Forms.Button();
            this.BTNYeniKategori = new System.Windows.Forms.Button();
            this.TBAcıklama = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BTNAltKategoriEkle);
            this.panel2.Controls.Add(this.BTNYeniKategori);
            this.panel2.Controls.Add(this.TBAcıklama);
            this.panel2.Controls.Add(this.treeView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 450);
            this.panel2.TabIndex = 2;
            // 
            // BTNAltKategoriEkle
            // 
            this.BTNAltKategoriEkle.Location = new System.Drawing.Point(235, 59);
            this.BTNAltKategoriEkle.Name = "BTNAltKategoriEkle";
            this.BTNAltKategoriEkle.Size = new System.Drawing.Size(126, 23);
            this.BTNAltKategoriEkle.TabIndex = 5;
            this.BTNAltKategoriEkle.Text = "Alt Kategori Ekle";
            this.BTNAltKategoriEkle.UseVisualStyleBackColor = true;
            this.BTNAltKategoriEkle.Click += new System.EventHandler(this.button3_Click);
            // 
            // BTNYeniKategori
            // 
            this.BTNYeniKategori.Location = new System.Drawing.Point(235, 12);
            this.BTNYeniKategori.Name = "BTNYeniKategori";
            this.BTNYeniKategori.Size = new System.Drawing.Size(126, 23);
            this.BTNYeniKategori.TabIndex = 3;
            this.BTNYeniKategori.Text = "Yeni Kategori Ekle";
            this.BTNYeniKategori.UseVisualStyleBackColor = true;
            this.BTNYeniKategori.Click += new System.EventHandler(this.BTNYeniKategori_Click);
            // 
            // TBAcıklama
            // 
            this.TBAcıklama.Location = new System.Drawing.Point(50, 33);
            this.TBAcıklama.Name = "TBAcıklama";
            this.TBAcıklama.Size = new System.Drawing.Size(158, 23);
            this.TBAcıklama.TabIndex = 1;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(3, 102);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(800, 348);
            this.treeView1.TabIndex = 0;
            // 
            // FKategoriList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FKategoriList";
            this.Text = "FStokList";
            this.Load += new System.EventHandler(this.FKategoriList_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private TreeView treeView1;
        private Button BTNAltKategoriEkle;
        private Button BTNYeniKategori;
        private TextBox TBAcıklama;
    }
}