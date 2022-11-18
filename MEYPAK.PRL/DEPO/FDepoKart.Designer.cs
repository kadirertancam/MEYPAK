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
            this.GCDepoKart = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GCGenelBilgi = new DevExpress.XtraEditors.GroupControl();
            this.BTDepoKartSec = new DevExpress.XtraEditors.SimpleButton();
            this.TBAdi = new DevExpress.XtraEditors.TextEdit();
            this.TBKod = new DevExpress.XtraEditors.TextEdit();
            this.CBAktif = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.TBAciklama = new System.Windows.Forms.TextBox();
            this.LBDepoKartSubeler = new DevExpress.XtraEditors.LabelControl();
            this.CLBSubeler = new System.Windows.Forms.CheckedListBox();
            this.LBDepoKartAdi = new DevExpress.XtraEditors.LabelControl();
            this.LBDepoKartAciklama = new DevExpress.XtraEditors.LabelControl();
            this.LBDepoKartKod = new DevExpress.XtraEditors.LabelControl();
            this.BTDepoKartSil = new DevExpress.XtraEditors.SimpleButton();
            this.BTDepoKartEkle = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GCDepoKart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GCGenelBilgi)).BeginInit();
            this.GCGenelBilgi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TBAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBKod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CBAktif)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(783, 450);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.GCDepoKart);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 251);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(783, 199);
            this.panel3.TabIndex = 1;
            // 
            // GCDepoKart
            // 
            this.GCDepoKart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GCDepoKart.Location = new System.Drawing.Point(0, 0);
            this.GCDepoKart.MainView = this.gridView1;
            this.GCDepoKart.Name = "GCDepoKart";
            this.GCDepoKart.Size = new System.Drawing.Size(783, 199);
            this.GCDepoKart.TabIndex = 1;
            this.GCDepoKart.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.GCDepoKart;
            this.gridView1.Name = "gridView1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupControl1);
            this.panel2.Controls.Add(this.GCGenelBilgi);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(783, 251);
            this.panel2.TabIndex = 0;
            // 
            // GCGenelBilgi
            // 
            this.GCGenelBilgi.Controls.Add(this.BTDepoKartSec);
            this.GCGenelBilgi.Controls.Add(this.TBAdi);
            this.GCGenelBilgi.Controls.Add(this.TBKod);
            this.GCGenelBilgi.Controls.Add(this.CBAktif);
            this.GCGenelBilgi.Controls.Add(this.TBAciklama);
            this.GCGenelBilgi.Controls.Add(this.LBDepoKartSubeler);
            this.GCGenelBilgi.Controls.Add(this.CLBSubeler);
            this.GCGenelBilgi.Controls.Add(this.LBDepoKartAdi);
            this.GCGenelBilgi.Controls.Add(this.LBDepoKartAciklama);
            this.GCGenelBilgi.Controls.Add(this.LBDepoKartKod);
            this.GCGenelBilgi.Dock = System.Windows.Forms.DockStyle.Top;
            this.GCGenelBilgi.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.GCGenelBilgi.Location = new System.Drawing.Point(0, 0);
            this.GCGenelBilgi.Name = "GCGenelBilgi";
            this.GCGenelBilgi.Size = new System.Drawing.Size(783, 174);
            this.GCGenelBilgi.TabIndex = 1;
            this.GCGenelBilgi.Text = "Genel Bilgi";
            // 
            // BTDepoKartSec
            // 
            this.BTDepoKartSec.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.BTDepoKartSec.Appearance.BackColor2 = System.Drawing.Color.Black;
            this.BTDepoKartSec.Appearance.BorderColor = System.Drawing.Color.Black;
            this.BTDepoKartSec.Appearance.ForeColor = System.Drawing.Color.Black;
            this.BTDepoKartSec.Appearance.Options.UseBackColor = true;
            this.BTDepoKartSec.Appearance.Options.UseBorderColor = true;
            this.BTDepoKartSec.Appearance.Options.UseFont = true;
            this.BTDepoKartSec.Appearance.Options.UseForeColor = true;
            this.BTDepoKartSec.AppearanceDisabled.BorderColor = System.Drawing.Color.Black;
            this.BTDepoKartSec.AppearanceDisabled.Options.UseBorderColor = true;
            this.BTDepoKartSec.AppearanceHovered.BorderColor = System.Drawing.Color.Black;
            this.BTDepoKartSec.AppearanceHovered.Options.UseBorderColor = true;
            this.BTDepoKartSec.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTDepoKartSec.ImageOptions.Image")));
            this.BTDepoKartSec.Location = new System.Drawing.Point(203, 22);
            this.BTDepoKartSec.Name = "BTDepoKartSec";
            this.BTDepoKartSec.Size = new System.Drawing.Size(59, 26);
            this.BTDepoKartSec.TabIndex = 61;
            this.BTDepoKartSec.Text = "Seç";
            this.BTDepoKartSec.Click += new System.EventHandler(this.BTDepoKartSec_Click);
            // 
            // TBAdi
            // 
            this.TBAdi.Location = new System.Drawing.Point(82, 54);
            this.TBAdi.Name = "TBAdi";
            this.TBAdi.Properties.Padding = new System.Windows.Forms.Padding(3);
            this.TBAdi.Size = new System.Drawing.Size(180, 26);
            this.TBAdi.TabIndex = 60;
            // 
            // TBKod
            // 
            this.TBKod.Location = new System.Drawing.Point(82, 22);
            this.TBKod.Name = "TBKod";
            this.TBKod.Properties.Padding = new System.Windows.Forms.Padding(3);
            this.TBKod.Size = new System.Drawing.Size(180, 26);
            this.TBKod.TabIndex = 59;
            // 
            // CBAktif
            // 
            this.CBAktif.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.CBAktif.Appearance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CBAktif.Appearance.Options.UseBackColor = true;
            this.CBAktif.Appearance.Options.UseFont = true;
            this.CBAktif.Appearance.Options.UseForeColor = true;
            this.CBAktif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CBAktif.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.CBAktif.CheckOnClick = true;
            this.CBAktif.IncrementalSearch = true;
            this.CBAktif.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(true, "Aktif", System.Windows.Forms.CheckState.Indeterminate)});
            this.CBAktif.Location = new System.Drawing.Point(72, 147);
            this.CBAktif.Name = "CBAktif";
            this.CBAktif.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.CBAktif.Size = new System.Drawing.Size(76, 21);
            this.CBAktif.TabIndex = 58;
            // 
            // TBAciklama
            // 
            this.TBAciklama.Location = new System.Drawing.Point(82, 82);
            this.TBAciklama.Multiline = true;
            this.TBAciklama.Name = "TBAciklama";
            this.TBAciklama.Size = new System.Drawing.Size(180, 61);
            this.TBAciklama.TabIndex = 3;
            // 
            // LBDepoKartSubeler
            // 
            this.LBDepoKartSubeler.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBDepoKartSubeler.Appearance.Options.UseFont = true;
            this.LBDepoKartSubeler.Location = new System.Drawing.Point(309, 15);
            this.LBDepoKartSubeler.Name = "LBDepoKartSubeler";
            this.LBDepoKartSubeler.Size = new System.Drawing.Size(41, 14);
            this.LBDepoKartSubeler.TabIndex = 57;
            this.LBDepoKartSubeler.Text = "Şubeler";
            // 
            // CLBSubeler
            // 
            this.CLBSubeler.FormattingEnabled = true;
            this.CLBSubeler.Location = new System.Drawing.Point(306, 33);
            this.CLBSubeler.Name = "CLBSubeler";
            this.CLBSubeler.Size = new System.Drawing.Size(214, 100);
            this.CLBSubeler.TabIndex = 5;
            // 
            // LBDepoKartAdi
            // 
            this.LBDepoKartAdi.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBDepoKartAdi.Appearance.Options.UseFont = true;
            this.LBDepoKartAdi.Location = new System.Drawing.Point(56, 56);
            this.LBDepoKartAdi.Name = "LBDepoKartAdi";
            this.LBDepoKartAdi.Size = new System.Drawing.Size(17, 14);
            this.LBDepoKartAdi.TabIndex = 4;
            this.LBDepoKartAdi.Text = "Adı";
            // 
            // LBDepoKartAciklama
            // 
            this.LBDepoKartAciklama.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBDepoKartAciklama.Appearance.Options.UseFont = true;
            this.LBDepoKartAciklama.Location = new System.Drawing.Point(27, 85);
            this.LBDepoKartAciklama.Name = "LBDepoKartAciklama";
            this.LBDepoKartAciklama.Size = new System.Drawing.Size(46, 14);
            this.LBDepoKartAciklama.TabIndex = 5;
            this.LBDepoKartAciklama.Text = "Açıklama";
            // 
            // LBDepoKartKod
            // 
            this.LBDepoKartKod.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBDepoKartKod.Appearance.Options.UseFont = true;
            this.LBDepoKartKod.Location = new System.Drawing.Point(52, 28);
            this.LBDepoKartKod.Name = "LBDepoKartKod";
            this.LBDepoKartKod.Size = new System.Drawing.Size(21, 14);
            this.LBDepoKartKod.TabIndex = 3;
            this.LBDepoKartKod.Text = "Kod";
            // 
            // BTDepoKartSil
            // 
            this.BTDepoKartSil.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.BTDepoKartSil.Appearance.Options.UseBackColor = true;
            this.BTDepoKartSil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTDepoKartSil.BackgroundImage")));
            this.BTDepoKartSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTDepoKartSil.ImageOptions.Image")));
            this.BTDepoKartSil.Location = new System.Drawing.Point(681, 25);
            this.BTDepoKartSil.Name = "BTDepoKartSil";
            this.BTDepoKartSil.Size = new System.Drawing.Size(82, 43);
            this.BTDepoKartSil.TabIndex = 47;
            this.BTDepoKartSil.Text = "Sil";
            // 
            // BTDepoKartEkle
            // 
            this.BTDepoKartEkle.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.BTDepoKartEkle.Appearance.Options.UseBackColor = true;
            this.BTDepoKartEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTDepoKartEkle.BackgroundImage")));
            this.BTDepoKartEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTDepoKartEkle.ImageOptions.Image")));
            this.BTDepoKartEkle.Location = new System.Drawing.Point(593, 25);
            this.BTDepoKartEkle.Name = "BTDepoKartEkle";
            this.BTDepoKartEkle.Size = new System.Drawing.Size(82, 43);
            this.BTDepoKartEkle.TabIndex = 46;
            this.BTDepoKartEkle.Text = "Ekle";
            this.BTDepoKartEkle.Click += new System.EventHandler(this.BTDepoKartEkle_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.BTDepoKartEkle);
            this.groupControl1.Controls.Add(this.BTDepoKartSil);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl1.Location = new System.Drawing.Point(0, 174);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(783, 77);
            this.groupControl1.TabIndex = 2;
            // 
            // FDepoKart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FDepoKart";
            this.Text = "FDepoKart";
            this.Load += new System.EventHandler(this.FDepoKart_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GCDepoKart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GCGenelBilgi)).EndInit();
            this.GCGenelBilgi.ResumeLayout(false);
            this.GCGenelBilgi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TBAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBKod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CBAktif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private CheckedListBox CLBSubeler;
        private TextBox TBAciklama;
        private DevExpress.XtraEditors.GroupControl GCGenelBilgi;
        private DevExpress.XtraEditors.LabelControl LBDepoKartKod;
        private DevExpress.XtraEditors.LabelControl LBDepoKartAdi;
        private DevExpress.XtraEditors.LabelControl LBDepoKartAciklama;
        private DevExpress.XtraEditors.LabelControl LBDepoKartSubeler;
        private DevExpress.XtraEditors.CheckedListBoxControl CBAktif;
        private DevExpress.XtraEditors.SimpleButton BTDepoKartSil;
        private DevExpress.XtraEditors.SimpleButton BTDepoKartEkle;
        private DevExpress.XtraGrid.GridControl GCDepoKart;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit TBKod;
        private DevExpress.XtraEditors.TextEdit TBAdi;
        private DevExpress.XtraEditors.SimpleButton BTDepoKartSec;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}