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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.DGCariDurum = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.LBKodu = new DevExpress.XtraEditors.LabelControl();
            this.LBAdi = new DevExpress.XtraEditors.LabelControl();
            this.BTKoduSec = new DevExpress.XtraEditors.ButtonEdit();
            this.TBAdi = new DevExpress.XtraEditors.TextEdit();
            this.LBAlacak = new DevExpress.XtraEditors.LabelControl();
            this.LBBorc = new DevExpress.XtraEditors.LabelControl();
            this.LBToplam = new DevExpress.XtraEditors.LabelControl();
            this.LBAlacakDeger = new DevExpress.XtraEditors.LabelControl();
            this.LBBorcDeger = new DevExpress.XtraEditors.LabelControl();
            this.LBToplamDeger = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGCariDurum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTKoduSec.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBAdi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(941, 538);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.groupControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(2, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(937, 103);
            this.panelControl2.TabIndex = 0;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.DGCariDurum);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(2, 105);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(937, 431);
            this.panelControl3.TabIndex = 1;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.LBToplamDeger);
            this.groupControl1.Controls.Add(this.LBBorcDeger);
            this.groupControl1.Controls.Add(this.LBAlacakDeger);
            this.groupControl1.Controls.Add(this.LBToplam);
            this.groupControl1.Controls.Add(this.LBBorc);
            this.groupControl1.Controls.Add(this.LBAlacak);
            this.groupControl1.Controls.Add(this.TBAdi);
            this.groupControl1.Controls.Add(this.BTKoduSec);
            this.groupControl1.Controls.Add(this.LBAdi);
            this.groupControl1.Controls.Add(this.LBKodu);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl1.Location = new System.Drawing.Point(2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(933, 95);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Cari Durum";
            // 
            // DGCariDurum
            // 
            this.DGCariDurum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGCariDurum.Location = new System.Drawing.Point(2, 2);
            this.DGCariDurum.MainView = this.gridView1;
            this.DGCariDurum.Name = "DGCariDurum";
            this.DGCariDurum.Size = new System.Drawing.Size(933, 427);
            this.DGCariDurum.TabIndex = 0;
            this.DGCariDurum.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.DGCariDurum;
            this.gridView1.Name = "gridView1";
            // 
            // LBKodu
            // 
            this.LBKodu.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBKodu.Appearance.Options.UseFont = true;
            this.LBKodu.Location = new System.Drawing.Point(47, 33);
            this.LBKodu.Name = "LBKodu";
            this.LBKodu.Size = new System.Drawing.Size(46, 13);
            this.LBKodu.TabIndex = 0;
            this.LBKodu.Text = "Cari Kodu";
            // 
            // LBAdi
            // 
            this.LBAdi.Location = new System.Drawing.Point(56, 58);
            this.LBAdi.Name = "LBAdi";
            this.LBAdi.Size = new System.Drawing.Size(37, 13);
            this.LBAdi.TabIndex = 1;
            this.LBAdi.Text = "Cari Adı";
            // 
            // BTKoduSec
            // 
            this.BTKoduSec.Location = new System.Drawing.Point(116, 30);
            this.BTKoduSec.Name = "BTKoduSec";
            this.BTKoduSec.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.BTKoduSec.Size = new System.Drawing.Size(158, 20);
            this.BTKoduSec.TabIndex = 2;
            // 
            // TBAdi
            // 
            this.TBAdi.Location = new System.Drawing.Point(116, 56);
            this.TBAdi.Name = "TBAdi";
            this.TBAdi.Size = new System.Drawing.Size(158, 20);
            this.TBAdi.TabIndex = 3;
            // 
            // LBAlacak
            // 
            this.LBAlacak.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBAlacak.Appearance.Options.UseFont = true;
            this.LBAlacak.Location = new System.Drawing.Point(397, 28);
            this.LBAlacak.Name = "LBAlacak";
            this.LBAlacak.Size = new System.Drawing.Size(42, 18);
            this.LBAlacak.TabIndex = 4;
            this.LBAlacak.Text = "Alacak";
            // 
            // LBBorc
            // 
            this.LBBorc.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBBorc.Appearance.Options.UseFont = true;
            this.LBBorc.Location = new System.Drawing.Point(479, 28);
            this.LBBorc.Name = "LBBorc";
            this.LBBorc.Size = new System.Drawing.Size(29, 18);
            this.LBBorc.TabIndex = 5;
            this.LBBorc.Text = "Borç";
            // 
            // LBToplam
            // 
            this.LBToplam.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBToplam.Appearance.Options.UseFont = true;
            this.LBToplam.Location = new System.Drawing.Point(541, 28);
            this.LBToplam.Name = "LBToplam";
            this.LBToplam.Size = new System.Drawing.Size(49, 18);
            this.LBToplam.TabIndex = 6;
            this.LBToplam.Text = "Toplam";
            // 
            // LBAlacakDeger
            // 
            this.LBAlacakDeger.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBAlacakDeger.Appearance.Options.UseFont = true;
            this.LBAlacakDeger.Location = new System.Drawing.Point(413, 58);
            this.LBAlacakDeger.Name = "LBAlacakDeger";
            this.LBAlacakDeger.Size = new System.Drawing.Size(8, 18);
            this.LBAlacakDeger.TabIndex = 7;
            this.LBAlacakDeger.Text = "0";
            // 
            // LBBorcDeger
            // 
            this.LBBorcDeger.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBBorcDeger.Appearance.Options.UseFont = true;
            this.LBBorcDeger.Location = new System.Drawing.Point(488, 57);
            this.LBBorcDeger.Name = "LBBorcDeger";
            this.LBBorcDeger.Size = new System.Drawing.Size(8, 18);
            this.LBBorcDeger.TabIndex = 8;
            this.LBBorcDeger.Text = "0";
            // 
            // LBToplamDeger
            // 
            this.LBToplamDeger.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBToplamDeger.Appearance.Options.UseFont = true;
            this.LBToplamDeger.Location = new System.Drawing.Point(560, 57);
            this.LBToplamDeger.Name = "LBToplamDeger";
            this.LBToplamDeger.Size = new System.Drawing.Size(8, 18);
            this.LBToplamDeger.TabIndex = 9;
            this.LBToplamDeger.Text = "0";
            // 
            // FCariDurum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 538);
            this.Controls.Add(this.panelControl1);
            this.Name = "FCariDurum";
            this.Text = "FCariDurum";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGCariDurum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTKoduSec.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBAdi.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraGrid.GridControl DGCariDurum;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit TBAdi;
        private DevExpress.XtraEditors.ButtonEdit BTKoduSec;
        private DevExpress.XtraEditors.LabelControl LBAdi;
        private DevExpress.XtraEditors.LabelControl LBKodu;
        private DevExpress.XtraEditors.LabelControl LBToplam;
        private DevExpress.XtraEditors.LabelControl LBBorc;
        private DevExpress.XtraEditors.LabelControl LBAlacak;
        private DevExpress.XtraEditors.LabelControl LBToplamDeger;
        private DevExpress.XtraEditors.LabelControl LBBorcDeger;
        private DevExpress.XtraEditors.LabelControl LBAlacakDeger;
    }
}