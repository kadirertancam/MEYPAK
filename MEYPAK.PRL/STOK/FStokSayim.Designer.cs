namespace MEYPAK.PRL.STOK
{
    partial class FStokSayim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FStokSayim));
            this.DGStokSayim = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TBAciklama = new DevExpress.XtraEditors.TextEdit();
            this.BTSil = new DevExpress.XtraEditors.SimpleButton();
            this.BTDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.BTKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.LBAciklama = new DevExpress.XtraEditors.LabelControl();
            this.DTSayimTar = new DevExpress.XtraEditors.DateEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.CBDepo = new DevExpress.XtraEditors.LookUpEdit();
            this.LBDepo = new DevExpress.XtraEditors.LabelControl();
            this.LBTarih = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.DGStokSayim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTSayimTar.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTSayimTar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CBDepo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // DGStokSayim
            // 
            this.DGStokSayim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGStokSayim.Location = new System.Drawing.Point(2, 2);
            this.DGStokSayim.MainView = this.gridView1;
            this.DGStokSayim.Name = "DGStokSayim";
            this.DGStokSayim.Size = new System.Drawing.Size(1392, 711);
            this.DGStokSayim.TabIndex = 2;
            this.DGStokSayim.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 303;
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView1.GridControl = this.DGStokSayim;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.DGStokSayim_DoubleClick);
            // 
            // TBAciklama
            // 
            this.TBAciklama.Location = new System.Drawing.Point(143, 84);
            this.TBAciklama.Name = "TBAciklama";
            this.TBAciklama.Size = new System.Drawing.Size(154, 20);
            this.TBAciklama.TabIndex = 101;
            // 
            // BTSil
            // 
            this.BTSil.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.BTSil.Appearance.Options.UseBackColor = true;
            this.BTSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTSil.ImageOptions.Image")));
            this.BTSil.Location = new System.Drawing.Point(203, 4);
            this.BTSil.Name = "BTSil";
            this.BTSil.Size = new System.Drawing.Size(70, 34);
            this.BTSil.TabIndex = 64;
            this.BTSil.Text = "&Sil";
            this.BTSil.Click += new System.EventHandler(this.BTSil_Click);
            // 
            // BTDuzenle
            // 
            this.BTDuzenle.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.BTDuzenle.Appearance.Options.UseBackColor = true;
            this.BTDuzenle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTDuzenle.ImageOptions.Image")));
            this.BTDuzenle.Location = new System.Drawing.Point(395, 33);
            this.BTDuzenle.Name = "BTDuzenle";
            this.BTDuzenle.Size = new System.Drawing.Size(70, 34);
            this.BTDuzenle.TabIndex = 63;
            this.BTDuzenle.Text = "&Düzenle";
            this.BTDuzenle.Click += new System.EventHandler(this.BTDuzenle_Click);
            // 
            // BTKaydet
            // 
            this.BTKaydet.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.BTKaydet.Appearance.Options.UseBackColor = true;
            this.BTKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTKaydet.ImageOptions.Image")));
            this.BTKaydet.Location = new System.Drawing.Point(320, 33);
            this.BTKaydet.Name = "BTKaydet";
            this.BTKaydet.Size = new System.Drawing.Size(70, 34);
            this.BTKaydet.TabIndex = 62;
            this.BTKaydet.Text = "&Kaydet";
            this.BTKaydet.Click += new System.EventHandler(this.BTKaydet_Click);
            // 
            // LBAciklama
            // 
            this.LBAciklama.Location = new System.Drawing.Point(61, 78);
            this.LBAciklama.Name = "LBAciklama";
            this.LBAciklama.Size = new System.Drawing.Size(41, 13);
            this.LBAciklama.TabIndex = 11;
            this.LBAciklama.Text = "Açıklama";
            // 
            // DTSayimTar
            // 
            this.DTSayimTar.EditValue = new System.DateTime(2022, 11, 16, 11, 39, 26, 554);
            this.DTSayimTar.Location = new System.Drawing.Point(115, 27);
            this.DTSayimTar.Name = "DTSayimTar";
            this.DTSayimTar.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DTSayimTar.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DTSayimTar.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.ClassicNew;
            this.DTSayimTar.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.DTSayimTar.Size = new System.Drawing.Size(154, 20);
            this.DTSayimTar.TabIndex = 102;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(926, 583);
            this.panelControl1.TabIndex = 103;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.DGStokSayim);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(2, 119);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(922, 462);
            this.panelControl3.TabIndex = 104;
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.groupControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(2, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(922, 117);
            this.panelControl2.TabIndex = 103;
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.groupControl1.Controls.Add(this.panelControl4);
            this.groupControl1.Controls.Add(this.DTSayimTar);
            this.groupControl1.Controls.Add(this.CBDepo);
            this.groupControl1.Controls.Add(this.TBAciklama);
            this.groupControl1.Controls.Add(this.LBDepo);
            this.groupControl1.Controls.Add(this.LBAciklama);
            this.groupControl1.Controls.Add(this.LBTarih);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1396, 125);
            this.groupControl1.TabIndex = 106;
            this.groupControl1.Text = "Stok Sayım";
            // 
            // panelControl4
            // 
            this.panelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl4.Controls.Add(this.BTSil);
            this.panelControl4.Controls.Add(this.BTDuzenle);
            this.panelControl4.Controls.Add(this.BTKaydet);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl4.Location = new System.Drawing.Point(1091, 33);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(303, 90);
            this.panelControl4.TabIndex = 106;
            // 
            // CBDepo
            // 
            this.CBDepo.Location = new System.Drawing.Point(115, 51);
            this.CBDepo.Name = "CBDepo";
            this.CBDepo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CBDepo.Properties.NullText = "";
            this.CBDepo.Size = new System.Drawing.Size(154, 20);
            this.CBDepo.TabIndex = 105;
            // 
            // LBDepo
            // 
            this.LBDepo.Location = new System.Drawing.Point(75, 54);
            this.LBDepo.Name = "LBDepo";
            this.LBDepo.Size = new System.Drawing.Size(25, 13);
            this.LBDepo.TabIndex = 104;
            this.LBDepo.Text = "Depo";
            // 
            // LBTarih
            // 
            this.LBTarih.Location = new System.Drawing.Point(75, 29);
            this.LBTarih.Name = "LBTarih";
            this.LBTarih.Size = new System.Drawing.Size(24, 13);
            this.LBTarih.TabIndex = 103;
            this.LBTarih.Text = "Tarih";
            // 
            // FStokSayim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 583);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FStokSayim";
            this.Text = "FStokSayim";
            this.Load += new System.EventHandler(this.FStokSayim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGStokSayim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTSayimTar.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTSayimTar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CBDepo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl DGStokSayim;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
      //  private DevExpress.XtraEditors.DateTimeOffsetEdit DTPSayimTarihi;
      ////  private DevExpress.XtraEditors.LabelControl LBSayimTar;
      //  private DevExpress.XtraEditors.DateEdit DTStokSayimTarihi;
      //  private DevExpress.XtraEditors.LabelControl LBStokSayimAciklama;
      //  private DevExpress.XtraEditors.SimpleButton BTStokSayimSil;
      //  private DevExpress.XtraEditors.SimpleButton BTStokSayimDegistir;
      //  private DevExpress.XtraEditors.SimpleButton BTStokSayimKaydet;
       // private DevExpress.XtraEditors.DateEdit DTStokSayimTarih;
        
        private DevExpress.XtraEditors.LabelControl LBAciklama;
        private DevExpress.XtraEditors.SimpleButton BTSil;
        private DevExpress.XtraEditors.SimpleButton BTKaydet;
        private DevExpress.XtraEditors.TextEdit TBAciklama;
        private DevExpress.XtraEditors.SimpleButton BTDuzenle;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.DateEdit DTSayimTar;
        private DevExpress.XtraEditors.LookUpEdit CBDepo;
        private DevExpress.XtraEditors.LabelControl LBDepo;
        private DevExpress.XtraEditors.LabelControl LBTarih;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.PanelControl panelControl4;
    }
}