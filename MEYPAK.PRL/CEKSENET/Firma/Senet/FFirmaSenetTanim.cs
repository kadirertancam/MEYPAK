using DevExpress.XtraEditors;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels;
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
    public partial class FFirmaSenetTanim : XtraForm
    {
        public FFirmaSenetTanim()
        {
            InitializeComponent();
            _firmaSenetServis = new GenericWebServis<PocoFIRMASENETSB>();
            _cariKartServis = new GenericWebServis<PocoCARIKART>();
            firmaCekKalem = new List<firmaSenetKalem>();
            _cekSenetUstSbServis = new GenericWebServis<PocoCEKSENETUSTSB>();
            _cariAltHesServis = new GenericWebServis<PocoCARIALTHES>();
            _cariAltHesCariServis = new GenericWebServis<PocoCARIALTHESCARI>();
            _cekSenetUstSbServis.Data(ServisList.CekSenetUstSBListeServis);
            _cariKartServis.Data(ServisList.CariListeServis);
            _firmaSenetServis.Data(ServisList.FirmaSenetSBListeServis);
        }
        GenericWebServis<PocoFIRMASENETSB> _firmaSenetServis;
        GenericWebServis<PocoCARIKART> _cariKartServis;
        GenericWebServis<PocoCARIALTHES> _cariAltHesServis;
        GenericWebServis<PocoCARIALTHESCARI> _cariAltHesCariServis;
        GenericWebServis<PocoCEKSENETUSTSB> _cekSenetUstSbServis;
        PocoFIRMACEKSB _tempFirmaCek;
        List<firmaSenetKalem> firmaCekKalem;
        FCariList _cariListe;
        public PocoCARIKART tempCari;
        public PocoCEKSENETUSTSB tempCekSenetUstSb;
        int i = 0;
        private void BTKaydet_Click(object sender, EventArgs e)
        {

            _cekSenetUstSbServis.Data(ServisList.CekSenetUstSBListeServis);

            _cekSenetUstSbServis.Data(ServisList.CekSenetUstSBEkleServis, new PocoCEKSENETUSTSB()
            {
                id = tempCekSenetUstSb != null ? tempCekSenetUstSb.id : 0,
                BORDROTIP = 2,
                BORDRONO = _cekSenetUstSbServis.obje.Count() > 0 ? (Convert.ToInt32(_cekSenetUstSbServis.obje.LastOrDefault().BORDRONO) + 1).ToString() : "10000000",
                ALTHESAPID = int.Parse(CBAltHesap.EditValue.ToString()),
                CARIID = _cariKartServis.obje.Where(x => x.kod == BTCariSec.Text).FirstOrDefault().id,
                TOPLAM = firmaCekKalem.Sum(x => x.TUTAR),
                userid = MPKullanici.ID
            });


            foreach (var item in firmaCekKalem)
            {


                _firmaSenetServis.Data(ServisList.FirmaSenetSBEkleServis, new PocoFIRMASENETSB()
                {

                    USTID = _cekSenetUstSbServis.obje2.id,
                    SENETNO = _cekSenetUstSbServis.obje2.BORDRONO,
                    CARIID = _cariKartServis.obje.Where(x => x.kod == BTCariSec.Text).FirstOrDefault().id,
                    VADETARIH = item.VADETARIHI,
                    ACIKLAMA1 = item.ACIKLAMA1,
                    ACIKLAMA2 = item.ACIKLAMA2,
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
            if (tempCekSenetUstSb == null)
            {
                firmaCekKalem.Add(new Assets.firmaSenetKalem()
                {
                    SIRA = i++,
                    TARIH = DateTime.Now,
                    VADETARIHI = DateTime.Now,
                });
            }
            else
            {
                foreach (var item in _firmaSenetServis.obje.Where(x => x.USTID == tempCekSenetUstSb.id))
                {
                    firmaCekKalem.Add(new Assets.firmaSenetKalem()
                    {
                        ID = item.id,
                        SIRA = i++,
                        SENETNO = item.SENETNO,
                        TARIH = item.CIKISTARIH,
                        VADETARIHI = item.VADETARIH,
                        TUTAR = item.TUTAR,
                        DOVIZCINSI = item.DOVIZID,
                        DOVIZTUTAR = item.DOVIZTUTAR,
                        ACIKLAMA1 = item.ACIKLAMA1,
                        ACIKLAMA2 = item.ACIKLAMA2,
                   

                    });
                }
            }

            DGFirmaSenet.DataSource = firmaCekKalem;
            DGFirmaSenet.RefreshDataSource();
            gridView1.Columns["ID"].Visible = false;
            gridView1.Columns["ID"].OptionsColumn.AllowEdit = false;
            gridView1.Columns["SIRA"].OptionsColumn.AllowEdit = false;
        }


        private void gridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Down)
            {
                firmaCekKalem.Add(new firmaSenetKalem()
                {
                    SIRA = firmaCekKalem.LastOrDefault().SIRA + 1,
                    TARIH = DateTime.Now,
                    VADETARIHI = DateTime.Now,

                });
                DGFirmaSenet.RefreshDataSource();
            }
        }

        private void BTCariSec_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            _cariListe = new FCariList(this.Tag.ToString(), "FFirmaSenetTanim");
            _cariListe.ShowDialog();
            if (tempCari!=null)
            {
                CariDoldur();
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

        private void FFirmaSenetTanim_Load(object sender, EventArgs e)
        {
            gridYapilandir();
            DTTarih.EditValue = DateTime.Now;
        }

        private void BTBordroSec_Properties_ButtonClick_1(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FBordroList fBordro = new FBordroList(this.Tag.ToString(), "FFirmaSenetTanim");
            fBordro.ShowDialog();

            if (tempCekSenetUstSb != null)
            {
                BTBordroSec.Text = tempCekSenetUstSb.BORDRONO;
                tempCari = _cariKartServis.obje.Where(x => x.id == tempCekSenetUstSb.CARIID).FirstOrDefault();
                CariDoldur();
                CBAltHesap.EditValue = tempCekSenetUstSb.ALTHESAPID;

                gridYapilandir();
            }
        }
    }
}
