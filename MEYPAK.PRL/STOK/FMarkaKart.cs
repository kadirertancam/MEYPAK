﻿using DevExpress.XtraEditors;
using MEYPAK.BLL.Assets;
using MEYPAK.BLL.STOK;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.DAL.Concrete.EntityFramework.Repository;
using MEYPAK.Entity.Models.FORMYETKI;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Depo;
using MEYPAK.Interfaces.Stok;
using MEYPAK.PRL.Assets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEYPAK.PRL.STOK
{
    public partial class FMarkaKart : XtraForm
    {
        public FMarkaKart()
        {
            InitializeComponent();
            _markaServis = new GenericWebServis<PocoSTOKMARKA>();
        }
        #region Tanımlar
        GenericWebServis<PocoSTOKMARKA> _markaServis;
        PocoSTOKMARKA _tempMarka;
        int id = 0;
        #endregion

        #region Methodlar
        void MarkalarıGetir()
        {
            _markaServis.Data(ServisList.StokMarkaListeServis);
            gridControl1.DataSource = _markaServis.obje.Where(x => x.kayittipi == 0);
        }
        #endregion
        private void FMarkaKart_Load(object sender, EventArgs e)
        {
            if (this.Tag == null)
            {
                this.FormBorderStyle = FormBorderStyle.Fixed3D;
            }

            MarkalarıGetir();
        }



        private void BTSil_Click(object sender, EventArgs e)
        {
            if (MPKullanici.YetkiGetir(AllForms.MARKATANIM.ToString()).SIL == true)
            {
                if (_tempMarka != null && _tempMarka.id > 0)
                {
                    _markaServis.Data(ServisList.StokMarkaDeleteByIdServis, id: _tempMarka.id.ToString(), method: HttpMethod.Post);
                    Temizle(this.Controls);
                    MessageBox.Show($"{_tempMarka.adi} adlı marka başarıyla silindi!");
                    _tempMarka = null;
                    MarkalarıGetir();
                }
                else
                {
                    MessageBox.Show("Silinecek marka bulunamadı!");
                    Temizle(this.Controls);
                }

            }
            else
                MessageBox.Show(MPKullanici.hata);




            // if(_tempMarka!=null)
            // _markaServis.Data(ServisList.StokMarkaSilServis,null,"filter=ID eq"+ _tempMarka.id);
            //MarkalarıGetir();

        }


        public void Temizle(Control.ControlCollection ctrlCollection)           //Formdaki Textboxları temizle
        {
            foreach (Control ctrl in ctrlCollection)
            {
                if (ctrl is TextBoxBase)
                {
                    ctrl.Text = String.Empty;
                }
                else
                {
                    Temizle(ctrl.Controls);
                }
            }
        }

        private void BTMarkaKartKaydet_Click(object sender, EventArgs e)
        {
            if (MPKullanici.YetkiGetir(AllForms.MARKATANIM.ToString()).EKLE == true)
            {
                _markaServis.Data(ServisList.StokMarkaEkleServis, (new PocoSTOKMARKA()
                {
                    id = id,
                    adi = TBMarkaAdi.Text,
                    aciklama = TBAciklama.Text,
                    kayittipi = 0,
                    userid = MPKullanici.ID,
                }));

                MessageBox.Show("Kayıt işlemi Başarılı!");
                id = 0;
                _tempMarka = null;
                Temizle(this.Controls);
                MarkalarıGetir();
            }
            else
                MessageBox.Show(MPKullanici.hata);
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            _tempMarka = _markaServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("id").ToString()).FirstOrDefault();
            TBMarkaAdi.Text = _tempMarka.adi;
            TBAciklama.Text = _tempMarka.aciklama;
            id = _tempMarka.id;

        }
    }
}
