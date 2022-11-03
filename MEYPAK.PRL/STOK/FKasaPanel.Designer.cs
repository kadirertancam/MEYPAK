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
            this.DGKasaPanel = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LBKasaAdi = new DevExpress.XtraEditors.LabelControl();
            this.LBKasaKodu = new DevExpress.XtraEditors.LabelControl();
            this.TBKasaAdi = new DevExpress.XtraEditors.TextEdit();
            this.TBKasaKodu = new DevExpress.XtraEditors.TextEdit();
            this.LBAciklama = new DevExpress.XtraEditors.LabelControl();
            this.TBAciklama = new DevExpress.XtraEditors.MemoEdit();
            this.BTKasaPanelSil = new DevExpress.XtraEditors.SimpleButton();
            this.BTKasaPanelKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGKasaPanel)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TBKasaAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBKasaKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBAciklama.Properties)).BeginInit();
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
            this.groupBox3.Controls.Add(this.BTKasaPanelSil);
            this.groupBox3.Controls.Add(this.TBAciklama);
            this.groupBox3.Controls.Add(this.LBAciklama);
            this.groupBox3.Controls.Add(this.BTKasaPanelKaydet);
            this.groupBox3.Controls.Add(this.TBKasaKodu);
            this.groupBox3.Controls.Add(this.TBKasaAdi);
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
            // LBKasaAdi
            // 
            this.LBKasaAdi.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBKasaAdi.Appearance.Options.UseFont = true;
            this.LBKasaAdi.Location = new System.Drawing.Point(35, 29);
            this.LBKasaAdi.Name = "LBKasaAdi";
            this.LBKasaAdi.Size = new System.Drawing.Size(45, 14);
            this.LBKasaAdi.TabIndex = 20;
            this.LBKasaAdi.Text = "Kasa Adı";
            // 
            // LBKasaKodu
            // 
            this.LBKasaKodu.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBKasaKodu.Appearance.Options.UseFont = true;
            this.LBKasaKodu.Location = new System.Drawing.Point(24, 83);
            this.LBKasaKodu.Name = "LBKasaKodu";
            this.LBKasaKodu.Size = new System.Drawing.Size(56, 14);
            this.LBKasaKodu.TabIndex = 21;
            this.LBKasaKodu.Text = "Kasa Kodu";
            // 
            // TBKasaAdi
            // 
            this.TBKasaAdi.Location = new System.Drawing.Point(86, 24);
            this.TBKasaAdi.Name = "TBKasaAdi";
            this.TBKasaAdi.Properties.Padding = new System.Windows.Forms.Padding(3);
            this.TBKasaAdi.Size = new System.Drawing.Size(200, 26);
            this.TBKasaAdi.TabIndex = 35;
            // 
            // TBKasaKodu
            // 
            this.TBKasaKodu.Location = new System.Drawing.Point(86, 77);
            this.TBKasaKodu.Name = "TBKasaKodu";
            this.TBKasaKodu.Properties.Padding = new System.Windows.Forms.Padding(3);
            this.TBKasaKodu.Size = new System.Drawing.Size(200, 26);
            this.TBKasaKodu.TabIndex = 36;
            // 
            // LBAciklama
            // 
            this.LBAciklama.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBAciklama.Appearance.Options.UseFont = true;
            this.LBAciklama.Location = new System.Drawing.Point(313, 29);
            this.LBAciklama.Name = "LBAciklama";
            this.LBAciklama.Size = new System.Drawing.Size(46, 14);
            this.LBAciklama.TabIndex = 37;
            this.LBAciklama.Text = "Açıklama";
            // 
            // TBAciklama
            // 
            this.TBAciklama.Location = new System.Drawing.Point(365, 22);
            this.TBAciklama.Name = "TBAciklama";
            this.TBAciklama.Size = new System.Drawing.Size(196, 81);
            this.TBAciklama.TabIndex = 38;
            // 
            // BTKasaPanelSil
            // 
            this.BTKasaPanelSil.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.BTKasaPanelSil.Appearance.Options.UseBackColor = true;
            this.BTKasaPanelSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTStokHarSil.ImageOptions.Image")));
            this.BTKasaPanelSil.Location = new System.Drawing.Point(912, 51);
            this.BTKasaPanelSil.Name = "BTKasaPanelSil";
            this.BTKasaPanelSil.Size = new System.Drawing.Size(94, 52);
            this.BTKasaPanelSil.TabIndex = 79;
            this.BTKasaPanelSil.Text = "Sil";
            // 
            // BTKasaPanelKaydet
            // 
            this.BTKasaPanelKaydet.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.BTKasaPanelKaydet.Appearance.Options.UseBackColor = true;
            this.BTKasaPanelKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTStokHarKaydet.ImageOptions.Image")));
            this.BTKasaPanelKaydet.Location = new System.Drawing.Point(812, 51);
            this.BTKasaPanelKaydet.Name = "BTKasaPanelKaydet";
            this.BTKasaPanelKaydet.Size = new System.Drawing.Size(94, 52);
            this.BTKasaPanelKaydet.TabIndex = 77;
            this.BTKasaPanelKaydet.Text = "Kaydet";
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
            ((System.ComponentModel.ISupportInitialize)(this.DGKasaPanel)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TBKasaAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBKasaKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBAciklama.Properties)).EndInit();
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
        private DevExpress.XtraEditors.TextEdit TBKasaKodu;
        private DevExpress.XtraEditors.TextEdit TBKasaAdi;
        private DevExpress.XtraEditors.LabelControl LBAciklama;
        private DevExpress.XtraEditors.MemoEdit TBAciklama;
        private DevExpress.XtraEditors.SimpleButton BTKasaPanelSil;
        private DevExpress.XtraEditors.SimpleButton BTKasaPanelKaydet;
    }
}