using DevExpress.XtraEditors;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.CARI;
using MEYPAK.Entity.PocoModels.CEKSENET;
using MEYPAK.Interfaces.Cari;
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
    public partial class FMusteriCekProtesto : XtraForm
    {
        public FMusteriCekProtesto()
        {
            InitializeComponent();
        }
        FMusteriCekListe fMusteriCekListe;


        public PocoMUSTERICEKSB _tempCek;
        List<PocoMUSTERICEKSB> _tempCariListe = new List<PocoMUSTERICEKSB>();
        GenericWebServis<PocoMUSTERICEKSB> _musteriCekServis = new GenericWebServis<PocoMUSTERICEKSB>();
        GenericWebServis<PocoMUSTERICEKHAR> _musteriCekHARServis = new GenericWebServis<PocoMUSTERICEKHAR>();
        GenericWebServis<PocoCEKSENETUSTSB> _cekSenetUstSBServis = new GenericWebServis<PocoCEKSENETUSTSB>();
        void GridiDoldur()
        {
            DGMCekProtesto.DataSource = _tempCariListe.Select(x => new
            {
                x.BORDRONO,
                x.CEKNO,
                x.TUTAR,
                x.ODEMETARIH,

            });
        }
        void FormuTemizle()
        {
            _tempCariListe.Clear();
            _tempCek = null;
            DGMCekProtesto.DataSource = "";
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

        private void BTCekSec_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            _tempCek = null;
            fMusteriCekListe = new FMusteriCekListe(this.Tag.ToString(), "FMusteriCekProtesto");
            fMusteriCekListe.ShowDialog();

            if (_tempCek != null && !_tempCariListe.Any(x => x.id == _tempCek.id))
            {
                _tempCariListe.Add(_tempCek);
                GridiDoldur();
            }
        }

        private void BTKaydet_Click(object sender, EventArgs e)
        {
            if (_tempCariListe.Count() > 0)
            {
                _cekSenetUstSBServis.Data(ServisList.CekSenetUstSBListeServis);
                _cekSenetUstSBServis.Data(ServisList.CekSenetUstSBEkleServis, new PocoCEKSENETUSTSB()
                {
                    BORDROTIP = 1,
                    BORDRONO = _cekSenetUstSBServis.obje.Count() > 0 ? (Convert.ToInt32(_cekSenetUstSBServis.obje.LastOrDefault().BORDRONO) + 1).ToString() : "10000000",
                    TOPLAM = _tempCariListe.Sum(x => x.TUTAR),
                    userid = MPKullanici.ID
                });

                foreach (PocoMUSTERICEKSB item in _tempCariListe)
                {
                    item.ISLEM = 2;
                    item.BORDRONO = _cekSenetUstSBServis.obje2.BORDRONO;
                    item.USTID = _cekSenetUstSBServis.obje2.id;
                    item.userid = MPKullanici.ID;
                    _musteriCekServis.Data(ServisList.MusteriCekSBEkleServis, item);

                    _musteriCekHARServis.Data(ServisList.MusteriCekHarEkleServis, new PocoMUSTERICEKHAR()
                    {
                        CEKID = item.id,
                        TARIH = Convert.ToDateTime(DTTarih.Text),
                        ISLEM = 2,
                        userid = MPKullanici.ID
                    });
                }

                MessageBox.Show($"{_tempCariListe.Count} adet {_tempCariListe.Sum(x => x.TUTAR)} toplam tutarlı çekler {_cekSenetUstSBServis.obje2.BORDRONO} Bordro numarası ile protesto edilmiştir.");
                FormuTemizle();
            }
            else
                MessageBox.Show("Çek eklemeden Ciro edemezsiniz!");
        }
    }
}
