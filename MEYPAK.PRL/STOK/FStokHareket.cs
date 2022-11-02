using MEYPAK.BLL.DEPO;
using MEYPAK.BLL.STOK;
using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Concrete.EntityFramework.Repository;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.DAL.Concrete.EntityFramework.Repository;
using MEYPAK.Entity.PocoModels;
using MEYPAK.Interfaces.Depo;
using MEYPAK.Interfaces.Stok;
using MEYPAK.PRL.Assets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.DEPO;
using DevExpress.XtraEditors;

namespace MEYPAK.PRL.STOK
{
    public partial class FStokHareket : Form
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
            CBBirim.EditValue = "";

            CBParaBirimi.EditValue = "";

        }
        GenericWebServis<PocoSTOKHAR> _stokHarServis ;
        GenericWebServis<PocoSTOKOLCUBR> _stokOlcuBrServis ;
        GenericWebServis<PocoOLCUBR> _olcuBrServis  ;
        GenericWebServis<PocoSTOK> _stokServis;
        // IStokServis _stokServis = new StokManager(new EFStokRepo());
        List<PocoStokHareketListesi> _tempdgvStok = new List<PocoStokHareketListesi>();
        public PocoSTOK _tempStok;
        int IO = 0;
        int _id;
        GenericWebServis<PocoDEPO> _depoServis ;

        decimal KdvEkle(decimal val)
        {
            decimal kdvy = (100 + Decimal.Parse(TBKdv.Text)) / 100;
            val = val * kdvy;
            return val;
        }
        void BakiyeGuncelle()
        {
            _stokHarServis.Data(ServisList.StokHarListeServis);
            LBToplamGiris.Text = _stokHarServis.obje.Where(x => x.IO == 1 && x.STOKID == _id).Sum(x => x.MIKTAR).ToString();
            LBToplamCikis.Text = _stokHarServis.obje.Where(x => x.IO == 0 && x.STOKID == _id).Sum(x => x.MIKTAR).ToString();
            LBBakiye.Text = (_stokHarServis.obje.Where(x => x.IO == 1 && x.STOKID == _id).Sum(x => x.MIKTAR) - _stokHarServis.obje.Where(x => x.IO == 0 && x.STOKID == _id).Sum(x => x.MIKTAR)).ToString();
        }
        void Doldur()
        {
            _stokHarServis.Data(ServisList.StokHarListeServis);
            _stokOlcuBrServis.Data(ServisList.StokOlcuBrListeServis);
            _depoServis.Data(ServisList.DepoListeServis);
            IO = RBGiris.Checked == true ? 1 : 0;
            if (_tempStok != null)
            {
                _id = _tempStok.id;
                TBStokKodu.Text = _tempStok.kod;
                TBStokAdi.Text = _tempStok.adi;
                var adi= _stokOlcuBrServis.obje.Where(x => x.STOKID == _tempStok.id).Select(x => _olcuBrServis.obje.Where(z => z.id.ToString() == x.OLCUBRID.ToString()).FirstOrDefault().adi).ToList();
                CBBirim.Properties.DataSource = adi; //_stokOlcuBrServis.Getir(x => x.STOKID == _id).Select(x => _olcuBrServis.Getir(z => z.ID == x.OLCUBRID).FirstOrDefault().ADI).ToList();
                CBBirim.Properties.ValueMember = "id";
                CBBirim.Properties.DisplayMember = "ADI";
                CBBirim.EditValue = adi.FirstOrDefault();
                //TBFiyat.Text = IO == 1 ? _tempStok.AFIYAT1.ToString() : _tempStok.SATISKDV.ToString();
                BakiyeGuncelle();
                GCStokHareket.DataSource = _stokHarServis.obje.Where(x=>x.STOKID==_tempStok.id).Select( x=> new PocoStokHareketListesi()
                {
                    Acıklama=x.ACIKLAMA,
                    BelgeNo=x.BELGE_NO,
                    Birim=_olcuBrServis.obje.Where(z=>z.id==x.BIRIM).FirstOrDefault().adi,
                    BrutToplam=x.BRUTTOPLAM,
                    Cikis=x.IO==0?x.MIKTAR:0,
                    Giris=x.IO==1?x.MIKTAR:0,
                    Depo=_depoServis.obje.Where(z=>z.id==x.DEPOID).FirstOrDefault().DEPOADI,
                    HareketTuru=x.HAREKETTURU==5?"Muhtelif":x.HAREKETTURU==1?"Satış Faturası":x.HAREKETTURU==2?"Alış Faturası":x.HAREKETTURU==3?"Satış İade":x.HAREKETTURU==4?"Alış İade":x.HAREKETTURU==6?"DAT":"",
                    NetFiyat=x.NETFIYAT,
                    NetToplam=x.NETTOPLAM,
                    Tarih=x.olusturmatarihi
                }).ToList();
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
            DTPTarih.EditValue = DateTime.Now;
            _depoServis.Data(ServisList.DepoListeServis);
            var depo= _depoServis.obje.Select(x => x.DEPOADI).ToList();
            CBDepo.Properties.DataSource = depo;
            CBDepo.EditValue = depo.FirstOrDefault();
            _tempdgvStok.Add(new PocoStokHareketListesi());
            GCStokHareket.DataSource = _tempdgvStok;
            ((ListBox)CLBDepo).DataSource = _depoServis.obje.Select(x => x.DEPOADI).ToList();

        }

        private void BTKaydet_Click(object sender, EventArgs e)
        {
            IO = RBGiris.Checked == true ? 1 : 0;

            _depoServis.Data(ServisList.DepoListeServis);

            _stokHarServis.Data(ServisList.StokHarEkleServis,(new PocoSTOKHAR()
            {
                STOKID = _id,
                BELGE_NO = TBBelgeNo.Text,
                ACIKLAMA = TBAciklama.Text,
                IO = this.IO,
                BIRIM = _olcuBrServis.obje.Where(x => x.adi == CBBirim.EditValue).FirstOrDefault().id,
                DEPOID = _depoServis.obje.Where(x => x.DEPOADI.ToString() == CBDepo.EditValue.ToString()).FirstOrDefault().id,
                MIKTAR = Convert.ToDecimal(TBMiktar.Text),
                HAREKETTURU = 5,         //Muhtelif
                FATURAID = 0,
                NETFIYAT = Convert.ToDecimal(TBFiyat.Text),
                KDV = Convert.ToDecimal(TBKdv.Text),
                NETTOPLAM = Convert.ToDecimal(TBFiyat.Text) * Convert.ToDecimal(TBMiktar.Text),
                BRUTTOPLAM = KdvEkle(Convert.ToDecimal(TBFiyat.Text) * Convert.ToDecimal(TBMiktar.Text)),
            }));
            GCStokHareket.DataSource = _stokHarServis.obje.Where(x=>x.id ==_id);
            TBMiktar.Text = "";
            TBBelgeNo.Text = "";
            TBAciklama.Text = "";
            TBFiyat.Text = "";
            BakiyeGuncelle();
            //Temizle(this.Controls);
            // dataGridView1.DataSource = _tempdgvStok;

        }

        private void BTStokSec_Click(object sender, EventArgs e)
        {
            _tempStok = null;
            FStokList fStokList = new FStokList("stokhar");
            fStokList.ShowDialog();

            Doldur();
        }

        private void TBStokKodu_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBStokKodu_Leave(object sender, EventArgs e)
        {
            if (TBStokKodu.Text != "" && _stokServis.obje.Where(x => x.kod == TBStokKodu.Text).FirstOrDefault() != null)
            {
                _tempStok = _stokServis.obje.Where(x => x.kod == TBStokKodu.Text).FirstOrDefault();
                Doldur();
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _tempStok = _stokServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("STOKID").ToString()).FirstOrDefault();
            TBMiktar.Text = gridView1.GetFocusedRowCellValue("MIKTAR").ToString();
            Doldur();
        }

        private void BTNSil_Click(object sender, EventArgs e)
        {
            _stokHarServis.Data(ServisList.StokHarSilServis,(_stokHarServis.obje.Where(x => x.id == Convert.ToInt32(gridView1.GetFocusedRowCellValue("id"))).FirstOrDefault()));

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
            FStokList fStokList = new FStokList("stokhar");
            fStokList.ShowDialog();

            Doldur();
        }

        private void CLBSube_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
