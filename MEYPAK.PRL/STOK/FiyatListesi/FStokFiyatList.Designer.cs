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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FStokFiyatList));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DGFiyatListesi = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DTPBitisTar = new System.Windows.Forms.DateTimePicker();
            this.DTPBasTar = new System.Windows.Forms.DateTimePicker();
            this.BTFiyatListesiSil = new DevExpress.XtraEditors.SimpleButton();
            this.BTFiyatListesiKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.CBAktif = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.CBBitisTar = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.LBBasTar = new DevExpress.XtraEditors.LabelControl();
            this.TBFiyatListesiAdi = new DevExpress.XtraEditors.TextEdit();
            this.LBFiyatListesiAdi = new DevExpress.XtraEditors.LabelControl();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGFiyatListesi)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CBAktif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CBBitisTar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBFiyatListesiAdi.Properties)).BeginInit();
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
            this.panel3.Controls.Add(this.DGFiyatListesi);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 109);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1079, 536);
            this.panel3.TabIndex = 1;
            // 
            // DGFiyatListesi
            // 
            this.DGFiyatListesi.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGFiyatListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGFiyatListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGFiyatListesi.Location = new System.Drawing.Point(0, 0);
            this.DGFiyatListesi.Name = "DGFiyatListesi";
            this.DGFiyatListesi.ReadOnly = true;
            this.DGFiyatListesi.RowTemplate.Height = 25;
            this.DGFiyatListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGFiyatListesi.Size = new System.Drawing.Size(1079, 536);
            this.DGFiyatListesi.TabIndex = 0;
            this.DGFiyatListesi.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
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
            this.groupBox1.Controls.Add(this.DTPBitisTar);
            this.groupBox1.Controls.Add(this.DTPBasTar);
            this.groupBox1.Controls.Add(this.BTFiyatListesiSil);
            this.groupBox1.Controls.Add(this.BTFiyatListesiKaydet);
            this.groupBox1.Controls.Add(this.CBAktif);
            this.groupBox1.Controls.Add(this.CBBitisTar);
            this.groupBox1.Controls.Add(this.LBBasTar);
            this.groupBox1.Controls.Add(this.TBFiyatListesiAdi);
            this.groupBox1.Controls.Add(this.LBFiyatListesiAdi);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1079, 106);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stok Fiyat Listesi";
            // 
            // DTPBitisTar
            // 
            this.DTPBitisTar.Location = new System.Drawing.Point(529, 45);
            this.DTPBitisTar.Name = "DTPBitisTar";
            this.DTPBitisTar.Size = new System.Drawing.Size(200, 23);
            this.DTPBitisTar.TabIndex = 73;
            // 
            // DTPBasTar
            // 
            this.DTPBasTar.Location = new System.Drawing.Point(304, 45);
            this.DTPBasTar.Name = "DTPBasTar";
            this.DTPBasTar.Size = new System.Drawing.Size(191, 23);
            this.DTPBasTar.TabIndex = 72;
            this.DTPBasTar.Value = new System.DateTime(2022, 11, 3, 10, 53, 10, 0);
            // 
            // BTFiyatListesiSil
            // 
            this.BTFiyatListesiSil.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.BTFiyatListesiSil.Appearance.Options.UseBackColor = true;
            this.BTFiyatListesiSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTFiyatListesiSil.ImageOptions.Image")));
            this.BTFiyatListesiSil.Location = new System.Drawing.Point(915, 27);
            this.BTFiyatListesiSil.Name = "BTFiyatListesiSil";
            this.BTFiyatListesiSil.Size = new System.Drawing.Size(113, 52);
            this.BTFiyatListesiSil.TabIndex = 71;
            this.BTFiyatListesiSil.Text = "Sil";
            // 
            // BTFiyatListesiKaydet
            // 
            this.BTFiyatListesiKaydet.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.BTFiyatListesiKaydet.Appearance.Options.UseBackColor = true;
            this.BTFiyatListesiKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTFiyatListesiKaydet.ImageOptions.Image")));
            this.BTFiyatListesiKaydet.Location = new System.Drawing.Point(792, 27);
            this.BTFiyatListesiKaydet.Name = "BTFiyatListesiKaydet";
            this.BTFiyatListesiKaydet.Size = new System.Drawing.Size(113, 52);
            this.BTFiyatListesiKaydet.TabIndex = 70;
            this.BTFiyatListesiKaydet.Text = "Kaydet";
            // 
            // CBAktif
            // 
            this.CBAktif.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.CBAktif.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CBAktif.Appearance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CBAktif.Appearance.Options.UseBackColor = true;
            this.CBAktif.Appearance.Options.UseFont = true;
            this.CBAktif.Appearance.Options.UseForeColor = true;
            this.CBAktif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CBAktif.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.CBAktif.CheckOnClick = true;
            this.CBAktif.IncrementalSearch = true;
            this.CBAktif.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(true, "Aktif")});
            this.CBAktif.Location = new System.Drawing.Point(94, 77);
            this.CBAktif.Name = "CBAktif";
            this.CBAktif.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.CBAktif.Size = new System.Drawing.Size(76, 21);
            this.CBAktif.TabIndex = 69;
            // 
            // CBBitisTar
            // 
            this.CBBitisTar.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.CBBitisTar.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CBBitisTar.Appearance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CBBitisTar.Appearance.Options.UseBackColor = true;
            this.CBBitisTar.Appearance.Options.UseFont = true;
            this.CBBitisTar.Appearance.Options.UseForeColor = true;
            this.CBBitisTar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CBBitisTar.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.CBBitisTar.CheckOnClick = true;
            this.CBBitisTar.IncrementalSearch = true;
            this.CBBitisTar.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(true, "Bitiş Tarihi")});
            this.CBBitisTar.Location = new System.Drawing.Point(529, 22);
            this.CBBitisTar.Name = "CBBitisTar";
            this.CBBitisTar.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.CBBitisTar.Size = new System.Drawing.Size(76, 21);
            this.CBBitisTar.TabIndex = 68;
            // 
            // LBBasTar
            // 
            this.LBBasTar.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBBasTar.Appearance.Options.UseFont = true;
            this.LBBasTar.Location = new System.Drawing.Point(304, 25);
            this.LBBasTar.Name = "LBBasTar";
            this.LBBasTar.Size = new System.Drawing.Size(81, 14);
            this.LBBasTar.TabIndex = 64;
            this.LBBasTar.Text = "Başlangıç Tarihi";
            // 
            // TBFiyatListesiAdi
            // 
            this.TBFiyatListesiAdi.Location = new System.Drawing.Point(94, 45);
            this.TBFiyatListesiAdi.Name = "TBFiyatListesiAdi";
            this.TBFiyatListesiAdi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TBFiyatListesiAdi.Properties.Appearance.Options.UseFont = true;
            this.TBFiyatListesiAdi.Properties.Padding = new System.Windows.Forms.Padding(3);
            this.TBFiyatListesiAdi.Size = new System.Drawing.Size(176, 26);
            this.TBFiyatListesiAdi.TabIndex = 63;
            // 
            // LBFiyatListesiAdi
            // 
            this.LBFiyatListesiAdi.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBFiyatListesiAdi.Appearance.Options.UseFont = true;
            this.LBFiyatListesiAdi.Location = new System.Drawing.Point(6, 51);
            this.LBFiyatListesiAdi.Name = "LBFiyatListesiAdi";
            this.LBFiyatListesiAdi.Size = new System.Drawing.Size(82, 14);
            this.LBFiyatListesiAdi.TabIndex = 9;
            this.LBFiyatListesiAdi.Text = "Fiyat Listesi Adı";
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
            ((System.ComponentModel.ISupportInitialize)(this.DGFiyatListesi)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CBAktif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CBBitisTar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBFiyatListesiAdi.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private DataGridView DGFiyatListesi;
        private Panel panel2;
        private GroupBox groupBox1;
        private DevExpress.XtraEditors.LabelControl LBFiyatListesiAdi;
        private DevExpress.XtraEditors.TextEdit TBFiyatListesiAdi;
        private DevExpress.XtraEditors.LabelControl LBBasTar;
        private DevExpress.XtraEditors.CheckedListBoxControl CBBitisTar;
        private DevExpress.XtraEditors.CheckedListBoxControl CBAktif;
        private DevExpress.XtraEditors.SimpleButton BTFiyatListesiSil;
        private DevExpress.XtraEditors.SimpleButton BTFiyatListesiKaydet;
        private DateTimePicker DTPBasTar;
        private DateTimePicker DTPBitisTar;
    }
}