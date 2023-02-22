using DevExpress.XtraEditors;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.IdentityModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEYPAK.PRL.KULLANICI
{
    public partial class FKullaniciYonetim : XtraForm
    {
        public FKullaniciYonetim()
        {
            InitializeComponent();
            passwordModel = new GenericWebServis<PasswordChangeModel>();
        }
        GenericWebServis<PasswordChangeModel> passwordModel;
        private void FKullaniciYonetim_Load(object sender, EventArgs e)
        {
            LBUserAd.Text = $"{MPKullanici.USER.AD + " " + MPKullanici.USER.SOYAD}";
            LBUser.Text = 
                $"Kullanıcı Adı = {MPKullanici.USER.UserName}\n\n" +
                $"Eposta = {MPKullanici.USER.Email}";
            
            
        }
        

        private void hyperlinkLabelControl1_Click(object sender, EventArgs e)
        {
            XTPSifre.PageVisible= true ;
        }

        private void BTNPersonelKaydet_Click(object sender, EventArgs e)
        {
            if (TBMevcutParola.Text!=""&&TBParolaTekrar.Text!=""&&TBYeniParola.Text!="")
            {
                if (TBParolaTekrar.Text==TBYeniParola.Text)
                {
                    if (TBYeniParola.Text.Length>5)
                    {
                        passwordModel.Data(ServisList.UserPasswordChangeServis, new PasswordChangeModel()
                        {
                            user=new MPUSER() { Id=MPKullanici.ID,AD="",SOYAD=""},
                            password = TBYeniParola.Text,
                            oldPassword = TBMevcutParola.Text
                        });

                        if (passwordModel.Content=="")
                        {
                            MessageBox.Show("Parolanız Başarıyla Değiştirildi!");
                            TBMevcutParola.Text = "";
                            TBParolaTekrar.Text = "";
                            TBYeniParola.Text = "";
                        }
                        else
                            MessageBox.Show("Parola Değiştirilirken Hata Oluştu!\nMevcut parolanızı doğru girdiğinize emin olun!");
                    }
                    else
                        MessageBox.Show("Yeni Parolanız 5 karakterden daha uzun olmalıdır!");
                }
                else
                    MessageBox.Show("Yeni Parola ve Parola tekrarı aynı olmalı!");
            }
            else
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz!");
        }
    }
}
