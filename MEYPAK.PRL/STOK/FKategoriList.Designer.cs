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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FKategoriList));
            this.BTAltEkle = new DevExpress.XtraEditors.SimpleButton();
            this.BTYeniEkle = new DevExpress.XtraEditors.SimpleButton();
            this.TBKategoriAdi = new DevExpress.XtraEditors.TextEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.LBAdi = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.TBKategoriAdi.Properties)).BeginInit();
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
            // BTAltEkle
            // 
            this.BTAltEkle.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.BTAltEkle.Appearance.Options.UseBackColor = true;
            this.BTAltEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTAltEkle.ImageOptions.Image")));
            this.BTAltEkle.Location = new System.Drawing.Point(490, 35);
            this.BTAltEkle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BTAltEkle.Name = "BTAltEkle";
            this.BTAltEkle.Size = new System.Drawing.Size(117, 39);
            this.BTAltEkle.TabIndex = 81;
            this.BTAltEkle.Text = "Alt Kategori";
            this.BTAltEkle.Click += new System.EventHandler(this.BTAltKateEkle_Click);
            // 
            // BTYeniEkle
            // 
            this.BTYeniEkle.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.BTYeniEkle.Appearance.Options.UseBackColor = true;
            this.BTYeniEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTYeniEkle.ImageOptions.Image")));
            this.BTYeniEkle.Location = new System.Drawing.Point(366, 35);
            this.BTYeniEkle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BTYeniEkle.Name = "BTYeniEkle";
            this.BTYeniEkle.Size = new System.Drawing.Size(117, 39);
            this.BTYeniEkle.TabIndex = 80;
            this.BTYeniEkle.Text = "Yeni Kategori";
            this.BTYeniEkle.Click += new System.EventHandler(this.BTYeniEkle_Click);
            // 
            // TBKategoriAdi
            // 
            this.TBKategoriAdi.Location = new System.Drawing.Point(114, 43);
            this.TBKategoriAdi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TBKategoriAdi.Name = "TBKategoriAdi";
            this.TBKategoriAdi.Size = new System.Drawing.Size(210, 20);
            this.TBKategoriAdi.TabIndex = 79;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1267, 620);
            this.panelControl1.TabIndex = 2;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.treeView1);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(2, 113);
            this.panelControl3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1263, 505);
            this.panelControl3.TabIndex = 4;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(2, 2);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(1259, 501);
            this.treeView1.TabIndex = 0;
            this.treeView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.treeView1_KeyPress);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.groupControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(2, 2);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1263, 111);
            this.panelControl2.TabIndex = 3;
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.Controls.Add(this.LBAdi);
            this.groupControl1.Controls.Add(this.BTAltEkle);
            this.groupControl1.Controls.Add(this.TBKategoriAdi);
            this.groupControl1.Controls.Add(this.BTYeniEkle);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl1.Location = new System.Drawing.Point(2, 2);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1259, 105);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Kategori";
            // 
            // LBAdi
            // 
            this.LBAdi.Appearance.Options.UseFont = true;
            this.LBAdi.Location = new System.Drawing.Point(28, 46);
            this.LBAdi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LBAdi.Name = "LBAdi";
            this.LBAdi.Size = new System.Drawing.Size(58, 13);
            this.LBAdi.TabIndex = 82;
            this.LBAdi.Text = "Kategori Adı";
            // 
            // FKategoriList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 618);
            this.Controls.Add(this.panelControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FKategoriList";
            this.Text = "FKategoriList";
            this.Load += new System.EventHandler(this.FKategoriList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TBKategoriAdi.Properties)).EndInit();
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
        private DevExpress.XtraEditors.TextEdit TBKategoriAdi;
        private DevExpress.XtraEditors.SimpleButton BTAltEkle;
        private DevExpress.XtraEditors.SimpleButton BTYeniEkle;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl LBAdi;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private TreeView treeView1;
    }
}