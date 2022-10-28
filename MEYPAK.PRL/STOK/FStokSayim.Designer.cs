namespace MEYPAK.PRL.STOK
{
    partial class FStokSayim
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTSayimSil = new System.Windows.Forms.Button();
            this.BTSayimGuncelle = new System.Windows.Forms.Button();
            this.BTSayimKaydet = new System.Windows.Forms.Button();
            this.TBAciklama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DTPSayimTarihi = new DevExpress.XtraEditors.DateTimeOffsetEdit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTPSayimTarihi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(837, 629);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gridControl1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 91);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(837, 538);
            this.panel3.TabIndex = 3;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(837, 538);
            this.gridControl1.TabIndex = 2;
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
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(837, 91);
            this.panel2.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DTPSayimTarihi);
            this.groupBox1.Controls.Add(this.BTSayimSil);
            this.groupBox1.Controls.Add(this.BTSayimGuncelle);
            this.groupBox1.Controls.Add(this.BTSayimKaydet);
            this.groupBox1.Controls.Add(this.TBAciklama);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(837, 91);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stok Sayım";
            // 
            // BTSayimSil
            // 
            this.BTSayimSil.Location = new System.Drawing.Point(717, 28);
            this.BTSayimSil.Name = "BTSayimSil";
            this.BTSayimSil.Size = new System.Drawing.Size(96, 54);
            this.BTSayimSil.TabIndex = 6;
            this.BTSayimSil.Text = "Sil";
            this.BTSayimSil.UseVisualStyleBackColor = true;
            this.BTSayimSil.Click += new System.EventHandler(this.BTSayimSil_Click);
            // 
            // BTSayimGuncelle
            // 
            this.BTSayimGuncelle.Location = new System.Drawing.Point(615, 28);
            this.BTSayimGuncelle.Name = "BTSayimGuncelle";
            this.BTSayimGuncelle.Size = new System.Drawing.Size(96, 54);
            this.BTSayimGuncelle.TabIndex = 5;
            this.BTSayimGuncelle.Text = "Degistir";
            this.BTSayimGuncelle.UseVisualStyleBackColor = true;
            this.BTSayimGuncelle.Click += new System.EventHandler(this.BTSayimDuzenle_Click);
            // 
            // BTSayimKaydet
            // 
            this.BTSayimKaydet.Location = new System.Drawing.Point(513, 28);
            this.BTSayimKaydet.Name = "BTSayimKaydet";
            this.BTSayimKaydet.Size = new System.Drawing.Size(96, 54);
            this.BTSayimKaydet.TabIndex = 4;
            this.BTSayimKaydet.Text = "Kaydet";
            this.BTSayimKaydet.UseVisualStyleBackColor = true;
            this.BTSayimKaydet.Click += new System.EventHandler(this.BTSayimKaydet_Click);
            // 
            // TBAciklama
            // 
            this.TBAciklama.Location = new System.Drawing.Point(301, 45);
            this.TBAciklama.Name = "TBAciklama";
            this.TBAciklama.Size = new System.Drawing.Size(154, 23);
            this.TBAciklama.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Açıklama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sayım Tarihi";
            // 
            // DTPSayimTarihi
            // 
            this.DTPSayimTarihi.EditValue = null;
            this.DTPSayimTarihi.Location = new System.Drawing.Point(90, 43);
            this.DTPSayimTarihi.Name = "DTPSayimTarihi";
            this.DTPSayimTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DTPSayimTarihi.Properties.DisplayFormat.FormatString = "d";
            this.DTPSayimTarihi.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.DTPSayimTarihi.Properties.MaskSettings.Set("mask", "dd.MM.yyyy HH:mm");
            this.DTPSayimTarihi.Properties.Padding = new System.Windows.Forms.Padding(3);
            this.DTPSayimTarihi.Size = new System.Drawing.Size(143, 26);
            this.DTPSayimTarihi.TabIndex = 8;
            // 
            // FStokSayim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 629);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FStokSayim";
            this.Text = "FStokSayim";
            this.Load += new System.EventHandler(this.FStokSayim_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTPSayimTarihi.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private GroupBox groupBox1;
        private Button BTSayimSil;
        private Button BTSayimGuncelle;
        private Button BTSayimKaydet;
        private TextBox TBAciklama;
        private Label label2;
        private Label label1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.DateTimeOffsetEdit DTPSayimTarihi;
    }
}