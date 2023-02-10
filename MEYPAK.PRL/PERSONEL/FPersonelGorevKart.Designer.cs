namespace MEYPAK.PRL.PERSONEL
{
    partial class FPersonelGorevKart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FPersonelGorevKart));
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.XTPDepartman = new DevExpress.XtraTab.XtraTabPage();
            this.BTNDepartmanSil = new DevExpress.XtraEditors.SimpleButton();
            this.BTNDepartmanKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.GCDepartman = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TBDepartman = new DevExpress.XtraEditors.TextEdit();
            this.LBDepartman = new System.Windows.Forms.Label();
            this.XTPGorev = new DevExpress.XtraTab.XtraTabPage();
            this.BTGorevSil = new DevExpress.XtraEditors.SimpleButton();
            this.BTGorevKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.TBGorev = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.CBDepartman = new DevExpress.XtraEditors.LookUpEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.GCGorev = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.XTPDepartman.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GCDepartman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBDepartman.Properties)).BeginInit();
            this.XTPGorev.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TBGorev.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CBDepartman.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GCGorev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(2, 2);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.XTPDepartman;
            this.xtraTabControl1.Size = new System.Drawing.Size(881, 457);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.XTPDepartman,
            this.XTPGorev});
            // 
            // XTPDepartman
            // 
            this.XTPDepartman.Controls.Add(this.BTNDepartmanSil);
            this.XTPDepartman.Controls.Add(this.BTNDepartmanKaydet);
            this.XTPDepartman.Controls.Add(this.panelControl2);
            this.XTPDepartman.Controls.Add(this.TBDepartman);
            this.XTPDepartman.Controls.Add(this.LBDepartman);
            this.XTPDepartman.Name = "XTPDepartman";
            this.XTPDepartman.Size = new System.Drawing.Size(879, 432);
            this.XTPDepartman.Text = "Personel Departman";
            // 
            // BTNDepartmanSil
            // 
            this.BTNDepartmanSil.Appearance.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTNDepartmanSil.Appearance.Options.UseBackColor = true;
            this.BTNDepartmanSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTNDepartmanSil.ImageOptions.Image")));
            this.BTNDepartmanSil.Location = new System.Drawing.Point(771, 12);
            this.BTNDepartmanSil.Name = "BTNDepartmanSil";
            this.BTNDepartmanSil.Size = new System.Drawing.Size(95, 40);
            this.BTNDepartmanSil.TabIndex = 64;
            this.BTNDepartmanSil.Text = "&SİL";
            this.BTNDepartmanSil.Click += new System.EventHandler(this.BTNDepartmanSil_Click);
            // 
            // BTNDepartmanKaydet
            // 
            this.BTNDepartmanKaydet.Appearance.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTNDepartmanKaydet.Appearance.Options.UseBackColor = true;
            this.BTNDepartmanKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTNDepartmanKaydet.ImageOptions.Image")));
            this.BTNDepartmanKaydet.Location = new System.Drawing.Point(670, 12);
            this.BTNDepartmanKaydet.Name = "BTNDepartmanKaydet";
            this.BTNDepartmanKaydet.Size = new System.Drawing.Size(95, 40);
            this.BTNDepartmanKaydet.TabIndex = 63;
            this.BTNDepartmanKaydet.Text = "&KAYDET";
            this.BTNDepartmanKaydet.Click += new System.EventHandler(this.BTNDepartmanKaydet_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.GCDepartman);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 67);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(879, 365);
            this.panelControl2.TabIndex = 2;
            // 
            // GCDepartman
            // 
            this.GCDepartman.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GCDepartman.Location = new System.Drawing.Point(2, 2);
            this.GCDepartman.MainView = this.gridView1;
            this.GCDepartman.Name = "GCDepartman";
            this.GCDepartman.Size = new System.Drawing.Size(875, 361);
            this.GCDepartman.TabIndex = 0;
            this.GCDepartman.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView1.GridControl = this.GCDepartman;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // TBDepartman
            // 
            this.TBDepartman.Location = new System.Drawing.Point(101, 22);
            this.TBDepartman.Name = "TBDepartman";
            this.TBDepartman.Size = new System.Drawing.Size(154, 20);
            this.TBDepartman.TabIndex = 1;
            // 
            // LBDepartman
            // 
            this.LBDepartman.AutoSize = true;
            this.LBDepartman.Location = new System.Drawing.Point(25, 25);
            this.LBDepartman.Name = "LBDepartman";
            this.LBDepartman.Size = new System.Drawing.Size(60, 13);
            this.LBDepartman.TabIndex = 0;
            this.LBDepartman.Text = "Departman";
            // 
            // XTPGorev
            // 
            this.XTPGorev.Controls.Add(this.BTGorevSil);
            this.XTPGorev.Controls.Add(this.BTGorevKaydet);
            this.XTPGorev.Controls.Add(this.TBGorev);
            this.XTPGorev.Controls.Add(this.label2);
            this.XTPGorev.Controls.Add(this.CBDepartman);
            this.XTPGorev.Controls.Add(this.label1);
            this.XTPGorev.Controls.Add(this.panelControl3);
            this.XTPGorev.Name = "XTPGorev";
            this.XTPGorev.Size = new System.Drawing.Size(879, 432);
            this.XTPGorev.Text = "Personel Görev";
            // 
            // BTGorevSil
            // 
            this.BTGorevSil.Appearance.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTGorevSil.Appearance.Options.UseBackColor = true;
            this.BTGorevSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTGorevSil.ImageOptions.Image")));
            this.BTGorevSil.Location = new System.Drawing.Point(761, 15);
            this.BTGorevSil.Name = "BTGorevSil";
            this.BTGorevSil.Size = new System.Drawing.Size(95, 40);
            this.BTGorevSil.TabIndex = 66;
            this.BTGorevSil.Text = "&SİL";
            this.BTGorevSil.Click += new System.EventHandler(this.BTGorevSil_Click);
            // 
            // BTGorevKaydet
            // 
            this.BTGorevKaydet.Appearance.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTGorevKaydet.Appearance.Options.UseBackColor = true;
            this.BTGorevKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTGorevKaydet.ImageOptions.Image")));
            this.BTGorevKaydet.Location = new System.Drawing.Point(660, 15);
            this.BTGorevKaydet.Name = "BTGorevKaydet";
            this.BTGorevKaydet.Size = new System.Drawing.Size(95, 40);
            this.BTGorevKaydet.TabIndex = 65;
            this.BTGorevKaydet.Text = "&KAYDET";
            this.BTGorevKaydet.Click += new System.EventHandler(this.BTGorevKaydet_Click);
            // 
            // TBGorev
            // 
            this.TBGorev.Location = new System.Drawing.Point(351, 25);
            this.TBGorev.Name = "TBGorev";
            this.TBGorev.Size = new System.Drawing.Size(132, 20);
            this.TBGorev.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Görev";
            // 
            // CBDepartman
            // 
            this.CBDepartman.Location = new System.Drawing.Point(106, 25);
            this.CBDepartman.Name = "CBDepartman";
            this.CBDepartman.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CBDepartman.Properties.NullText = "";
            this.CBDepartman.Size = new System.Drawing.Size(132, 20);
            this.CBDepartman.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Departman";
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.GCGorev);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl3.Location = new System.Drawing.Point(0, 78);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(879, 354);
            this.panelControl3.TabIndex = 0;
            // 
            // GCGorev
            // 
            this.GCGorev.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GCGorev.Location = new System.Drawing.Point(2, 2);
            this.GCGorev.MainView = this.gridView2;
            this.GCGorev.Name = "GCGorev";
            this.GCGorev.Size = new System.Drawing.Size(875, 350);
            this.GCGorev.TabIndex = 0;
            this.GCGorev.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView2.GridControl = this.GCGorev;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.xtraTabControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(885, 461);
            this.panelControl1.TabIndex = 1;
            // 
            // FPersonelGorevKart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 461);
            this.Controls.Add(this.panelControl1);
            this.Name = "FPersonelGorevKart";
            this.Text = "Personel Departman Görev Tanim";
            this.Load += new System.EventHandler(this.FPersonelGorevKart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.XTPDepartman.ResumeLayout(false);
            this.XTPDepartman.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GCDepartman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBDepartman.Properties)).EndInit();
            this.XTPGorev.ResumeLayout(false);
            this.XTPGorev.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TBGorev.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CBDepartman.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GCGorev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage XTPDepartman;
        private DevExpress.XtraEditors.TextEdit TBDepartman;
        private Label LBDepartman;
        private DevExpress.XtraTab.XtraTabPage XTPGorev;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl GCDepartman;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton BTNDepartmanKaydet;
        private DevExpress.XtraEditors.SimpleButton BTNDepartmanSil;
        private DevExpress.XtraEditors.SimpleButton BTGorevSil;
        private DevExpress.XtraEditors.SimpleButton BTGorevKaydet;
        private DevExpress.XtraEditors.TextEdit TBGorev;
        private Label label2;
        private DevExpress.XtraEditors.LookUpEdit CBDepartman;
        private Label label1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraGrid.GridControl GCGorev;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
    }
}