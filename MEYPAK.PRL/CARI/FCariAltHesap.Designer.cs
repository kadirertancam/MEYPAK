namespace MEYPAK.PRL.CARI
{
    partial class FCariAltHesap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FCariAltHesap));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.CBDoviz = new DevExpress.XtraEditors.LookUpEdit();
            this.CBAktif = new DevExpress.XtraEditors.CheckEdit();
            this.TBCariAdi = new DevExpress.XtraEditors.TextEdit();
            this.LBDoviz = new DevExpress.XtraEditors.LabelControl();
            this.LBCariAdi = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTSil = new DevExpress.XtraEditors.SimpleButton();
            this.BTKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DGAltHesap = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CBDoviz.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CBAktif.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBCariAdi.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGAltHesap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.CBDoviz);
            this.groupControl1.Controls.Add(this.CBAktif);
            this.groupControl1.Controls.Add(this.TBCariAdi);
            this.groupControl1.Controls.Add(this.LBDoviz);
            this.groupControl1.Controls.Add(this.LBCariAdi);
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(304, 97);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Alt Hesap";
            // 
            // CBDoviz
            // 
            this.CBDoviz.Location = new System.Drawing.Point(95, 54);
            this.CBDoviz.Name = "CBDoviz";
            this.CBDoviz.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CBDoviz.Properties.NullText = "";
            this.CBDoviz.Size = new System.Drawing.Size(89, 20);
            this.CBDoviz.TabIndex = 3;
            // 
            // CBAktif
            // 
            this.CBAktif.Location = new System.Drawing.Point(190, 54);
            this.CBAktif.Name = "CBAktif";
            this.CBAktif.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CBAktif.Properties.Appearance.Options.UseFont = true;
            this.CBAktif.Properties.Caption = "Aktif";
            this.CBAktif.Size = new System.Drawing.Size(50, 20);
            this.CBAktif.TabIndex = 4;
            // 
            // TBCariAdi
            // 
            this.TBCariAdi.Location = new System.Drawing.Point(95, 28);
            this.TBCariAdi.Name = "TBCariAdi";
            this.TBCariAdi.Size = new System.Drawing.Size(161, 20);
            this.TBCariAdi.TabIndex = 2;
            // 
            // LBDoviz
            // 
            this.LBDoviz.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBDoviz.Appearance.Options.UseFont = true;
            this.LBDoviz.Location = new System.Drawing.Point(53, 57);
            this.LBDoviz.Name = "LBDoviz";
            this.LBDoviz.Size = new System.Drawing.Size(28, 13);
            this.LBDoviz.TabIndex = 1;
            this.LBDoviz.Text = "Döviz";
            // 
            // LBCariAdi
            // 
            this.LBCariAdi.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBCariAdi.Appearance.Options.UseFont = true;
            this.LBCariAdi.Location = new System.Drawing.Point(12, 31);
            this.LBCariAdi.Name = "LBCariAdi";
            this.LBCariAdi.Size = new System.Drawing.Size(69, 13);
            this.LBCariAdi.TabIndex = 0;
            this.LBCariAdi.Text = "Alt Hesap Adı";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BTSil);
            this.panel1.Controls.Add(this.BTKaydet);
            this.panel1.Controls.Add(this.groupControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1303, 111);
            this.panel1.TabIndex = 1;
            // 
            // BTSil
            // 
            this.BTSil.Appearance.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTSil.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTSil.Appearance.Options.UseBackColor = true;
            this.BTSil.Appearance.Options.UseFont = true;
            this.BTSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTSil.ImageOptions.Image")));
            this.BTSil.Location = new System.Drawing.Point(744, 34);
            this.BTSil.Name = "BTSil";
            this.BTSil.Size = new System.Drawing.Size(94, 52);
            this.BTSil.TabIndex = 2;
            this.BTSil.Text = "Sil";
            this.BTSil.Click += new System.EventHandler(this.BTSil_Click);
            // 
            // BTKaydet
            // 
            this.BTKaydet.Appearance.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTKaydet.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTKaydet.Appearance.Options.UseBackColor = true;
            this.BTKaydet.Appearance.Options.UseFont = true;
            this.BTKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTKaydet.ImageOptions.Image")));
            this.BTKaydet.Location = new System.Drawing.Point(641, 34);
            this.BTKaydet.Name = "BTKaydet";
            this.BTKaydet.Size = new System.Drawing.Size(94, 52);
            this.BTKaydet.TabIndex = 1;
            this.BTKaydet.Text = "&Kaydet";
            this.BTKaydet.Click += new System.EventHandler(this.BTKaydet_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DGAltHesap);
            this.panel2.Location = new System.Drawing.Point(1, 116);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1301, 568);
            this.panel2.TabIndex = 2;
            // 
            // DGAltHesap
            // 
            this.DGAltHesap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGAltHesap.Location = new System.Drawing.Point(0, 0);
            this.DGAltHesap.MainView = this.gridView1;
            this.DGAltHesap.Name = "DGAltHesap";
            this.DGAltHesap.Size = new System.Drawing.Size(1301, 568);
            this.DGAltHesap.TabIndex = 0;
            this.DGAltHesap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.DGAltHesap;
            this.gridView1.Name = "gridView1";
            // 
            // FCariAltHesap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 687);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FCariAltHesap";
            this.Text = "FCariAltHesap";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CBDoviz.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CBAktif.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBCariAdi.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGAltHesap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.CheckEdit CBAktif;
        private DevExpress.XtraEditors.TextEdit TBCariAdi;
        private DevExpress.XtraEditors.LabelControl LBDoviz;
        private DevExpress.XtraEditors.LabelControl LBCariAdi;
        private Panel panel1;
        private DevExpress.XtraEditors.SimpleButton BTKaydet;
        private Panel panel2;
        private DevExpress.XtraGrid.GridControl DGAltHesap;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton BTSil;
        private DevExpress.XtraEditors.LookUpEdit CBDoviz;
    }
}