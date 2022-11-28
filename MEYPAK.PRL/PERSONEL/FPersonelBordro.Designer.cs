namespace MEYPAK.PRL.PERSONEL
{
    partial class FPersonelBordro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FPersonelBordro));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DGPersonelBordro = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BTHesapla = new DevExpress.XtraEditors.SimpleButton();
            this.TBAy = new DevExpress.XtraEditors.TextEdit();
            this.TBTcKimlik = new DevExpress.XtraEditors.TextEdit();
            this.LBGorev = new DevExpress.XtraEditors.LabelControl();
            this.LBAy = new DevExpress.XtraEditors.LabelControl();
            this.LBSoyadi = new DevExpress.XtraEditors.LabelControl();
            this.LBAdi = new DevExpress.XtraEditors.LabelControl();
            this.LBTcKimlik = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGPersonelBordro)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TBAy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBTcKimlik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1400, 850);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.DGPersonelBordro);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 164);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1400, 686);
            this.panel3.TabIndex = 1;
            // 
            // DGPersonelBordro
            // 
            this.DGPersonelBordro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGPersonelBordro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGPersonelBordro.Location = new System.Drawing.Point(0, 0);
            this.DGPersonelBordro.Name = "DGPersonelBordro";
            this.DGPersonelBordro.RowTemplate.Height = 25;
            this.DGPersonelBordro.Size = new System.Drawing.Size(1400, 686);
            this.DGPersonelBordro.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1400, 164);
            this.panel2.TabIndex = 0;
            // 
            // BTHesapla
            // 
            this.BTHesapla.Appearance.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTHesapla.Appearance.Options.UseBackColor = true;
            this.BTHesapla.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTHesapla.ImageOptions.Image")));
            this.BTHesapla.Location = new System.Drawing.Point(344, 36);
            this.BTHesapla.Name = "BTHesapla";
            this.BTHesapla.Size = new System.Drawing.Size(95, 40);
            this.BTHesapla.TabIndex = 63;
            this.BTHesapla.Text = "Hesapla";
            // 
            // TBAy
            // 
            this.TBAy.EditValue = "";
            this.TBAy.Location = new System.Drawing.Point(113, 128);
            this.TBAy.Name = "TBAy";
            this.TBAy.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TBAy.Properties.Appearance.Options.UseFont = true;
            this.TBAy.Size = new System.Drawing.Size(180, 20);
            this.TBAy.TabIndex = 61;
            // 
            // TBTcKimlik
            // 
            this.TBTcKimlik.EditValue = "___________";
            this.TBTcKimlik.Location = new System.Drawing.Point(113, 39);
            this.TBTcKimlik.Name = "TBTcKimlik";
            this.TBTcKimlik.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TBTcKimlik.Properties.Appearance.Options.UseFont = true;
            this.TBTcKimlik.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegularMaskManager));
            this.TBTcKimlik.Properties.MaskSettings.Set("MaskManagerSignature", "ignoreMaskBlank=True");
            this.TBTcKimlik.Properties.MaskSettings.Set("mask", "[0-9]");
            this.TBTcKimlik.Size = new System.Drawing.Size(180, 20);
            this.TBTcKimlik.TabIndex = 26;
            // 
            // LBGorev
            // 
            this.LBGorev.Location = new System.Drawing.Point(58, 112);
            this.LBGorev.Name = "LBGorev";
            this.LBGorev.Size = new System.Drawing.Size(29, 13);
            this.LBGorev.TabIndex = 25;
            this.LBGorev.Text = "Görev";
            // 
            // LBAy
            // 
            this.LBAy.Location = new System.Drawing.Point(74, 131);
            this.LBAy.Name = "LBAy";
            this.LBAy.Size = new System.Drawing.Size(13, 13);
            this.LBAy.TabIndex = 24;
            this.LBAy.Text = "Ay";
            // 
            // LBSoyadi
            // 
            this.LBSoyadi.Location = new System.Drawing.Point(57, 90);
            this.LBSoyadi.Name = "LBSoyadi";
            this.LBSoyadi.Size = new System.Drawing.Size(30, 13);
            this.LBSoyadi.TabIndex = 23;
            this.LBSoyadi.Text = "Soyad";
            // 
            // LBAdi
            // 
            this.LBAdi.Location = new System.Drawing.Point(74, 68);
            this.LBAdi.Name = "LBAdi";
            this.LBAdi.Size = new System.Drawing.Size(13, 13);
            this.LBAdi.TabIndex = 22;
            this.LBAdi.Text = "Ad";
            // 
            // LBTcKimlik
            // 
            this.LBTcKimlik.Location = new System.Drawing.Point(58, 42);
            this.LBTcKimlik.Name = "LBTcKimlik";
            this.LBTcKimlik.Size = new System.Drawing.Size(29, 13);
            this.LBTcKimlik.TabIndex = 21;
            this.LBTcKimlik.Text = "TC No";
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.groupControl1.Controls.Add(this.BTHesapla);
            this.groupControl1.Controls.Add(this.LBTcKimlik);
            this.groupControl1.Controls.Add(this.LBAdi);
            this.groupControl1.Controls.Add(this.TBAy);
            this.groupControl1.Controls.Add(this.LBSoyadi);
            this.groupControl1.Controls.Add(this.LBGorev);
            this.groupControl1.Controls.Add(this.TBTcKimlik);
            this.groupControl1.Controls.Add(this.LBAy);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1400, 158);
            this.groupControl1.TabIndex = 13;
            this.groupControl1.Text = "Genel Bilgi";
            // 
            // FPersonelBordro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 850);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FPersonelBordro";
            this.Text = "FPersonelBordro";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGPersonelBordro)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TBAy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBTcKimlik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private DataGridView DGPersonelBordro;
        private Panel panel2;
        private DevExpress.XtraEditors.LabelControl LBGorev;
        private DevExpress.XtraEditors.LabelControl LBAy;
        private DevExpress.XtraEditors.LabelControl LBSoyadi;
        private DevExpress.XtraEditors.LabelControl LBAdi;
        private DevExpress.XtraEditors.LabelControl LBTcKimlik;
        private DevExpress.XtraEditors.TextEdit TBTcKimlik;
        private DevExpress.XtraEditors.TextEdit TBAy;
        private DevExpress.XtraEditors.SimpleButton BTHesapla;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}