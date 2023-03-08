namespace MEYPAK.PRL.DESTEKSERVIS
{
    partial class FDestekServis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FDestekServis));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.LBMesaj = new DevExpress.XtraEditors.LabelControl();
            this.LBDepartman = new DevExpress.XtraEditors.LabelControl();
            this.LBBaslik = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1128, 898);
            this.panelControl1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.groupControl1.Controls.Add(this.LBMesaj);
            this.groupControl1.Controls.Add(this.LBDepartman);
            this.groupControl1.Controls.Add(this.LBBaslik);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1124, 232);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Destek Servis";
            // 
            // LBMesaj
            // 
            this.LBMesaj.Location = new System.Drawing.Point(55, 90);
            this.LBMesaj.Name = "LBMesaj";
            this.LBMesaj.Size = new System.Drawing.Size(28, 13);
            this.LBMesaj.TabIndex = 45;
            this.LBMesaj.Text = "Mesaj";
            // 
            // LBDepartman
            // 
            this.LBDepartman.Location = new System.Drawing.Point(325, 57);
            this.LBDepartman.Name = "LBDepartman";
            this.LBDepartman.Size = new System.Drawing.Size(53, 13);
            this.LBDepartman.TabIndex = 44;
            this.LBDepartman.Text = "Departman";
            // 
            // LBBaslik
            // 
            this.LBBaslik.Location = new System.Drawing.Point(57, 57);
            this.LBBaslik.Name = "LBBaslik";
            this.LBBaslik.Size = new System.Drawing.Size(26, 13);
            this.LBBaslik.TabIndex = 43;
            this.LBBaslik.Text = "Başlık";
            // 
            // FDestekServis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 898);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FDestekServis";
            this.Text = "FDestekServis";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl LBMesaj;
        private DevExpress.XtraEditors.LabelControl LBDepartman;
        private DevExpress.XtraEditors.LabelControl LBBaslik;
    }
}