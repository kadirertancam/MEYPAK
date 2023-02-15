using DevExpress.XtraEditors;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.CARI;
using MEYPAK.Entity.PocoModels.CEKSENET;
using MEYPAK.PRL.CARI;
using MEYPAK.PRL.CEKSENET.Müşteri.Çek;
using MEYPAK.PRL.CEKSENET.Müşteri.Senet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEYPAK.PRL.CEKSENET
{
    public partial class FMusteriSenetCariCiro : XtraForm
    {
        public FMusteriSenetCariCiro()
        {
            InitializeComponent();
        }
        #region TANIM
        FCariList _cariListe;
        FMusteriSenetListe fMusteriCekListe;

        public PocoCARIKART _tempCari;
        public PocoMUSTERISENETSB _tempCek;
        List<PocoMUSTERISENETSB> _tempCariListe = new List<PocoMUSTERISENETSB>();
        GenericWebServis<PocoMUSTERISENETSB>  _musteriSenetServis = new GenericWebServis<PocoMUSTERISENETSB>();
        GenericWebServis<PocoMUSTERISENETHAR> _musteriSenetHARServis = new GenericWebServis<PocoMUSTERISENETHAR>();
        GenericWebServis<PocoCARIHAR> _cariHarServis = new GenericWebServis<PocoCARIHAR>();
        GenericWebServis<PocoCEKSENETUSTSB> _cekSenetUstSBServis = new GenericWebServis<PocoCEKSENETUSTSB>();
        #endregion
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
            DGMSenetCiro.DataSource = _tempCariListe.Select(x => new
            {
                x.BORDRONO,
                x.SENETNO,
                x.TUTAR,
                x.ODEMETARIHI,

            });
        }
        void FormuTemizle()
        {
            _tempCari = null;
            _tempCariListe.Clear();
            _tempCek = null;
            DGMSenetCiro.DataSource = "";
        }

        private void BTCariSec_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            _cariListe = new FCariList(this.Tag.ToString(), "FMusteriSenetCariCiro");
            _cariListe.ShowDialog();

            CariDoldur();
        }

        private void BTCekSec_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            _tempCek = null;
            fMusteriCekListe = new FMusteriSenetListe(this.Tag.ToString(), "FMusteriSenetCariCiro");
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
                dialogResult = MessageBox.Show($"{_tempCek.SENETNO} Numaralı seneti çıkarmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    _tempCariListe.Remove(_tempCek);
                    GridiDoldur();
                }

            }
        }

        private void BTKaydet_Click(object sender, EventArgs e)
        {
            if (_tempCari != null)
            {
                if (_tempCariListe.Count() > 0)
                {
                    _cekSenetUstSBServis.Data(ServisList.CekSenetUstSBListeServis);
                    _cekSenetUstSBServis.Data(ServisList.CekSenetUstSBEkleServis, new PocoCEKSENETUSTSB()
                    {
                        BORDROTIP = 4,
                        BORDRONO = _cekSenetUstSBServis.obje.Count() > 0 ? (Convert.ToInt32(_cekSenetUstSBServis.obje.LastOrDefault().BORDRONO) + 1).ToString() : "10000000",
                        CARIID = _tempCari.id,
                        TOPLAM = _tempCariListe.Sum(x => x.TUTAR),
                        userid = MPKullanici.ID
                    });

                    foreach (PocoMUSTERISENETSB item in _tempCariListe)
                    {
                        item.ISLEM = 1;
                        item.BORDRONO = _cekSenetUstSBServis.obje2.BORDRONO;
                        item.USTID = _cekSenetUstSBServis.obje2.id;
                        item.userid = MPKullanici.ID;
                        _musteriSenetServis.Data(ServisList.MusteriSenetSBEkleServis, item);

                        _musteriSenetHARServis.Data(ServisList.MusteriSenetHarEkleServis, new PocoMUSTERISENETHAR()
                        {
                            SENETID = item.id,
                            TARIH = Convert.ToDateTime(DTTarih.Text),
                            CARIID = _tempCari.id,
                            ISLEM = 1,
                            userid = MPKullanici.ID
                        });
                    }
                    _cariHarServis.Data(ServisList.CariHarEkleServis, new PocoCARIHAR()
                    {
                        cariid = _tempCari.id,
                        harekettipi = 6,
                        tutar = _tempCariListe.Sum(x => x.TUTAR),
                        belgE_NO = _cekSenetUstSBServis.obje2.BORDRONO,
                        harekettarihi = Convert.ToDateTime(DTTarih.Text),
                        userid = MPKullanici.ID
                    });
                    MessageBox.Show($"{_tempCariListe.Count} adet {_tempCariListe.Sum(x => x.TUTAR)} toplam tutarlı senetler {_cekSenetUstSBServis.obje2.BORDRONO} Bordro numarası ile {_tempCari.unvan} ünvanlı cari ye ciro edilmiştir.");
                    FormuTemizle();
                }
                else
                    MessageBox.Show("Senet eklemeden Ciro edemezsiniz!");
            }
            else
                MessageBox.Show("Cari Seçmeden Ciro edemezsiniz!");
        }
    }
}
