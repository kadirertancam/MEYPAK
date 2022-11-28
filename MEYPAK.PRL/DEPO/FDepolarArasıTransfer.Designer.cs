namespace MEYPAK.PRL.DEPO
{
    partial class FDepolarArasıTransfer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FDepolarArasıTransfer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.GCDepolarArasiTransfer = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.BTDepolarArasiTransferKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.BTDepoKartSil = new DevExpress.XtraEditors.SimpleButton();
            this.BTHedefDepoSec = new DevExpress.XtraEditors.SimpleButton();
            this.TBHedefDepo = new DevExpress.XtraEditors.TextEdit();
            this.BTCikisDepoSec = new DevExpress.XtraEditors.SimpleButton();
            this.TBCikisDepo = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.LBTransferCikisDepo = new DevExpress.XtraEditors.LabelControl();
            this.LBTransferHedefDepo = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GCDepolarArasiTransfer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TBHedefDepo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBCikisDepo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelControl2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1398, 818);
            this.panel1.TabIndex = 1;
            // 
            // GCDepolarArasiTransfer
            // 
            this.GCDepolarArasiTransfer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GCDepolarArasiTransfer.Location = new System.Drawing.Point(2, 2);
            this.GCDepolarArasiTransfer.MainView = this.gridView1;
            this.GCDepolarArasiTransfer.Name = "GCDepolarArasiTransfer";
            this.GCDepolarArasiTransfer.Size = new System.Drawing.Size(1394, 715);
            this.GCDepolarArasiTransfer.TabIndex = 3;
            this.GCDepolarArasiTransfer.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 303;
            this.gridView1.GridControl = this.GCDepolarArasiTransfer;
            this.gridView1.Name = "gridView1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1398, 99);
            this.panel2.TabIndex = 2;
            // 
            // groupControl1
            // 
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.groupControl1.Controls.Add(this.panelControl1);
            this.groupControl1.Controls.Add(this.BTHedefDepoSec);
            this.groupControl1.Controls.Add(this.TBHedefDepo);
            this.groupControl1.Controls.Add(this.BTCikisDepoSec);
            this.groupControl1.Controls.Add(this.TBCikisDepo);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.LBTransferCikisDepo);
            this.groupControl1.Controls.Add(this.LBTransferHedefDepo);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1398, 94);
            this.groupControl1.TabIndex = 11;
            this.groupControl1.Text = "Depolar Arası Transfer";
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.BTDepolarArasiTransferKaydet);
            this.panelControl1.Controls.Add(this.BTDepoKartSil);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl1.Location = new System.Drawing.Point(1179, 33);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(217, 59);
            this.panelControl1.TabIndex = 67;
            // 
            // BTDepolarArasiTransferKaydet
            // 
            this.BTDepolarArasiTransferKaydet.Appearance.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTDepolarArasiTransferKaydet.Appearance.Options.UseBackColor = true;
            this.BTDepolarArasiTransferKaydet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTDepolarArasiTransferKaydet.BackgroundImage")));
            this.BTDepolarArasiTransferKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTDepolarArasiTransferKaydet.ImageOptions.Image")));
            this.BTDepolarArasiTransferKaydet.Location = new System.Drawing.Point(5, 6);
            this.BTDepolarArasiTransferKaydet.Name = "BTDepolarArasiTransferKaydet";
            this.BTDepolarArasiTransferKaydet.Size = new System.Drawing.Size(95, 40);
            this.BTDepolarArasiTransferKaydet.TabIndex = 60;
            this.BTDepolarArasiTransferKaydet.Text = "&KAYDET";
            // 
            // BTDepoKartSil
            // 
            this.BTDepoKartSil.Appearance.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTDepoKartSil.Appearance.Options.UseBackColor = true;
            this.BTDepoKartSil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTDepoKartSil.BackgroundImage")));
            this.BTDepoKartSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTDepoKartSil.ImageOptions.Image")));
            this.BTDepoKartSil.Location = new System.Drawing.Point(106, 5);
            this.BTDepoKartSil.Name = "BTDepoKartSil";
            this.BTDepoKartSil.Size = new System.Drawing.Size(95, 40);
            this.BTDepoKartSil.TabIndex = 61;
            this.BTDepoKartSil.Text = "&Sil";
            // 
            // BTHedefDepoSec
            // 
            this.BTHedefDepoSec.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.BTHedefDepoSec.Appearance.BackColor2 = System.Drawing.Color.Black;
            this.BTHedefDepoSec.Appearance.BorderColor = System.Drawing.Color.Black;
            this.BTHedefDepoSec.Appearance.ForeColor = System.Drawing.Color.Black;
            this.BTHedefDepoSec.Appearance.Options.UseBackColor = true;
            this.BTHedefDepoSec.Appearance.Options.UseBorderColor = true;
            this.BTHedefDepoSec.Appearance.Options.UseFont = true;
            this.BTHedefDepoSec.Appearance.Options.UseForeColor = true;
            this.BTHedefDepoSec.AppearanceDisabled.BorderColor = System.Drawing.Color.Black;
            this.BTHedefDepoSec.AppearanceDisabled.Options.UseBorderColor = true;
            this.BTHedefDepoSec.AppearanceHovered.BorderColor = System.Drawing.Color.Black;
            this.BTHedefDepoSec.AppearanceHovered.Options.UseBorderColor = true;
            this.BTHedefDepoSec.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTHedefDepoSec.ImageOptions.Image")));
            this.BTHedefDepoSec.Location = new System.Drawing.Point(568, 42);
            this.BTHedefDepoSec.Name = "BTHedefDepoSec";
            this.BTHedefDepoSec.Size = new System.Drawing.Size(51, 23);
            this.BTHedefDepoSec.TabIndex = 66;
            this.BTHedefDepoSec.Text = "Seç";
            // 
            // TBHedefDepo
            // 
            this.TBHedefDepo.Location = new System.Drawing.Point(455, 44);
            this.TBHedefDepo.Name = "TBHedefDepo";
            this.TBHedefDepo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TBHedefDepo.Properties.Appearance.Options.UseFont = true;
            this.TBHedefDepo.Size = new System.Drawing.Size(164, 20);
            this.TBHedefDepo.TabIndex = 65;
            // 
            // BTCikisDepoSec
            // 
            this.BTCikisDepoSec.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.BTCikisDepoSec.Appearance.BackColor2 = System.Drawing.Color.Black;
            this.BTCikisDepoSec.Appearance.BorderColor = System.Drawing.Color.Black;
            this.BTCikisDepoSec.Appearance.ForeColor = System.Drawing.Color.Black;
            this.BTCikisDepoSec.Appearance.Options.UseBackColor = true;
            this.BTCikisDepoSec.Appearance.Options.UseBorderColor = true;
            this.BTCikisDepoSec.Appearance.Options.UseFont = true;
            this.BTCikisDepoSec.Appearance.Options.UseForeColor = true;
            this.BTCikisDepoSec.AppearanceDisabled.BorderColor = System.Drawing.Color.Black;
            this.BTCikisDepoSec.AppearanceDisabled.Options.UseBorderColor = true;
            this.BTCikisDepoSec.AppearanceHovered.BorderColor = System.Drawing.Color.Black;
            this.BTCikisDepoSec.AppearanceHovered.Options.UseBorderColor = true;
            this.BTCikisDepoSec.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTCikisDepoSec.ImageOptions.Image")));
            this.BTCikisDepoSec.Location = new System.Drawing.Point(255, 42);
            this.BTCikisDepoSec.Name = "BTCikisDepoSec";
            this.BTCikisDepoSec.Size = new System.Drawing.Size(51, 23);
            this.BTCikisDepoSec.TabIndex = 64;
            this.BTCikisDepoSec.Text = "Seç";
            // 
            // TBCikisDepo
            // 
            this.TBCikisDepo.Location = new System.Drawing.Point(142, 44);
            this.TBCikisDepo.Name = "TBCikisDepo";
            this.TBCikisDepo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TBCikisDepo.Properties.Appearance.Options.UseFont = true;
            this.TBCikisDepo.Size = new System.Drawing.Size(164, 20);
            this.TBCikisDepo.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-73, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Hedef Depo";
            // 
            // LBTransferCikisDepo
            // 
            this.LBTransferCikisDepo.Location = new System.Drawing.Point(70, 47);
            this.LBTransferCikisDepo.Name = "LBTransferCikisDepo";
            this.LBTransferCikisDepo.Size = new System.Drawing.Size(49, 13);
            this.LBTransferCikisDepo.TabIndex = 11;
            this.LBTransferCikisDepo.Text = "Çıkış Depo";
            // 
            // LBTransferHedefDepo
            // 
            this.LBTransferHedefDepo.Location = new System.Drawing.Point(383, 47);
            this.LBTransferHedefDepo.Name = "LBTransferHedefDepo";
            this.LBTransferHedefDepo.Size = new System.Drawing.Size(57, 13);
            this.LBTransferHedefDepo.TabIndex = 57;
            this.LBTransferHedefDepo.Text = "Hedef Depo";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.GCDepolarArasiTransfer);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 99);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1398, 719);
            this.panelControl2.TabIndex = 4;
            // 
            // FDepolarArasıTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 818);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FDepolarArasıTransfer";
            this.Text = "FDepolarArasıTransfer";
            this.Load += new System.EventHandler(this.FDepolarArasıTransfer_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GCDepolarArasiTransfer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TBHedefDepo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBCikisDepo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl LBTransferCikisDepo;
        private DevExpress.XtraEditors.LabelControl LBTransferHedefDepo;
        private DevExpress.XtraEditors.SimpleButton BTDepoKartSil;
        private DevExpress.XtraEditors.SimpleButton BTDepolarArasiTransferKaydet;
        private DevExpress.XtraGrid.GridControl GCDepolarArasiTransfer;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton BTCikisDepoSec;
        private DevExpress.XtraEditors.TextEdit TBCikisDepo;
        private DevExpress.XtraEditors.SimpleButton BTHedefDepoSec;
        private DevExpress.XtraEditors.TextEdit TBHedefDepo;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
    }
}