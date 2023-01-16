namespace MEYPAK.PRL.BANKA
{
    partial class FBankaTanim
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.TBIl = new MEYPAK.PRL.Assets.YeniTextEdit();
            this.TBIlce = new MEYPAK.PRL.Assets.YeniTextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.TBBankaAdi = new MEYPAK.PRL.Assets.YeniTextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TBBankaKod = new MEYPAK.PRL.Assets.YeniTextEdit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TBIl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBIlce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBBankaAdi.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBBankaKod.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TBBankaKod);
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TBIl);
            this.panel1.Controls.Add(this.TBIlce);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TBBankaAdi);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 101);
            this.panel1.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(353, 27);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(100, 54);
            this.simpleButton1.TabIndex = 8;
            this.simpleButton1.Text = "Kaydet";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "/";
            // 
            // TBIl
            // 
            this.TBIl.Location = new System.Drawing.Point(195, 65);
            this.TBIl.Name = "TBIl";
            this.TBIl.Size = new System.Drawing.Size(83, 20);
            this.TBIl.TabIndex = 6;
            // 
            // TBIlce
            // 
            this.TBIlce.Location = new System.Drawing.Point(96, 65);
            this.TBIlce.Name = "TBIlce";
            this.TBIlce.Size = new System.Drawing.Size(74, 20);
            this.TBIlce.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "İl/İlçe";
            // 
            // TBBankaAdi
            // 
            this.TBBankaAdi.Location = new System.Drawing.Point(96, 38);
            this.TBBankaAdi.Name = "TBBankaAdi";
            this.TBBankaAdi.Size = new System.Drawing.Size(182, 20);
            this.TBBankaAdi.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Banka Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Banka Kodu";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(801, 431);
            this.panel2.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(801, 431);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // TBBankaKod
            // 
            this.TBBankaKod.Location = new System.Drawing.Point(96, 12);
            this.TBBankaKod.Name = "TBBankaKod";
            this.TBBankaKod.Size = new System.Drawing.Size(182, 20);
            this.TBBankaKod.TabIndex = 9;
            // 
            // FBankaTanim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 532);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FBankaTanim";
            this.Text = "FBankaTanim";
            this.Load += new System.EventHandler(this.FBankaTanim_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TBIl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBIlce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBBankaAdi.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBBankaKod.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private Label label4;
        private Assets.YeniTextEdit TBIl;
        private Assets.YeniTextEdit TBIlce;
        private Label label3;
        private Assets.YeniTextEdit TBBankaAdi;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private Assets.YeniTextEdit TBBankaKod;
    }
}