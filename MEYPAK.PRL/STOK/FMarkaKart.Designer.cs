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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TBMarkaAdi = new System.Windows.Forms.TextBox();
            this.TBAciklama = new System.Windows.Forms.TextBox();
            this.LBMarkaAdi = new DevExpress.XtraEditors.LabelControl();
            this.LBMarkaAciklama = new DevExpress.XtraEditors.LabelControl();
            this.BTMarkaKartSil = new DevExpress.XtraEditors.SimpleButton();
            this.BTMarkaKartKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGMarkaKart)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.DGMarkaKart);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 152);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 298);
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
            this.DGMarkaKart.Size = new System.Drawing.Size(800, 298);
            this.DGMarkaKart.TabIndex = 0;
            this.DGMarkaKart.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BTMarkaKartSil);
            this.panel2.Controls.Add(this.BTMarkaKartKaydet);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 152);
            this.panel2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LBMarkaAciklama);
            this.groupBox1.Controls.Add(this.LBMarkaAdi);
            this.groupBox1.Controls.Add(this.TBMarkaAdi);
            this.groupBox1.Controls.Add(this.TBAciklama);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 134);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Genel";
            // 
            // TBMarkaAdi
            // 
            this.TBMarkaAdi.Location = new System.Drawing.Point(93, 23);
            this.TBMarkaAdi.Name = "TBMarkaAdi";
            this.TBMarkaAdi.Size = new System.Drawing.Size(206, 23);
            this.TBMarkaAdi.TabIndex = 2;
            // 
            // TBAciklama
            // 
            this.TBAciklama.Location = new System.Drawing.Point(93, 52);
            this.TBAciklama.Multiline = true;
            this.TBAciklama.Name = "TBAciklama";
            this.TBAciklama.Size = new System.Drawing.Size(206, 76);
            this.TBAciklama.TabIndex = 3;
            // 
            // LBMarkaAdi
            // 
            this.LBMarkaAdi.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBMarkaAdi.Appearance.Options.UseFont = true;
            this.LBMarkaAdi.Location = new System.Drawing.Point(6, 26);
            this.LBMarkaAdi.Name = "LBMarkaAdi";
            this.LBMarkaAdi.Size = new System.Drawing.Size(52, 14);
            this.LBMarkaAdi.TabIndex = 12;
            this.LBMarkaAdi.Text = "Marka Adı";
            // 
            // LBMarkaAciklama
            // 
            this.LBMarkaAciklama.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBMarkaAciklama.Appearance.Options.UseFont = true;
            this.LBMarkaAciklama.Location = new System.Drawing.Point(6, 55);
            this.LBMarkaAciklama.Name = "LBMarkaAciklama";
            this.LBMarkaAciklama.Size = new System.Drawing.Size(46, 14);
            this.LBMarkaAciklama.TabIndex = 13;
            this.LBMarkaAciklama.Text = "Açıklama";
            // 
            // BTMarkaKartSil
            // 
            this.BTMarkaKartSil.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.BTMarkaKartSil.Appearance.Options.UseBackColor = true;
            this.BTMarkaKartSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTOlcuBrKartSil.ImageOptions.Image")));
            this.BTMarkaKartSil.Location = new System.Drawing.Point(687, 88);
            this.BTMarkaKartSil.Name = "BTMarkaKartSil";
            this.BTMarkaKartSil.Size = new System.Drawing.Size(94, 52);
            this.BTMarkaKartSil.TabIndex = 80;
            this.BTMarkaKartSil.Text = "Sil";
            // 
            // BTMarkaKartKaydet
            // 
            this.BTMarkaKartKaydet.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.BTMarkaKartKaydet.Appearance.Options.UseBackColor = true;
            this.BTMarkaKartKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTOlcuBrKartKaydet.ImageOptions.Image")));
            this.BTMarkaKartKaydet.Location = new System.Drawing.Point(587, 88);
            this.BTMarkaKartKaydet.Name = "BTMarkaKartKaydet";
            this.BTMarkaKartKaydet.Size = new System.Drawing.Size(94, 52);
            this.BTMarkaKartKaydet.TabIndex = 79;
            this.BTMarkaKartKaydet.Text = "Kaydet";
            // 
            // FMarkaKart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private TextBox TBAciklama;
        private TextBox TBMarkaAdi;
        private DataGridView DGMarkaKart;
        private GroupBox groupBox1;
        private DevExpress.XtraEditors.LabelControl LBMarkaAdi;
        private DevExpress.XtraEditors.LabelControl LBMarkaAciklama;
        private DevExpress.XtraEditors.SimpleButton BTMarkaKartSil;
        private DevExpress.XtraEditors.SimpleButton BTMarkaKartKaydet;
    }
}