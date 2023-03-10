namespace MEYPAK.PRL
{
    partial class LoginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            this.TBEmail = new DevExpress.XtraEditors.TextEdit();
            this.TBSifre = new DevExpress.XtraEditors.TextEdit();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboBoxEdit2 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.BTNGiris = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.TBEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBSifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // TBEmail
            // 
            this.TBEmail.Location = new System.Drawing.Point(650, 284);
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TBEmail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TBEmail.Properties.Appearance.ForeColor = System.Drawing.Color.Silver;
            this.TBEmail.Properties.Appearance.Options.UseBackColor = true;
            this.TBEmail.Properties.Appearance.Options.UseFont = true;
            this.TBEmail.Properties.Appearance.Options.UseForeColor = true;
            this.TBEmail.Properties.NullText = "Kullanıcı Adı";
            this.TBEmail.Properties.Padding = new System.Windows.Forms.Padding(3);
            this.TBEmail.Size = new System.Drawing.Size(209, 36);
            this.TBEmail.TabIndex = 0;
            // 
            // TBSifre
            // 
            this.TBSifre.Location = new System.Drawing.Point(650, 326);
            this.TBSifre.Name = "TBSifre";
            this.TBSifre.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TBSifre.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TBSifre.Properties.Appearance.ForeColor = System.Drawing.Color.Silver;
            this.TBSifre.Properties.Appearance.Options.UseBackColor = true;
            this.TBSifre.Properties.Appearance.Options.UseFont = true;
            this.TBSifre.Properties.Appearance.Options.UseForeColor = true;
            this.TBSifre.Properties.NullText = "Şifre";
            this.TBSifre.Properties.Padding = new System.Windows.Forms.Padding(3);
            this.TBSifre.Properties.PasswordChar = '*';
            this.TBSifre.Size = new System.Drawing.Size(209, 36);
            this.TBSifre.TabIndex = 1;
            this.TBSifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBSifre_KeyPress);
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.EditValue = "GÜNDÜZ MEY-PAK";
            this.comboBoxEdit1.Location = new System.Drawing.Point(650, 200);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBoxEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Silver;
            this.comboBoxEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.comboBoxEdit1.Properties.Appearance.Options.UseFont = true;
            this.comboBoxEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Properties.Items.AddRange(new object[] {
            "GÜNDÜZ MEY-PAK",
            "ELİZ MEYPAK"});
            this.comboBoxEdit1.Properties.NullText = "Firma";
            this.comboBoxEdit1.Properties.Padding = new System.Windows.Forms.Padding(3);
            this.comboBoxEdit1.Size = new System.Drawing.Size(209, 36);
            this.comboBoxEdit1.TabIndex = 2;
            // 
            // comboBoxEdit2
            // 
            this.comboBoxEdit2.EditValue = "Merkez";
            this.comboBoxEdit2.Location = new System.Drawing.Point(650, 242);
            this.comboBoxEdit2.Name = "comboBoxEdit2";
            this.comboBoxEdit2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBoxEdit2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxEdit2.Properties.Appearance.ForeColor = System.Drawing.Color.Silver;
            this.comboBoxEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.comboBoxEdit2.Properties.Appearance.Options.UseFont = true;
            this.comboBoxEdit2.Properties.Appearance.Options.UseForeColor = true;
            this.comboBoxEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit2.Properties.Items.AddRange(new object[] {
            "ŞAŞMAZ DEPO",
            "ANTALYA DEPO",
            "MERSİN DEPO"});
            this.comboBoxEdit2.Properties.NullText = "Şube";
            this.comboBoxEdit2.Properties.Padding = new System.Windows.Forms.Padding(3);
            this.comboBoxEdit2.Size = new System.Drawing.Size(209, 36);
            this.comboBoxEdit2.TabIndex = 3;
            // 
            // BTNGiris
            // 
            this.BTNGiris.Appearance.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BTNGiris.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTNGiris.Appearance.ForeColor = System.Drawing.Color.Black;
            this.BTNGiris.Appearance.Options.UseBackColor = true;
            this.BTNGiris.Appearance.Options.UseFont = true;
            this.BTNGiris.Appearance.Options.UseForeColor = true;
            this.BTNGiris.AppearanceDisabled.BackColor = System.Drawing.Color.Lime;
            this.BTNGiris.AppearanceDisabled.Options.UseBackColor = true;
            this.BTNGiris.Location = new System.Drawing.Point(704, 399);
            this.BTNGiris.Name = "BTNGiris";
            this.BTNGiris.Size = new System.Drawing.Size(109, 35);
            this.BTNGiris.TabIndex = 4;
            this.BTNGiris.Text = "GİRİŞ YAP";
            this.BTNGiris.Click += new System.EventHandler(this.BTNGiris_Click);
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(909, 561);
            this.Controls.Add(this.BTNGiris);
            this.Controls.Add(this.comboBoxEdit2);
            this.Controls.Add(this.comboBoxEdit1);
            this.Controls.Add(this.TBSifre);
            this.Controls.Add(this.TBEmail);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.LoginScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TBEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBSifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit2.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit TBEmail;
        private DevExpress.XtraEditors.TextEdit TBSifre;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit2;
        private DevExpress.XtraEditors.SimpleButton BTNGiris;
    }
}