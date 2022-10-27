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
            _stokOlcuBrServis.Data(ServisList.StokOlcuBrListeServis);
            IO = RBGiris.Checked == true ? 1 : 0;
            if (_tempStok != null)
            {
                _id = _tempStok.ID;
                TBStokKodu.Text = _tempStok.KOD;
                TBStokAdi.Text = _tempStok.ADI;
                CBBirim.DataSource = _stokOlcuBrServis.obje.Where(x => x.STOKID == _tempStok.ID).Select(x => _olcuBrServis.obje.Where(z => z.ID.ToString() == x.OLCUBRID.ToString()).FirstOrDefault().ADI).ToList(); //_stokOlcuBrServis.Getir(x => x.STOKID == _id).Select(x => _olcuBrServis.Getir(z => z.ID == x.OLCUBRID).FirstOrDefault().ADI).ToList();
                TBKdv.Text = IO == 1 ? _tempStok.ALISKDV.ToString() : _tempStok.SATISKDV.ToString();
                //TBFiyat.Text = IO == 1 ? _tempStok.AFIYAT1.ToString() : _tempStok.SATISKDV.ToString();
                BakiyeGuncelle();
                gridControl1.DataSource = _stokHarServis.obje.Where(x=>x.STOKID==_tempStok.ID).ToList();
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
            CBDepo.DataSource = _depoServis.obje.Select(x => x.DEPOADI).ToList();
            _tempdgvStok.Add(new PocoStokHareketListesi());
            gridControl1.DataSource = _tempdgvStok;
            ((ListBox)CLBDepo).DataSource = _depoServis.obje.Select(x => x.DEPOADI).ToList();

        }

        private void BTKaydet_Click(object sender, EventArgs e)
        {
            IO = RBGiris.Checked == true ? 1 : 0;

            _depoServis.Data(ServisList.DepoListeServis);

            _stokHarServis.Data(ServisList.StokHarListeServis,(new PocoSTOKHAR()
            {
                STOKID = _id,
                BELGE_NO = TBBelgeNo.Text,
                ACIKLAMA = TBAciklama.Text,
                IO = this.IO,
                BIRIM = _olcuBrServis.obje.Where(x => x.ADI == CBBirim.SelectedValue).FirstOrDefault().ID,
                DEPOID = _depoServis.obje.Where(x => x.DEPOADI == CBDepo.SelectedValue).FirstOrDefault().ID,
                MIKTAR = Convert.ToDecimal(TBMiktar.Text),
                HAREKETTURU = 5,         //Muhtelif
                FATURAID = 0,
                NETFIYAT = Convert.ToDecimal(TBFiyat.Text),
                KDV = Convert.ToDecimal(TBKdv.Text),
                NETTOPLAM = Convert.ToDecimal(TBFiyat.Text) * Convert.ToDecimal(TBMiktar.Text),
                BRUTTOPLAM = KdvEkle(Convert.ToDecimal(TBFiyat.Text) * Convert.ToDecimal(TBMiktar.Text)),
            }));
            gridControl1.DataSource = _stokHarServis.obje.Where(x=>x.ID==_id);
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
            if (TBStokKodu.Text != "" && _stokServis.obje.Where(x => x.KOD == TBStokKodu.Text).FirstOrDefault() != null)
            {
                _tempStok = _stokServis.obje.Where(x => x.KOD == TBStokKodu.Text).FirstOrDefault();
                Doldur();
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _tempStok = _stokServis.obje.Where(x => x.ID.ToString() == gridView1.GetFocusedRowCellValue("STOKID").ToString()).FirstOrDefault();
            TBMiktar.Text = gridView1.GetFocusedRowCellValue("MIKTAR").ToString();
            Doldur();
        }

        private void BTNSil_Click(object sender, EventArgs e)
        {
            _stokHarServis.Data(ServisList.StokHarSilServis,(_stokHarServis.obje.Where(x => x.ID == Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"))).FirstOrDefault()));

        }

        #region KeyPress


        private void TBMiktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void TBFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void TBKdv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void TBKur_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }





        #endregion


    }
}
