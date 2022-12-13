namespace MEYPAK.PRL.DEPO.Raporlar
{
    partial class FDepoRaporu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FDepoRaporu));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.DGDepoRpr = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.CBAktif = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.BTRaporla = new DevExpress.XtraEditors.SimpleButton();
            this.BTDepoSec = new DevExpress.XtraEditors.ButtonEdit();
            this.LBAktif = new DevExpress.XtraEditors.LabelControl();
            this.LBDepoKodu = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGDepoRpr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CBAktif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BTDepoSec.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1325, 748);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.DGDepoRpr);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(2, 128);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1321, 618);
            this.panelControl3.TabIndex = 1;
            // 
            // DGDepoRpr
            // 
            this.DGDepoRpr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGDepoRpr.Location = new System.Drawing.Point(2, 2);
            this.DGDepoRpr.MainView = this.gridView1;
            this.DGDepoRpr.Name = "DGDepoRpr";
            this.DGDepoRpr.Size = new System.Drawing.Size(1317, 614);
            this.DGDepoRpr.TabIndex = 0;
            this.DGDepoRpr.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.DGDepoRpr;
            this.gridView1.Name = "gridView1";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.groupControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(2, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1321, 126);
            this.panelControl2.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.groupControl1.Controls.Add(this.CBAktif);
            this.groupControl1.Controls.Add(this.panelControl4);
            this.groupControl1.Controls.Add(this.BTDepoSec);
            this.groupControl1.Controls.Add(this.LBAktif);
            this.groupControl1.Controls.Add(this.LBDepoKodu);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl1.Location = new System.Drawing.Point(2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1317, 119);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Filtrele";
            // 
            // CBAktif
            // 
            this.CBAktif.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.CBAktif.Appearance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CBAktif.Appearance.Options.UseBackColor = true;
            this.CBAktif.Appearance.Options.UseFont = true;
            this.CBAktif.Appearance.Options.UseForeColor = true;
            this.CBAktif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CBAktif.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.CBAktif.CheckOnClick = true;
            this.CBAktif.IncrementalSearch = true;
            this.CBAktif.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(true, "Aktif")});
            this.CBAktif.Location = new System.Drawing.Point(155, 68);
            this.CBAktif.Name = "CBAktif";
            this.CBAktif.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.CBAktif.Size = new System.Drawing.Size(81, 27);
            this.CBAktif.TabIndex = 59;
            // 
            // panelControl4
            // 
            this.panelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl4.Controls.Add(this.BTRaporla);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl4.Location = new System.Drawing.Point(1212, 23);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(103, 94);
            this.panelControl4.TabIndex = 4;
            // 
            // BTRaporla
            // 
            this.BTRaporla.Appearance.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTRaporla.Appearance.Options.UseBackColor = true;
            this.BTRaporla.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTRaporla.ImageOptions.Image")));
            this.BTRaporla.Location = new System.Drawing.Point(3, 4);
            this.BTRaporla.Name = "BTRaporla";
            this.BTRaporla.Size = new System.Drawing.Size(95, 40);
            this.BTRaporla.TabIndex = 5;
            this.BTRaporla.Text = "&Raporla";
            // 
            // BTDepoSec
            // 
            this.BTDepoSec.Location = new System.Drawing.Point(155, 36);
            this.BTDepoSec.Name = "BTDepoSec";
            this.BTDepoSec.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Seç", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.BTDepoSec.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.BTDepoSec_Properties_ButtonClick);
            this.BTDepoSec.Size = new System.Drawing.Size(180, 22);
            this.BTDepoSec.TabIndex = 2;
            // 
            // LBAktif
            // 
            this.LBAktif.Location = new System.Drawing.Point(94, 68);
            this.LBAktif.Name = "LBAktif";
            this.LBAktif.Size = new System.Drawing.Size(37, 13);
            this.LBAktif.TabIndex = 1;
            this.LBAktif.Text = "Durumu";
            // 
            // LBDepoKodu
            // 
            this.LBDepoKodu.Location = new System.Drawing.Point(79, 39);
            this.LBDepoKodu.Name = "LBDepoKodu";
            this.LBDepoKodu.Size = new System.Drawing.Size(52, 13);
            this.LBDepoKodu.TabIndex = 0;
            this.LBDepoKodu.Text = "Depo Kodu";
            // 
            // FDepoRaporu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 748);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FDepoRaporu";
            this.Text = "FDepoRaporu";
            this.Load += new System.EventHandler(this.FDepoRaporu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGDepoRpr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CBAktif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BTDepoSec.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl LBAktif;
        private DevExpress.XtraEditors.LabelControl LBDepoKodu;
        private DevExpress.XtraEditors.ButtonEdit BTDepoSec;
        private DevExpress.XtraEditors.SimpleButton BTRaporla;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraGrid.GridControl DGDepoRpr;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.CheckedListBoxControl CBAktif;
    }
}