namespace MEYPAK.PRL.CARI
{
    partial class FCariDurum
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
            this.PLCariDurum1 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.PLCariDurum = new System.Windows.Forms.Panel();
            this.LBAlacakDeger = new DevExpress.XtraEditors.LabelControl();
            this.LBBakiyeDeger = new DevExpress.XtraEditors.LabelControl();
            this.LBBorcDeger = new DevExpress.XtraEditors.LabelControl();
            this.LBBakiye = new DevExpress.XtraEditors.LabelControl();
            this.Alacak = new DevExpress.XtraEditors.LabelControl();
            this.LBBorc = new DevExpress.XtraEditors.LabelControl();
            this.LBCariKodu = new DevExpress.XtraEditors.LabelControl();
            this.BECariKoduSec = new DevExpress.XtraEditors.ButtonEdit();
            this.TECariKodu = new DevExpress.XtraEditors.TextEdit();
            this.panel1.SuspendLayout();
            this.PLCariDurum1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.PLCariDurum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BECariKoduSec.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TECariKodu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PLCariDurum1);
            this.panel1.Controls.Add(this.PLCariDurum);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 584);
            this.panel1.TabIndex = 0;
            // 
            // PLCariDurum1
            // 
            this.PLCariDurum1.Controls.Add(this.gridControl1);
            this.PLCariDurum1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PLCariDurum1.Location = new System.Drawing.Point(0, 100);
            this.PLCariDurum1.Name = "PLCariDurum1";
            this.PLCariDurum1.Size = new System.Drawing.Size(1184, 484);
            this.PLCariDurum1.TabIndex = 2;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1184, 484);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // PLCariDurum
            // 
            this.PLCariDurum.Controls.Add(this.TECariKodu);
            this.PLCariDurum.Controls.Add(this.BECariKoduSec);
            this.PLCariDurum.Controls.Add(this.LBAlacakDeger);
            this.PLCariDurum.Controls.Add(this.LBBakiyeDeger);
            this.PLCariDurum.Controls.Add(this.LBBorcDeger);
            this.PLCariDurum.Controls.Add(this.LBBakiye);
            this.PLCariDurum.Controls.Add(this.Alacak);
            this.PLCariDurum.Controls.Add(this.LBBorc);
            this.PLCariDurum.Controls.Add(this.LBCariKodu);
            this.PLCariDurum.Dock = System.Windows.Forms.DockStyle.Top;
            this.PLCariDurum.Location = new System.Drawing.Point(0, 0);
            this.PLCariDurum.Name = "PLCariDurum";
            this.PLCariDurum.Size = new System.Drawing.Size(1184, 100);
            this.PLCariDurum.TabIndex = 0;
            // 
            // LBAlacakDeger
            // 
            this.LBAlacakDeger.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBAlacakDeger.Appearance.Options.UseFont = true;
            this.LBAlacakDeger.Location = new System.Drawing.Point(536, 49);
            this.LBAlacakDeger.Name = "LBAlacakDeger";
            this.LBAlacakDeger.Size = new System.Drawing.Size(9, 19);
            this.LBAlacakDeger.TabIndex = 12;
            this.LBAlacakDeger.Text = "0";
            // 
            // LBBakiyeDeger
            // 
            this.LBBakiyeDeger.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBBakiyeDeger.Appearance.Options.UseFont = true;
            this.LBBakiyeDeger.Location = new System.Drawing.Point(648, 49);
            this.LBBakiyeDeger.Name = "LBBakiyeDeger";
            this.LBBakiyeDeger.Size = new System.Drawing.Size(9, 19);
            this.LBBakiyeDeger.TabIndex = 11;
            this.LBBakiyeDeger.Text = "0";
            // 
            // LBBorcDeger
            // 
            this.LBBorcDeger.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBBorcDeger.Appearance.Options.UseFont = true;
            this.LBBorcDeger.Location = new System.Drawing.Point(425, 49);
            this.LBBorcDeger.Name = "LBBorcDeger";
            this.LBBorcDeger.Size = new System.Drawing.Size(9, 19);
            this.LBBorcDeger.TabIndex = 10;
            this.LBBorcDeger.Text = "0";
            // 
            // LBBakiye
            // 
            this.LBBakiye.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBBakiye.Appearance.Options.UseFont = true;
            this.LBBakiye.Location = new System.Drawing.Point(629, 19);
            this.LBBakiye.Name = "LBBakiye";
            this.LBBakiye.Size = new System.Drawing.Size(45, 19);
            this.LBBakiye.TabIndex = 9;
            this.LBBakiye.Text = "Bakiye";
            // 
            // Alacak
            // 
            this.Alacak.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Alacak.Appearance.Options.UseFont = true;
            this.Alacak.Location = new System.Drawing.Point(519, 19);
            this.Alacak.Name = "Alacak";
            this.Alacak.Size = new System.Drawing.Size(47, 19);
            this.Alacak.TabIndex = 8;
            this.Alacak.Text = "Alacak";
            // 
            // LBBorc
            // 
            this.LBBorc.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBBorc.Appearance.Options.UseFont = true;
            this.LBBorc.Location = new System.Drawing.Point(414, 19);
            this.LBBorc.Name = "LBBorc";
            this.LBBorc.Size = new System.Drawing.Size(31, 19);
            this.LBBorc.TabIndex = 7;
            this.LBBorc.Text = "Borç";
            // 
            // LBCariKodu
            // 
            this.LBCariKodu.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBCariKodu.Appearance.Options.UseFont = true;
            this.LBCariKodu.Location = new System.Drawing.Point(79, 35);
            this.LBCariKodu.Name = "LBCariKodu";
            this.LBCariKodu.Size = new System.Drawing.Size(51, 14);
            this.LBCariKodu.TabIndex = 6;
            this.LBCariKodu.Text = "Cari Kodu";
            this.LBCariKodu.Click += new System.EventHandler(this.LBCariKodu_Click);
            // 
            // BECariKoduSec
            // 
            this.BECariKoduSec.Location = new System.Drawing.Point(149, 32);
            this.BECariKoduSec.Name = "BECariKoduSec";
            this.BECariKoduSec.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.BECariKoduSec.Size = new System.Drawing.Size(174, 20);
            this.BECariKoduSec.TabIndex = 13;
            // 
            // TECariKodu
            // 
            this.TECariKodu.Location = new System.Drawing.Point(149, 59);
            this.TECariKodu.Name = "TECariKodu";
            this.TECariKodu.Size = new System.Drawing.Size(174, 20);
            this.TECariKodu.TabIndex = 14;
            // 
            // FCariDurum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 584);
            this.Controls.Add(this.panel1);
            this.Name = "FCariDurum";
            this.Text = "FCariDurum";
            this.Load += new System.EventHandler(this.FCariDurum_Load);
            this.panel1.ResumeLayout(false);
            this.PLCariDurum1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.PLCariDurum.ResumeLayout(false);
            this.PLCariDurum.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BECariKoduSec.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TECariKodu.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel PLCariDurum;
        private Panel PLCariDurum1;
        private DevExpress.XtraEditors.LabelControl LBCariKodu;
        private DevExpress.XtraEditors.LabelControl LBBorc;
        private DevExpress.XtraEditors.LabelControl LBAlacakDeger;
        private DevExpress.XtraEditors.LabelControl LBBakiyeDeger;
        private DevExpress.XtraEditors.LabelControl LBBorcDeger;
        private DevExpress.XtraEditors.LabelControl LBBakiye;
        private DevExpress.XtraEditors.LabelControl Alacak;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.ButtonEdit BECariKoduSec;
        private DevExpress.XtraEditors.TextEdit TECariKodu;
    }
}