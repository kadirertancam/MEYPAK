namespace MEYPAK.PRL.STOK
{
    partial class FKasaPanel
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBAciklama = new System.Windows.Forms.TextBox();
            this.TBKasaKodu = new System.Windows.Forms.TextBox();
            this.LBIskonto = new System.Windows.Forms.Label();
            this.BTKasaSil = new System.Windows.Forms.Button();
            this.BTKasaKaydet = new System.Windows.Forms.Button();
            this.TBKasaAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1038, 150);
            this.panel1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1038, 165);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kasa";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.TBAciklama);
            this.groupBox3.Controls.Add(this.TBKasaKodu);
            this.groupBox3.Controls.Add(this.LBIskonto);
            this.groupBox3.Controls.Add(this.BTKasaSil);
            this.groupBox3.Controls.Add(this.BTKasaKaydet);
            this.groupBox3.Controls.Add(this.TBKasaAdi);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(3, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1032, 122);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kasa Ekle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Açıklama";
            // 
            // TBAciklama
            // 
            this.TBAciklama.Location = new System.Drawing.Point(387, 30);
            this.TBAciklama.Multiline = true;
            this.TBAciklama.Name = "TBAciklama";
            this.TBAciklama.Size = new System.Drawing.Size(159, 73);
            this.TBAciklama.TabIndex = 18;
            // 
            // TBKasaKodu
            // 
            this.TBKasaKodu.Location = new System.Drawing.Point(100, 80);
            this.TBKasaKodu.Name = "TBKasaKodu";
            this.TBKasaKodu.Size = new System.Drawing.Size(173, 23);
            this.TBKasaKodu.TabIndex = 17;
            // 
            // LBIskonto
            // 
            this.LBIskonto.AutoSize = true;
            this.LBIskonto.Location = new System.Drawing.Point(18, 83);
            this.LBIskonto.Name = "LBIskonto";
            this.LBIskonto.Size = new System.Drawing.Size(65, 15);
            this.LBIskonto.TabIndex = 16;
            this.LBIskonto.Text = "Kasa Kodu:";
            // 
            // BTKasaSil
            // 
            this.BTKasaSil.Location = new System.Drawing.Point(889, 36);
            this.BTKasaSil.Name = "BTKasaSil";
            this.BTKasaSil.Size = new System.Drawing.Size(84, 67);
            this.BTKasaSil.TabIndex = 13;
            this.BTKasaSil.Text = "Sil";
            this.BTKasaSil.UseVisualStyleBackColor = true;
            // 
            // BTKasaKaydet
            // 
            this.BTKasaKaydet.Location = new System.Drawing.Point(799, 36);
            this.BTKasaKaydet.Name = "BTKasaKaydet";
            this.BTKasaKaydet.Size = new System.Drawing.Size(84, 67);
            this.BTKasaKaydet.TabIndex = 12;
            this.BTKasaKaydet.Text = "Kaydet";
            this.BTKasaKaydet.UseVisualStyleBackColor = true;
            this.BTKasaKaydet.Click += new System.EventHandler(this.BTStokKaydet_Click);
            // 
            // TBKasaAdi
            // 
            this.TBKasaAdi.Location = new System.Drawing.Point(100, 30);
            this.TBKasaAdi.Name = "TBKasaAdi";
            this.TBKasaAdi.Size = new System.Drawing.Size(173, 23);
            this.TBKasaAdi.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kasa Adı :";
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
            this.dataGridView1.Size = new System.Drawing.Size(1038, 488);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1038, 488);
            this.panel2.TabIndex = 5;
            // 
            // FKasaPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 488);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FKasaPanel";
            this.Text = "FKasaPanel";
            this.Load += new System.EventHandler(this.FKasaPanel_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private TextBox TBKasaKodu;
        private Label LBIskonto;
        private Button BTKasaSil;
        private Button BTKasaKaydet;
        private TextBox TBKasaAdi;
        private Label label1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Label label3;
        private TextBox TBAciklama;
    }
}