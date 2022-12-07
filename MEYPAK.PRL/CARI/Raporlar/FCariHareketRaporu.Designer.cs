namespace MEYPAK.PRL.CARI.Raporlar
{
    partial class FCariHareketRaporu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FCariHareketRaporu));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.DGCariHareketRpr = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.BTRaporla = new DevExpress.XtraEditors.SimpleButton();
            this.BTCariSec = new DevExpress.XtraEditors.ButtonEdit();
            this.LBCariKodu = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGCariHareketRpr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BTCariSec.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1398, 818);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.DGCariHareketRpr);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(2, 110);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1394, 706);
            this.panelControl3.TabIndex = 1;
            // 
            // DGCariHareketRpr
            // 
            this.DGCariHareketRpr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGCariHareketRpr.Location = new System.Drawing.Point(2, 2);
            this.DGCariHareketRpr.MainView = this.gridView1;
            this.DGCariHareketRpr.Name = "DGCariHareketRpr";
            this.DGCariHareketRpr.Size = new System.Drawing.Size(1390, 702);
            this.DGCariHareketRpr.TabIndex = 0;
            this.DGCariHareketRpr.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.DGCariHareketRpr;
            this.gridView1.Name = "gridView1";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.groupControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(2, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1394, 108);
            this.panelControl2.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.BTRaporla);
            this.groupControl1.Controls.Add(this.BTCariSec);
            this.groupControl1.Controls.Add(this.LBCariKodu);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl1.Location = new System.Drawing.Point(2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1390, 100);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Cari Hareket Raporu";
            // 
            // BTRaporla
            // 
            this.BTRaporla.Appearance.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTRaporla.Appearance.Options.UseBackColor = true;
            this.BTRaporla.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTRaporla.ImageOptions.Image")));
            this.BTRaporla.Location = new System.Drawing.Point(347, 33);
            this.BTRaporla.Name = "BTRaporla";
            this.BTRaporla.Size = new System.Drawing.Size(95, 40);
            this.BTRaporla.TabIndex = 2;
            this.BTRaporla.Text = "&Raporla";
            // 
            // BTCariSec
            // 
            this.BTCariSec.Location = new System.Drawing.Point(130, 43);
            this.BTCariSec.Name = "BTCariSec";
            this.BTCariSec.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.BTCariSec.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.BTCariSec_Properties_ButtonClick);
            this.BTCariSec.Size = new System.Drawing.Size(180, 20);
            this.BTCariSec.TabIndex = 1;
            // 
            // LBCariKodu
            // 
            this.LBCariKodu.Location = new System.Drawing.Point(63, 46);
            this.LBCariKodu.Name = "LBCariKodu";
            this.LBCariKodu.Size = new System.Drawing.Size(46, 13);
            this.LBCariKodu.TabIndex = 0;
            this.LBCariKodu.Text = "Cari Kodu";
            // 
            // FCariHareketRaporu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 818);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FCariHareketRaporu";
            this.Text = "FCariHareketRaporu";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGCariHareketRpr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BTCariSec.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl LBCariKodu;
        private DevExpress.XtraEditors.ButtonEdit BTCariSec;
        private DevExpress.XtraEditors.SimpleButton BTRaporla;
        private DevExpress.XtraGrid.GridControl DGCariHareketRpr;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}