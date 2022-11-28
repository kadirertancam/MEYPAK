namespace MEYPAK.PRL.STOK
{
    partial class FHizmetKart
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FHizmetKart));
            this.DGHizmetKart = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TBHizmetAdi = new DevExpress.XtraEditors.TextEdit();
            this.BTHizmetSec = new DevExpress.XtraEditors.ButtonEdit();
            this.LBHizmetAdi = new DevExpress.XtraEditors.LabelControl();
            this.LBHizmetKodu = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.DGHizmetKart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBHizmetAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTHizmetSec.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGHizmetKart
            // 
            this.DGHizmetKart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGHizmetKart.Location = new System.Drawing.Point(0, 0);
            this.DGHizmetKart.MainView = this.gridView1;
            this.DGHizmetKart.Name = "DGHizmetKart";
            this.DGHizmetKart.Size = new System.Drawing.Size(1394, 692);
            this.DGHizmetKart.TabIndex = 0;
            this.DGHizmetKart.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 303;
            this.gridView1.GridControl = this.DGHizmetKart;
            this.gridView1.Name = "gridView1";
            // 
            // TBHizmetAdi
            // 
            this.TBHizmetAdi.Location = new System.Drawing.Point(182, 66);
            this.TBHizmetAdi.Name = "TBHizmetAdi";
            this.TBHizmetAdi.Size = new System.Drawing.Size(180, 20);
            this.TBHizmetAdi.TabIndex = 35;
            // 
            // BTHizmetSec
            // 
            this.BTHizmetSec.Location = new System.Drawing.Point(182, 36);
            this.BTHizmetSec.Name = "BTHizmetSec";
            this.BTHizmetSec.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "SEÇ", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.BTHizmetSec.Size = new System.Drawing.Size(180, 22);
            this.BTHizmetSec.TabIndex = 33;
            // 
            // LBHizmetAdi
            // 
            this.LBHizmetAdi.Location = new System.Drawing.Point(101, 69);
            this.LBHizmetAdi.Name = "LBHizmetAdi";
            this.LBHizmetAdi.Size = new System.Drawing.Size(50, 13);
            this.LBHizmetAdi.TabIndex = 9;
            this.LBHizmetAdi.Text = "Hizmet Adı";
            // 
            // LBHizmetKodu
            // 
            this.LBHizmetKodu.Location = new System.Drawing.Point(92, 39);
            this.LBHizmetKodu.Name = "LBHizmetKodu";
            this.LBHizmetKodu.Size = new System.Drawing.Size(59, 13);
            this.LBHizmetKodu.TabIndex = 7;
            this.LBHizmetKodu.Text = "Hizmet Kodu";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1398, 818);
            this.panelControl1.TabIndex = 1;
            // 
            // panelControl3
            // 
            this.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl3.Controls.Add(this.DGHizmetKart);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(2, 124);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1394, 692);
            this.panelControl3.TabIndex = 2;
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.groupControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(2, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1394, 122);
            this.panelControl2.TabIndex = 1;
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.groupControl1.Controls.Add(this.TBHizmetAdi);
            this.groupControl1.Controls.Add(this.LBHizmetKodu);
            this.groupControl1.Controls.Add(this.BTHizmetSec);
            this.groupControl1.Controls.Add(this.LBHizmetAdi);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1394, 113);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Genel Bilgi";
            // 
            // FHizmetKart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 818);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FHizmetKart";
            this.Text = "FHizmetKart";
            ((System.ComponentModel.ISupportInitialize)(this.DGHizmetKart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBHizmetAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTHizmetSec.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl LBHizmetKodu;
        private DevExpress.XtraEditors.LabelControl LBHizmetAdi;
        private DevExpress.XtraEditors.ButtonEdit BTHizmetSec;
        private DevExpress.XtraEditors.TextEdit TBHizmetAdi;
        private DevExpress.XtraGrid.GridControl DGHizmetKart;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}