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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TBCariKodu = new DevExpress.XtraEditors.TextEdit();
            this.BTCariKoduSec = new DevExpress.XtraEditors.ButtonEdit();
            this.LBAlacakDeger = new DevExpress.XtraEditors.LabelControl();
            this.LBBakiyeDeger = new DevExpress.XtraEditors.LabelControl();
            this.LBBorcDeger = new DevExpress.XtraEditors.LabelControl();
            this.LBBakiye = new DevExpress.XtraEditors.LabelControl();
            this.LBAlacak = new DevExpress.XtraEditors.LabelControl();
            this.LBBorc = new DevExpress.XtraEditors.LabelControl();
            this.LBCariKodu = new DevExpress.XtraEditors.LabelControl();
            this.DGCariDurum = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TBCariKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTCariKoduSec.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGCariDurum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 584);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TBCariKodu);
            this.panel2.Controls.Add(this.BTCariKoduSec);
            this.panel2.Controls.Add(this.LBAlacakDeger);
            this.panel2.Controls.Add(this.LBBakiyeDeger);
            this.panel2.Controls.Add(this.LBBorcDeger);
            this.panel2.Controls.Add(this.LBBakiye);
            this.panel2.Controls.Add(this.LBAlacak);
            this.panel2.Controls.Add(this.LBBorc);
            this.panel2.Controls.Add(this.LBCariKodu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1184, 100);
            this.panel2.TabIndex = 0;
            // 
            // TBCariKodu
            // 
            this.TBCariKodu.Location = new System.Drawing.Point(149, 57);
            this.TBCariKodu.Name = "TBCariKodu";
            this.TBCariKodu.Size = new System.Drawing.Size(149, 20);
            this.TBCariKodu.TabIndex = 65;
            // 
            // BTCariKoduSec
            // 
            this.BTCariKoduSec.Location = new System.Drawing.Point(149, 29);
            this.BTCariKoduSec.Name = "BTCariKoduSec";
            this.BTCariKoduSec.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Seç", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.BTCariKoduSec.Size = new System.Drawing.Size(149, 22);
            this.BTCariKoduSec.TabIndex = 64;
            this.BTCariKoduSec.Click += new System.EventHandler(this.BTCariKoduSec_Click);
            // 
            // LBAlacakDeger
            // 
            this.LBAlacakDeger.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBAlacakDeger.Appearance.Options.UseFont = true;
            this.LBAlacakDeger.Location = new System.Drawing.Point(536, 49);
            this.LBAlacakDeger.Name = "LBAlacakDeger";
            this.LBAlacakDeger.Size = new System.Drawing.Size(9, 21);
            this.LBAlacakDeger.TabIndex = 12;
            this.LBAlacakDeger.Text = "0";
            // 
            // LBBakiyeDeger
            // 
            this.LBBakiyeDeger.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBBakiyeDeger.Appearance.Options.UseFont = true;
            this.LBBakiyeDeger.Location = new System.Drawing.Point(648, 49);
            this.LBBakiyeDeger.Name = "LBBakiyeDeger";
            this.LBBakiyeDeger.Size = new System.Drawing.Size(9, 21);
            this.LBBakiyeDeger.TabIndex = 11;
            this.LBBakiyeDeger.Text = "0";
            // 
            // LBBorcDeger
            // 
            this.LBBorcDeger.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBBorcDeger.Appearance.Options.UseFont = true;
            this.LBBorcDeger.Location = new System.Drawing.Point(425, 49);
            this.LBBorcDeger.Name = "LBBorcDeger";
            this.LBBorcDeger.Size = new System.Drawing.Size(9, 21);
            this.LBBorcDeger.TabIndex = 10;
            this.LBBorcDeger.Text = "0";
            // 
            // LBBakiye
            // 
            this.LBBakiye.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBBakiye.Appearance.Options.UseFont = true;
            this.LBBakiye.Location = new System.Drawing.Point(629, 19);
            this.LBBakiye.Name = "LBBakiye";
            this.LBBakiye.Size = new System.Drawing.Size(45, 21);
            this.LBBakiye.TabIndex = 9;
            this.LBBakiye.Text = "Bakiye";
            // 
            // LBAlacak
            // 
            this.LBAlacak.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBAlacak.Appearance.Options.UseFont = true;
            this.LBAlacak.Location = new System.Drawing.Point(519, 19);
            this.LBAlacak.Name = "LBAlacak";
            this.LBAlacak.Size = new System.Drawing.Size(45, 21);
            this.LBAlacak.TabIndex = 8;
            this.LBAlacak.Text = "Alacak";
            // 
            // LBBorc
            // 
            this.LBBorc.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBBorc.Appearance.Options.UseFont = true;
            this.LBBorc.Location = new System.Drawing.Point(414, 19);
            this.LBBorc.Name = "LBBorc";
            this.LBBorc.Size = new System.Drawing.Size(31, 21);
            this.LBBorc.TabIndex = 7;
            this.LBBorc.Text = "Borç";
            // 
            // LBCariKodu
            // 
            this.LBCariKodu.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBCariKodu.Appearance.Options.UseFont = true;
            this.LBCariKodu.Location = new System.Drawing.Point(75, 32);
            this.LBCariKodu.Name = "LBCariKodu";
            this.LBCariKodu.Size = new System.Drawing.Size(50, 13);
            this.LBCariKodu.TabIndex = 6;
            this.LBCariKodu.Text = "Cari Kodu";
            // 
            // DGCariDurum
            // 
            this.DGCariDurum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGCariDurum.Location = new System.Drawing.Point(0, 0);
            this.DGCariDurum.MainView = this.gridView1;
            this.DGCariDurum.Name = "DGCariDurum";
            this.DGCariDurum.Size = new System.Drawing.Size(1184, 484);
            this.DGCariDurum.TabIndex = 0;
            this.DGCariDurum.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.DGCariDurum;
            this.gridView1.Name = "gridView1";
            // 
            // FCariDurum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 584);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FCariDurum";
            this.Text = "FCariDurum";
            this.Load += new System.EventHandler(this.FCariDurum_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TBCariKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTCariKoduSec.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGCariDurum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
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
        private DevExpress.XtraEditors.LabelControl LBAlacak;
        private DevExpress.XtraGrid.GridControl DGCariDurum;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit TBCariKodu;
        private DevExpress.XtraEditors.ButtonEdit BTCariKoduSec;
        private Panel panel2;
    }
}