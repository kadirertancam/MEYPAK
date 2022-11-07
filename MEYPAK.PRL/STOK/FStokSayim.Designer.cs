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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.GCStokSayim = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GBStokSayim = new System.Windows.Forms.GroupBox();
            this.TBAcikla = new DevExpress.XtraEditors.TextEdit();
            this.DTSayimTar = new System.Windows.Forms.DateTimePicker();
            this.BTSil = new DevExpress.XtraEditors.SimpleButton();
            this.BTDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.BTKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.LBAciklama = new DevExpress.XtraEditors.LabelControl();
            this.LBSayimTarihi = new DevExpress.XtraEditors.LabelControl();
            this.DTStokSayimTarih = new DevExpress.XtraEditors.DateEdit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GCStokSayim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.GBStokSayim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TBAcikla.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTStokSayimTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTStokSayimTarih.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(837, 629);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.GCStokSayim);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 91);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(837, 538);
            this.panel3.TabIndex = 3;
            // 
            // GCStokSayim
            // 
            this.GCStokSayim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GCStokSayim.Location = new System.Drawing.Point(0, 0);
            this.GCStokSayim.MainView = this.gridView1;
            this.GCStokSayim.Name = "GCStokSayim";
            this.GCStokSayim.Size = new System.Drawing.Size(837, 538);
            this.GCStokSayim.TabIndex = 2;
            this.GCStokSayim.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.GCStokSayim;
            this.gridView1.Name = "gridView1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.GBStokSayim);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(837, 91);
            this.panel2.TabIndex = 2;
            // 
            // GBStokSayim
            // 
            this.GBStokSayim.Controls.Add(this.TBAcikla);
            this.GBStokSayim.Controls.Add(this.DTSayimTar);
            this.GBStokSayim.Controls.Add(this.BTSil);
            this.GBStokSayim.Controls.Add(this.BTDuzenle);
            this.GBStokSayim.Controls.Add(this.BTKaydet);
            this.GBStokSayim.Controls.Add(this.LBAciklama);
            this.GBStokSayim.Controls.Add(this.LBSayimTarihi);
            this.GBStokSayim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GBStokSayim.Location = new System.Drawing.Point(0, 0);
            this.GBStokSayim.Name = "GBStokSayim";
            this.GBStokSayim.Size = new System.Drawing.Size(837, 91);
            this.GBStokSayim.TabIndex = 0;
            this.GBStokSayim.TabStop = false;
            this.GBStokSayim.Text = "Stok Sayım";
            // 
            // TBAcikla
            // 
            this.TBAcikla.Location = new System.Drawing.Point(353, 38);
            this.TBAcikla.Name = "TBAcikla";
            this.TBAcikla.Size = new System.Drawing.Size(144, 20);
            this.TBAcikla.TabIndex = 99;
            // 
            // DTSayimTar
            // 
            this.DTSayimTar.CalendarFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DTSayimTar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DTSayimTar.Location = new System.Drawing.Point(100, 36);
            this.DTSayimTar.Name = "DTSayimTar";
            this.DTSayimTar.Size = new System.Drawing.Size(180, 21);
            this.DTSayimTar.TabIndex = 78;
            this.DTSayimTar.Value = new System.DateTime(2022, 11, 3, 13, 26, 0, 0);
            // 
            // BTSil
            // 
            this.BTSil.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.BTSil.Appearance.Options.UseBackColor = true;
            this.BTSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTSil.ImageOptions.Image")));
            this.BTSil.Location = new System.Drawing.Point(725, 22);
            this.BTSil.Name = "BTSil";
            this.BTSil.Size = new System.Drawing.Size(94, 52);
            this.BTSil.TabIndex = 64;
            this.BTSil.Text = "Sil";
            this.BTSil.Click += new System.EventHandler(this.BTSil_Click);
            // 
            // BTDuzenle
            // 
            this.BTDuzenle.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.BTDuzenle.Appearance.Options.UseBackColor = true;
            this.BTDuzenle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTDegistir.ImageOptions.Image")));
            this.BTDuzenle.Location = new System.Drawing.Point(625, 22);
            this.BTDuzenle.Name = "BTDuzenle";
            this.BTDuzenle.Size = new System.Drawing.Size(94, 52);
            this.BTDuzenle.TabIndex = 63;
            this.BTDuzenle.Text = "Düzenle";
            this.BTDuzenle.Click += new System.EventHandler(this.BTDuzenle_Click);
            // 
            // BTKaydet
            // 
            this.BTKaydet.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.BTKaydet.Appearance.Options.UseBackColor = true;
            this.BTKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTKaydet.ImageOptions.Image")));
            this.BTKaydet.Location = new System.Drawing.Point(525, 22);
            this.BTKaydet.Name = "BTKaydet";
            this.BTKaydet.Size = new System.Drawing.Size(94, 52);
            this.BTKaydet.TabIndex = 62;
            this.BTKaydet.Text = "Kaydet";
            this.BTKaydet.Click += new System.EventHandler(this.BTKaydet_Click);
            // 
            // LBAciklama
            // 
            this.LBAciklama.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBAciklama.Appearance.Options.UseFont = true;
            this.LBAciklama.Location = new System.Drawing.Point(302, 41);
            this.LBAciklama.Name = "LBAciklama";
            this.LBAciklama.Size = new System.Drawing.Size(45, 13);
            this.LBAciklama.TabIndex = 11;
            this.LBAciklama.Text = "Açıklama";
            // 
            // LBSayimTarihi
            // 
            this.LBSayimTarihi.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBSayimTarihi.Appearance.Options.UseFont = true;
            this.LBSayimTarihi.Location = new System.Drawing.Point(30, 39);
            this.LBSayimTarihi.Name = "LBSayimTarihi";
            this.LBSayimTarihi.Size = new System.Drawing.Size(61, 13);
            this.LBSayimTarihi.TabIndex = 9;
            this.LBSayimTarihi.Text = "Sayım Tarihi";
            // 
            // DTStokSayimTarih
            // 
            this.DTStokSayimTarih.EditValue = new System.DateTime(2022, 11, 2, 12, 14, 48, 0);
            this.DTStokSayimTarih.Location = new System.Drawing.Point(90, 38);
            this.DTStokSayimTarih.Name = "DTStokSayimTarih";
            this.DTStokSayimTarih.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DTStokSayimTarih.Properties.Appearance.Options.UseFont = true;
            this.DTStokSayimTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.SpinDown)});
            this.DTStokSayimTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DTStokSayimTarih.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.ClassicNew;
            this.DTStokSayimTarih.Properties.MaskSettings.Set("mask", "f");
            this.DTStokSayimTarih.Properties.VistaCalendarInitialViewStyle = DevExpress.XtraEditors.VistaCalendarInitialViewStyle.YearsGroupView;
            this.DTStokSayimTarih.Properties.VistaCalendarViewStyle = ((DevExpress.XtraEditors.VistaCalendarViewStyle)(((((DevExpress.XtraEditors.VistaCalendarViewStyle.MonthView | DevExpress.XtraEditors.VistaCalendarViewStyle.YearView) 
            | DevExpress.XtraEditors.VistaCalendarViewStyle.QuarterView) 
            | DevExpress.XtraEditors.VistaCalendarViewStyle.YearsGroupView) 
            | DevExpress.XtraEditors.VistaCalendarViewStyle.CenturyView)));
            this.DTStokSayimTarih.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.DTStokSayimTarih.Size = new System.Drawing.Size(140, 24);
            this.DTStokSayimTarih.TabIndex = 65;
            // 
            // FStokSayim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 629);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FStokSayim";
            this.Text = "FStokSayim";
            this.Load += new System.EventHandler(this.FStokSayim_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GCStokSayim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.GBStokSayim.ResumeLayout(false);
            this.GBStokSayim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TBAcikla.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTStokSayimTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTStokSayimTarih.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private GroupBox GBStokSayim;
        private TextBox TBStokSayimAciklama;
        private DevExpress.XtraGrid.GridControl GCStokSayim;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.DateTimeOffsetEdit DTPSayimTarihi;
        private DevExpress.XtraEditors.LabelControl LBSayimTarihi;
        private DevExpress.XtraEditors.DateEdit DTStokSayimTarihi;
        private DevExpress.XtraEditors.LabelControl LBStokSayimAciklama;
        private DevExpress.XtraEditors.SimpleButton BTStokSayimSil;
        private DevExpress.XtraEditors.SimpleButton BTStokSayimDegistir;
        private DevExpress.XtraEditors.SimpleButton BTStokSayimKaydet;
        private DevExpress.XtraEditors.DateEdit DTStokSayimTarih;
        private TextBox TBAciklama;
        private DevExpress.XtraEditors.LabelControl LBAciklama;
        private DateTimePicker DTSayimTar;
        private DevExpress.XtraEditors.SimpleButton BTDegistir;
        private DevExpress.XtraEditors.SimpleButton BTSil;
        private DevExpress.XtraEditors.SimpleButton BTKaydet;
        private DevExpress.XtraEditors.TextEdit TBAcikla;
        private DevExpress.XtraEditors.SimpleButton BTDuzenle;
    }
}