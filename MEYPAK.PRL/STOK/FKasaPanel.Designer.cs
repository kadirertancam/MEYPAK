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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FKasaPanel));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BTSil = new DevExpress.XtraEditors.SimpleButton();
            this.BTKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.TBAciklama = new DevExpress.XtraEditors.MemoEdit();
            this.TBKasaKodu = new DevExpress.XtraEditors.TextEdit();
            this.TBKasaAdi = new DevExpress.XtraEditors.TextEdit();
            this.LBAciklama = new DevExpress.XtraEditors.LabelControl();
            this.LBKasaKodu = new DevExpress.XtraEditors.LabelControl();
            this.LBKasaAdi = new DevExpress.XtraEditors.LabelControl();
            this.DGKasaPanel = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TBAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBKasaKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBKasaAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGKasaPanel)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1038, 151);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kasa";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BTSil);
            this.groupBox3.Controls.Add(this.BTKaydet);
            this.groupBox3.Controls.Add(this.TBAciklama);
            this.groupBox3.Controls.Add(this.TBKasaKodu);
            this.groupBox3.Controls.Add(this.TBKasaAdi);
            this.groupBox3.Controls.Add(this.LBAciklama);
            this.groupBox3.Controls.Add(this.LBKasaKodu);
            this.groupBox3.Controls.Add(this.LBKasaAdi);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(3, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1032, 122);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kasa Ekle";
            // 
            // BTSil
            // 
            this.BTSil.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.BTSil.Appearance.Options.UseBackColor = true;
            this.BTSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTDegistir.ImageOptions.Image")));
            this.BTSil.Location = new System.Drawing.Point(914, 57);
            this.BTSil.Name = "BTSil";
            this.BTSil.Size = new System.Drawing.Size(95, 49);
            this.BTSil.TabIndex = 84;
            this.BTSil.Text = "Sil";
            this.BTSil.Click += new System.EventHandler(this.BTSil_Click);
            // 
            // BTKaydet
            // 
            this.BTKaydet.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.BTKaydet.Appearance.Options.UseBackColor = true;
            this.BTKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTKaydet.ImageOptions.Image")));
            this.BTKaydet.Location = new System.Drawing.Point(813, 58);
            this.BTKaydet.Name = "BTKaydet";
            this.BTKaydet.Size = new System.Drawing.Size(95, 49);
            this.BTKaydet.TabIndex = 83;
            this.BTKaydet.Text = "Kaydet";
            this.BTKaydet.Click += new System.EventHandler(this.BTKaydet_Click);
            // 
            // TBAciklama
            // 
            this.TBAciklama.Location = new System.Drawing.Point(364, 27);
            this.TBAciklama.Name = "TBAciklama";
            this.TBAciklama.Size = new System.Drawing.Size(173, 56);
            this.TBAciklama.TabIndex = 82;
            // 
            // TBKasaKodu
            // 
            this.TBKasaKodu.Location = new System.Drawing.Point(86, 63);
            this.TBKasaKodu.Name = "TBKasaKodu";
            this.TBKasaKodu.Size = new System.Drawing.Size(177, 20);
            this.TBKasaKodu.TabIndex = 81;
            // 
            // TBKasaAdi
            // 
            this.TBKasaAdi.Location = new System.Drawing.Point(86, 26);
            this.TBKasaAdi.Name = "TBKasaAdi";
            this.TBKasaAdi.Size = new System.Drawing.Size(177, 20);
            this.TBKasaAdi.TabIndex = 80;
            // 
            // LBAciklama
            // 
            this.LBAciklama.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBAciklama.Appearance.Options.UseFont = true;
            this.LBAciklama.Location = new System.Drawing.Point(313, 29);
            this.LBAciklama.Name = "LBAciklama";
            this.LBAciklama.Size = new System.Drawing.Size(45, 13);
            this.LBAciklama.TabIndex = 37;
            this.LBAciklama.Text = "Açıklama";
            // 
            // LBKasaKodu
            // 
            this.LBKasaKodu.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBKasaKodu.Appearance.Options.UseFont = true;
            this.LBKasaKodu.Location = new System.Drawing.Point(27, 66);
            this.LBKasaKodu.Name = "LBKasaKodu";
            this.LBKasaKodu.Size = new System.Drawing.Size(53, 13);
            this.LBKasaKodu.TabIndex = 21;
            this.LBKasaKodu.Text = "Kasa Kodu";
            // 
            // LBKasaAdi
            // 
            this.LBKasaAdi.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBKasaAdi.Appearance.Options.UseFont = true;
            this.LBKasaAdi.Location = new System.Drawing.Point(35, 29);
            this.LBKasaAdi.Name = "LBKasaAdi";
            this.LBKasaAdi.Size = new System.Drawing.Size(43, 13);
            this.LBKasaAdi.TabIndex = 20;
            this.LBKasaAdi.Text = "Kasa Adı";
            // 
            // DGKasaPanel
            // 
            this.DGKasaPanel.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGKasaPanel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGKasaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGKasaPanel.Location = new System.Drawing.Point(0, 0);
            this.DGKasaPanel.Name = "DGKasaPanel";
            this.DGKasaPanel.ReadOnly = true;
            this.DGKasaPanel.RowTemplate.Height = 25;
            this.DGKasaPanel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGKasaPanel.Size = new System.Drawing.Size(1038, 337);
            this.DGKasaPanel.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1038, 488);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.DGKasaPanel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 151);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1038, 337);
            this.panel3.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1038, 151);
            this.panel1.TabIndex = 1;
            // 
            // FKasaPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 488);
            this.Controls.Add(this.panel2);
            this.Name = "FKasaPanel";
            this.Text = "FKasaPanel";
            this.Load += new System.EventHandler(this.FKasaPanel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TBAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBKasaKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBKasaAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGKasaPanel)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private DataGridView DGKasaPanel;
        private Panel panel2;
        private Panel panel3;
        private Panel panel1;
        private DevExpress.XtraEditors.LabelControl LBKasaAdi;
        private DevExpress.XtraEditors.LabelControl LBKasaKodu;
        private DevExpress.XtraEditors.LabelControl LBAciklama;
        private DevExpress.XtraEditors.TextEdit TBKasaAdi;
        private DevExpress.XtraEditors.TextEdit TBKasaKodu;
        private DevExpress.XtraEditors.MemoEdit TBAciklama;
        private DevExpress.XtraEditors.SimpleButton BTSil;
        private DevExpress.XtraEditors.SimpleButton BTKaydet;
    }
}