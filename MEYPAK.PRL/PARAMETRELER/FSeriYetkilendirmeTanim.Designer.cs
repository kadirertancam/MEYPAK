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
            this.GBSeriTanim = new System.Windows.Forms.GroupBox();
            this.RGStokHarGirisCikis = new DevExpress.XtraEditors.RadioGroup();
            this.BTSeriKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.LBKullanici = new DevExpress.XtraEditors.LabelControl();
            this.GBKullanici = new DevExpress.XtraEditors.ComboBoxEdit();
            this.LBSeri = new DevExpress.XtraEditors.LabelControl();
            this.BESeri = new DevExpress.XtraEditors.ButtonEdit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.GBSeriTanim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RGStokHarGirisCikis.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GBKullanici.Properties)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 86);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(800, 364);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.GBSeriTanim);
            this.panel2.Controls.Add(this.BTSeriKaydet);
            this.panel2.Controls.Add(this.LBKullanici);
            this.panel2.Controls.Add(this.GBKullanici);
            this.panel2.Controls.Add(this.LBSeri);
            this.panel2.Controls.Add(this.BESeri);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 86);
            this.panel2.TabIndex = 0;
            // 
            // GBSeriTanim
            // 
            this.GBSeriTanim.Controls.Add(this.RGStokHarGirisCikis);
            this.GBSeriTanim.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GBSeriTanim.Location = new System.Drawing.Point(435, 23);
            this.GBSeriTanim.Name = "GBSeriTanim";
            this.GBSeriTanim.Size = new System.Drawing.Size(324, 52);
            this.GBSeriTanim.TabIndex = 76;
            this.GBSeriTanim.TabStop = false;
            // 
            // RGStokHarGirisCikis
            // 
            this.RGStokHarGirisCikis.Location = new System.Drawing.Point(13, 14);
            this.RGStokHarGirisCikis.Name = "RGStokHarGirisCikis";
            this.RGStokHarGirisCikis.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.RGStokHarGirisCikis.Properties.Appearance.Options.UseBackColor = true;
            this.RGStokHarGirisCikis.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.RGStokHarGirisCikis.Properties.Columns = 2;
            this.RGStokHarGirisCikis.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.RGStokHarGirisCikis.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(true, "Fatura", true, true, "RBFatura"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(true, "İrsaliye", true, true, "RBIrsaliye")});
            this.RGStokHarGirisCikis.Size = new System.Drawing.Size(299, 29);
            this.RGStokHarGirisCikis.TabIndex = 7;
            // 
            // BTSeriKaydet
            // 
            this.BTSeriKaydet.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.BTSeriKaydet.Appearance.Options.UseBackColor = true;
            this.BTSeriKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTSeriKaydet.ImageOptions.Image")));
            this.BTSeriKaydet.Location = new System.Drawing.Point(269, 23);
            this.BTSeriKaydet.Name = "BTSeriKaydet";
            this.BTSeriKaydet.Size = new System.Drawing.Size(94, 52);
            this.BTSeriKaydet.TabIndex = 75;
            this.BTSeriKaydet.Text = "Kaydet";
            // 
            // LBKullanici
            // 
            this.LBKullanici.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBKullanici.Appearance.Options.UseFont = true;
            this.LBKullanici.Location = new System.Drawing.Point(18, 54);
            this.LBKullanici.Name = "LBKullanici";
            this.LBKullanici.Size = new System.Drawing.Size(46, 16);
            this.LBKullanici.TabIndex = 32;
            this.LBKullanici.Text = "Kullanıcı";
            // 
            // GBKullanici
            // 
            this.GBKullanici.Location = new System.Drawing.Point(75, 52);
            this.GBKullanici.Name = "GBKullanici";
            this.GBKullanici.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GBKullanici.Properties.Appearance.Options.UseFont = true;
            this.GBKullanici.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.GBKullanici.Properties.Items.AddRange(new object[] {
            "TL"});
            this.GBKullanici.Properties.Padding = new System.Windows.Forms.Padding(3);
            this.GBKullanici.Size = new System.Drawing.Size(180, 26);
            this.GBKullanici.TabIndex = 31;
            // 
            // LBSeri
            // 
            this.LBSeri.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBSeri.Appearance.Options.UseFont = true;
            this.LBSeri.Location = new System.Drawing.Point(44, 25);
            this.LBSeri.Name = "LBSeri";
            this.LBSeri.Size = new System.Drawing.Size(20, 14);
            this.LBSeri.TabIndex = 8;
            this.LBSeri.Text = "Seri";
            this.LBSeri.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Application;
            // 
            // BESeri
            // 
            this.BESeri.Location = new System.Drawing.Point(75, 20);
            this.BESeri.Name = "BESeri";
            this.BESeri.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.BESeri.Properties.Padding = new System.Windows.Forms.Padding(3);
            this.BESeri.Size = new System.Drawing.Size(180, 26);
            this.BESeri.TabIndex = 9;
            this.BESeri.EditValueChanged += new System.EventHandler(this.BESeri_EditValueChanged);
            // 
            // FSeriTanim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FSeriTanim";
            this.Text = "FSeriTanim";
            this.Load += new System.EventHandler(this.FSeriTanim_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.GBSeriTanim.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RGStokHarGirisCikis.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GBKullanici.Properties)).EndInit();
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
        private DevExpress.XtraEditors.ComboBoxEdit GBKullanici;
        private DevExpress.XtraEditors.SimpleButton BTSeriKaydet;
        private GroupBox GBSeriTanim;
        private DevExpress.XtraEditors.RadioGroup RGStokHarGirisCikis;
    }
}