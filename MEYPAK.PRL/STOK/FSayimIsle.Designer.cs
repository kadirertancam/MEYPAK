﻿namespace MEYPAK.PRL.STOK
{
    partial class FSayimIsle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FSayimIsle));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.label4 = new System.Windows.Forms.Label();
            this.LBSayim = new DevExpress.XtraEditors.LabelControl();
            this.LBSayimTarihi = new DevExpress.XtraEditors.LabelControl();
            this.LBDurum = new DevExpress.XtraEditors.LabelControl();
            this.BTSayimIsle = new DevExpress.XtraEditors.SimpleButton();
            this.BTKaldir = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.TBDurum = new DevExpress.XtraEditors.LabelControl();
            this.DTSayimTar = new DevExpress.XtraEditors.DateEdit();
            this.BTSayimSec = new DevExpress.XtraEditors.ButtonEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTSayimTar.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTSayimTar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTSayimSec.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(10, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 7;
            // 
            // LBSayim
            // 
            this.LBSayim.Location = new System.Drawing.Point(65, 54);
            this.LBSayim.Name = "LBSayim";
            this.LBSayim.Size = new System.Drawing.Size(28, 13);
            this.LBSayim.TabIndex = 8;
            this.LBSayim.Text = "Sayım";
            // 
            // LBSayimTarihi
            // 
            this.LBSayimTarihi.Location = new System.Drawing.Point(36, 81);
            this.LBSayimTarihi.Name = "LBSayimTarihi";
            this.LBSayimTarihi.Size = new System.Drawing.Size(57, 13);
            this.LBSayimTarihi.TabIndex = 35;
            this.LBSayimTarihi.Text = "Sayım Tarihi";
            // 
            // LBDurum
            // 
            this.LBDurum.Appearance.Options.UseFont = true;
            this.LBDurum.Location = new System.Drawing.Point(56, 106);
            this.LBDurum.Name = "LBDurum";
            this.LBDurum.Size = new System.Drawing.Size(37, 13);
            this.LBDurum.TabIndex = 36;
            this.LBDurum.Text = "Durumu";
            // 
            // BTSayimIsle
            // 
            this.BTSayimIsle.Appearance.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTSayimIsle.Appearance.Options.UseBackColor = true;
            this.BTSayimIsle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTSayimIsle.ImageOptions.Image")));
            this.BTSayimIsle.Location = new System.Drawing.Point(6, 5);
            this.BTSayimIsle.Name = "BTSayimIsle";
            this.BTSayimIsle.Size = new System.Drawing.Size(95, 40);
            this.BTSayimIsle.TabIndex = 61;
            this.BTSayimIsle.Text = "İşle";
            this.BTSayimIsle.Click += new System.EventHandler(this.BTSayimIsle_Click);
            // 
            // BTKaldir
            // 
            this.BTKaldir.Appearance.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTKaldir.Appearance.Options.UseBackColor = true;
            this.BTKaldir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTKaldir.ImageOptions.Image")));
            this.BTKaldir.Location = new System.Drawing.Point(107, 5);
            this.BTKaldir.Name = "BTKaldir";
            this.BTKaldir.Size = new System.Drawing.Size(95, 40);
            this.BTKaldir.TabIndex = 62;
            this.BTKaldir.Text = "Kaldır";
            this.BTKaldir.Click += new System.EventHandler(this.BTKaldir_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1130, 930);
            this.panelControl1.TabIndex = 63;
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.groupControl1.Controls.Add(this.panelControl2);
            this.groupControl1.Controls.Add(this.TBDurum);
            this.groupControl1.Controls.Add(this.DTSayimTar);
            this.groupControl1.Controls.Add(this.BTSayimSec);
            this.groupControl1.Controls.Add(this.LBSayim);
            this.groupControl1.Controls.Add(this.LBDurum);
            this.groupControl1.Controls.Add(this.LBSayimTarihi);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1126, 926);
            this.groupControl1.TabIndex = 63;
            this.groupControl1.Text = "Sayım İşle";
            // 
            // TBDurum
            // 
            this.TBDurum.Location = new System.Drawing.Point(112, 106);
            this.TBDurum.Name = "TBDurum";
            this.TBDurum.Size = new System.Drawing.Size(12, 13);
            this.TBDurum.TabIndex = 63;
            this.TBDurum.Text = "...";
            // 
            // DTSayimTar
            // 
            this.DTSayimTar.EditValue = new System.DateTime(2022, 11, 17, 13, 35, 2, 150);
            this.DTSayimTar.Enabled = false;
            this.DTSayimTar.Location = new System.Drawing.Point(112, 78);
            this.DTSayimTar.Name = "DTSayimTar";
            this.DTSayimTar.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DTSayimTar.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DTSayimTar.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.ClassicNew;
            this.DTSayimTar.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.DTSayimTar.Size = new System.Drawing.Size(194, 20);
            this.DTSayimTar.TabIndex = 37;
            // 
            // BTSayimSec
            // 
            this.BTSayimSec.Location = new System.Drawing.Point(112, 50);
            this.BTSayimSec.Name = "BTSayimSec";
            this.BTSayimSec.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Seç", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.BTSayimSec.Properties.Name = "BTSayimSec";
            this.BTSayimSec.Properties.Click += new System.EventHandler(this.BTSayimSec_Properties_Click);
            this.BTSayimSec.Size = new System.Drawing.Size(194, 22);
            this.BTSayimSec.TabIndex = 36;
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.BTKaldir);
            this.panelControl2.Controls.Add(this.BTSayimIsle);
            this.panelControl2.Location = new System.Drawing.Point(213, 142);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(212, 51);
            this.panelControl2.TabIndex = 64;
            // 
            // FSayimIsle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 930);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FSayimIsle";
            this.Text = "FSayimIsle";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTSayimTar.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTSayimTar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTSayimSec.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label4;
        private DevExpress.XtraEditors.LabelControl LBSayim;
        private DevExpress.XtraEditors.LabelControl LBSayimTarihi;
        private DevExpress.XtraEditors.LabelControl LBDurum;
        private DevExpress.XtraEditors.SimpleButton BTSayimIsle;
        private DevExpress.XtraEditors.SimpleButton BTKaldir;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.ButtonEdit BTSayimSec;
        private DevExpress.XtraEditors.DateEdit DTSayimTar;
        private DevExpress.XtraEditors.LabelControl TBDurum;
        private DevExpress.XtraEditors.PanelControl panelControl2;
    }
}