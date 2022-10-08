namespace MEYPAK.PRL.STOK
{
    partial class FOlcuBrKart
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
            this.LBOlcuBr = new System.Windows.Forms.Label();
            this.LBOlcuBrAdi = new System.Windows.Forms.Label();
            this.TBOlcuBrAdi = new System.Windows.Forms.TextBox();
            this.TBOlcuBr = new System.Windows.Forms.TextBox();
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
            this.panel3.Location = new System.Drawing.Point(0, 138);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 312);
            this.panel3.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(800, 312);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.BTSil);
            this.panel2.Controls.Add(this.BTKaydet);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 138);
            this.panel2.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LBOlcuBr);
            this.groupBox1.Controls.Add(this.LBOlcuBrAdi);
            this.groupBox1.Controls.Add(this.TBOlcuBrAdi);
            this.groupBox1.Controls.Add(this.TBOlcuBr);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Genel";
            // 
            // LBOlcuBr
            // 
            this.LBOlcuBr.AutoSize = true;
            this.LBOlcuBr.Location = new System.Drawing.Point(6, 58);
            this.LBOlcuBr.Name = "LBOlcuBr";
            this.LBOlcuBr.Size = new System.Drawing.Size(35, 15);
            this.LBOlcuBr.TabIndex = 5;
            this.LBOlcuBr.Text = "Birim";
            // 
            // LBOlcuBrAdi
            // 
            this.LBOlcuBrAdi.AutoSize = true;
            this.LBOlcuBrAdi.Location = new System.Drawing.Point(6, 26);
            this.LBOlcuBrAdi.Name = "LBOlcuBrAdi";
            this.LBOlcuBrAdi.Size = new System.Drawing.Size(84, 15);
            this.LBOlcuBrAdi.TabIndex = 4;
            this.LBOlcuBrAdi.Text = "Ölçü Bİrim Adı";
            // 
            // TBOlcuBrAdi
            // 
            this.TBOlcuBrAdi.Location = new System.Drawing.Point(96, 23);
            this.TBOlcuBrAdi.Name = "TBOlcuBrAdi";
            this.TBOlcuBrAdi.Size = new System.Drawing.Size(249, 23);
            this.TBOlcuBrAdi.TabIndex = 6;
            // 
            // TBOlcuBr
            // 
            this.TBOlcuBr.Location = new System.Drawing.Point(96, 55);
            this.TBOlcuBr.Name = "TBOlcuBr";
            this.TBOlcuBr.Size = new System.Drawing.Size(249, 23);
            this.TBOlcuBr.TabIndex = 7;
            // 
            // BTSil
            // 
            this.BTSil.Location = new System.Drawing.Point(684, 94);
            this.BTSil.Name = "BTSil";
            this.BTSil.Size = new System.Drawing.Size(106, 38);
            this.BTSil.TabIndex = 8;
            this.BTSil.Text = "Sil";
            this.BTSil.UseVisualStyleBackColor = true;
            this.BTSil.Click += new System.EventHandler(this.BTSil_Click);
            // 
            // BTKaydet
            // 
            this.BTKaydet.Location = new System.Drawing.Point(572, 94);
            this.BTKaydet.Name = "BTKaydet";
            this.BTKaydet.Size = new System.Drawing.Size(106, 38);
            this.BTKaydet.TabIndex = 8;
            this.BTKaydet.Text = "Kaydet";
            this.BTKaydet.UseVisualStyleBackColor = true;
            this.BTKaydet.Click += new System.EventHandler(this.BTKaydet_Click);
            // 
            // FOlcuBrKart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FOlcuBrKart";
            this.Text = "FOlcuBrKart";
            this.Load += new System.EventHandler(this.FStokOlcuBrKart_Load);
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
        private Label LBOlcuBr;
        private Label LBOlcuBrAdi;
        private TextBox TBOlcuBrAdi;
        private TextBox TBOlcuBr;
        private Button BTSil;
        private Button BTKaydet;
    }
}