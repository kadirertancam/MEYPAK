namespace MEYPAK.PRL.DEPO
{
    partial class FDepoKart
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
            this.BTSil = new System.Windows.Forms.Button();
            this.BTEkle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTSec = new System.Windows.Forms.Button();
            this.TBKod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CLBSubeler = new System.Windows.Forms.CheckedListBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.TBAciklama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.panel1.Size = new System.Drawing.Size(561, 450);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 219);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(561, 231);
            this.panel3.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(561, 231);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BTSil);
            this.panel2.Controls.Add(this.BTEkle);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(561, 219);
            this.panel2.TabIndex = 0;
            // 
            // BTSil
            // 
            this.BTSil.Location = new System.Drawing.Point(90, 178);
            this.BTSil.Name = "BTSil";
            this.BTSil.Size = new System.Drawing.Size(77, 41);
            this.BTSil.TabIndex = 2;
            this.BTSil.Text = "Sil";
            this.BTSil.UseVisualStyleBackColor = true;
            // 
            // BTEkle
            // 
            this.BTEkle.Location = new System.Drawing.Point(12, 178);
            this.BTEkle.Name = "BTEkle";
            this.BTEkle.Size = new System.Drawing.Size(77, 41);
            this.BTEkle.TabIndex = 1;
            this.BTEkle.Text = "Ekle";
            this.BTEkle.UseVisualStyleBackColor = true;
            this.BTEkle.Click += new System.EventHandler(this.BTEkle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTSec);
            this.groupBox1.Controls.Add(this.TBKod);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CLBSubeler);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.TBAciklama);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TBAdi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(536, 166);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Genel Bilgi";
            // 
            // BTSec
            // 
            this.BTSec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTSec.Location = new System.Drawing.Point(202, 22);
            this.BTSec.Name = "BTSec";
            this.BTSec.Size = new System.Drawing.Size(40, 23);
            this.BTSec.TabIndex = 9;
            this.BTSec.Text = "Seç";
            this.BTSec.UseVisualStyleBackColor = true;
            this.BTSec.Click += new System.EventHandler(this.BTSec_Click);
            // 
            // TBKod
            // 
            this.TBKod.Location = new System.Drawing.Point(66, 22);
            this.TBKod.Name = "TBKod";
            this.TBKod.Size = new System.Drawing.Size(148, 23);
            this.TBKod.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kod";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Şubeler";
            // 
            // CLBSubeler
            // 
            this.CLBSubeler.FormattingEnabled = true;
            this.CLBSubeler.Location = new System.Drawing.Point(309, 31);
            this.CLBSubeler.Name = "CLBSubeler";
            this.CLBSubeler.Size = new System.Drawing.Size(214, 130);
            this.CLBSubeler.TabIndex = 5;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(66, 147);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(51, 19);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Aktif";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // TBAciklama
            // 
            this.TBAciklama.Location = new System.Drawing.Point(66, 80);
            this.TBAciklama.Multiline = true;
            this.TBAciklama.Name = "TBAciklama";
            this.TBAciklama.Size = new System.Drawing.Size(176, 61);
            this.TBAciklama.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Açıklama";
            // 
            // TBAdi
            // 
            this.TBAdi.Location = new System.Drawing.Point(66, 51);
            this.TBAdi.Name = "TBAdi";
            this.TBAdi.Size = new System.Drawing.Size(176, 23);
            this.TBAdi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı";
            // 
            // FDepoKart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FDepoKart";
            this.Text = "FDepoKart";
            this.Load += new System.EventHandler(this.FDepoKart_Load);
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
        private Button BTSil;
        private Button BTEkle;
        private GroupBox groupBox1;
        private Label label3;
        private CheckedListBox CLBSubeler;
        private CheckBox checkBox1;
        private TextBox TBAciklama;
        private Label label2;
        private TextBox TBAdi;
        private Label label1;
        private Button BTSec;
        private TextBox TBKod;
        private Label label4;
    }
}