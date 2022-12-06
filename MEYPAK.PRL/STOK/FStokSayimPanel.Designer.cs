namespace MEYPAK.PRL.STOK
{
    partial class FStokSayimPanel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FStokSayimPanel));
            this.LBDepo = new DevExpress.XtraEditors.LabelControl();
            this.LBTarih = new DevExpress.XtraEditors.LabelControl();
            this.BTKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.DGStokSayim = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BTCik = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl5 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.TBDepo = new DevExpress.XtraEditors.TextEdit();
            this.DTPSayimTar = new DevExpress.XtraEditors.DateEdit();
            this.TBAciklama = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.LBSayim = new DevExpress.XtraEditors.LabelControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exceleAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pdfeAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DGStokSayim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).BeginInit();
            this.panelControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TBDepo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTPSayimTar.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTPSayimTar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBAciklama.Properties)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBDepo
            // 
            this.LBDepo.Location = new System.Drawing.Point(317, 44);
            this.LBDepo.Name = "LBDepo";
            this.LBDepo.Size = new System.Drawing.Size(25, 13);
            this.LBDepo.TabIndex = 11;
            this.LBDepo.Text = "Depo";
            // 
            // LBTarih
            // 
            this.LBTarih.Location = new System.Drawing.Point(69, 44);
            this.LBTarih.Name = "LBTarih";
            this.LBTarih.Size = new System.Drawing.Size(24, 13);
            this.LBTarih.TabIndex = 10;
            this.LBTarih.Text = "Tarih";
            // 
            // BTKaydet
            // 
            this.BTKaydet.Appearance.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTKaydet.Appearance.Options.UseBackColor = true;
            this.BTKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTKaydet.ImageOptions.Image")));
            this.BTKaydet.Location = new System.Drawing.Point(52, 5);
            this.BTKaydet.Name = "BTKaydet";
            this.BTKaydet.Size = new System.Drawing.Size(95, 40);
            this.BTKaydet.TabIndex = 79;
            this.BTKaydet.Text = "&KAYDET";
            this.BTKaydet.Click += new System.EventHandler(this.BTKaydet_Click);
            // 
            // DGStokSayim
            // 
            this.DGStokSayim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGStokSayim.Location = new System.Drawing.Point(2, 2);
            this.DGStokSayim.MainView = this.gridView1;
            this.DGStokSayim.Name = "DGStokSayim";
            this.DGStokSayim.Size = new System.Drawing.Size(1394, 655);
            this.DGStokSayim.TabIndex = 11;
            this.DGStokSayim.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 303;
            this.gridView1.GridControl = this.DGStokSayim;
            this.gridView1.Name = "gridView1";
            // 
            // BTCik
            // 
            this.BTCik.Appearance.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTCik.Appearance.Options.UseBackColor = true;
            this.BTCik.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTCik.ImageOptions.Image")));
            this.BTCik.Location = new System.Drawing.Point(153, 5);
            this.BTCik.Name = "BTCik";
            this.BTCik.Size = new System.Drawing.Size(95, 40);
            this.BTCik.TabIndex = 80;
            this.BTCik.Text = "Çık";
            this.BTCik.Click += new System.EventHandler(this.BTCik_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.panelControl4);
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1398, 818);
            this.panelControl1.TabIndex = 81;
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.DGStokSayim);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl4.Location = new System.Drawing.Point(0, 100);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(1398, 659);
            this.panelControl4.TabIndex = 83;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.panelControl5);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl3.Location = new System.Drawing.Point(0, 759);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1398, 59);
            this.panelControl3.TabIndex = 82;
            // 
            // panelControl5
            // 
            this.panelControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl5.Controls.Add(this.BTCik);
            this.panelControl5.Controls.Add(this.BTKaydet);
            this.panelControl5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl5.Location = new System.Drawing.Point(1119, 2);
            this.panelControl5.Name = "panelControl5";
            this.panelControl5.Size = new System.Drawing.Size(277, 55);
            this.panelControl5.TabIndex = 84;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.groupControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1398, 100);
            this.panelControl2.TabIndex = 81;
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.groupControl1.Controls.Add(this.TBDepo);
            this.groupControl1.Controls.Add(this.DTPSayimTar);
            this.groupControl1.Controls.Add(this.TBAciklama);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.LBTarih);
            this.groupControl1.Controls.Add(this.LBSayim);
            this.groupControl1.Controls.Add(this.LBDepo);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl1.Location = new System.Drawing.Point(2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1394, 93);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Sayım Bilgi";
            // 
            // TBDepo
            // 
            this.TBDepo.Enabled = false;
            this.TBDepo.Location = new System.Drawing.Point(360, 41);
            this.TBDepo.Name = "TBDepo";
            this.TBDepo.Size = new System.Drawing.Size(154, 20);
            this.TBDepo.TabIndex = 88;
            // 
            // DTPSayimTar
            // 
            this.DTPSayimTar.EditValue = null;
            this.DTPSayimTar.Enabled = false;
            this.DTPSayimTar.Location = new System.Drawing.Point(112, 41);
            this.DTPSayimTar.Name = "DTPSayimTar";
            this.DTPSayimTar.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DTPSayimTar.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DTPSayimTar.Size = new System.Drawing.Size(154, 20);
            this.DTPSayimTar.TabIndex = 87;
            // 
            // TBAciklama
            // 
            this.TBAciklama.Enabled = false;
            this.TBAciklama.Location = new System.Drawing.Point(633, 41);
            this.TBAciklama.Name = "TBAciklama";
            this.TBAciklama.Size = new System.Drawing.Size(154, 20);
            this.TBAciklama.TabIndex = 86;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(576, 44);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(41, 13);
            this.labelControl1.TabIndex = 85;
            this.labelControl1.Text = "Açıklama";
            // 
            // LBSayim
            // 
            this.LBSayim.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBSayim.Appearance.Options.UseFont = true;
            this.LBSayim.Location = new System.Drawing.Point(375, 36);
            this.LBSayim.Name = "LBSayim";
            this.LBSayim.Size = new System.Drawing.Size(0, 18);
            this.LBSayim.TabIndex = 84;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exceleAktarToolStripMenuItem,
            this.pdfeAktarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(142, 48);
            // 
            // exceleAktarToolStripMenuItem
            // 
            this.exceleAktarToolStripMenuItem.Name = "exceleAktarToolStripMenuItem";
            this.exceleAktarToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.exceleAktarToolStripMenuItem.Text = "Excel\'e Aktar";
            this.exceleAktarToolStripMenuItem.Click += new System.EventHandler(this.exceleAktarToolStripMenuItem_Click);
            // 
            // pdfeAktarToolStripMenuItem
            // 
            this.pdfeAktarToolStripMenuItem.Name = "pdfeAktarToolStripMenuItem";
            this.pdfeAktarToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.pdfeAktarToolStripMenuItem.Text = "Pdf\'e Aktar";
            this.pdfeAktarToolStripMenuItem.Click += new System.EventHandler(this.pdfeAktarToolStripMenuItem_Click);
            // 
            // FStokSayimPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 818);
            this.Controls.Add(this.panelControl1);
            this.Name = "FStokSayimPanel";
            this.Text = "FStokSayimPanel";
            this.Load += new System.EventHandler(this.FStokSayimPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGStokSayim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).EndInit();
            this.panelControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TBDepo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTPSayimTar.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTPSayimTar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBAciklama.Properties)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl LBTarih;
        private DevExpress.XtraEditors.LabelControl LBDepo;
        private DevExpress.XtraEditors.SimpleButton BTCik;
        private DevExpress.XtraGrid.GridControl DGStokSayim;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton BTKaydet;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl LBSayim;
        private DevExpress.XtraEditors.TextEdit TBAciklama;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit DTPSayimTar;
        private DevExpress.XtraEditors.TextEdit TBDepo;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem exceleAktarToolStripMenuItem;
        private ToolStripMenuItem pdfeAktarToolStripMenuItem;
        private DevExpress.XtraEditors.PanelControl panelControl5;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl4;
    }
}