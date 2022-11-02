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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FKategoriList));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.TBKategoriList = new DevExpress.XtraEditors.TextEdit();
            this.BTNAltKategoriEkle = new DevExpress.XtraEditors.SimpleButton();
            this.BTNYeniKategori = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TBKategoriList.Properties)).BeginInit();
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
            this.panel2.Controls.Add(this.TBKategoriList);
            this.panel2.Controls.Add(this.treeView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 450);
            this.panel2.TabIndex = 2;
            // 
            // treeView1
            // 
            this.treeView1.FullRowSelect = true;
            this.treeView1.Location = new System.Drawing.Point(3, 102);
            this.treeView1.Name = "treeView1";
            this.treeView1.ShowLines = false;
            this.treeView1.Size = new System.Drawing.Size(800, 348);
            this.treeView1.TabIndex = 0;
            this.treeView1.DoubleClick += new System.EventHandler(this.treeView1_DoubleClick);
            this.treeView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.treeView1_KeyPress);
            // 
            // TBKategoriList
            // 
            this.TBKategoriList.Location = new System.Drawing.Point(48, 39);
            this.TBKategoriList.Name = "TBKategoriList";
            this.TBKategoriList.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TBKategoriList.Properties.Appearance.Options.UseFont = true;
            this.TBKategoriList.Properties.Padding = new System.Windows.Forms.Padding(3);
            this.TBKategoriList.Size = new System.Drawing.Size(194, 26);
            this.TBKategoriList.TabIndex = 20;
            // 
            // BTNAltKategoriEkle
            // 
            this.BTNAltKategoriEkle.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.BTNAltKategoriEkle.Appearance.Options.UseBackColor = true;
            this.BTNAltKategoriEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTStokHarSil.ImageOptions.Image")));
            this.BTNAltKategoriEkle.Location = new System.Drawing.Point(265, 56);
            this.BTNAltKategoriEkle.Name = "BTNAltKategoriEkle";
            this.BTNAltKategoriEkle.Size = new System.Drawing.Size(163, 32);
            this.BTNAltKategoriEkle.TabIndex = 78;
            this.BTNAltKategoriEkle.Text = "Alt Kategori Ekle";
            // 
            // BTNYeniKategori
            // 
            this.BTNYeniKategori.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.BTNYeniKategori.Appearance.Options.UseBackColor = true;
            this.BTNYeniKategori.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTStokHarDegistir.ImageOptions.Image")));
            this.BTNYeniKategori.Location = new System.Drawing.Point(265, 12);
            this.BTNYeniKategori.Name = "BTNYeniKategori";
            this.BTNYeniKategori.Size = new System.Drawing.Size(163, 32);
            this.BTNYeniKategori.TabIndex = 77;
            this.BTNYeniKategori.Text = "Yeni Kategori Ekle";
            // 
            // FKategoriList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FKategoriList";
            this.Text = "FKategoriList";
            this.Load += new System.EventHandler(this.FKategoriList_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TBKategoriList.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private TreeView treeView1;
        private DevExpress.XtraEditors.TextEdit TBKategoriList;
        private DevExpress.XtraEditors.SimpleButton BTNAltKategoriEkle;
        private DevExpress.XtraEditors.SimpleButton BTNYeniKategori;
    }
}