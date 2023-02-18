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
        }
        GenericWebServis<MPUSER> userServis;
        GenericWebServis<PocoFORM> _formServis;
        GenericWebServis<RegisterModel> registerModel;
        GenericWebServis<PocoFORMYETKI> _formYetkiServis;
        List<FormYetkiKalem> pocoFORMYETKIs = new List<FormYetkiKalem>();
        MPUSER tempuser;
        #region EVENTS
        void YETKIGRIDDOLDUR()
        {
            pocoFORMYETKIs.Clear();
            foreach (var item in _formServis.obje)
            {
                pocoFORMYETKIs.Add(new FormYetkiKalem() { FORMADI = item.FORMADI, KULLANICI = tempuser.AD + " " + tempuser.SOYAD });
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
            if (tempuser != null && tempuser.Id!="")
            {
                DialogResult dialogResult = new DialogResult();
                dialogResult = MessageBox.Show($"{tempuser.AD + " " + tempuser.SOYAD} isimli kullanıcının bilgilerini güncellemek istediğinize emin misiniz?", "Kullanıcı Bilgilerini Güncelleme", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {

                    tempuser.AD = TBAD.Text;
                    tempuser.SOYAD = TBSOYAD.Text;
                    tempuser.UserName = TBUSERNAME.Text;
                    tempuser.Email = TBEPOSTA.Text;
                    tempuser.PhoneNumber = TBTelefon.Text;
                    userServis.Data(ServisList.UserUpdateServis, tempuser);
                    userServis.Data(ServisList.UserPasswordRemoveServis, tempuser);
                    userServis.Data(ServisList.UserGetServis);
                    tempuser =userServis.obje.Where(x => x.Id == tempuser.Id).FirstOrDefault();
                    userServis.Data(ServisList.UserPasswordAddServis,tempuser,parameters: $"password={TBPAROLA.Text}");

                    _formYetkiServis.Data(ServisList.FormYetkiListeServis);

                    foreach (FormYetkiKalem item in pocoFORMYETKIs)
                    {
                        if (item.GORUNTULE || item.EKLE || item.SIL || item.GUNCELLE)
                        {
                            _formYetkiServis.Data(ServisList.FormYetkiEkleServis, new PocoFORMYETKI()
                            {
                                id = _formYetkiServis.obje.Where(x => x.FORMID == (_formServis.obje.Where(x => x.FORMADI == item.FORMADI).FirstOrDefault().id) && x.USERID == tempuser.Id).Count() > 0 ? _formYetkiServis.obje.Where(x => x.FORMID == (_formServis.obje.Where(x => x.FORMADI == item.FORMADI).FirstOrDefault().id) && x.USERID == tempuser.Id).FirstOrDefault().id : 0,
                                FORMID = _formServis.obje.Where(x => x.FORMADI == item.FORMADI).FirstOrDefault().id,
                                GORUNTULE = item.GORUNTULE,
                                EKLE = item.EKLE,
                                GUNCELLE = item.GUNCELLE,
                                SIL = item.SIL,
                                USERID = tempuser.Id,
                                userid = MPKullanici.ID

                            });
                        }
                        else if (_formYetkiServis.obje.Where(x => x.FORMID == (_formServis.obje.Where(x => x.FORMADI == item.FORMADI).FirstOrDefault().id) && x.USERID == tempuser.Id).Count() > 0)
                            _formYetkiServis.Data(ServisList.FormYetkiDeleteByIdServis, id: _formYetkiServis.obje.Where(x => x.FORMID == (_formServis.obje.Where(x => x.FORMADI == item.FORMADI).FirstOrDefault().id) && x.USERID == tempuser.Id).FirstOrDefault().id.ToString());

                    }
                }
            }
            else
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
                      tempuser = userServis.obje.Where(x=>x.AD==TBAD.Text&&x.SOYAD==TBSOYAD.Text&&x.Email==TBEPOSTA.Text&& x.PhoneNumber ==TBTelefon.Text).FirstOrDefault();
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
                                USERID = tempuser.Id,
                                userid = MPKullanici.ID

                            });
                        }
                    }
                }
            }
        }

        private void BTNTemizle_Click(object sender, EventArgs e)
        {
            KullaniciTemizle();
        }
    }
}
