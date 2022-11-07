using MEYPAK.BLL.Assets;
using MEYPAK.Entity.Models.IRSALIYE;
using MEYPAK.Entity.Models.SIPARIS;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels;
using MEYPAK.Entity.PocoModels.IRSALIYE;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Stok;
using MEYPAK.PRL.Assets.Scripts;
using MEYPAK.PRL.STOK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEYPAK.PRL.SIPARIS
{
    public partial class FSatisIrsaliye : Form
    { 
        public FSatisIrsaliye()
        {
            InitializeComponent();
            DGVStokSec = new DataGridViewButtonColumn();
            DGVFiyatList = new DataGridViewComboBoxColumn();
            DGVKasaSec = new DataGridViewButtonColumn();
            DGVKasaList = new DataGridViewComboBoxColumn();
            _fStokList = new FStokList(this.Tag.ToString(),"siparis");
            fKasaList = new FKasaList(this.Tag.ToString(),"Siparis");
            _olcuBrServis = new GenericWebServis<PocoOLCUBR>();
            GCIrsaliye.MultiSelect = false;
            CBDepo.Properties.DataSource = StaticContext._depoServis.Listele().Select(x => x.depoadi).ToList();
        }
        FKasaList fKasaList;
        List<PocoIRSALIYEDETAY> _tempIrsaliyeDetay = new List<PocoIRSALIYEDETAY>();
        DataGridViewComboBoxColumn DGVOlcuBr = new DataGridViewComboBoxColumn();
        PocoIRSALIYEDETAY _tempPocokalem;
        FStokList _fStokList;
        public MPSTOK _tempStok;
        public MPSTOKKASA _tempKasa;
        DataGridViewButtonColumn DGVStokSec;
        DataGridViewButtonColumn DGVKasaSec;
        GenericWebServis<PocoOLCUBR> _olcuBrServis;

        DataGridViewComboBoxColumn DGVFiyatList;
        DataGridViewComboBoxColumn DGVKasaList;
        DataGridViewCell DGVtempCell;
        void temizle()
        {
            //GCIrsaliye.DataSource = "";
            //_tempIrsaliyeDetay.Clear();
            //_tempIrsaliyeDetay.Add(new PocoIRSALIYEDETAY());
            //GCIrsaliye.DataSource = _tempIrsaliyeDetay;
            //DGVOlcuBr.DataSource = _olc.Select(x => x.MPOLCUBR.ADI).ToList();
        }
        void DataGridYapilandir()
        {
            //_olcuBrServis.Data(ServisList.OlcuBrListeServis);
            //_tempStok = new MPSTOK();
            //_tempIrsaliyeDetay.Add(new PocoIRSALIYEDETAY());
            //GCIrsaliye.DataSource = _tempIrsaliyeDetay;
            //DGVStokSec.FlatStyle = FlatStyle.Flat;
            //DGVOlcuBr.Name = "DGVOlcuBr";
            //DGVOlcuBr.HeaderText = "Birim";
            //DGVOlcuBr.FlatStyle = FlatStyle.Flat;
            //GCIrsaliye.Columns["Birim"].Visible = false;
            //DGVOlcuBr.DataSource = _olcuBrServis.obje.Where(x=>x.).Select(x => x.MPOLCUBR.ADI).ToList();
            //GCIrsaliye.Columns.Add(DGVOlcuBr);
            //DGVStokSec.Name = "DGVStoKSec";
            //DGVStokSec.HeaderText = "Seç";
            //DGVStokSec.Text = "Seç";
            //DGVStokSec.UseColumnTextForButtonValue = true;
            //DGVFiyatList.Name = "DGVFiyatList";
            //DGVFiyatList.FlatStyle = FlatStyle.Flat;
            //GCIrsaliye.Columns.Add(DGVStokSec);
            //GCIrsaliye.Columns.Add(DGVFiyatList);
            //GCIrsaliye.Columns["StokId"].Visible = false;
            //GCIrsaliye.Columns["MPSTOK"].Visible = false;
            //GCIrsaliye.Columns["KasaId"].Visible = false;
            //GCIrsaliye.Columns["DGVStoKSec"].DisplayIndex = 2;
            //GCIrsaliye.Columns["DGVOlcuBr"].DisplayIndex = 5;
            //GCIrsaliye.AllowUserToAddRows = false;
            //GCIrsaliye.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            ////KASA SEÇME İŞLEMLERİ
            //DGVKasaList.Name = "DVGKasaList";
            //DGVKasaList.FlatStyle = FlatStyle.Flat;
            //GCIrsaliye.Columns.Add(DGVKasaList);

            //DGVKasaSec.FlatStyle = FlatStyle.Flat;
            //DGVKasaSec.Name = "DGVKasaSec";
            //DGVKasaSec.HeaderText = "Seç";
            //DGVKasaSec.Text = "Seç";
            //DGVKasaSec.UseColumnTextForButtonValue = true;
            //GCIrsaliye.Columns.Add(DGVKasaSec);
            //GCIrsaliye.Columns["DGVKasaSec"].DisplayIndex = 7;

        }
        private void BTKaydet_Click(object sender, EventArgs e)
        {


            //StaticContext._stokServis.Listele();
            //var _tempp = StaticContext._siparisServis.Ekle(new Entity.Models.SIPARIS.MPSIPARIS()
            //{
            //    ACIKLAMA = TBAciklama.Text,
            //    KUR = Convert.ToDecimal(TBKur.Text),
            //    BELGENO = TBBelgeNo.Text,
            //    VADETARIHI = DTPVadeTarihi.Value,
            //    GUNCELLEMETARIHI = DateTime.Now,
            //    VADEGUNU = Convert.ToInt32(TBSVadeGunu.Text),
            //    CARIADI = TBCariAdi.Text,
            //    CARIID = 0,
            //    DEPOID = StaticContext._depoServis.Getir(x => x.DEPOADI == CBDepo.SelectedValue).FirstOrDefault().ID,
            //    DOVIZID = 0,
            //    ISKONTOTOPLAM = _tempIrsaliyeDetay.Sum(x => x.IskontoTutarı),
            //    KDVTOPLAM = _tempIrsaliyeDetay.Sum(x => x.KdvTutarı),
            //    BRUTTOPLAM = _tempIrsaliyeDetay.Sum(x => x.BrütToplam),
            //    NETTOPLAM = _tempIrsaliyeDetay.Sum(x => x.NetToplam),
            //    GENELTOPLAM = _tempIrsaliyeDetay.Sum(x => x.KdvTutarı) + _tempIrsaliyeDetay.Sum(x => x.NetToplam),

            //});

            //foreach (var item in _tempIrsaliyeDetay.Where(x => x.StokKodu != "").ToList())
            //{

            //    StaticContext._siparisDetayServis.EkleyadaGuncelle(new MPSIPARISDETAY()
            //    {
            //        STOKID = item.StokId,
            //        STOKADI = item.MPSTOK.ADI,
            //        ACIKLAMA = item.Acıklama,
            //        KDV = item.Kdv,
            //        KASAID = item.KasaId,
            //        NETTOPLAM = item.NetToplam,
            //        NETFIYAT = item.NetFiyat,
            //        BIRIMID = item.MPSTOK.MPSTOKOLCUBR.Where(x => x.NUM == 1).Select(x => x.MPOLCUBR.ID).FirstOrDefault(),
            //        DOVIZID = 0,
            //        MIKTAR = item.Miktar,
            //        ISTKONTO1 = item.İskonto1,
            //        ISTKONTO2 = item.İskonto2,
            //        ISTKONTO3 = item.İskonto3,
            //        SIPARISID = _tempp.ID,
            //        BRUTFIYAT = item.BrütFiyat,
            //        BRUTTOPLAM = item.BrütFiyat * item.Miktar,
            //        BEKLEYENMIKTAR = 0,
            //        HAREKETDURUMU = 0,
            //        LISTEFIYATID = 0,
            //        TIP = 0,
            //        KDVTUTARI = item.KdvTutarı
            //    });
            //}
            //temizle();
            //DataGrideSiparisleriGetir();
        }
        private void FIrsaliyeOlustur_Load(object sender, EventArgs e)
        {
            // siparis detayı irsaliye detaya çevir.
        }

        private void BTKaydet_Click_1(object sender, EventArgs e)
        {

        }
    }
}
