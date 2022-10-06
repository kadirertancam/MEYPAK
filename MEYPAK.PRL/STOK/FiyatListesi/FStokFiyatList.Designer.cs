namespace MEYPAK.PRL.STOK
{
    partial class FStokFiyatList
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
            this.CHBBittar = new System.Windows.Forms.CheckBox();
            this.CHBAktif = new System.Windows.Forms.CheckBox();
            this.DTPBittar = new System.Windows.Forms.DateTimePicker();
            this.DTPBastar = new System.Windows.Forms.DateTimePicker();
            this.BTSil = new System.Windows.Forms.Button();
            this.BTKaydet = new System.Windows.Forms.Button();
            this.LBBastar = new System.Windows.Forms.Label();
            this.LBFiyatListesiAdi = new System.Windows.Forms.Label();
            this.TBFiyatListesiAdi = new System.Windows.Forms.TextBox();
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
            this.panel1.Size = new System.Drawing.Size(1079, 645);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 109);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1079, 536);
            this.panel3.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1079, 536);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1079, 109);
            this.panel2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CHBBittar);
            this.groupBox1.Controls.Add(this.CHBAktif);
            this.groupBox1.Controls.Add(this.DTPBittar);
            this.groupBox1.Controls.Add(this.DTPBastar);
            this.groupBox1.Controls.Add(this.BTSil);
            this.groupBox1.Controls.Add(this.BTKaydet);
            this.groupBox1.Controls.Add(this.LBBastar);
            this.groupBox1.Controls.Add(this.LBFiyatListesiAdi);
            this.groupBox1.Controls.Add(this.TBFiyatListesiAdi);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1079, 94);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fiyat Listesi";
            // 
            // CHBBittar
            // 
            this.CHBBittar.AutoSize = true;
            this.CHBBittar.Location = new System.Drawing.Point(541, 45);
            this.CHBBittar.Name = "CHBBittar";
            this.CHBBittar.Size = new System.Drawing.Size(79, 19);
            this.CHBBittar.TabIndex = 8;
            this.CHBBittar.Text = "Bitiş Tarihi";
            this.CHBBittar.UseVisualStyleBackColor = true;
            // 
            // CHBAktif
            // 
            this.CHBAktif.AutoSize = true;
            this.CHBAktif.Location = new System.Drawing.Point(110, 69);
            this.CHBAktif.Name = "CHBAktif";
            this.CHBAktif.Size = new System.Drawing.Size(51, 19);
            this.CHBAktif.TabIndex = 7;
            this.CHBAktif.Text = "Aktif";
            this.CHBAktif.UseVisualStyleBackColor = true;
            // 
            // DTPBittar
            // 
            this.DTPBittar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPBittar.Location = new System.Drawing.Point(628, 41);
            this.DTPBittar.Name = "DTPBittar";
            this.DTPBittar.Size = new System.Drawing.Size(152, 23);
            this.DTPBittar.TabIndex = 6;
            // 
            // DTPBastar
            // 
            this.DTPBastar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPBastar.Location = new System.Drawing.Point(381, 41);
            this.DTPBastar.Name = "DTPBastar";
            this.DTPBastar.Size = new System.Drawing.Size(152, 23);
            this.DTPBastar.TabIndex = 5;
            // 
            // BTSil
            // 
            this.BTSil.Location = new System.Drawing.Point(960, 38);
            this.BTSil.Name = "BTSil";
            this.BTSil.Size = new System.Drawing.Size(105, 53);
            this.BTSil.TabIndex = 4;
            this.BTSil.Text = "Sil";
            this.BTSil.UseVisualStyleBackColor = true;
            // 
            // BTKaydet
            // 
            this.BTKaydet.Location = new System.Drawing.Point(849, 38);
            this.BTKaydet.Name = "BTKaydet";
            this.BTKaydet.Size = new System.Drawing.Size(105, 53);
            this.BTKaydet.TabIndex = 4;
            this.BTKaydet.Text = "Kaydet";
            this.BTKaydet.UseVisualStyleBackColor = true;
            this.BTKaydet.Click += new System.EventHandler(this.BTKayet_Click);
            // 
            // LBBastar
            // 
            this.LBBastar.AutoSize = true;
            this.LBBastar.Location = new System.Drawing.Point(292, 44);
            this.LBBastar.Name = "LBBastar";
            this.LBBastar.Size = new System.Drawing.Size(88, 15);
            this.LBBastar.TabIndex = 2;
            this.LBBastar.Text = "Başlangıç Tarihi";
            // 
            // LBFiyatListesiAdi
            // 
            this.LBFiyatListesiAdi.AutoSize = true;
            this.LBFiyatListesiAdi.Location = new System.Drawing.Point(16, 44);
            this.LBFiyatListesiAdi.Name = "LBFiyatListesiAdi";
            this.LBFiyatListesiAdi.Size = new System.Drawing.Size(88, 15);
            this.LBFiyatListesiAdi.TabIndex = 1;
            this.LBFiyatListesiAdi.Text = "Fiyat Listesi Adı";
            // 
            // TBFiyatListesiAdi
            // 
            this.TBFiyatListesiAdi.Location = new System.Drawing.Point(110, 41);
            this.TBFiyatListesiAdi.Name = "TBFiyatListesiAdi";
            this.TBFiyatListesiAdi.Size = new System.Drawing.Size(156, 23);
            this.TBFiyatListesiAdi.TabIndex = 0;
            // 
            // FStokFiyatList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 645);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FStokFiyatList";
            this.Text = "FStokFiyatList";
            this.Load += new System.EventHandler(this.FStokFiyatList_Load);
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
        private DataGridView dataGridView1;
        private Panel panel2;
        private GroupBox groupBox1;
        private CheckBox CHBAktif;
        private DateTimePicker DTPBittar;
        private DateTimePicker DTPBastar;
        private Button BTSil;
        private Button BTKaydet;
        private Label LBBastar;
        private Label LBFiyatListesiAdi;
        private TextBox TBFiyatListesiAdi;
        private CheckBox CHBBittar;
    }
}