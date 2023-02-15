namespace MEYPAK.PRL.PERSONEL
{
    partial class FPersonelParametre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FPersonelParametre));
            this.panel1 = new System.Windows.Forms.Panel();
            this.TBAvans = new DevExpress.XtraEditors.TextEdit();
            this.BTNPersonelKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.TSAvans = new DevExpress.XtraEditors.ToggleSwitch();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TBAvans.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TSAvans.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TBAvans);
            this.panel1.Controls.Add(this.BTNPersonelKaydet);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.TSAvans);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 515);
            this.panel1.TabIndex = 0;
            // 
            // TBAvans
            // 
            this.TBAvans.Location = new System.Drawing.Point(109, 39);
            this.TBAvans.Name = "TBAvans";
            this.TBAvans.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.TBAvans.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.TBAvans.Properties.MaskSettings.Set("mask", "d");
            this.TBAvans.Properties.MaskSettings.Set("valueType", typeof(ulong));
            this.TBAvans.Properties.UseMaskAsDisplayFormat = true;
            this.TBAvans.Size = new System.Drawing.Size(100, 20);
            this.TBAvans.TabIndex = 64;
            // 
            // BTNPersonelKaydet
            // 
            this.BTNPersonelKaydet.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.BTNPersonelKaydet.Appearance.Options.UseBackColor = true;
            this.BTNPersonelKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTNPersonelKaydet.ImageOptions.Image")));
            this.BTNPersonelKaydet.Location = new System.Drawing.Point(59, 70);
            this.BTNPersonelKaydet.Name = "BTNPersonelKaydet";
            this.BTNPersonelKaydet.Size = new System.Drawing.Size(125, 40);
            this.BTNPersonelKaydet.TabIndex = 63;
            this.BTNPersonelKaydet.Text = "&Güncelle";
            this.BTNPersonelKaydet.Click += new System.EventHandler(this.BTNPersonelKaydet_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(23, 10);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(245, 18);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Personel Avans Miktarı Kontrolü ";
            // 
            // TSAvans
            // 
            this.TSAvans.Location = new System.Drawing.Point(22, 40);
            this.TSAvans.Name = "TSAvans";
            this.TSAvans.Properties.OffText = "Katı";
            this.TSAvans.Properties.OnText = "Miktarı";
            this.TSAvans.Size = new System.Drawing.Size(81, 18);
            this.TSAvans.TabIndex = 0;
            // 
            // FPersonelParametre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 515);
            this.Controls.Add(this.panel1);
            this.Name = "FPersonelParametre";
            this.Text = "FPersonelParametre";
            this.Load += new System.EventHandler(this.FPersonelParametre_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TBAvans.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TSAvans.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ToggleSwitch TSAvans;
        private DevExpress.XtraEditors.SimpleButton BTNPersonelKaydet;
        private DevExpress.XtraEditors.TextEdit TBAvans;
    }
}