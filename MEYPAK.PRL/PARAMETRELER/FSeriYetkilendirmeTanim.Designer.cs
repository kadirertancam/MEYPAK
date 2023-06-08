namespace MEYPAK.PRL.PARAMETRELER
{
    partial class FSeriYetkilendirmeTanim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FSeriYetkilendirmeTanim));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.BTSeriKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.LBKullanici = new DevExpress.XtraEditors.LabelControl();
            this.LBSeri = new DevExpress.XtraEditors.LabelControl();
            this.BESeri = new DevExpress.XtraEditors.ButtonEdit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BESeri.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControl1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 390);
            this.panel1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 75);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(686, 315);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 303;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lookUpEdit1);
            this.panel2.Controls.Add(this.BTSeriKaydet);
            this.panel2.Controls.Add(this.LBKullanici);
            this.panel2.Controls.Add(this.LBSeri);
            this.panel2.Controls.Add(this.BESeri);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(686, 75);
            this.panel2.TabIndex = 0;
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(71, 49);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.NullText = "";
            this.lookUpEdit1.Size = new System.Drawing.Size(154, 20);
            this.lookUpEdit1.TabIndex = 77;
            // 
            // BTSeriKaydet
            // 
            this.BTSeriKaydet.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.BTSeriKaydet.Appearance.Options.UseBackColor = true;
            this.BTSeriKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTSeriKaydet.ImageOptions.Image")));
            this.BTSeriKaydet.Location = new System.Drawing.Point(231, 20);
            this.BTSeriKaydet.Name = "BTSeriKaydet";
            this.BTSeriKaydet.Size = new System.Drawing.Size(81, 45);
            this.BTSeriKaydet.TabIndex = 75;
            this.BTSeriKaydet.Text = "Kaydet";
            this.BTSeriKaydet.Click += new System.EventHandler(this.BTSeriKaydet_Click);
            // 
            // LBKullanici
            // 
            this.LBKullanici.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBKullanici.Appearance.Options.UseFont = true;
            this.LBKullanici.Location = new System.Drawing.Point(15, 47);
            this.LBKullanici.Name = "LBKullanici";
            this.LBKullanici.Size = new System.Drawing.Size(46, 16);
            this.LBKullanici.TabIndex = 32;
            this.LBKullanici.Text = "Kullanıcı";
            // 
            // LBSeri
            // 
            this.LBSeri.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBSeri.Appearance.Options.UseFont = true;
            this.LBSeri.Location = new System.Drawing.Point(38, 22);
            this.LBSeri.Name = "LBSeri";
            this.LBSeri.Size = new System.Drawing.Size(20, 14);
            this.LBSeri.TabIndex = 8;
            this.LBSeri.Text = "Seri";
            this.LBSeri.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Application;
            // 
            // BESeri
            // 
            this.BESeri.Location = new System.Drawing.Point(71, 17);
            this.BESeri.Name = "BESeri";
            this.BESeri.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.BESeri.Properties.Padding = new System.Windows.Forms.Padding(3);
            this.BESeri.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.BESeri_Properties_ButtonClick);
            this.BESeri.Size = new System.Drawing.Size(154, 26);
            this.BESeri.TabIndex = 9;
            this.BESeri.EditValueChanged += new System.EventHandler(this.BESeri_EditValueChanged);
            // 
            // FSeriYetkilendirmeTanim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.panel1);
            this.Name = "FSeriYetkilendirmeTanim";
            this.Text = "FSeriTanim";
            this.Load += new System.EventHandler(this.FSeriTanim_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BESeri.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl LBSeri;
        private DevExpress.XtraEditors.ButtonEdit BESeri;
        private DevExpress.XtraEditors.LabelControl LBKullanici;
        private DevExpress.XtraEditors.SimpleButton BTSeriKaydet;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
    }
}