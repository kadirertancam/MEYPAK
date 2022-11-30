namespace MEYPAK.PRL.STOK
{
    partial class FKategoriList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FKategoriList));
            this.BTAltEkle = new DevExpress.XtraEditors.SimpleButton();
            this.BTYeniEkle = new DevExpress.XtraEditors.SimpleButton();
            this.TBKategoriAdi = new DevExpress.XtraEditors.TextEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.treeView = new DevExpress.XtraTreeList.TreeList();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.BTSec = new DevExpress.XtraEditors.SimpleButton();
            this.BtnKategoriSil = new DevExpress.XtraEditors.SimpleButton();
            this.LBAdi = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.TBKategoriAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTAltEkle
            // 
            this.BTAltEkle.Appearance.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTAltEkle.Appearance.Options.UseBackColor = true;
            this.BTAltEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTAltEkle.ImageOptions.Image")));
            this.BTAltEkle.Location = new System.Drawing.Point(247, 12);
            this.BTAltEkle.Name = "BTAltEkle";
            this.BTAltEkle.Size = new System.Drawing.Size(108, 40);
            this.BTAltEkle.TabIndex = 81;
            this.BTAltEkle.Text = "Alt Kategori";
            this.BTAltEkle.Click += new System.EventHandler(this.BTAltKateEkle_Click);
            // 
            // BTYeniEkle
            // 
            this.BTYeniEkle.Appearance.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTYeniEkle.Appearance.Options.UseBackColor = true;
            this.BTYeniEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTYeniEkle.ImageOptions.Image")));
            this.BTYeniEkle.Location = new System.Drawing.Point(133, 12);
            this.BTYeniEkle.Name = "BTYeniEkle";
            this.BTYeniEkle.Size = new System.Drawing.Size(108, 40);
            this.BTYeniEkle.TabIndex = 80;
            this.BTYeniEkle.Text = "Yeni Kategori";
            this.BTYeniEkle.Click += new System.EventHandler(this.BTYeniEkle_Click);
            // 
            // TBKategoriAdi
            // 
            this.TBKategoriAdi.Location = new System.Drawing.Point(170, 48);
            this.TBKategoriAdi.Name = "TBKategoriAdi";
            this.TBKategoriAdi.Size = new System.Drawing.Size(180, 20);
            this.TBKategoriAdi.TabIndex = 79;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1398, 818);
            this.panelControl1.TabIndex = 2;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.treeView);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(2, 109);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1394, 707);
            this.panelControl3.TabIndex = 4;
            // 
            // treeView
            // 
            this.treeView.Appearance.FocusedCell.BackColor = System.Drawing.Color.LightSteelBlue;
            this.treeView.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.Green;
            this.treeView.Appearance.FocusedCell.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.treeView.Appearance.FocusedCell.Options.UseBackColor = true;
            this.treeView.Appearance.FocusedRow.BackColor = System.Drawing.Color.LightSteelBlue;
            this.treeView.Appearance.FocusedRow.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.Location = new System.Drawing.Point(2, 2);
            this.treeView.Name = "treeView";
            this.treeView.OptionsBehavior.Editable = false;
            this.treeView.OptionsView.ShowFirstLines = false;
            this.treeView.OptionsView.ShowHorzLines = false;
            this.treeView.OptionsView.ShowTreeLines = DevExpress.Utils.DefaultBoolean.False;
            this.treeView.OptionsView.ShowVertLines = false;
            this.treeView.OptionsView.TreeLineStyle = DevExpress.XtraTreeList.LineStyle.None;
            this.treeView.ParentFieldName = "USTID";
            this.treeView.SelectImageList = this.ımageList1;
            this.treeView.ShowButtonMode = DevExpress.XtraTreeList.ShowButtonModeEnum.ShowForFocusedRow;
            this.treeView.Size = new System.Drawing.Size(1390, 703);
            this.treeView.TabIndex = 0;
            this.treeView.CustomDrawNodeButton += new DevExpress.XtraTreeList.CustomDrawNodeButtonEventHandler(this.treeView_CustomDrawNodeButton);
            this.treeView.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.treeView_KeyPress);
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "yeni klasör.png");
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.groupControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(2, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1394, 107);
            this.panelControl2.TabIndex = 3;
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.groupControl1.Controls.Add(this.panelControl4);
            this.groupControl1.Controls.Add(this.LBAdi);
            this.groupControl1.Controls.Add(this.TBKategoriAdi);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl1.Location = new System.Drawing.Point(2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1390, 98);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Kategori Tanım";
            // 
            // panelControl4
            // 
            this.panelControl4.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panelControl4.Appearance.Options.UseBackColor = true;
            this.panelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl4.Controls.Add(this.BTSec);
            this.panelControl4.Controls.Add(this.BtnKategoriSil);
            this.panelControl4.Controls.Add(this.BTYeniEkle);
            this.panelControl4.Controls.Add(this.BTAltEkle);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl4.Location = new System.Drawing.Point(901, 33);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(487, 63);
            this.panelControl4.TabIndex = 84;
            // 
            // BTSec
            // 
            this.BTSec.Appearance.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTSec.Appearance.Options.UseBackColor = true;
            this.BTSec.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BTSec.ImageOptions.SvgImage")));
            this.BTSec.Location = new System.Drawing.Point(16, 12);
            this.BTSec.Name = "BTSec";
            this.BTSec.Size = new System.Drawing.Size(108, 40);
            this.BTSec.TabIndex = 84;
            this.BTSec.Text = "Seç";
            this.BTSec.Click += new System.EventHandler(this.BTSec_Click);
            // 
            // BtnKategoriSil
            // 
            this.BtnKategoriSil.Appearance.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BtnKategoriSil.Appearance.Options.UseBackColor = true;
            this.BtnKategoriSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKategoriSil.ImageOptions.Image")));
            this.BtnKategoriSil.Location = new System.Drawing.Point(361, 12);
            this.BtnKategoriSil.Name = "BtnKategoriSil";
            this.BtnKategoriSil.Size = new System.Drawing.Size(108, 40);
            this.BtnKategoriSil.TabIndex = 83;
            this.BtnKategoriSil.Text = "Sil";
            this.BtnKategoriSil.Click += new System.EventHandler(this.BtnKategoriSil_Click);
            // 
            // LBAdi
            // 
            this.LBAdi.Appearance.Options.UseFont = true;
            this.LBAdi.Location = new System.Drawing.Point(93, 51);
            this.LBAdi.Name = "LBAdi";
            this.LBAdi.Size = new System.Drawing.Size(58, 13);
            this.LBAdi.TabIndex = 82;
            this.LBAdi.Text = "Kategori Adı";
            // 
            // FKategoriList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 818);
            this.Controls.Add(this.panelControl1);
            this.Name = "FKategoriList";
            this.Text = "FKategoriList";
            this.Load += new System.EventHandler(this.FKategoriList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TBKategoriAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit TBKategoriAdi;
        private DevExpress.XtraEditors.SimpleButton BTAltEkle;
        private DevExpress.XtraEditors.SimpleButton BTYeniEkle;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl LBAdi;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton BtnKategoriSil;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private ImageList ımageList1;
        private DevExpress.XtraTreeList.TreeList treeView;
        private DevExpress.XtraEditors.SimpleButton BTSec;
    }
}