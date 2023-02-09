namespace MEYPAK.PRL.STOK
{
    partial class StokKasaGirisPanel
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.TBKasaKoduSec = new DevExpress.XtraEditors.ButtonEdit();
            this.TBKasaAdi = new MEYPAK.PRL.Assets.YeniTextEdit();
            this.DTPTarih = new DevExpress.XtraEditors.DateEdit();
            this.TBMiktar = new MEYPAK.PRL.Assets.YeniTextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.BTSil = new DevExpress.XtraEditors.SimpleButton();
            this.BTKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.LBGirisBaslik = new DevExpress.XtraEditors.LabelControl();
            this.LBCikisBaslik = new DevExpress.XtraEditors.LabelControl();
            this.LBBakiyeBaslik = new DevExpress.XtraEditors.LabelControl();
            this.LBGiris = new DevExpress.XtraEditors.LabelControl();
            this.LBCikis = new DevExpress.XtraEditors.LabelControl();
            this.LBBakiye = new DevExpress.XtraEditors.LabelControl();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TBKasaKoduSec.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBKasaAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTPTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTPTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBMiktar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1049, 506);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gridControl1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 149);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1049, 357);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1049, 149);
            this.panel2.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(15, 37);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Kasa Kodu:";
            // 
            // TBKasaKoduSec
            // 
            this.TBKasaKoduSec.Location = new System.Drawing.Point(88, 34);
            this.TBKasaKoduSec.Name = "TBKasaKoduSec";
            this.TBKasaKoduSec.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Seç", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.TBKasaKoduSec.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.buttonEdit1_Properties_ButtonClick);
            this.TBKasaKoduSec.Size = new System.Drawing.Size(166, 22);
            this.TBKasaKoduSec.TabIndex = 2;
            // 
            // TBKasaAdi
            // 
            this.TBKasaAdi.Enabled = false;
            this.TBKasaAdi.Location = new System.Drawing.Point(88, 60);
            this.TBKasaAdi.Name = "TBKasaAdi";
            this.TBKasaAdi.Size = new System.Drawing.Size(166, 20);
            this.TBKasaAdi.TabIndex = 3;
            // 
            // DTPTarih
            // 
            this.DTPTarih.EditValue = null;
            this.DTPTarih.Location = new System.Drawing.Point(88, 86);
            this.DTPTarih.Name = "DTPTarih";
            this.DTPTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DTPTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DTPTarih.Size = new System.Drawing.Size(166, 20);
            this.DTPTarih.TabIndex = 4;
            // 
            // TBMiktar
            // 
            this.TBMiktar.Location = new System.Drawing.Point(88, 112);
            this.TBMiktar.Name = "TBMiktar";
            this.TBMiktar.Size = new System.Drawing.Size(166, 20);
            this.TBMiktar.TabIndex = 5;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(41, 89);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(28, 13);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Tarih:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(36, 115);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(33, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Miktar:";
            // 
            // BTSil
            // 
            this.BTSil.Location = new System.Drawing.Point(826, 78);
            this.BTSil.Name = "BTSil";
            this.BTSil.Size = new System.Drawing.Size(98, 65);
            this.BTSil.TabIndex = 8;
            this.BTSil.Text = "Sil";
            // 
            // BTKaydet
            // 
            this.BTKaydet.Location = new System.Drawing.Point(939, 78);
            this.BTKaydet.Name = "BTKaydet";
            this.BTKaydet.Size = new System.Drawing.Size(98, 65);
            this.BTKaydet.TabIndex = 9;
            this.BTKaydet.Text = "Kaydet";
            this.BTKaydet.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1049, 357);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.groupControl2);
            this.groupControl1.Controls.Add(this.TBMiktar);
            this.groupControl1.Controls.Add(this.BTKaydet);
            this.groupControl1.Controls.Add(this.BTSil);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.TBKasaKoduSec);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.TBKasaAdi);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.DTPTarih);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1049, 149);
            this.groupControl1.TabIndex = 10;
            this.groupControl1.Text = "Stok Kasa";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.LBBakiye);
            this.groupControl2.Controls.Add(this.LBCikis);
            this.groupControl2.Controls.Add(this.LBGiris);
            this.groupControl2.Controls.Add(this.LBBakiyeBaslik);
            this.groupControl2.Controls.Add(this.LBCikisBaslik);
            this.groupControl2.Controls.Add(this.LBGirisBaslik);
            this.groupControl2.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl2.Location = new System.Drawing.Point(300, 23);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(244, 120);
            this.groupControl2.TabIndex = 10;
            // 
            // LBGirisBaslik
            // 
            this.LBGirisBaslik.Appearance.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBGirisBaslik.Appearance.ForeColor = System.Drawing.Color.Red;
            this.LBGirisBaslik.Appearance.Options.UseFont = true;
            this.LBGirisBaslik.Appearance.Options.UseForeColor = true;
            this.LBGirisBaslik.Location = new System.Drawing.Point(18, 26);
            this.LBGirisBaslik.Name = "LBGirisBaslik";
            this.LBGirisBaslik.Size = new System.Drawing.Size(36, 23);
            this.LBGirisBaslik.TabIndex = 0;
            this.LBGirisBaslik.Text = "Giriş";
            // 
            // LBCikisBaslik
            // 
            this.LBCikisBaslik.Appearance.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBCikisBaslik.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.LBCikisBaslik.Appearance.Options.UseFont = true;
            this.LBCikisBaslik.Appearance.Options.UseForeColor = true;
            this.LBCikisBaslik.Location = new System.Drawing.Point(93, 26);
            this.LBCikisBaslik.Name = "LBCikisBaslik";
            this.LBCikisBaslik.Size = new System.Drawing.Size(36, 23);
            this.LBCikisBaslik.TabIndex = 0;
            this.LBCikisBaslik.Text = "Çıkış";
            // 
            // LBBakiyeBaslik
            // 
            this.LBBakiyeBaslik.Appearance.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBBakiyeBaslik.Appearance.Options.UseFont = true;
            this.LBBakiyeBaslik.Location = new System.Drawing.Point(170, 26);
            this.LBBakiyeBaslik.Name = "LBBakiyeBaslik";
            this.LBBakiyeBaslik.Size = new System.Drawing.Size(53, 23);
            this.LBBakiyeBaslik.TabIndex = 0;
            this.LBBakiyeBaslik.Text = "Bakiye";
            // 
            // LBGiris
            // 
            this.LBGiris.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBGiris.Appearance.ForeColor = System.Drawing.Color.Red;
            this.LBGiris.Appearance.Options.UseFont = true;
            this.LBGiris.Appearance.Options.UseForeColor = true;
            this.LBGiris.Location = new System.Drawing.Point(31, 76);
            this.LBGiris.Name = "LBGiris";
            this.LBGiris.Size = new System.Drawing.Size(9, 19);
            this.LBGiris.TabIndex = 1;
            this.LBGiris.Text = "0";
            // 
            // LBCikis
            // 
            this.LBCikis.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBCikis.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.LBCikis.Appearance.Options.UseFont = true;
            this.LBCikis.Appearance.Options.UseForeColor = true;
            this.LBCikis.Location = new System.Drawing.Point(106, 76);
            this.LBCikis.Name = "LBCikis";
            this.LBCikis.Size = new System.Drawing.Size(9, 19);
            this.LBCikis.TabIndex = 1;
            this.LBCikis.Text = "0";
            // 
            // LBBakiye
            // 
            this.LBBakiye.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBBakiye.Appearance.Options.UseFont = true;
            this.LBBakiye.Location = new System.Drawing.Point(190, 76);
            this.LBBakiye.Name = "LBBakiye";
            this.LBBakiye.Size = new System.Drawing.Size(9, 19);
            this.LBBakiye.TabIndex = 1;
            this.LBBakiye.Text = "0";
            // 
            // StokKasaGirisPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 506);
            this.Controls.Add(this.panel1);
            this.Name = "StokKasaGirisPanel";
            this.Text = "StokKasaGirisPanel";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TBKasaKoduSec.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBKasaAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTPTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTPTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBMiktar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private DevExpress.XtraEditors.SimpleButton BTKaydet;
        private DevExpress.XtraEditors.SimpleButton BTSil;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private Assets.YeniTextEdit TBMiktar;
        private DevExpress.XtraEditors.DateEdit DTPTarih;
        private Assets.YeniTextEdit TBKasaAdi;
        private DevExpress.XtraEditors.ButtonEdit TBKasaKoduSec;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl LBBakiye;
        private DevExpress.XtraEditors.LabelControl LBCikis;
        private DevExpress.XtraEditors.LabelControl LBGiris;
        private DevExpress.XtraEditors.LabelControl LBBakiyeBaslik;
        private DevExpress.XtraEditors.LabelControl LBCikisBaslik;
        private DevExpress.XtraEditors.LabelControl LBGirisBaslik;
    }
}