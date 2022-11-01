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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FCariDurum));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.GCCariDurum = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.PLCariDurum = new System.Windows.Forms.Panel();
            this.TECariKodu = new DevExpress.XtraEditors.TextEdit();
            this.LBCariKodu = new DevExpress.XtraEditors.LabelControl();
            this.BTCariKodSec = new DevExpress.XtraEditors.ButtonEdit();
            this.LBBorc = new DevExpress.XtraEditors.LabelControl();
            this.Alacak = new DevExpress.XtraEditors.LabelControl();
            this.LBBakiye = new DevExpress.XtraEditors.LabelControl();
            this.LBBorcDeger = new DevExpress.XtraEditors.LabelControl();
            this.LBBakiyeDeger = new DevExpress.XtraEditors.LabelControl();
            this.LBAlacakDeger = new DevExpress.XtraEditors.LabelControl();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GCCariDurum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.PLCariDurum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TECariKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTCariKodSec.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.PLCariDurum);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 584);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.GCCariDurum);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1184, 484);
            this.panel3.TabIndex = 2;
            // 
            // GCCariDurum
            // 
            this.GCCariDurum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GCCariDurum.Location = new System.Drawing.Point(0, 0);
            this.GCCariDurum.MainView = this.gridView1;
            this.GCCariDurum.Name = "GCCariDurum";
            this.GCCariDurum.Size = new System.Drawing.Size(1184, 484);
            this.GCCariDurum.TabIndex = 1;
            this.GCCariDurum.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.GCCariDurum;
            this.gridView1.Name = "gridView1";
            // 
            // PLCariDurum
            // 
            this.PLCariDurum.Controls.Add(this.LBAlacakDeger);
            this.PLCariDurum.Controls.Add(this.LBBakiyeDeger);
            this.PLCariDurum.Controls.Add(this.LBBorcDeger);
            this.PLCariDurum.Controls.Add(this.LBBakiye);
            this.PLCariDurum.Controls.Add(this.Alacak);
            this.PLCariDurum.Controls.Add(this.LBBorc);
            this.PLCariDurum.Controls.Add(this.LBCariKodu);
            this.PLCariDurum.Controls.Add(this.TECariKodu);
            this.PLCariDurum.Controls.Add(this.BTCariKodSec);
            this.PLCariDurum.Dock = System.Windows.Forms.DockStyle.Top;
            this.PLCariDurum.Location = new System.Drawing.Point(0, 0);
            this.PLCariDurum.Name = "PLCariDurum";
            this.PLCariDurum.Size = new System.Drawing.Size(1184, 100);
            this.PLCariDurum.TabIndex = 0;
            // 
            // TECariKodu
            // 
            this.TECariKodu.Location = new System.Drawing.Point(77, 46);
            this.TECariKodu.Name = "TECariKodu";
            this.TECariKodu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TECariKodu.Properties.Appearance.Options.UseFont = true;
            this.TECariKodu.Size = new System.Drawing.Size(168, 28);
            this.TECariKodu.TabIndex = 3;
            // 
            // LBCariKodu
            // 
            this.LBCariKodu.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBCariKodu.Appearance.Options.UseFont = true;
            this.LBCariKodu.Location = new System.Drawing.Point(12, 18);
            this.LBCariKodu.Name = "LBCariKodu";
            this.LBCariKodu.Size = new System.Drawing.Size(51, 14);
            this.LBCariKodu.TabIndex = 6;
            this.LBCariKodu.Text = "Cari Kodu";
            // 
            // BTCariKodSec
            // 
            this.BTCariKodSec.EditValue = "Seç";
            this.BTCariKodSec.Location = new System.Drawing.Point(77, 10);
            this.BTCariKodSec.Name = "BTCariKodSec";
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.BTCariKodSec.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, true, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.BTCariKodSec.Size = new System.Drawing.Size(168, 33);
            this.BTCariKodSec.TabIndex = 2;
            // 
            // LBBorc
            // 
            this.LBBorc.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBBorc.Appearance.Options.UseFont = true;
            this.LBBorc.Location = new System.Drawing.Point(330, 20);
            this.LBBorc.Name = "LBBorc";
            this.LBBorc.Size = new System.Drawing.Size(31, 19);
            this.LBBorc.TabIndex = 7;
            this.LBBorc.Text = "Borç";
            // 
            // Alacak
            // 
            this.Alacak.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Alacak.Appearance.Options.UseFont = true;
            this.Alacak.Location = new System.Drawing.Point(435, 20);
            this.Alacak.Name = "Alacak";
            this.Alacak.Size = new System.Drawing.Size(47, 19);
            this.Alacak.TabIndex = 8;
            this.Alacak.Text = "Alacak";
            // 
            // LBBakiye
            // 
            this.LBBakiye.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBBakiye.Appearance.Options.UseFont = true;
            this.LBBakiye.Location = new System.Drawing.Point(545, 20);
            this.LBBakiye.Name = "LBBakiye";
            this.LBBakiye.Size = new System.Drawing.Size(45, 19);
            this.LBBakiye.TabIndex = 9;
            this.LBBakiye.Text = "Bakiye";
            // 
            // LBBorcDeger
            // 
            this.LBBorcDeger.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBBorcDeger.Appearance.Options.UseFont = true;
            this.LBBorcDeger.Location = new System.Drawing.Point(341, 50);
            this.LBBorcDeger.Name = "LBBorcDeger";
            this.LBBorcDeger.Size = new System.Drawing.Size(9, 19);
            this.LBBorcDeger.TabIndex = 10;
            this.LBBorcDeger.Text = "0";
            // 
            // LBBakiyeDeger
            // 
            this.LBBakiyeDeger.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBBakiyeDeger.Appearance.Options.UseFont = true;
            this.LBBakiyeDeger.Location = new System.Drawing.Point(564, 50);
            this.LBBakiyeDeger.Name = "LBBakiyeDeger";
            this.LBBakiyeDeger.Size = new System.Drawing.Size(9, 19);
            this.LBBakiyeDeger.TabIndex = 11;
            this.LBBakiyeDeger.Text = "0";
            // 
            // LBAlacakDeger
            // 
            this.LBAlacakDeger.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBAlacakDeger.Appearance.Options.UseFont = true;
            this.LBAlacakDeger.Location = new System.Drawing.Point(452, 50);
            this.LBAlacakDeger.Name = "LBAlacakDeger";
            this.LBAlacakDeger.Size = new System.Drawing.Size(9, 19);
            this.LBAlacakDeger.TabIndex = 12;
            this.LBAlacakDeger.Text = "0";
            // 
            // FCariDurum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 584);
            this.Controls.Add(this.panel1);
            this.Name = "FCariDurum";
            this.Text = "FCariDurum";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GCCariDurum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.PLCariDurum.ResumeLayout(false);
            this.PLCariDurum.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TECariKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTCariKodSec.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel PLCariDurum;
        private Panel panel3;
        private DevExpress.XtraGrid.GridControl GCCariDurum;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit TECariKodu;
        private DevExpress.XtraEditors.LabelControl LBCariKodu;
        private DevExpress.XtraEditors.ButtonEdit BTCariKodSec;
        private DevExpress.XtraEditors.LabelControl LBBorc;
        private DevExpress.XtraEditors.LabelControl LBAlacakDeger;
        private DevExpress.XtraEditors.LabelControl LBBakiyeDeger;
        private DevExpress.XtraEditors.LabelControl LBBorcDeger;
        private DevExpress.XtraEditors.LabelControl LBBakiye;
        private DevExpress.XtraEditors.LabelControl Alacak;
    }
}