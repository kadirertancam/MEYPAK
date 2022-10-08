namespace MEYPAK.PRL.STOK
{
    partial class FStokFiyatListPanel
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
            this.BTStokSil = new System.Windows.Forms.Button();
            this.BTTemizle = new System.Windows.Forms.Button();
            this.BTStokKaydet = new System.Windows.Forms.Button();
            this.TBFiyat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BTCık = new System.Windows.Forms.Button();
            this.BTKaydet = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TBStokAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TBIskonto = new System.Windows.Forms.TextBox();
            this.LBIskonto = new System.Windows.Forms.Label();
            this.CMBDovizId = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBKur = new System.Windows.Forms.TextBox();
            this.LBKur = new System.Windows.Forms.Label();
            this.TBStokKodu = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTStokSil
            // 
            this.BTStokSil.Location = new System.Drawing.Point(711, 44);
            this.BTStokSil.Name = "BTStokSil";
            this.BTStokSil.Size = new System.Drawing.Size(84, 67);
            this.BTStokSil.TabIndex = 13;
            this.BTStokSil.Text = "Sil";
            this.BTStokSil.UseVisualStyleBackColor = true;
            this.BTStokSil.Click += new System.EventHandler(this.BTStokSil_Click);
            // 
            // BTTemizle
            // 
            this.BTTemizle.Location = new System.Drawing.Point(801, 44);
            this.BTTemizle.Name = "BTTemizle";
            this.BTTemizle.Size = new System.Drawing.Size(84, 67);
            this.BTTemizle.TabIndex = 12;
            this.BTTemizle.Text = "Temizle";
            this.BTTemizle.UseVisualStyleBackColor = true;
            this.BTTemizle.Click += new System.EventHandler(this.BTTemizle_Click);
            // 
            // BTStokKaydet
            // 
            this.BTStokKaydet.Location = new System.Drawing.Point(621, 44);
            this.BTStokKaydet.Name = "BTStokKaydet";
            this.BTStokKaydet.Size = new System.Drawing.Size(84, 67);
            this.BTStokKaydet.TabIndex = 12;
            this.BTStokKaydet.Text = "Kaydet";
            this.BTStokKaydet.UseVisualStyleBackColor = true;
            this.BTStokKaydet.Click += new System.EventHandler(this.BTStokKaydet_Click);
            // 
            // TBFiyat
            // 
            this.TBFiyat.Location = new System.Drawing.Point(415, 88);
            this.TBFiyat.Name = "TBFiyat";
            this.TBFiyat.Size = new System.Drawing.Size(173, 23);
            this.TBFiyat.TabIndex = 12;
            this.TBFiyat.Text = "0";
            this.TBFiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBFiyat_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(331, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Fiyat";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 150);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1039, 485);
            this.panel2.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.BTCık);
            this.panel4.Controls.Add(this.BTKaydet);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 424);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1039, 61);
            this.panel4.TabIndex = 2;
            // 
            // BTCık
            // 
            this.BTCık.Location = new System.Drawing.Point(937, 6);
            this.BTCık.Name = "BTCık";
            this.BTCık.Size = new System.Drawing.Size(90, 44);
            this.BTCık.TabIndex = 1;
            this.BTCık.Text = "Çık";
            this.BTCık.UseVisualStyleBackColor = true;
            this.BTCık.Click += new System.EventHandler(this.BTCık_Click);
            // 
            // BTKaydet
            // 
            this.BTKaydet.Location = new System.Drawing.Point(841, 6);
            this.BTKaydet.Name = "BTKaydet";
            this.BTKaydet.Size = new System.Drawing.Size(90, 44);
            this.BTKaydet.TabIndex = 0;
            this.BTKaydet.Text = "Kaydet";
            this.BTKaydet.UseVisualStyleBackColor = true;
            this.BTKaydet.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1039, 424);
            this.panel3.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1039, 424);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_DoubleClick);
            // 
            // TBStokAdi
            // 
            this.TBStokAdi.Enabled = false;
            this.TBStokAdi.Location = new System.Drawing.Point(100, 59);
            this.TBStokAdi.Name = "TBStokAdi";
            this.TBStokAdi.Size = new System.Drawing.Size(173, 23);
            this.TBStokAdi.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stok Kodu";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(236, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Seç";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TBIskonto);
            this.groupBox3.Controls.Add(this.LBIskonto);
            this.groupBox3.Controls.Add(this.CMBDovizId);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.BTStokSil);
            this.groupBox3.Controls.Add(this.BTTemizle);
            this.groupBox3.Controls.Add(this.BTStokKaydet);
            this.groupBox3.Controls.Add(this.TBFiyat);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.TBKur);
            this.groupBox3.Controls.Add(this.LBKur);
            this.groupBox3.Controls.Add(this.TBStokAdi);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.TBStokKodu);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(3, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1033, 122);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Stok Bilgi";
            // 
            // TBIskonto
            // 
            this.TBIskonto.Location = new System.Drawing.Point(100, 91);
            this.TBIskonto.Name = "TBIskonto";
            this.TBIskonto.Size = new System.Drawing.Size(173, 23);
            this.TBIskonto.TabIndex = 17;
            this.TBIskonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBIskonto_KeyPress);
            // 
            // LBIskonto
            // 
            this.LBIskonto.AutoSize = true;
            this.LBIskonto.Location = new System.Drawing.Point(16, 94);
            this.LBIskonto.Name = "LBIskonto";
            this.LBIskonto.Size = new System.Drawing.Size(46, 15);
            this.LBIskonto.TabIndex = 16;
            this.LBIskonto.Text = "İskonto";
            // 
            // CMBDovizId
            // 
            this.CMBDovizId.FormattingEnabled = true;
            this.CMBDovizId.Location = new System.Drawing.Point(415, 30);
            this.CMBDovizId.Name = "CMBDovizId";
            this.CMBDovizId.Size = new System.Drawing.Size(173, 23);
            this.CMBDovizId.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Döviz";
            // 
            // TBKur
            // 
            this.TBKur.Location = new System.Drawing.Point(415, 59);
            this.TBKur.Name = "TBKur";
            this.TBKur.Size = new System.Drawing.Size(173, 23);
            this.TBKur.TabIndex = 6;
            this.TBKur.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBKur_KeyPress);
            // 
            // LBKur
            // 
            this.LBKur.AutoSize = true;
            this.LBKur.Location = new System.Drawing.Point(331, 62);
            this.LBKur.Name = "LBKur";
            this.LBKur.Size = new System.Drawing.Size(25, 15);
            this.LBKur.TabIndex = 5;
            this.LBKur.Text = "Kur";
            // 
            // TBStokKodu
            // 
            this.TBStokKodu.Location = new System.Drawing.Point(100, 30);
            this.TBStokKodu.Name = "TBStokKodu";
            this.TBStokKodu.Size = new System.Drawing.Size(140, 23);
            this.TBStokKodu.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1039, 165);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stok Sayım";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1039, 150);
            this.panel1.TabIndex = 2;
            // 
            // FStokFiyatListPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 635);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FStokFiyatListPanel";
            this.Text = "FStokFiyatListPanel";
            this.Load += new System.EventHandler(this.FStokFiyatListPanel_Load);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button BTStokSil;
        private Button BTTemizle;
        private Button BTStokKaydet;
        private TextBox TBFiyat;
        private Label label7;
        private Panel panel2;
        private Panel panel4;
        private Button BTCık;
        private Button BTKaydet;
        private Panel panel3;
        private DataGridView dataGridView1;
        private TextBox TBStokAdi;
        private Label label1;
        private Button button1;
        private GroupBox groupBox3;
        private ComboBox CMBDovizId;
        private Label label2;
        private TextBox TBKur;
        private Label LBKur;
        private TextBox TBStokKodu;
        private GroupBox groupBox1;
        private Panel panel1;
        private TextBox TBIskonto;
        private Label LBIskonto;
    }
}