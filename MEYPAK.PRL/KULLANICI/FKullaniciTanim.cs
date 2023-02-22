using DevExpress.XtraEditors;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.IdentityModels;
using MEYPAK.Entity.PocoModels.FORMYETKI;
using MEYPAK.PRL.Assets;
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
    public partial class FKullaniciTanim : XtraForm
    {
        public FKullaniciTanim()
        {
            InitializeComponent();
            userServis = new GenericWebServis<MPUSER>();
            _formServis = new GenericWebServis<PocoFORM>();
            _formYetkiServis = new GenericWebServis<PocoFORMYETKI>();
            registerModel = new GenericWebServis<RegisterModel>();
            _passwordServis = new GenericWebServis<PasswordChangeModel>();
        }
        GenericWebServis<MPUSER> userServis;
        GenericWebServis<PocoFORM> _formServis;
        GenericWebServis<RegisterModel> registerModel;
        GenericWebServis<PocoFORMYETKI> _formYetkiServis;
        GenericWebServis<PasswordChangeModel> _passwordServis;
        List<FormYetkiKalem> pocoFORMYETKIs = new List<FormYetkiKalem>();
        MPUSER tempuser;
        #region METHODS
        void YETKIGRIDDOLDUR()
        {
            _formYetkiServis.Data(ServisList.FormYetkiListeServis);
            pocoFORMYETKIs.Clear();
            foreach (var item in _formServis.obje)
            {
                if (_formYetkiServis.obje.Where(x => x.FORMID == item.id && x.KULLANICIID == tempuser.Id).Count() == 0)
                    pocoFORMYETKIs.Add(new FormYetkiKalem() { FORMADI = item.FORMADI, KULLANICI = tempuser.AD + " " + tempuser.SOYAD });
                else
                {
                    PocoFORMYETKI formYetki = _formYetkiServis.obje.Where(x => x.FORMID == item.id && x.KULLANICIID == tempuser.Id).FirstOrDefault();
                    pocoFORMYETKIs.Add(new FormYetkiKalem() { FORMADI = item.FORMADI, GORUNTULE = formYetki.GORUNTULE, EKLE = formYetki.EKLE, SIL = formYetki.SIL, GUNCELLE = formYetki.GUNCELLE, KULLANICI = tempuser.AD + " " + tempuser.SOYAD });
                }

            }

            GCKullaniciYetki.RefreshDataSource();
        }

        void KULLANICIDOLDUR()
        {
            if (tempuser != null && tempuser.Id != "")
            {
                TBAD.Text = tempuser.AD;
                TBSOYAD.Text = tempuser.SOYAD;
                TBUSERNAME.Text = tempuser.UserName;
                TBEPOSTA.Text = tempuser.Email;
                TBTelefon.Text = tempuser.PhoneNumber;
                YETKIGRIDDOLDUR();
            }
        }

        void KullaniciTemizle()
        {
            tempuser = null;
            foreach (Control ctrl in groupControl1.Controls)
            {
                if (ctrl is TextEdit)
                {
                    ctrl.Text = "";
                }
            }
            pocoFORMYETKIs.Clear();
            GCKullaniciYetki.RefreshDataSource();
        }

        void KullaniciGetir()
        {
            userServis.Data(ServisList.UserGetServis);
            GCKullanici.DataSource = userServis.obje.Select(x => new
            {
                x.Id,
                x.AD,
                x.SOYAD,
                KULLANICIADI = x.UserName,
                EMAIL = x.Email,
            });
            gridView1.Columns["Id"].Visible = false;
        }
        #endregion
        private void FKullaniciTanim_Load(object sender, EventArgs e)
        {
            if (!MPKullanici.Roller.Contains("ADMIN"))
            {
                MessageBox.Show("Bu Sayfaya Erişim Yetkiniz Bulunmamaktadır!");
                this.Close();
            }
            else
            {

                _formServis.Data(ServisList.FormListeServis);

                KullaniciGetir();

                GCKullaniciYetki.DataSource = pocoFORMYETKIs;
            }
        }



        private void GCKullanici_DoubleClick(object sender, EventArgs e)
        {
            tempuser = userServis.obje.Where(x => x.Id == gridView1.GetFocusedRowCellValue("Id").ToString()).FirstOrDefault();
            KULLANICIDOLDUR();
        }


        private void BTNPersonelKaydet_Click(object sender, EventArgs e)
        {
            if (tempuser != null && tempuser.Id != "")
            {
                userServis.Data(ServisList.UserGetServis);
                if (userServis.obje.Where(x => x.UserName == TBUSERNAME.Text && x.Id == tempuser.Id).Count() == 0 && userServis.obje.Where(x => x.Email == TBEPOSTA.Text && x.Id == tempuser.Id).Count() == 0)
                {

                    DialogResult dialogResult = new DialogResult();
                    dialogResult = MessageBox.Show($"{tempuser.AD + " " + tempuser.SOYAD} isimli kullanıcının bilgilerini güncellemek istediğinize emin misiniz?", "Kullanıcı Bilgilerini Güncelleme", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        if (TBAD.Text != tempuser.AD || TBSOYAD.Text != tempuser.SOYAD || TBTelefon.Text != tempuser.PhoneNumber || TBUSERNAME.Text != tempuser.UserName || TBEPOSTA.Text != tempuser.Email)
                        {
                            tempuser.AD = TBAD.Text;
                            tempuser.SOYAD = TBSOYAD.Text;
                            tempuser.UserName = TBUSERNAME.Text;
                            tempuser.Email = TBEPOSTA.Text;
                            tempuser.PhoneNumber = TBTelefon.Text;

                            userServis.Data(ServisList.UserUpdateServis, tempuser);
                        }
                        if (TBPAROLA.Text != "")
                            if (TBPAROLA.Text.Length > 5 && TBPAROLA.Text == TBPARALOTKR.Text)
                            {
                                _passwordServis.Data(ServisList.UserPasswordAddServis, new PasswordChangeModel()
                                {
                                    user = tempuser,
                                    password = TBPAROLA.Text
                                });
                            }
                            else
                                MessageBox.Show("Parola uzunluğu 5 karakterden fazla ve tekrarıyla eşleşmelidir!");



                        _formYetkiServis.Data(ServisList.FormYetkiListeServis);

                        foreach (FormYetkiKalem item in pocoFORMYETKIs)
                        {
                            if (item.GORUNTULE || item.EKLE || item.SIL || item.GUNCELLE)
                            {
                                _formYetkiServis.Data(ServisList.FormYetkiEkleServis, new PocoFORMYETKI()
                                {
                                    id = _formYetkiServis.obje.Where(x => x.FORMID == (_formServis.obje.Where(x => x.FORMADI == item.FORMADI).FirstOrDefault().id) && x.KULLANICIID == tempuser.Id).Count() > 0 ? _formYetkiServis.obje.Where(x => x.FORMID == (_formServis.obje.Where(x => x.FORMADI == item.FORMADI).FirstOrDefault().id) && x.KULLANICIID == tempuser.Id).FirstOrDefault().id : 0,
                                    FORMID = _formServis.obje.Where(x => x.FORMADI == item.FORMADI).FirstOrDefault().id,
                                    GORUNTULE = item.GORUNTULE,
                                    EKLE = item.EKLE,
                                    GUNCELLE = item.GUNCELLE,
                                    SIL = item.SIL,
                                    KULLANICIID = tempuser.Id,
                                    userid = MPKullanici.ID

                                });
                            }
                            else if (_formYetkiServis.obje.Where(x => x.FORMID == _formServis.obje.Where(y => y.FORMADI == item.FORMADI).FirstOrDefault().id && x.KULLANICIID == tempuser.Id).Count() > 0)
                                _formYetkiServis.Data(ServisList.FormYetkiSilServis, modellist: _formYetkiServis.obje.Where(x => x.FORMID == _formServis.obje.Where(y => y.FORMADI == item.FORMADI).FirstOrDefault().id && x.KULLANICIID == tempuser.Id).ToList());

                        }
                        MessageBox.Show($"{tempuser.AD + " " + tempuser.SOYAD} isimli kullanıcının bilgileri Başarıyla Güncellendi");
                        KullaniciTemizle();
                    }
                }
                else
                    MessageBox.Show("Kullanıcı adı veya eposta zaten kullanılıyor!");
            }
            else
            {
                if (TBAD.Text != "" && TBSOYAD.Text != "" && TBEPOSTA.Text != "" && TBUSERNAME.Text != "" && TBPAROLA.Text != "" && TBPARALOTKR.Text != "")
                {
                    userServis.Data(ServisList.UserGetServis);
                    if (userServis.obje.Where(x => x.UserName == TBUSERNAME.Text).Count() == 0 && userServis.obje.Where(x => x.Email == TBEPOSTA.Text).Count() == 0)
                    {
                        if (TBPAROLA.Text.Length > 5 && TBPAROLA.Text == TBPARALOTKR.Text)
                        {
                            DialogResult dialogResult = new DialogResult();
                            dialogResult = MessageBox.Show($"{TBAD.Text + " " + TBSOYAD} isimli yeni bir kullanıcı eklemek istediğinize emin misiniz?", "Yeni Kullanıcı Ekleme", MessageBoxButtons.YesNo);

                            if (dialogResult == DialogResult.Yes)
                            {
                                registerModel.Data(ServisList.UserEkleServis, new RegisterModel()
                                {
                                    Ad = TBAD.Text,
                                    Soyad = TBSOYAD.Text,
                                    Email = TBEPOSTA.Text,
                                    Password = TBPAROLA.Text,
                                    UserName = TBUSERNAME.Text,
                                    Telefon = TBTelefon.Text
                                });
                                userServis.Data(ServisList.UserGetServis);
                                tempuser = userServis.obje.Where(x => x.AD == TBAD.Text && x.SOYAD == TBSOYAD.Text && x.Email == TBEPOSTA.Text && x.PhoneNumber == TBTelefon.Text).FirstOrDefault();
                                foreach (FormYetkiKalem item in pocoFORMYETKIs)
                                {
                                    if (item.GORUNTULE || item.EKLE || item.SIL || item.GUNCELLE)
                                    {
                                        _formYetkiServis.Data(ServisList.FormYetkiEkleServis, new PocoFORMYETKI()
                                        {
                                            FORMID = _formServis.obje.Where(x => x.FORMADI == item.FORMADI).FirstOrDefault().id,
                                            GORUNTULE = item.GORUNTULE,
                                            EKLE = item.EKLE,
                                            GUNCELLE = item.GUNCELLE,
                                            SIL = item.SIL,
                                            KULLANICIID = tempuser.Id,
                                            userid = MPKullanici.ID
                                        });
                                    }
                                }
                                MessageBox.Show($"{tempuser.AD + " " + tempuser.SOYAD} isimli kullanıcının bilgileri Başarıyla Güncellendi");
                                KullaniciTemizle();
                            }
                        }
                        else
                            MessageBox.Show("Parola uzunluğu 5 karakterden fazla ve tekrarıyla eşleşmelidir!");
                    }
                    else
                        MessageBox.Show("Kullanıcı adı veya eposta zaten kullanılıyor!");
                }
                else
                    MessageBox.Show("Gerekli alanları doldurmanız gerekmelidir!");
            }
        }

        private void BTNTemizle_Click(object sender, EventArgs e)
        {
            KullaniciTemizle();
        }
    }
}
