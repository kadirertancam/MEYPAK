namespace MEYPAK.PRL.KASA
{
    partial class FKasaKart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FKasaKart));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.DTPTarih = new DevExpress.XtraEditors.DateEdit();
            this.CBParaBirim = new DevExpress.XtraEditors.LookUpEdit();
            this.TBTutar = new DevExpress.XtraEditors.TextEdit();
            this.TBAdi = new DevExpress.XtraEditors.TextEdit();
            this.TBKod = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.TBAciklama = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.CEAktif = new DevExpress.XtraEditors.CheckEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BTNKaydet = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTPTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTPTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CBParaBirim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBTutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBKod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CEAktif.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(800, 450);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.gridControl1);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(2, 197);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(796, 251);
            this.panelControl3.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(792, 247);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.BTNKaydet);
            this.panelControl2.Controls.Add(this.DTPTarih);
            this.panelControl2.Controls.Add(this.CBParaBirim);
            this.panelControl2.Controls.Add(this.TBTutar);
            this.panelControl2.Controls.Add(this.TBAdi);
            this.panelControl2.Controls.Add(this.TBKod);
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Controls.Add(this.TBAciklama);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.CEAktif);
            this.panelControl2.Controls.Add(this.label3);
            this.panelControl2.Controls.Add(this.label2);
            this.panelControl2.Controls.Add(this.label1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(2, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(796, 195);
            this.panelControl2.TabIndex = 0;
            // 
            // DTPTarih
            // 
            this.DTPTarih.EditValue = null;
            this.DTPTarih.Location = new System.Drawing.Point(91, 116);
            this.DTPTarih.Name = "DTPTarih";
            this.DTPTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DTPTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DTPTarih.Size = new System.Drawing.Size(135, 20);
            this.DTPTarih.TabIndex = 12;
            // 
            // CBParaBirim
            // 
            this.CBParaBirim.Location = new System.Drawing.Point(91, 83);
            this.CBParaBirim.Name = "CBParaBirim";
            this.CBParaBirim.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CBParaBirim.Size = new System.Drawing.Size(135, 20);
            this.CBParaBirim.TabIndex = 11;
            // 
            // TBTutar
            // 
            this.TBTutar.Location = new System.Drawing.Point(359, 116);
            this.TBTutar.Name = "TBTutar";
            this.TBTutar.Size = new System.Drawing.Size(135, 20);
            this.TBTutar.TabIndex = 10;
            // 
            // TBAdi
            // 
            this.TBAdi.Location = new System.Drawing.Point(91, 52);
            this.TBAdi.Name = "TBAdi";
            this.TBAdi.Size = new System.Drawing.Size(135, 20);
            this.TBAdi.TabIndex = 9;
            // 
            // TBKod
            // 
            this.TBKod.Location = new System.Drawing.Point(91, 17);
            this.TBKod.Name = "TBKod";
            this.TBKod.Size = new System.Drawing.Size(135, 20);
            this.TBKod.TabIndex = 8;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(298, 20);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(41, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Açıklama";
            // 
            // TBAciklama
            // 
            this.TBAciklama.Location = new System.Drawing.Point(359, 5);
            this.TBAciklama.Name = "TBAciklama";
            this.TBAciklama.Size = new System.Drawing.Size(135, 96);
            this.TBAciklama.TabIndex = 6;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(298, 122);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(26, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Tutar";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(61, 119);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Tarih";
            // 
            // CEAktif
            // 
            this.CEAktif.Location = new System.Drawing.Point(394, 142);
            this.CEAktif.Name = "CEAktif";
            this.CEAktif.Properties.Caption = "Aktif";
            this.CEAktif.Size = new System.Drawing.Size(75, 20);
            this.CEAktif.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Parabirimi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kod";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı";
            // 
            // BTNKaydet
            // 
            this.BTNKaydet.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.BTNKaydet.Appearance.Options.UseBackColor = true;
            this.BTNKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.BTNKaydet.Location = new System.Drawing.Point(592, 116);
            this.BTNKaydet.Name = "BTNKaydet";
            this.BTNKaydet.Size = new System.Drawing.Size(146, 46);
            this.BTNKaydet.TabIndex = 63;
            this.BTNKaydet.Text = "&Kaydet";
            this.BTNKaydet.Click += new System.EventHandler(this.BTNKaydet_Click);
            // 
            // FKasaKart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelControl1);
            this.Name = "FKasaKart";
            this.Text = "FKasaKart";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTPTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTPTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CBParaBirim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBTutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBKod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CEAktif.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.MemoEdit TBAciklama;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.CheckEdit CEAktif;
        private Label label3;
        private Label label2;
        private Label label1;
        private DevExpress.XtraEditors.TextEdit TBTutar;
        private DevExpress.XtraEditors.TextEdit TBAdi;
        private DevExpress.XtraEditors.TextEdit TBKod;
        private DevExpress.XtraEditors.DateEdit DTPTarih;
        private DevExpress.XtraEditors.LookUpEdit CBParaBirim;
        private DevExpress.XtraEditors.SimpleButton BTNKaydet;
    }
}