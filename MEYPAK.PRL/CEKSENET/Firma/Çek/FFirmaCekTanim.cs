using DevExpress.XtraEditors;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.CARI;
using MEYPAK.Entity.PocoModels.CEKSENET;
using MEYPAK.Interfaces.Cari;
using MEYPAK.PRL.Assets;
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

namespace MEYPAK.PRL.CEKSENET
{
    public partial class FFirmaCekTanim : XtraForm
    {
        public FFirmaCekTanim()
        {
            InitializeComponent();
            _firmaCekServis = new GenericWebServis<PocoFIRMACEKSB>();
            _cariKartServis = new GenericWebServis<PocoCARIKART>();
            firmaCekKalem = new List<firmaCekKalem>();
            _cekSenetUstSbServis = new GenericWebServis<PocoCEKSENETUSTSB>();
            _cariAltHesServis = new GenericWebServis<PocoCARIALTHES>();
            _cariAltHesCariServis = new GenericWebServis<PocoCARIALTHESCARI>();
        }
        GenericWebServis<PocoFIRMACEKSB> _firmaCekServis;
        GenericWebServis<PocoCARIKART> _cariKartServis;
        GenericWebServis<PocoCARIALTHES> _cariAltHesServis;
        GenericWebServis<PocoCARIALTHESCARI> _cariAltHesCariServis;
        GenericWebServis<PocoCEKSENETUSTSB> _cekSenetUstSbServis;
        PocoFIRMACEKSB _tempFirmaCek;
        List<firmaCekKalem> firmaCekKalem;
        FCariList _cariListe;
        public PocoCARIKART tempCari;
        private void BTKaydet_Click(object sender, EventArgs e)
        {
            _firmaCekServis.Data(ServisList.FirmaCekSBListeServis);
            _cariKartServis.Data(ServisList.CariListeServis);

            _cekSenetUstSbServis.Data(ServisList.CekSenetUstSBEkleServis, new PocoCEKSENETUSTSB()
            {
                //BORDROTIP=BTBordroSec.Text,
                //ADET= firmaCekKalem.Count,
                //ALTHESAPID=int.Parse(CBAltHesap.EditValue.ToString()), 
                //CARIID = _cariKartServis.obje.Where(x => x.kod == BTCariSec.Text).FirstOrDefault().id,
                

            });


            foreach (var item in firmaCekKalem)
            {

                
                _tempFirmaCek = new PocoFIRMACEKSB()
                {
                    BORDRONO = int.Parse(BTBordroSec.Text),
                    CARIID = _cariKartServis.obje.Where(x => x.kod == BTCariSec.Text).FirstOrDefault().id,
                    VADETARIH = item.VADETARIHI,
                    BANKA = item.BANKA,
                    SUBE = item.SUBE,
                    ACIKLAMA1 = item.ACIKLAMA1,
                    ACIKLAMA2 = item.ACIKLAMA2,
                    CEKNO = item.CEKNO,
                    HESAPNO = item.HESAPNO,
                    IBANNO=item.IBAN,
                    DOVIZID=item.DOVIZCINSI,
                    DOVIZTUTAR=item.DOVIZTUTAR,
                    CIKISTARIH=item.TARIH,
                    TUTAR=item.TUTAR,
                    KUR=0,
                    
                
            };
            }
        }

        void gridYapilandir()
        {
            firmaCekKalem.Add(new Assets.firmaCekKalem()
            {
                SIRA = 1,
                TARIH = DateTime.Now,
            });
            DGFirmaCek.DataSource = firmaCekKalem;
        }

        private void FFirmaCekTanim_Load(object sender, EventArgs e)
        {
            gridYapilandir();
            DTTarih.EditValue = DateTime.Now;
            CBAltHesap.Properties.DisplayMember = "adi";
            CBAltHesap.Properties.ValueMember = "id";
        }

        private void gridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Down)
            {
                firmaCekKalem.Add(new firmaCekKalem()
                {
                    SIRA = firmaCekKalem.LastOrDefault().SIRA + 1,
                    TARIH = DateTime.Now
                });
                DGFirmaCek.RefreshDataSource();
            }
        }

        private void BTCariSec_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            _cariListe = new FCariList(this.Tag.ToString(), "FFirmaCekTanim");
            _cariListe.ShowDialog();
            BTCariSec.Text = tempCari.kod;
            TBCariAdi.Text = tempCari.unvan;
            _cariAltHesServis.Data(ServisList.CariAltHesListeServis);
            _cariAltHesCariServis.Data(ServisList.CariAltHesCariListeServis);
            var tempp = from test in _cariAltHesCariServis.obje
                        join test2 in _cariAltHesServis.obje on test.carialthesid equals test2.id
                        where test.cariid == tempCari.id
                        select new { test2.id,test2.adi};

            CBAltHesap.Properties.DataSource = tempp;

        }
    }
}
