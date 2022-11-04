namespace MEYPAK.PRL.DEPO
{
    partial class FSevkiyatCekiPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FSevkiyatCekiPanel));
            this.LBStokKodu = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BTSevkiyatCeki = new DevExpress.XtraEditors.SimpleButton();
            this.BTKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBStokKodu
            // 
            this.LBStokKodu.AutoSize = true;
            this.LBStokKodu.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBStokKodu.ForeColor = System.Drawing.Color.White;
            this.LBStokKodu.Location = new System.Drawing.Point(12, 69);
            this.LBStokKodu.Name = "LBStokKodu";
            this.LBStokKodu.Size = new System.Drawing.Size(122, 32);
            this.LBStokKodu.TabIndex = 0;
            this.LBStokKodu.Text = "Stok Kodu";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 681);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 167);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(840, 514);
            this.panel3.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(840, 455);
            this.dataGridView1.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.BTKaydet);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 455);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(840, 59);
            this.panel4.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(840, 167);
            this.panel2.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTSevkiyatCeki);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.LBStokKodu);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(840, 167);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(164, 69);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(311, 36);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // BTSevkiyatCeki
            // 
            this.BTSevkiyatCeki.Appearance.BackColor = System.Drawing.Color.Silver;
            this.BTSevkiyatCeki.Appearance.Options.UseBackColor = true;
            this.BTSevkiyatCeki.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTSevkiyatCeki.BackgroundImage")));
            this.BTSevkiyatCeki.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTMalKabulCeki.ImageOptions.Image")));
            this.BTSevkiyatCeki.Location = new System.Drawing.Point(505, 48);
            this.BTSevkiyatCeki.Name = "BTSevkiyatCeki";
            this.BTSevkiyatCeki.Size = new System.Drawing.Size(73, 73);
            this.BTSevkiyatCeki.TabIndex = 7;
            // 
            // BTKaydet
            // 
            this.BTKaydet.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.BTKaydet.Appearance.Options.UseBackColor = true;
            this.BTKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTDokumanlarKaydet.ImageOptions.Image")));
            this.BTKaydet.Location = new System.Drawing.Point(720, 2);
            this.BTKaydet.Name = "BTKaydet";
            this.BTKaydet.Size = new System.Drawing.Size(117, 57);
            this.BTKaydet.TabIndex = 62;
            this.BTKaydet.Text = "Kaydet";
            // 
            // FSevkiyatCekiPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(840, 681);
            this.Controls.Add(this.panel1);
            this.Name = "FSevkiyatCekiPanel";
            this.Text = "FSevkiyatCekiPanel";
            this.Load += new System.EventHandler(this.FSevkiyatCekiPanel_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label LBStokKodu;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private GroupBox groupBox1;
        private ComboBox comboBox1;
        private Panel panel4;
        public DataGridView dataGridView1;
        private DevExpress.XtraEditors.SimpleButton BTSevkiyatCeki;
        private DevExpress.XtraEditors.SimpleButton BTKaydet;
    }
}