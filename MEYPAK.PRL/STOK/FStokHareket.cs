using MEYPAK.BLL.DEPO;
using MEYPAK.BLL.STOK;
using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Concrete.EntityFramewok.Repository;
using MEYPAK.DAL.Concrete.EntityFramework.Repository;
using MEYPAK.Entity.Models;
using MEYPAK.Entity.PocoModels;
using MEYPAK.Interfaces.Depo;
using MEYPAK.Interfaces.Stok;
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

namespace MEYPAK.PRL.STOK
{
    public partial class FStokHareket : Form
    {
        public FStokHareket()
        {
            InitializeComponent();
        }
        IStokHarServis _stokHarServis = new StokHarManager(new EFStokHareketRepo());
        IStokOlcuBrServis _stokOlcuBrServis = new StokOlcuBrManager(new EFStokOlcuBrRepo());
        IOlcuBrServis _olcuBrServis = new OlcuBrManager(new EFOlcuBrRepo());
        IStokServis _stokServis = new StokManager(new EFStokRepo());
        List<PocoStokHareketListesi> _tempdgvStok = new List<PocoStokHareketListesi>();
        public MPSTOK _tempStok;
        int IO=0;
        int _id;
        IDepoServis _depoServis = new DepoManager(new EFDepoRepo());
     
        decimal KdvEkle(decimal val)
        {
            decimal kdvy = (100 + Decimal.Parse(TBKdv.Text))/100;
            val=val*kdvy;
            return val;
        }
        void BakiyeGuncelle()
        {
            LBToplamGiris.Text = _stokHarServis.Listele().Where(x => x.IO == 1 && x.STOKID == _id).Sum(x => x.MIKTAR).ToString();
            LBToplamCikis.Text = _stokHarServis.Listele().Where(x => x.IO == 0 && x.STOKID == _id).Sum(x => x.MIKTAR).ToString();
            LBBakiye.Text = (_stokHarServis.Listele().Where(x => x.IO == 1 && x.STOKID == _id).Sum(x => x.MIKTAR) - _stokHarServis.Listele().Where(x => x.IO == 0 && x.STOKID == _id).Sum(x => x.MIKTAR)).ToString();
        }
        void Doldur()
        {
           IO= RBGiris.Checked==true ? 1 : 0;
            if (_tempStok != null)
            {
                _id = _tempStok.ID;
                TBStokKodu.Text = _tempStok.KOD;
                TBStokAdi.Text = _tempStok.ADI;
                CBDepo.SelectedIndex = CBDepo.FindStringExact(_depoServis.Getir(_tempStok.DEPOID.ToString()).FirstOrDefault().DEPOADI);
                CBBirim.DataSource = _stokOlcuBrServis.Listele().Where(x => x.STOKID == _tempStok.ID).Select(x => x.MPOLCUBR.ADI).ToList(); //_stokOlcuBrServis.Getir(x => x.STOKID == _id).Select(x => _olcuBrServis.Getir(z => z.ID == x.OLCUBRID).FirstOrDefault().ADI).ToList();
                TBKdv.Text = IO == 1 ? _tempStok.ALISKDV.ToString() : _tempStok.SATISKDV.ToString();
                //TBFiyat.Text = IO == 1 ? _tempStok.AFIYAT1.ToString() : _tempStok.SATISKDV.ToString();
                BakiyeGuncelle();
                dataGridView1.DataSource = _stokHarServis.PocoStokHareketListesi(_tempStok.ID);
                

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
            CBDepo.DataSource = _depoServis.Listele().Select(x=>x.DEPOADI).ToList();
            _tempdgvStok.Add(new PocoStokHareketListesi());
            dataGridView1.DataSource = _tempdgvStok;
            ((ListBox)CLBDepo).DataSource = _depoServis.Listele().Select(x=>x.DEPOADI).ToList();
             
        }

        private void BTKaydet_Click(object sender, EventArgs e)
        {
            IO = RBGiris.Checked==true ?  1 :  0;
              

            
            _stokHarServis.EkleyadaGuncelle(new Entity.Models.MPSTOKHAR()
            {
                STOKID = _id,
                BELGE_NO = TBBelgeNo.Text,
                ACIKLAMA = TBAciklama.Text,
                IO = this.IO,
                BIRIM = _olcuBrServis.Getir(x => x.ADI == CBBirim.SelectedValue).FirstOrDefault().ID,
                DEPOID = _depoServis.Getir(x => x.DEPOADI == CBDepo.SelectedValue).FirstOrDefault().ID,
                MIKTAR = Convert.ToDecimal(TBMiktar.Text),
                HAREKETTURU = 5,         //Muhtelif
                FATURAID = 0,
                NETFIYAT = Convert.ToDecimal(TBFiyat.Text),
                KDV = Convert.ToDecimal(TBKdv.Text),
                NETTOPLAM = Convert.ToDecimal(TBFiyat.Text) * Convert.ToDecimal(TBMiktar.Text),
                BRUTTOPLAM = KdvEkle(Convert.ToDecimal(TBFiyat.Text) * Convert.ToDecimal(TBMiktar.Text)),
            });
            dataGridView1.DataSource = _stokHarServis.PocoStokHareketListesi(_id);
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
            FStokList fStokList = new FStokList();
            fStokList.ShowDialog();
            
            Doldur();
        }

        private void TBStokKodu_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void TBStokKodu_Leave(object sender, EventArgs e)
        {
            _tempStok = _stokServis.Getir(x => x.KOD == TBStokKodu.Text).FirstOrDefault();
            Doldur();
        }
    }
}
