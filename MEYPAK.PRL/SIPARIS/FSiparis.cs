using MEYPAK.BLL.STOK;
using MEYPAK.DAL.Concrete.EntityFramework.Repository;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.DAL.Concrete.EntityFramework.Repository;
using MEYPAK.Entity.Models;
using MEYPAK.Entity.PocoModels;
using MEYPAK.Interfaces.Depo;
using MEYPAK.Interfaces.Siparis;
using MEYPAK.Interfaces.Stok;
using MEYPAK.PRL.Assets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MEYPAK.PRL.STOK;

namespace MEYPAK.PRL.SIPARIS
{
    public partial class FSiparis : Form
    {
        public FSiparis()
        {
            InitializeComponent();
            DGVStokSec = new DataGridViewButtonColumn();
            DGVFiyatList=new DataGridViewComboBoxColumn();
            _fStokList = new FStokList("siparis");
            dataGridView1.MultiSelect = false;
        }
        static MEYPAKContext context = NinjectFactory.CompositionRoot.Resolve<MEYPAKContext>();
        ISiparisServis _siparisServis = new SiparisManager(new EFSiparisRepo(context));
        ISiparisDetayServis _siparisDetayServis = new SiparisDetayManager(new EFSiparisDetayRepo(context));
        IStokServis stokServis = new StokManager(new EFStokRepo(context));
        List<PocoSiparisKalem> _tempSiparisDetay=new List<PocoSiparisKalem>();
        PocoSiparisKalem _tempPocokalem;
        FStokList _fStokList;
        public MPSTOK _tempStok;

        private void FSiparis_Load(object sender, EventArgs e)
        {
            DataGridYapilandir();
        }
        DataGridViewButtonColumn DGVStokSec;
        DataGridViewComboBoxColumn DGVFiyatList;
        void DataGridYapilandir()
        {
            _tempSiparisDetay.Add(new PocoSiparisKalem());
            dataGridView1.DataSource = _tempSiparisDetay;
            DGVStokSec.Name = "DGVStoKSec";
            DGVStokSec.HeaderText = "Seç";
            DGVStokSec.Text = "Seç";
            DGVStokSec.UseColumnTextForButtonValue = true;
            DGVFiyatList.Name = "DGVFiyatList";
            DGVFiyatList.FlatStyle = FlatStyle.Flat;
            dataGridView1.Columns.Add(DGVStokSec);
            dataGridView1.Columns.Add(DGVFiyatList);
            dataGridView1.Columns["DGVStoKSec"].DisplayIndex = 1;
            


        }

        private void BTKaydet_Click(object sender, EventArgs e)
        {
            //_siparisServis.EkleyadaGuncelle(new Entity.Models.MPSIPARIS()
            //{
            //    ACIKLAMA = TBAciklama.Text,
            //    KUR = Convert.ToDecimal(TBKur.Text),
            //    BELGENO = TBBelgeNo.Text,
            //    VADETARIHI = DTPVadeTarihi.Value,
            //    GUNCELLEMETARIHI=DateTime.Now,
            //    VADEGUNU=Convert.ToInt32(TBSVadeGunu.Text),
            //    CARIADI=TBCariAdi.Text,
            //    CARIID=0,
            //    DEPOID=CBDepo.SelectedIndex,
            //    DOVIZID=0,
                

            //    //DEPOID = _depoServis.Getir(x => x.DEPOADI == CBDepo.SelectedValue).FirstOrDefault().ID,


            //});
            foreach (var item in _tempSiparisDetay)
            {
                _siparisDetayServis.EkleyadaGuncelle(new MPSIPARISDETAY()
                {
                    STOKID = item.MPSTOK.Select(x => x.ID).FirstOrDefault()
                });
            }
            
            //DataGrideSiparisleriGetir();
        }




        public void Temizle(Control.ControlCollection ctrlCollection)           
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name== "DGVStoKSec")
            {
                _fStokList.ShowDialog();

                _tempPocokalem = new PocoSiparisKalem()
                {
                    StokKodu = _tempStok.KOD,
                    StokAdı = _tempStok.ADI,
                    Birim = _tempStok.MPSTOKOLCUBR.Where(x => x.NUM == 1).Select(x => x.MPOLCUBR.ADI).FirstOrDefault().ToString(),
                    Kdv = _tempStok.SATISKDV,
                    Doviz = "TL", //_tempStok.SDOVIZID 


                };

                DGVFiyatList.DataSource = _tempStok.MPSTOKFIYATLISTHAR.Select(x => x.MPSTOKFIYATLIST.FIYATLISTADI).ToList();
                _tempSiparisDetay[e.RowIndex] = _tempPocokalem;
                dataGridView1.DataSource = _tempSiparisDetay;
                dataGridView1.Refresh();
            }
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Down)
            {
                dataGridView1.DataSource = "";
                _tempSiparisDetay.Add(new PocoSiparisKalem());
                dataGridView1.DataSource = _tempSiparisDetay;
                dataGridView1.Refresh();
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Selected = true;
            }
        }
    }
}
