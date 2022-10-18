using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels;
using MEYPAK.PRL.Assets.Scripts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEYPAK.PRL.DEPO
{
    public partial class FMalKabulCekiPanel : Form
    {
        public FMalKabulCekiPanel()
        {
            InitializeComponent();

            _tempStokSevkiyatList = new MPSTOKMALKABULLIST();
            _tempStok = StaticContext._stokServis.Listele();
        }
        List<MPSTOK> _tempStok;
        MPSTOK _Stok;
        public MPDEPOEMIR _tempEmir;
        MPSTOKMALKABULLIST _tempStokSevkiyatList;
        public List<MPSTOKMALKABULLIST> _tempList;

        private void button2_Click(object sender, EventArgs e)
        {
            List<PocoStokSevkiyatList> aaa = (List<PocoStokSevkiyatList>)dataGridView1.DataSource;
            int _id;
            foreach (var item in aaa)
            {
                _id = StaticContext._stokServis.Getir(x => x.KOD == item.StokKodu).FirstOrDefault().ID;
                StaticContext._stokMalKabulListServis.OnYukle();
                StaticContext._stokMalKabulListServis.EkleyadaGuncelle(new MPSTOKMALKABULLIST()
                {
                    STOKID = _id,
                    EMIRID = _tempEmir.ID,
                    BIRIMID = StaticContext._siparisDetayServis.Getir(x => x.SIPARISID == _tempEmir.SIPARISID && x.STOKID == _id).FirstOrDefault().BIRIMID,
                    MIKTAR = item.Miktar,
                    DEPOID = _tempEmir.MPSIPARIS.DEPOID,
                    SIRKETID = 0,
                    SIPARISMIKTARI = _tempEmir.MPSIPARIS.MPSIPARISDETAY.Where(x => x.STOKID == _id).Sum(x => x.MIKTAR),
                    SIPARISDETAYID = _tempList.Where(x => x.MPSIPARISDETAY.STOKID == _id && x.EMIRID == _tempEmir.ID).FirstOrDefault().MPSIPARISDETAY.ID,
                    SUBEID = 0,
                    KULLANICIID = 0
                });

                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            _Stok = StaticContext._stokServis.Getir(x => x.ID.ToString() == comboBox1.SelectedValue.ToString()).FirstOrDefault();
            _tempStokSevkiyatList = new MPSTOKMALKABULLIST()
            {
                STOKID = _Stok.ID,
                EMIRID = _tempEmir.ID,
                DEPOID = _tempEmir.MPSIPARIS.DEPOID,
                MIKTAR = 0,
                SIPARISMIKTARI = _tempEmir.MPSIPARIS.MPSIPARISDETAY.Where(x => x.STOKID.ToString() == comboBox1.SelectedValue.ToString()).FirstOrDefault().MIKTAR,
                BIRIMID = _Stok.MPSTOKOLCUBR.Where(x => x.NUM == 1).Select(x => x.MPOLCUBR.ID).FirstOrDefault(),
                MPOLCUBR = _Stok.MPSTOKOLCUBR.Where(x => x.NUM == 1).Select(x => x.MPOLCUBR).FirstOrDefault(),
                MPDEPOEMIR = _tempEmir,
                MPSTOK = _Stok,


            };
            _tempList.Add(_tempStokSevkiyatList);
            if (dataGridView1.DataSource != null)
            {
                dataGridView1.DataSource = null;
            }
            dataGridView1.DataSource = _tempList.Select(x => new PocoStokSevkiyatList()
            {
                StokAdı = x.MPSTOK.ADI,
                StokKodu = x.MPSTOK.KOD,
                Birim = x.MPOLCUBR.ADI,
                Miktar = x.MIKTAR,
                ID = x.STOKID,
                MPSTOK = _Stok
            }).ToList();
        }

        private void FMalKabulCekiPanel_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _tempList.Select(x => new PocoStokSevkiyatList { StokKodu = x.MPSTOK.KOD, StokAdı = x.MPSTOK.ADI, Birim = "0" }).ToList();
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox1.DisplayMember = "KOD";
            comboBox1.ValueMember = "ID";
            comboBox1.DataSource = _tempStok.Select(x => new { KOD = x.KOD, ID = x.ID }).ToList();
        }
    }
}
