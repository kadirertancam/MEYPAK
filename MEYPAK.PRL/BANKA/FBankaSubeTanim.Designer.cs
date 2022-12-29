namespace MEYPAK.PRL.BANKA
{
    partial class FBankaSubeTanim
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
            this.TBSubeAdi = new DevExpress.XtraEditors.TextEdit();
            this.TBSubeKodu = new DevExpress.XtraEditors.TextEdit();
            this.CBBanka = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TBSubeAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBSubeKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CBBanka.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TBSubeAdi);
            this.panel1.Controls.Add(this.TBSubeKodu);
            this.panel1.Controls.Add(this.CBBanka);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 116);
            this.panel1.TabIndex = 0;
            // 
            // TBSubeAdi
            // 
            this.TBSubeAdi.Location = new System.Drawing.Point(99, 79);
            this.TBSubeAdi.Name = "TBSubeAdi";
            this.TBSubeAdi.Size = new System.Drawing.Size(122, 20);
            this.TBSubeAdi.TabIndex = 14;
            // 
            // TBSubeKodu
            // 
            this.TBSubeKodu.Location = new System.Drawing.Point(99, 49);
            this.TBSubeKodu.Name = "TBSubeKodu";
            this.TBSubeKodu.Size = new System.Drawing.Size(122, 20);
            this.TBSubeKodu.TabIndex = 13;
            // 
            // CBBanka
            // 
            this.CBBanka.Location = new System.Drawing.Point(99, 21);
            this.CBBanka.Name = "CBBanka";
            this.CBBanka.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CBBanka.Properties.NullText = "Banka Seç...";
            this.CBBanka.Size = new System.Drawing.Size(122, 20);
            this.CBBanka.TabIndex = 12;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(40, 81);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(42, 13);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "Şube Adı";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(33, 52);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(51, 13);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "Şube Kodu";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(51, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(29, 13);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Banka";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(279, 31);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(100, 54);
            this.simpleButton1.TabIndex = 8;
            this.simpleButton1.Text = "Kaydet";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 116);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(801, 416);
            this.panel2.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(801, 416);
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
            // FBankaSubeTanim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 532);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FBankaSubeTanim";
            this.Text = "FBankaSubeTanim";
            this.Load += new System.EventHandler(this.FBankaSubeTanim_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TBSubeAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBSubeKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CBBanka.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private Panel panel2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit TBSubeAdi;
        private DevExpress.XtraEditors.TextEdit TBSubeKodu;
        private DevExpress.XtraEditors.LookUpEdit CBBanka;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}