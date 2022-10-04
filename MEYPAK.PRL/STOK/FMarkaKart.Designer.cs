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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LBAciklama = new System.Windows.Forms.Label();
            this.LBMarkaAdi = new System.Windows.Forms.Label();
            this.TBMarkaAdi = new System.Windows.Forms.TextBox();
            this.TBAciklama = new System.Windows.Forms.TextBox();
            this.BTSil = new System.Windows.Forms.Button();
            this.BTKaydet = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 152);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 298);
            this.panel3.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(800, 298);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.BTSil);
            this.panel2.Controls.Add(this.BTKaydet);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 152);
            this.panel2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LBAciklama);
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
            // LBAciklama
            // 
            this.LBAciklama.AutoSize = true;
            this.LBAciklama.Location = new System.Drawing.Point(6, 55);
            this.LBAciklama.Name = "LBAciklama";
            this.LBAciklama.Size = new System.Drawing.Size(56, 15);
            this.LBAciklama.TabIndex = 1;
            this.LBAciklama.Text = "Açıklama";
            // 
            // LBMarkaAdi
            // 
            this.LBMarkaAdi.AutoSize = true;
            this.LBMarkaAdi.Location = new System.Drawing.Point(6, 26);
            this.LBMarkaAdi.Name = "LBMarkaAdi";
            this.LBMarkaAdi.Size = new System.Drawing.Size(61, 15);
            this.LBMarkaAdi.TabIndex = 0;
            this.LBMarkaAdi.Text = "Marka Adı";
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
            // BTSil
            // 
            this.BTSil.Location = new System.Drawing.Point(682, 108);
            this.BTSil.Name = "BTSil";
            this.BTSil.Size = new System.Drawing.Size(106, 38);
            this.BTSil.TabIndex = 9;
            this.BTSil.Text = "Sil";
            this.BTSil.UseVisualStyleBackColor = true;
            this.BTSil.Click += new System.EventHandler(this.BTSil_Click);
            // 
            // BTKaydet
            // 
            this.BTKaydet.Location = new System.Drawing.Point(570, 108);
            this.BTKaydet.Name = "BTKaydet";
            this.BTKaydet.Size = new System.Drawing.Size(106, 38);
            this.BTKaydet.TabIndex = 10;
            this.BTKaydet.Text = "Kaydet";
            this.BTKaydet.UseVisualStyleBackColor = true;
            this.BTKaydet.Click += new System.EventHandler(this.BTKaydet_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private Label LBAciklama;
        private Label LBMarkaAdi;
        private DataGridView dataGridView1;
        private Button BTSil;
        private Button BTKaydet;
        private GroupBox groupBox1;
    }
}