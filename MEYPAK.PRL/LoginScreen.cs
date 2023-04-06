using DevExpress.XtraEditors;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.IdentityModels;
using MEYPAK.PRL.CEKSENET.Firma.Çek;
using MEYPAK.PRL.DEKONT;
using MEYPAK.PRL.PERSONEL;
using MEYPAK.PRL.STOK;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace MEYPAK.PRL
{
    public partial class LoginScreen : XtraForm
    {
        public LoginScreen()
        {
            InitializeComponent();
            _loginService = new GenericWebServis<LoginModel>();
           
        }
        Main fMain;
        GenericWebServis<LoginModel> _loginService;
        FPersonelMaas maas;
        

        private void BTNGiris_Click(object sender, EventArgs e)
        {
            try
            {
                _loginService.Data(ServisList.UserLoginServis, new LoginModel()
                {
                    Email = TBEmail.Text,
                    Password = TBSifre.Text,
                    RememberMe = true,
                });

                if (_loginService.loginResult !=null)
                {
                    //FPersonelMaas maas = new FPersonelMaas();
                    ////maas.Show();
                    //FFATURASTOKOLCUESLE ff = new FFATURASTOKOLCUESLE();
                    //ff.Show();
                    fMain = new Main(_loginService.loginResult.MPUSER, _loginService.loginResult.userRoles);
                    fMain.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Giriş Yapılamadı Tekrar Deneyin!");

            }
            catch (Exception)
            {
                MessageBox.Show("Giriş Yapılamadı Tekrar Deneyin!");
            }

        }

        private void TBSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)Keys.Enter)
            {
                BTNGiris_Click(sender, e);
            }
        }
     
        private void LoginScreen_Load(object sender, EventArgs e)
        {
            //player = new MpvPlayer(this.Handle)
            //{
            //    Loop = false,
            //    Volume = 50
            //};
            //player.Load(@"C:\Users\User\Desktop\Yeni klasör (14)\shutterstock_1063987486.mov");
            //player.Resume();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
            if(MessageBox.Show("Çıkış yapmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
