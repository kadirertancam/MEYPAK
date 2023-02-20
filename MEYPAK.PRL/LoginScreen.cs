using MEYPAK.BLL.Assets;
using MEYPAK.Entity.IdentityModels;
using MEYPAK.PRL.CEKSENET.Firma.Çek;
using MEYPAK.PRL.PERSONEL;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEYPAK.PRL
{
    public partial class LoginScreen : Form
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
                    
                    fMain = new Main(_loginService.loginResult.MPUSER, _loginService.loginResult.userRoles);
                    fMain.Show();
                    //FirmaCekListe firmaCekListe = new FirmaCekListe();
                    //firmaCekListe.ShowDialog();
                    //maas = new FPersonelMaas();
                    //maas.ShowDialog();
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
    }
}
