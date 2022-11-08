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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FDepoKart));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DGDepoKart = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BTSil = new DevExpress.XtraEditors.SimpleButton();
            this.GCGenelBilgi = new DevExpress.XtraEditors.GroupControl();
            this.CBAktif = new DevExpress.XtraEditors.CheckEdit();
            this.TBAciklama = new DevExpress.XtraEditors.MemoEdit();
            this.TBAdi = new DevExpress.XtraEditors.TextEdit();
            this.BTKodSec = new DevExpress.XtraEditors.ButtonEdit();
            this.LBDepoKartSubeler = new DevExpress.XtraEditors.LabelControl();
            this.CBSubeler = new System.Windows.Forms.CheckedListBox();
            this.LBAdi = new DevExpress.XtraEditors.LabelControl();
            this.LBDepoKartAciklama = new DevExpress.XtraEditors.LabelControl();
            this.LBKod = new DevExpress.XtraEditors.LabelControl();
            this.BTEkle = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGDepoKart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GCGenelBilgi)).BeginInit();
            this.GCGenelBilgi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CBAktif.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTKodSec.Properties)).BeginInit();
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
            this.panel3.Controls.Add(this.DGDepoKart);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 229);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(561, 221);
            this.panel3.TabIndex = 1;
            // 
            // DGDepoKart
            // 
            this.DGDepoKart.Location = new System.Drawing.Point(0, 3);
            this.DGDepoKart.MainView = this.gridView1;
            this.DGDepoKart.Name = "DGDepoKart";
            this.DGDepoKart.Size = new System.Drawing.Size(561, 218);
            this.DGDepoKart.TabIndex = 1;
            this.DGDepoKart.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.DGDepoKart;
            this.gridView1.Name = "gridView1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BTSil);
            this.panel2.Controls.Add(this.GCGenelBilgi);
            this.panel2.Controls.Add(this.BTEkle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(561, 229);
            this.panel2.TabIndex = 0;
            // 
            // BTSil
            // 
            this.BTSil.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.BTSil.Appearance.Options.UseBackColor = true;
            this.BTSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTSil.ImageOptions.Image")));
            this.BTSil.Location = new System.Drawing.Point(100, 182);
            this.BTSil.Name = "BTSil";
            this.BTSil.Size = new System.Drawing.Size(84, 41);
            this.BTSil.TabIndex = 49;
            this.BTSil.Text = "Sil";
            this.BTSil.Click += new System.EventHandler(this.BTSil_Click);
            // 
            // GCGenelBilgi
            // 
            this.GCGenelBilgi.Controls.Add(this.CBAktif);
            this.GCGenelBilgi.Controls.Add(this.TBAciklama);
            this.GCGenelBilgi.Controls.Add(this.TBAdi);
            this.GCGenelBilgi.Controls.Add(this.BTKodSec);
            this.GCGenelBilgi.Controls.Add(this.LBDepoKartSubeler);
            this.GCGenelBilgi.Controls.Add(this.CBSubeler);
            this.GCGenelBilgi.Controls.Add(this.LBAdi);
            this.GCGenelBilgi.Controls.Add(this.LBDepoKartAciklama);
            this.GCGenelBilgi.Controls.Add(this.LBKod);
            this.GCGenelBilgi.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.GCGenelBilgi.Location = new System.Drawing.Point(2, 3);
            this.GCGenelBilgi.Name = "GCGenelBilgi";
            this.GCGenelBilgi.Size = new System.Drawing.Size(556, 173);
            this.GCGenelBilgi.TabIndex = 1;
            this.GCGenelBilgi.Text = "Genel Bilgi";
            // 
            // CBAktif
            // 
            this.CBAktif.EditValue = true;
            this.CBAktif.Location = new System.Drawing.Point(98, 147);
            this.CBAktif.Name = "CBAktif";
            this.CBAktif.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CBAktif.Properties.Appearance.Options.UseFont = true;
            this.CBAktif.Properties.Caption = "Aktif";
            this.CBAktif.Size = new System.Drawing.Size(75, 20);
            this.CBAktif.TabIndex = 104;
            // 
            // TBAciklama
            // 
            this.TBAciklama.Location = new System.Drawing.Point(82, 83);
            this.TBAciklama.Name = "TBAciklama";
            this.TBAciklama.Size = new System.Drawing.Size(158, 58);
            this.TBAciklama.TabIndex = 63;
            // 
            // TBAdi
            // 
            this.TBAdi.Location = new System.Drawing.Point(82, 53);
            this.TBAdi.Name = "TBAdi";
            this.TBAdi.Size = new System.Drawing.Size(158, 20);
            this.TBAdi.TabIndex = 62;
            // 
            // BTKodSec
            // 
            this.BTKodSec.Location = new System.Drawing.Point(82, 25);
            this.BTKodSec.Name = "BTKodSec";
            this.BTKodSec.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.BTKodSec.Size = new System.Drawing.Size(158, 20);
            this.BTKodSec.TabIndex = 61;
            this.BTKodSec.Click += new System.EventHandler(this.BTKodSec_Click);
            // 
            // LBDepoKartSubeler
            // 
            this.LBDepoKartSubeler.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBDepoKartSubeler.Appearance.Options.UseFont = true;
            this.LBDepoKartSubeler.Location = new System.Drawing.Point(309, 22);
            this.LBDepoKartSubeler.Name = "LBDepoKartSubeler";
            this.LBDepoKartSubeler.Size = new System.Drawing.Size(39, 13);
            this.LBDepoKartSubeler.TabIndex = 57;
            this.LBDepoKartSubeler.Text = "Şubeler";
            // 
            // CBSubeler
            // 
            this.CBSubeler.FormattingEnabled = true;
            this.CBSubeler.Location = new System.Drawing.Point(309, 41);
            this.CBSubeler.Name = "CBSubeler";
            this.CBSubeler.Size = new System.Drawing.Size(127, 100);
            this.CBSubeler.TabIndex = 5;
            // 
            // LBAdi
            // 
            this.LBAdi.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBAdi.Appearance.Options.UseFont = true;
            this.LBAdi.Location = new System.Drawing.Point(56, 56);
            this.LBAdi.Name = "LBAdi";
            this.LBAdi.Size = new System.Drawing.Size(17, 13);
            this.LBAdi.TabIndex = 4;
            this.LBAdi.Text = "Adı";
            // 
            // LBDepoKartAciklama
            // 
            this.LBDepoKartAciklama.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBDepoKartAciklama.Appearance.Options.UseFont = true;
            this.LBDepoKartAciklama.Location = new System.Drawing.Point(27, 85);
            this.LBDepoKartAciklama.Name = "LBDepoKartAciklama";
            this.LBDepoKartAciklama.Size = new System.Drawing.Size(45, 13);
            this.LBDepoKartAciklama.TabIndex = 5;
            this.LBDepoKartAciklama.Text = "Açıklama";
            // 
            // LBKod
            // 
            this.LBKod.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBKod.Appearance.Options.UseFont = true;
            this.LBKod.Location = new System.Drawing.Point(52, 28);
            this.LBKod.Name = "LBKod";
            this.LBKod.Size = new System.Drawing.Size(20, 13);
            this.LBKod.TabIndex = 3;
            this.LBKod.Text = "Kod";
            // 
            // BTEkle
            // 
            this.BTEkle.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.BTEkle.Appearance.Options.UseBackColor = true;
            this.BTEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTEkle.ImageOptions.Image")));
            this.BTEkle.Location = new System.Drawing.Point(10, 182);
            this.BTEkle.Name = "BTEkle";
            this.BTEkle.Size = new System.Drawing.Size(84, 41);
            this.BTEkle.TabIndex = 48;
            this.BTEkle.Text = "Ekle";
            this.BTEkle.Click += new System.EventHandler(this.BTEkle_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.DGDepoKart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GCGenelBilgi)).EndInit();
            this.GCGenelBilgi.ResumeLayout(false);
            this.GCGenelBilgi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CBAktif.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTKodSec.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private CheckedListBox CBSubeler;
        private DevExpress.XtraEditors.GroupControl GCGenelBilgi;
        private DevExpress.XtraEditors.LabelControl LBKod;
        private DevExpress.XtraEditors.LabelControl LBAdi;
        private DevExpress.XtraEditors.LabelControl LBDepoKartAciklama;
        private DevExpress.XtraEditors.LabelControl LBDepoKartSubeler;
        private DevExpress.XtraGrid.GridControl DGDepoKart;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.ButtonEdit BTKodSec;
        private DevExpress.XtraEditors.MemoEdit TBAciklama;
        private DevExpress.XtraEditors.TextEdit TBAdi;
        private DevExpress.XtraEditors.CheckEdit CBAktif;
        private DevExpress.XtraEditors.SimpleButton BTSil;
        private DevExpress.XtraEditors.SimpleButton BTEkle;
    }
}