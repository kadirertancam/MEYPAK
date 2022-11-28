using MEYPAK.Entity.PocoModels;
using System.Data;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.DEPO;
using DevExpress.XtraEditors;

namespace MEYPAK.PRL.STOK
{
    public partial class FStokHareket : XtraForm
    {
        public FStokHareket()
        {
            InitializeComponent();
            _stokHarServis = new GenericWebServis<PocoSTOKHAR>();
            _stokOlcuBrServis = new GenericWebServis<PocoSTOKOLCUBR>();
            _olcuBrServis = new GenericWebServis<PocoOLCUBR>();
            _stokServis = new GenericWebServis<PocoSTOK>();
            _depoServis = new GenericWebServis<PocoDEPO>();
            _stokHarServis.Data(ServisList.StokHarListeServis);
            _stokServis.Data(ServisList.StokListeServis);
            _stokOlcuBrServis.Data(ServisList.StokOlcuBrListeServis);
            _olcuBrServis.Data(ServisList.OlcuBrListeServis);
            _depoServis.Data(ServisList.DepoListeServis);
            //CBBirim.EditValue = "";



        }
        GenericWebServis<PocoSTOKHAR> _stokHarServis;
        GenericWebServis<PocoSTOKOLCUBR> _stokOlcuBrServis;
        GenericWebServis<PocoOLCUBR> _olcuBrServis;
        GenericWebServis<PocoSTOK> _stokServis;
        // IStokServis _stokServis = new StokManager(new EFStokRepo());
        List<PocoStokHareketListesi> _tempdgvStok = new List<PocoStokHareketListesi>();
        public PocoSTOK _tempStok;
        int IO = 0;
        int _id;
        GenericWebServis<PocoDEPO> _depoServis;

        decimal KdvEkle(decimal val)
        {
            //decimal kdvy = (100 + Decimal.Parse(TBKdv.Text)) / 100;
            val = val;
            return val;
        }
        void BakiyeGuncelle()
        {
            _stokHarServis.Data(ServisList.StokHarListeServis);
            LBStokHarToplamGirisDeger.Text = _stokHarServis.obje.Where(x =>x.kayittipi==0&& x.io == 1 && x.stokid == _id).Sum(x => x.miktar).ToString();
            LBStokHarToplamCikisDeger.Text = _stokHarServis.obje.Where(x => x.kayittipi == 0 && x.io == 0 && x.stokid == _id).Sum(x => x.miktar).ToString();
            LBStokHarBakiyeDeger.Text = (_stokHarServis.obje.Where(x => x.kayittipi == 0 && x.io == 1 && x.stokid == _id).Sum(x => x.miktar) - _stokHarServis.obje.Where(x => x.io == 0 && x.stokid == _id).Sum(x => x.miktar)).ToString();
        }
        void Doldur()
        {
            _stokHarServis.Data(ServisList.StokHarListeServis);
            _stokOlcuBrServis.Data(ServisList.StokOlcuBrListeServis);
            _depoServis.Data(ServisList.DepoListeServis);
            //IO = RGStokHarGirisCikis.SelectedIndex == 0 ? 1 : 0;
            if (_tempStok != null)
            {
                _id = _tempStok.id;
                BTStokKoduSec.EditValue = _tempStok.kod;
                TBStokAdi.Text = _tempStok.adi;
                var adi = _stokOlcuBrServis.obje.Where(x => x.stokid == _tempStok.id).Select(x => _olcuBrServis.obje.Where(z => z.id.ToString() == x.olcubrid.ToString()).FirstOrDefault().adi).ToList();
                //CBBirim.Properties.DataSource = adi; //_stokOlcuBrServis.Getir(x => x.stokid == _id).Select(x => _olcuBrServis.Getir(z => z.ID == x.OLCUBRID).FirstOrDefault().ADI).ToList();
                //CBBirim.Properties.ValueMember = "id";
                //CBBirim.Properties.DisplayMember = "ADI";
                //TBKdv.Text = _tempStok.satiskdv.ToString();
                //CBBirim.EditValue = adi.FirstOrDefault();
                //TBFiyat.Text = IO == 1 ? _tempStok.AFIYAT1.ToString() : _tempStok.SATISKDV.ToString();
                BakiyeGuncelle();
                GCStokHareket.DataSource = _stokHarServis.obje.Where(x => x.kayittipi == 0 && x.stokid == _tempStok.id).Select(x => new PocoStokHareketListesi()
                {
                    STOKID = x.stokid,
                    Acıklama = x.aciklama,
                    BelgeNo = x.belgE_NO,
                    Birim = _olcuBrServis.obje.Where(z => z.id == x.birim).FirstOrDefault().adi,
                    BrutToplam = x.bruttoplam,
                    Cikis = x.io == 0 ? x.miktar : 0,
                    Giris = x.io == 1 ? x.miktar : 0,
                    Depo = _depoServis.obje.Where(z => z.id == x.depoid).FirstOrDefault().depoadi,
                    HareketTuru = x.hareketturu == 5 ? "Muhtelif" : x.hareketturu == 1 ? "Satış Faturası" : x.hareketturu == 2 ? "Alış Faturası" : x.hareketturu == 3 ? "Satış İade" : x.hareketturu == 4 ? "Alış İade" : x.hareketturu == 6 ? "DAT" : x.hareketturu == 0 ? "Muhtelif" : x.hareketturu == 7 ? "Sayım" : "",
                    NetFiyat = x.netfiyat,
                    NetToplam = x.nettoplam,
                    Tarih = x.olusturmatarihi
                });
                gridView1.Columns["STOKID"].Visible = false;
                gridView1.RefreshData();
                // _tempStok = null;


            }
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

        private void FStokHareket_Load(object sender, EventArgs e)
        {

            _depoServis.Data(ServisList.DepoListeServis);
            _tempdgvStok.Add(new PocoStokHareketListesi());
            GCStokHareket.DataSource = _tempdgvStok;
            CLBDepo.DataSource = _depoServis.obje.Where(x => x.kayittipi == 0).Select(x => x.depoadi).ToList();

        }



        private void BTStokKoduSec_Click(object sender, EventArgs e)
        {
            _tempStok = null;
            FStokList fStokList = new FStokList(this.Tag.ToString(), "stokhar");
            fStokList.ShowDialog();

            Doldur();
        }



        private void BTStokKoduSec_Leave(object sender, EventArgs e)
        {
            if (BTStokKoduSec.EditValue != "" && _stokServis.obje.Where(x => x.kod == BTStokKoduSec.EditValue).FirstOrDefault() != null)
            {
                _tempStok = _stokServis.obje.Where(x => x.kod == BTStokKoduSec.EditValue).FirstOrDefault();
                Doldur();
            }
        }



        #region KeyPress


        private void TBMiktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar != '.' && e.KeyChar != ',')
            //{
            //    e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            //}
        }

        private void TBFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar != '.' && e.KeyChar != ',')
            //{
            //    e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            //}
        }

        private void TBKdv_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar != '.' && e.KeyChar != ',')
            //{
            //    e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            //}
        }

        private void TBKur_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar != '.' && e.KeyChar != ',')
            //{
            //    e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            //}
        }






        #endregion

        private void buttonEdit1_Properties_Click(object sender, EventArgs e)
        {
            _tempStok = null;
            FStokList fStokList = new FStokList(this.Tag.ToString(), "stokhar");
            fStokList.ShowDialog();

            Doldur();
        }



        //private void BTStokHarKaydet_Click(object sender, EventArgs e)
        //{
        //    IO = RGStokHarGirisCikis.SelectedIndex == 0 ? 1 : 0;

        //    _depoServis.Data(ServisList.DepoListeServis);

        //    _stokHarServis.Data(ServisList.StokHarEkleServis, (new PocoSTOKHAR()
        //    {
        //        stokid = _id,
        //        belgE_NO = TBBelgeNo.Text,
        //        aciklama = TBAciklama.Text,
        //        io = this.IO,
        //        birim = _olcuBrServis.obje.Where(x => x.adi == CBBirim.EditValue).FirstOrDefault().id,
        //        depoid = _depoServis.obje.Where(x => x.depoadi.ToString() == CBDepo.EditValue.ToString()).FirstOrDefault().id,
        //        miktar = Convert.ToDecimal(TBMiktar.Text),
        //        hareketturu = 5,         //Muhtelif
        //        faturaid = 0,
        //        netfiyat = Convert.ToDecimal(TBFiyat.Text),
        //        kdv = Convert.ToDecimal(TBKdv.Text),
        //        nettoplam = Convert.ToDecimal(TBFiyat.Text) * Convert.ToDecimal(TBMiktar.Text),
        //        bruttoplam = KdvEkle(Convert.ToDecimal(TBFiyat.Text) * Convert.ToDecimal(TBMiktar.Text)),
        //    }));
        //    _stokHarServis.Data(ServisList.StokHarListeServis);
        //    GCStokHareket.DataSource = _stokHarServis.obje.Where(x => x.id == _id);
        //    TBMiktar.Text = "0";
        //    TBBelgeNo.Text = "";
        //    TBAciklama.Text = "";
        //    TBFiyat.Text = "0";
        //    BakiyeGuncelle();
        //    GCStokHareket.DataSource = _stokHarServis.obje.Where(x => x.stokid == _tempStok.id).Select(x => new PocoStokHareketListesi()
        //    {
        //        Acıklama = x.aciklama,
        //        BelgeNo = x.belgE_NO,
        //        Birim = _olcuBrServis.obje.Where(z => z.id == x.birim).FirstOrDefault().adi,
        //        BrutToplam = x.bruttoplam,
        //        Cikis = x.io == 0 ? x.miktar : 0,
        //        Giris = x.io == 1 ? x.miktar : 0,
        //        Depo = _depoServis.obje.Where(z => z.id == x.depoid).FirstOrDefault().depoadi,
        //        HareketTuru = x.hareketturu == 5 ? "Muhtelif" : x.hareketturu == 1 ? "Satış Faturası" : x.hareketturu == 2 ? "Alış Faturası" : x.hareketturu == 3 ? "Satış İade" : x.hareketturu == 4 ? "Alış İade" : x.hareketturu == 6 ? "DAT" : x.hareketturu == 0 ? "Muhtelif" : "",
        //        NetFiyat = x.netfiyat,
        //        NetToplam = x.nettoplam,
        //        Tarih = x.olusturmatarihi
        //    });
        //    //Temizle(this.Controls);
        //    // dataGridView1.DataSource = _tempdgvStok;
        //}

        private void BTStokHarSil_Click(object sender, EventArgs e)
        {
            _stokHarServis.Data(ServisList.StokHarSilServis, (_stokHarServis.obje.Where(x => x.id == Convert.ToInt32(gridView1.GetFocusedRowCellValue("id"))).FirstOrDefault()));

        }


        private void CLBDepo_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            if (CLBDepo.CheckedItems.Count > 0)
            {
                if (_tempStok != null)
                {
                    List<PocoSTOKHAR> datasource = new List<PocoSTOKHAR>();
                    foreach (var item in CLBDepo.CheckedItems)
                    {
                        datasource.AddRange(_stokHarServis.obje.Where(x => x.kayittipi == 0 && x.stokid == _tempStok.id && x.depoid == _depoServis.obje.Where(x => x.kayittipi == 0 && x.depoadi == item.ToString()).FirstOrDefault().id));
                    }
                    GCStokHareket.DataSource = datasource.Select(x => new PocoStokHareketListesi()
                    {
                        STOKID = x.stokid,
                        Acıklama = x.aciklama,
                        BelgeNo = x.belgE_NO,
                        Birim = _olcuBrServis.obje.Where(z => z.id == x.birim).FirstOrDefault().adi,
                        BrutToplam = x.bruttoplam,
                        Cikis = x.io == 0 ? x.miktar : 0,
                        Giris = x.io == 1 ? x.miktar : 0,
                        Depo = _depoServis.obje.Where(z => z.id == x.depoid).FirstOrDefault().depoadi,
                        HareketTuru = x.hareketturu == 5 ? "Muhtelif" : x.hareketturu == 1 ? "Satış Faturası" : x.hareketturu == 2 ? "Alış Faturası" : x.hareketturu == 3 ? "Satış İade" : x.hareketturu == 4 ? "Alış İade" : x.hareketturu == 6 ? "DAT" : x.hareketturu == 0 ? "Muhtelif" : x.hareketturu == 7 ? "Sayım" : "",
                        NetFiyat = x.netfiyat,
                        NetToplam = x.nettoplam,
                        Tarih = x.olusturmatarihi
                    });
                    gridView1.Columns["STOKID"].Visible = false;
                    gridView1.RefreshData();
                    LBStokHarToplamGirisDeger.Text = datasource.Where(x => x.io == 1 && x.stokid == _id).Sum(x => x.miktar).ToString();
                    LBStokHarToplamCikisDeger.Text = datasource.Where(x => x.io == 0 && x.stokid == _id).Sum(x => x.miktar).ToString();
                    LBStokHarBakiyeDeger.Text = (datasource.Where(x => x.io == 1 && x.stokid == _id).Sum(x => x.miktar) - datasource.Where(x => x.io == 0 && x.stokid == _id).Sum(x => x.miktar)).ToString();
                }
            }
            else
            {
                Doldur();
            }


        }

        //private void gridView1_DoubleClick(object sender, EventArgs e)
        //{
        //    _tempStok = _stokServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("STOKID").ToString()).FirstOrDefault();
        //    TBMiktar.Text = gridView1.GetFocusedRowCellValue("Giris").ToString()=="0"? gridView1.GetFocusedRowCellValue("Cikis").ToString(): gridView1.GetFocusedRowCellValue("Giris").ToString();
        //    RGStokHarGirisCikis.SelectedIndex = gridView1.GetFocusedRowCellValue("Giris").ToString() == "0" ? 1 : 0;
        //    TBFiyat.Text = gridView1.GetFocusedRowCellValue("NetFiyat").ToString();
        //    Doldur();
        //}
    }
}
