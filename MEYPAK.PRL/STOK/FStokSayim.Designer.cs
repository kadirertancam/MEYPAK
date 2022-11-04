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
            this.DTStokSayimTarih = new DevExpress.XtraEditors.DateEdit();
            this.BTStokSayimSil = new DevExpress.XtraEditors.SimpleButton();
            this.BTStokSayimDegistir = new DevExpress.XtraEditors.SimpleButton();
            this.BTStokSayimKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.LBStokSayimAciklama = new DevExpress.XtraEditors.LabelControl();
            this.LBSayimTarihi = new DevExpress.XtraEditors.LabelControl();
            this.TBStokSayimAciklama = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GCStokSayim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.GBStokSayim.SuspendLayout();
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
            this.GBStokSayim.Controls.Add(this.DTStokSayimTarih);
            this.GBStokSayim.Controls.Add(this.BTStokSayimSil);
            this.GBStokSayim.Controls.Add(this.BTStokSayimDegistir);
            this.GBStokSayim.Controls.Add(this.BTStokSayimKaydet);
            this.GBStokSayim.Controls.Add(this.LBStokSayimAciklama);
            this.GBStokSayim.Controls.Add(this.LBSayimTarihi);
            this.GBStokSayim.Controls.Add(this.TBStokSayimAciklama);
            this.GBStokSayim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GBStokSayim.Location = new System.Drawing.Point(0, 0);
            this.GBStokSayim.Name = "GBStokSayim";
            this.GBStokSayim.Size = new System.Drawing.Size(837, 91);
            this.GBStokSayim.TabIndex = 0;
            this.GBStokSayim.TabStop = false;
            this.GBStokSayim.Text = "Stok Sayım";
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
            // BTStokSayimSil
            // 
            this.BTStokSayimSil.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.BTStokSayimSil.Appearance.Options.UseBackColor = true;
            this.BTStokSayimSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTStokSayimSil.ImageOptions.Image")));
            this.BTStokSayimSil.Location = new System.Drawing.Point(697, 22);
            this.BTStokSayimSil.Name = "BTStokSayimSil";
            this.BTStokSayimSil.Size = new System.Drawing.Size(94, 52);
            this.BTStokSayimSil.TabIndex = 64;
            this.BTStokSayimSil.Text = "Sil";
            // 
            // BTStokSayimDegistir
            // 
            this.BTStokSayimDegistir.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.BTStokSayimDegistir.Appearance.Options.UseBackColor = true;
            this.BTStokSayimDegistir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTStokSayimDegistir.ImageOptions.Image")));
            this.BTStokSayimDegistir.Location = new System.Drawing.Point(597, 22);
            this.BTStokSayimDegistir.Name = "BTStokSayimDegistir";
            this.BTStokSayimDegistir.Size = new System.Drawing.Size(94, 52);
            this.BTStokSayimDegistir.TabIndex = 63;
            this.BTStokSayimDegistir.Text = "Değiştir";
            // 
            // BTStokSayimKaydet
            // 
            this.BTStokSayimKaydet.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.BTStokSayimKaydet.Appearance.Options.UseBackColor = true;
            this.BTStokSayimKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTStokSayimKaydet.ImageOptions.Image")));
            this.BTStokSayimKaydet.Location = new System.Drawing.Point(497, 22);
            this.BTStokSayimKaydet.Name = "BTStokSayimKaydet";
            this.BTStokSayimKaydet.Size = new System.Drawing.Size(94, 52);
            this.BTStokSayimKaydet.TabIndex = 62;
            this.BTStokSayimKaydet.Text = "Kaydet";
            this.BTStokSayimKaydet.Click += new System.EventHandler(this.BTStokSayimKaydet_Click);
            // 
            // LBStokSayimAciklama
            // 
            this.LBStokSayimAciklama.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBStokSayimAciklama.Appearance.Options.UseFont = true;
            this.LBStokSayimAciklama.Location = new System.Drawing.Point(248, 43);
            this.LBStokSayimAciklama.Name = "LBStokSayimAciklama";
            this.LBStokSayimAciklama.Size = new System.Drawing.Size(46, 14);
            this.LBStokSayimAciklama.TabIndex = 11;
            this.LBStokSayimAciklama.Text = "Açıklama";
            // 
            // LBSayimTarihi
            // 
            this.LBSayimTarihi.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBSayimTarihi.Appearance.Options.UseFont = true;
            this.LBSayimTarihi.Location = new System.Drawing.Point(20, 43);
            this.LBSayimTarihi.Name = "LBSayimTarihi";
            this.LBSayimTarihi.Size = new System.Drawing.Size(64, 14);
            this.LBSayimTarihi.TabIndex = 9;
            this.LBSayimTarihi.Text = "Sayım Tarihi";
            // 
            // TBStokSayimAciklama
            // 
            this.TBStokSayimAciklama.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TBStokSayimAciklama.Location = new System.Drawing.Point(300, 38);
            this.TBStokSayimAciklama.Multiline = true;
            this.TBStokSayimAciklama.Name = "TBStokSayimAciklama";
            this.TBStokSayimAciklama.Size = new System.Drawing.Size(140, 24);
            this.TBStokSayimAciklama.TabIndex = 3;
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
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.SimpleButton BTStokSayimSil;
        private DevExpress.XtraEditors.SimpleButton BTStokSayimDegistir;
        private DevExpress.XtraEditors.SimpleButton BTStokSayimKaydet;
        private DevExpress.XtraEditors.DateEdit DTStokSayimTarih;
    }
}