using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.CARI;
using MEYPAK.Entity.PocoModels.CEKSENET;
using MEYPAK.Interfaces.Cari;
using MEYPAK.Interfaces.CekSenet;
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
            _cekSenetUstSbServis.Data(ServisList.CekSenetUstSBListeServis);
            _cariKartServis.Data(ServisList.CariListeServis);
            _firmaCekServis.Data(ServisList.FirmaCekSBListeServis);
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
        public PocoCEKSENETUSTSB tempCekSenetUstSb;
        int i = 0;
        private void BTKaydet_Click(object sender, EventArgs e)
        {
            
            _cekSenetUstSbServis.Data(ServisList.CekSenetUstSBListeServis);

            _cekSenetUstSbServis.Data(ServisList.CekSenetUstSBEkleServis, new PocoCEKSENETUSTSB()
            {
                id= tempCekSenetUstSb!=null? tempCekSenetUstSb.id:0,
                BORDROTIP = 1,
                BORDRONO = _cekSenetUstSbServis.obje.Count() > 0 ? (Convert.ToInt32(_cekSenetUstSbServis.obje.LastOrDefault().BORDRONO) + 1).ToString() : "10000000",
                ALTHESAPID = int.Parse(CBAltHesap.EditValue.ToString()),
                CARIID = _cariKartServis.obje.Where(x => x.kod == BTCariSec.Text).FirstOrDefault().id,
                TOPLAM = firmaCekKalem.Sum(x=>x.TUTAR),
                userid = MPKullanici.ID

            });


            foreach (var item in firmaCekKalem)
            {


                _firmaCekServis.Data(ServisList.FirmaCekSBEkleServis,new PocoFIRMACEKSB()
                {
                    
                    USTID = _cekSenetUstSbServis.obje2.id,
                    BORDRONO = _cekSenetUstSbServis.obje2.BORDRONO,
                    CARIID = _cariKartServis.obje.Where(x => x.kod == BTCariSec.Text).FirstOrDefault().id,
                    VADETARIH = item.VADETARIHI,
                    BANKA = item.BANKA,
                    SUBE = item.SUBE,
                    ACIKLAMA1 = item.ACIKLAMA1,
                    ACIKLAMA2 = item.ACIKLAMA2,
                    CEKNO = item.CEKNO,
                    HESAPNO = item.HESAPNO,
                    IBANNO = item.IBAN,
                    DOVIZID = item.DOVIZCINSI,
                    DOVIZTUTAR = item.DOVIZTUTAR,
                    CIKISTARIH = item.TARIH,
                    TUTAR = item.TUTAR,
                    KUR = 0,
                    userid = MPKullanici.ID
                });
            }
        }

        void gridYapilandir()
        {
            firmaCekKalem.Clear();
            i = 0;
            if (tempCekSenetUstSb==null)
            {
                firmaCekKalem.Add(new Assets.firmaCekKalem()
                {
                    SIRA = i++,
                    TARIH = DateTime.Now,
                    VADETARIHI= DateTime.Now,
                });
            }
            else
            {
                foreach (var item in _firmaCekServis.obje.Where(x=> x.USTID== tempCekSenetUstSb.id))
                {
                    firmaCekKalem.Add(new Assets.firmaCekKalem()
                    {
                        ID=item.id,
                        SIRA=i++,
                        CEKNO=item.CEKNO,
                        TARIH=item.CIKISTARIH,
                        VADETARIHI= item.VADETARIH,
                        TUTAR=item.TUTAR,
                        DOVIZCINSI=item.DOVIZID,
                        DOVIZTUTAR=item.DOVIZTUTAR,
                        ACIKLAMA1=item.ACIKLAMA1,
                        ACIKLAMA2=item.ACIKLAMA2,
                        BANKA=item.BANKA,
                        SUBE=item.SUBE,
                        HESAPNO=item.HESAPNO,
                        IBAN=item.IBANNO,

                    });
                }
            }
            
            DGFirmaCek.DataSource = firmaCekKalem;
            DGFirmaCek.RefreshDataSource();
            gridView1.Columns["ID"].Visible= false;
            gridView1.Columns["ID"].OptionsColumn.AllowEdit=false;
            gridView1.Columns["SIRA"].OptionsColumn.AllowEdit = false;
        }




        private void gridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Down)
            {
                firmaCekKalem.Add(new firmaCekKalem()
                {
                    SIRA = firmaCekKalem.LastOrDefault().SIRA + 1,
                    TARIH = DateTime.Now,
                    VADETARIHI=DateTime.Now,
                    
                });
                DGFirmaCek.RefreshDataSource();
            }
        }

        private void BTCariSec_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            _cariListe = new FCariList(this.Tag.ToString(), "FFirmaCekTanim");
            _cariListe.ShowDialog();

            CariDoldur();
            


        }

        private void BTBordroSec_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
          FBordroList fBordro=new FBordroList(this.Tag.ToString(), "FFirmaCekTanim");
            fBordro.ShowDialog();

            if (tempCekSenetUstSb!=null)
            {
                BTBordroSec.Text = tempCekSenetUstSb.BORDRONO;
                tempCari = _cariKartServis.obje.Where(x=>x.id== tempCekSenetUstSb.CARIID).FirstOrDefault();
                CariDoldur();
                CBAltHesap.EditValue = tempCekSenetUstSb.ALTHESAPID;

                gridYapilandir();
            }
        }

        void CariDoldur()
        {
            BTCariSec.Text = tempCari.kod;
            TBCariAdi.Text = tempCari.unvan;
            _cariAltHesServis.Data(ServisList.CariAltHesListeServis);
            _cariAltHesCariServis.Data(ServisList.CariAltHesCariListeServis);
            var tempp = from test in _cariAltHesCariServis.obje
                        join test2 in _cariAltHesServis.obje on test.carialthesid equals test2.id
                        where test.cariid == tempCari.id
                        select new { test2.id, test2.adi };
            CBAltHesap.Properties.DataSource = tempp;
            CBAltHesap.Properties.DisplayMember = "adi";
            CBAltHesap.Properties.ValueMember = "id";

        }

        private void FFirmaCekTanim_Load(object sender, EventArgs e)
        {
            gridYapilandir();
            DTTarih.EditValue = DateTime.Now;
        }
    }
}
