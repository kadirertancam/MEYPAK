namespace MEYPAK.PRL.DEPO
{
    partial class FDepolarArasıTransfer
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTNCikisDepoSec = new System.Windows.Forms.Button();
            this.BTNHedefDepoSec = new System.Windows.Forms.Button();
            this.TBHedefDepo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTDepoTransferKaydet = new System.Windows.Forms.Button();
            this.TBCıkısDepo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(941, 514);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(941, 605);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 91);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(941, 514);
            this.panel3.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(941, 91);
            this.panel2.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTNCikisDepoSec);
            this.groupBox1.Controls.Add(this.BTNHedefDepoSec);
            this.groupBox1.Controls.Add(this.TBHedefDepo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BTDepoTransferKaydet);
            this.groupBox1.Controls.Add(this.TBCıkısDepo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(941, 91);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Depolar Arası Transfer";
            // 
            // BTNCikisDepoSec
            // 
            this.BTNCikisDepoSec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNCikisDepoSec.Location = new System.Drawing.Point(246, 39);
            this.BTNCikisDepoSec.Name = "BTNCikisDepoSec";
            this.BTNCikisDepoSec.Size = new System.Drawing.Size(37, 23);
            this.BTNCikisDepoSec.TabIndex = 10;
            this.BTNCikisDepoSec.Text = "Seç";
            this.BTNCikisDepoSec.UseVisualStyleBackColor = true;
            this.BTNCikisDepoSec.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTNHedefDepoSec
            // 
            this.BTNHedefDepoSec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNHedefDepoSec.Location = new System.Drawing.Point(566, 38);
            this.BTNHedefDepoSec.Name = "BTNHedefDepoSec";
            this.BTNHedefDepoSec.Size = new System.Drawing.Size(37, 23);
            this.BTNHedefDepoSec.TabIndex = 9;
            this.BTNHedefDepoSec.Text = "Seç";
            this.BTNHedefDepoSec.UseVisualStyleBackColor = true;
            this.BTNHedefDepoSec.Click += new System.EventHandler(this.BTNHedefDepoSec_Click);
            // 
            // TBHedefDepo
            // 
            this.TBHedefDepo.Location = new System.Drawing.Point(415, 38);
            this.TBHedefDepo.Name = "TBHedefDepo";
            this.TBHedefDepo.Size = new System.Drawing.Size(154, 23);
            this.TBHedefDepo.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(339, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Hedef Depo";
            // 
            // BTDepoTransferKaydet
            // 
            this.BTDepoTransferKaydet.Location = new System.Drawing.Point(753, 23);
            this.BTDepoTransferKaydet.Name = "BTDepoTransferKaydet";
            this.BTDepoTransferKaydet.Size = new System.Drawing.Size(96, 54);
            this.BTDepoTransferKaydet.TabIndex = 4;
            this.BTDepoTransferKaydet.Text = "Kaydet";
            this.BTDepoTransferKaydet.UseVisualStyleBackColor = true;
            this.BTDepoTransferKaydet.Click += new System.EventHandler(this.BTDepoTransferKaydet_Click);
            // 
            // TBCıkısDepo
            // 
            this.TBCıkısDepo.Location = new System.Drawing.Point(95, 39);
            this.TBCıkısDepo.Name = "TBCıkısDepo";
            this.TBCıkısDepo.Size = new System.Drawing.Size(154, 23);
            this.TBCıkısDepo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Çıkış Depo";
            // 
            // FDepolarArasıTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 605);
            this.Controls.Add(this.panel1);
            this.Name = "FDepolarArasıTransfer";
            this.Text = "FDepolarArasıTransfer";
            this.Load += new System.EventHandler(this.FDepolarArasıTransfer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private GroupBox groupBox1;
        private Button BTDepoTransferKaydet;
        private TextBox TBCıkısDepo;
        private Label label2;
        private TextBox TBHedefDepo;
        private Label label1;
        private Button BTNCikisDepoSec;
        private Button BTNHedefDepoSec;
    }
}