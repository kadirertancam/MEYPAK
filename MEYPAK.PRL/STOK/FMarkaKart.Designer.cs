namespace MEYPAK.PRL.STOK
{
    partial class FMarkaKart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMarkaKart));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DGMarkaKart = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BTSil = new DevExpress.XtraEditors.SimpleButton();
            this.BTKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LBAciklama = new DevExpress.XtraEditors.LabelControl();
            this.LBMarkaAdi = new DevExpress.XtraEditors.LabelControl();
            this.TBMarkaAdi = new DevExpress.XtraEditors.TextEdit();
            this.TBAciklama = new DevExpress.XtraEditors.MemoEdit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGMarkaKart)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TBMarkaAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBAciklama.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 558);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.DGMarkaKart);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 152);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(796, 406);
            this.panel3.TabIndex = 1;
            // 
            // DGMarkaKart
            // 
            this.DGMarkaKart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGMarkaKart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGMarkaKart.Location = new System.Drawing.Point(0, 0);
            this.DGMarkaKart.Name = "DGMarkaKart";
            this.DGMarkaKart.ReadOnly = true;
            this.DGMarkaKart.RowTemplate.Height = 25;
            this.DGMarkaKart.Size = new System.Drawing.Size(796, 406);
            this.DGMarkaKart.TabIndex = 0;
            this.DGMarkaKart.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BTSil);
            this.panel2.Controls.Add(this.BTKaydet);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(796, 152);
            this.panel2.TabIndex = 0;
            // 
            // BTSil
            // 
            this.BTSil.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.BTSil.Appearance.Options.UseBackColor = true;
            this.BTSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTMarkaKartSil.ImageOptions.Image")));
            this.BTSil.Location = new System.Drawing.Point(687, 88);
            this.BTSil.Name = "BTSil";
            this.BTSil.Size = new System.Drawing.Size(94, 52);
            this.BTSil.TabIndex = 80;
            this.BTSil.Text = "Sil";
            this.BTSil.Click += new System.EventHandler(this.BTSil_Click);
            // 
            // BTKaydet
            // 
            this.BTKaydet.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.BTKaydet.Appearance.Options.UseBackColor = true;
            this.BTKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTMarkaKartKaydet.ImageOptions.Image")));
            this.BTKaydet.Location = new System.Drawing.Point(587, 88);
            this.BTKaydet.Name = "BTKaydet";
            this.BTKaydet.Size = new System.Drawing.Size(94, 52);
            this.BTKaydet.TabIndex = 79;
            this.BTKaydet.Text = "Kaydet";
            this.BTKaydet.Click += new System.EventHandler(this.BTKaydet_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TBAciklama);
            this.groupBox1.Controls.Add(this.TBMarkaAdi);
            this.groupBox1.Controls.Add(this.LBAciklama);
            this.groupBox1.Controls.Add(this.LBMarkaAdi);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 140);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Genel";
            // 
            // LBAciklama
            // 
            this.LBAciklama.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBAciklama.Appearance.Options.UseFont = true;
            this.LBAciklama.Location = new System.Drawing.Point(31, 52);
            this.LBAciklama.Name = "LBAciklama";
            this.LBAciklama.Size = new System.Drawing.Size(45, 13);
            this.LBAciklama.TabIndex = 13;
            this.LBAciklama.Text = "Açıklama";
            // 
            // LBMarkaAdi
            // 
            this.LBMarkaAdi.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBMarkaAdi.Appearance.Options.UseFont = true;
            this.LBMarkaAdi.Location = new System.Drawing.Point(24, 27);
            this.LBMarkaAdi.Name = "LBMarkaAdi";
            this.LBMarkaAdi.Size = new System.Drawing.Size(52, 13);
            this.LBMarkaAdi.TabIndex = 12;
            this.LBMarkaAdi.Text = "Marka Adı";
            // 
            // TBMarkaAdi
            // 
            this.TBMarkaAdi.Location = new System.Drawing.Point(93, 24);
            this.TBMarkaAdi.Name = "TBMarkaAdi";
            this.TBMarkaAdi.Size = new System.Drawing.Size(163, 20);
            this.TBMarkaAdi.TabIndex = 81;
            // 
            // TBAciklama
            // 
            this.TBAciklama.Location = new System.Drawing.Point(93, 51);
            this.TBAciklama.Name = "TBAciklama";
            this.TBAciklama.Size = new System.Drawing.Size(163, 77);
            this.TBAciklama.TabIndex = 81;
            // 
            // FMarkaKart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 558);
            this.Controls.Add(this.panel1);
            this.Name = "FMarkaKart";
            this.Text = "FMarkaKart";
            this.Load += new System.EventHandler(this.FMarkaKart_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGMarkaKart)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TBMarkaAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBAciklama.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private DataGridView DGMarkaKart;
        private GroupBox groupBox1;
        private DevExpress.XtraEditors.LabelControl LBMarkaAdi;
        private DevExpress.XtraEditors.LabelControl LBAciklama;
        private DevExpress.XtraEditors.SimpleButton BTSil;
        private DevExpress.XtraEditors.SimpleButton BTKaydet;
        private DevExpress.XtraEditors.TextEdit TBMarkaAdi;
        private DevExpress.XtraEditors.MemoEdit TBAciklama;
    }
}