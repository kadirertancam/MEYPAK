using DevExpress.XtraEditors;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.Models.FORMYETKI;
using MEYPAK.Entity.PocoModels.CARI;
using MEYPAK.Entity.PocoModels.CEKSENET;
using MEYPAK.PRL.CARI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEYPAK.PRL.CEKSENET.Müşteri.Çek
{
    public partial class FMusteriCekTeminat : XtraForm
    {
        public FMusteriCekTeminat()
        {
            InitializeComponent();
        }
        #region TANIM
        FCariList _cariListe;
        FMusteriCekListe fMusteriCekListe;

        public PocoCARIKART _tempCari;
        public PocoMUSTERICEKSB _tempCek;
        List<PocoMUSTERICEKSB> _tempCariListe = new List<PocoMUSTERICEKSB>();
        GenericWebServis<PocoMUSTERICEKSB> _musteriCekServis = new GenericWebServis<PocoMUSTERICEKSB>();
        GenericWebServis<PocoMUSTERICEKHAR> _musteriCekHARServis = new GenericWebServis<PocoMUSTERICEKHAR>();
        GenericWebServis<PocoCARIHAR> _cariHarServis = new GenericWebServis<PocoCARIHAR>();
        GenericWebServis<PocoCEKSENETUSTSB> _cekSenetUstSBServis = new GenericWebServis<PocoCEKSENETUSTSB>();
        #endregion
        #region METHODS
        void FormuTemizle()
        {
            _tempCari = null;
            _tempCariListe.Clear();
            _tempCek = null;
            DGMCekTeminat.DataSource = "";
        }
        void CariDoldur()
        {
            if (_tempCari != null)
            {
                BTCariSec.Text = _tempCari.kod;
                TBCariAdi.Text = _tempCari.unvan;
            }
        }
        void GridiDoldur()
        {
            DGMCekTeminat.DataSource = _tempCariListe.Select(x => new
            {
                x.BORDRONO,
                x.CEKNO,
                x.TUTAR,
                x.ODEMETARIH,

            });
        }


        #endregion

        private void BTCekSec_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            _tempCek = null;
            fMusteriCekListe = new FMusteriCekListe(this.Tag.ToString(), "FMusteriCekTeminat");
            fMusteriCekListe.ShowDialog();

            if (_tempCek != null && !_tempCariListe.Any(x => x.id == _tempCek.id))
            {
                _tempCariListe.Add(_tempCek);
                GridiDoldur();
            }
        }

        private void BTKaldir_Click(object sender, EventArgs e)
        {
            if (_tempCek != null && _tempCariListe.Any(x => x.id == _tempCek.id))
            {
                DialogResult dialogResult = new DialogResult();
                dialogResult = MessageBox.Show($"{_tempCek.CEKNO} Numaralı çeki çıkarmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    _tempCariListe.Remove(_tempCek);
                    GridiDoldur();
                }

            }
        }

        private void BTKaydet_Click(object sender, EventArgs e)
        {
            if (MPKullanici.YetkiGetir(AllForms.MUSTERICEKTEMINAT.ToString()).EKLE==true)
            {

          
            if (_tempCari != null)
            {
                if (_tempCariListe.Count() > 0)
                {
                    _cekSenetUstSBServis.Data(ServisList.CekSenetUstSBListeServis);
                    _cekSenetUstSBServis.Data(ServisList.CekSenetUstSBEkleServis, new PocoCEKSENETUSTSB()
                    {
                        BORDROTIP = 3,
                        BORDRONO = _cekSenetUstSBServis.obje.Count() > 0 ? (Convert.ToInt32(_cekSenetUstSBServis.obje.LastOrDefault().BORDRONO) + 1).ToString() : "10000000",
                        CARIID = _tempCari.id,
                        TOPLAM = _tempCariListe.Sum(x => x.TUTAR),
                        userid = MPKullanici.ID
                    });

                    foreach (PocoMUSTERICEKSB item in _tempCariListe)
                    {
                        item.ISLEM = 4;
                        item.BORDRONO = _cekSenetUstSBServis.obje2.BORDRONO;
                        item.USTID = _cekSenetUstSBServis.obje2.id;
                        item.userid = MPKullanici.ID;
                        _musteriCekServis.Data(ServisList.MusteriCekSBEkleServis, item);

                        _musteriCekHARServis.Data(ServisList.MusteriCekHarEkleServis, new PocoMUSTERICEKHAR()
                        {
                            CEKID = item.id,
                            TARIH = Convert.ToDateTime(DTTarih.Text),
                            CARID = _tempCari.id,
                            ISLEM = 4,
                            userid = MPKullanici.ID
                        });
                    }
                    _cariHarServis.Data(ServisList.CariHarEkleServis, new PocoCARIHAR()
                    {
                        cariid = _tempCari.id,
                        harekettipi = 8,
                        tutar = _tempCariListe.Sum(x => x.TUTAR),
                        belgE_NO = _cekSenetUstSBServis.obje2.BORDRONO,
                        harekettarihi = Convert.ToDateTime(DTTarih.Text),
                        userid = MPKullanici.ID
                    });
                    MessageBox.Show($"{_tempCariListe.Count} adet {_tempCariListe.Sum(x => x.TUTAR)} toplam tutarlı çekler {_cekSenetUstSBServis.obje2.BORDRONO} Bordro numarası ile {_tempCari.unvan} ünvanlı cari ye ciro edilmiştir.");
                    FormuTemizle();
                }
                else
                    MessageBox.Show("Çek eklemeden Teminat yapamazsınız!");
            }
            else
                MessageBox.Show("Cari Seçmeden Teminat yapamazsınız!");
            }
            else
                MessageBox.Show(MPKullanici.hata);
        }

        private void BTCariSec_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            _cariListe = new FCariList(this.Tag.ToString(), "FMusteriCekTeminat");
            _cariListe.ShowDialog();

            CariDoldur();
        }
    }
}
