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
using MEYPAK.BLL.DEPO;

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
            CBDepo.DataSource = _depoServis.Listele().Select(x => x.DEPOADI).ToList();
        }
        static MEYPAKContext context = NinjectFactory.CompositionRoot.Resolve<MEYPAKContext>();
        ISiparisServis _siparisServis = new SiparisManager(new EFSiparisRepo(context));
        ISiparisDetayServis _siparisDetayServis = new SiparisDetayManager(new EFSiparisDetayRepo(context));
        IStokServis _stokServis = new StokManager(new EFStokRepo(context));
        IDepoServis _depoServis = new DepoManager(new EFDepoRepo(context));
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
            dataGridView1.Columns["StokId"].Visible = false;
            dataGridView1.Columns["MPSTOK"].Visible = false;
            dataGridView1.Columns["DGVStoKSec"].DisplayIndex = 1;
            


        }

        private void BTKaydet_Click(object sender, EventArgs e)
        {

            
            _stokServis.Listele();
            var _tempp = _siparisServis.Ekle(new Entity.Models.MPSIPARIS()
            {
                ACIKLAMA = TBAciklama.Text,
                KUR = Convert.ToDecimal(TBKur.Text),
                BELGENO = TBBelgeNo.Text,
                VADETARIHI = DTPVadeTarihi.Value,
                GUNCELLEMETARIHI = DateTime.Now,
                VADEGUNU = Convert.ToInt32(TBSVadeGunu.Text),
                CARIADI = TBCariAdi.Text,
                CARIID = 0,
                DEPOID = _depoServis.Getir(x => x.DEPOADI == CBDepo.SelectedValue).FirstOrDefault().ID,
                DOVIZID = 0,
                ISKONTOTOPLAM =  _tempSiparisDetay.Sum(x => x.İskontoTutarı),
                KDVTOPLAM = _tempSiparisDetay.Sum(x=>x.KdvTutarı),
                BRUTTOPLAM =_tempSiparisDetay.Sum(x=>x.BrütToplam),
                NETTOPLAM=_tempSiparisDetay.Sum(x=>x.NetToplam),
                GENELTOPLAM=_tempSiparisDetay.Sum(x=>x.KdvTutarı)+ _tempSiparisDetay.Sum(x => x.BrütToplam),
               
                 


            });

            foreach (var item in _tempSiparisDetay)
            {
                 
                _siparisDetayServis.EkleyadaGuncelle(new MPSIPARISDETAY()
                {
                    STOKID = item.StokId,
                    STOKADI=item.MPSTOK.ADI,
                    ACIKLAMA=item.Acıklama,
                    KDV=item.Kdv,
                    NETTOPLAM= item.NetToplam*item.Miktar,
                    NETFIYAT=item.NetFiyat,
                    BIRIMID=  item.MPSTOK.MPSTOKOLCUBR.Where(x=>x.NUM==1).Select(x=>x.MPOLCUBR.ID).FirstOrDefault(),
                    DOVIZID =0,
                    MIKTAR= item.Miktar,
                    ISTKONTO1= item.İskonto1,
                    ISTKONTO2=item.İskonto2,
                    ISTKONTO3=item.İskonto3,
                    SIPARISID=_tempp.ID,
                    BRUTFIYAT=item.BrütFiyat,
                    BRUTTOPLAM=item.BrütFiyat*item.Miktar,
                    BEKLEYENMIKTAR=0,
                    HARIKETDURUMU=0,
                    LISTEFIYATID=0,
                    TIP=0,
                    

                   
                   
                    

                    
                }) ;
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
                    StokId = _tempStok.ID,
                    MPSTOK=_tempStok,
                    StokKodu = _tempStok.KOD,
                    StokAdı = _tempStok.ADI,
                    Birim = _tempStok.MPSTOKOLCUBR.Where(x => x.NUM == 1).Select(x => x.MPOLCUBR.ADI).FirstOrDefault().ToString(),
                    Kdv = _tempStok.SATISKDV,
                    Doviz = "TL", //_tempStok.SDOVIZID 


                };
                IStokFiyatListServis stokFiyatListServis = new StokFiyatListManager(new EFStokFiyatListRepo(context)); 
                IStokFiyatListHarServis stokFiyatListHarServis = new StokFiyatListHarManager(new EFStokFiyatListHarRepo(context));
                stokFiyatListServis.Listele();
                DGVFiyatList.DataSource = _tempStok.MPSTOKFIYATLISTHAR.Select(x => x.MPSTOKFIYATLIST.FIYATLISTADI==null?"": x.MPSTOKFIYATLIST.FIYATLISTADI).ToList();
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

        private void dataGridView1_Leave(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            decimal birimfiyat,kdv,bsnc,brutfiyat,netfiyat,nettoplam,brüttoplam, geneltoplam,isktoplam,kdvtoplam,miktar;
            if (CHBKdvDahil.Checked == false)
            {
                birimfiyat = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["BirimFiyat"].EditedFormattedValue);
                kdv = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["Kdv"].EditedFormattedValue);
                miktar=_tempSiparisDetay.Where(x => x.StokId.ToString() == dataGridView1.Rows[e.RowIndex].Cells["StokId"].Value.ToString()).FirstOrDefault().Miktar;
                isktoplam = (birimfiyat * Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["İskonto1"].EditedFormattedValue)) / 100;
                isktoplam += (isktoplam * Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["İskonto2"].EditedFormattedValue)) / 100;
                isktoplam += (isktoplam * Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["İskonto3"].EditedFormattedValue)) / 100;
                nettoplam = birimfiyat * miktar;
                brutfiyat = birimfiyat - isktoplam;
                kdvtoplam = ((brutfiyat * kdv / 100) * miktar);
                brüttoplam = brutfiyat * miktar;
                geneltoplam = brüttoplam;
            }
            else
            { 
                kdv = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["BirimFiyat"].EditedFormattedValue) - (Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["BirimFiyat"].EditedFormattedValue) / (1+( Convert.ToDecimal(_tempSiparisDetay.Where(x => x.StokId.ToString() == dataGridView1.Rows[e.RowIndex].Cells["StokId"].Value.ToString()).FirstOrDefault().Kdv) / 100)));
                birimfiyat = (Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["BirimFiyat"].EditedFormattedValue))-kdv;
                netfiyat = birimfiyat;
               miktar = _tempSiparisDetay.Where(x => x.StokId.ToString() == dataGridView1.Rows[e.RowIndex].Cells["StokId"].Value.ToString()).FirstOrDefault().Miktar;
                nettoplam = birimfiyat * miktar ;
                isktoplam = (netfiyat* Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["İskonto1"].EditedFormattedValue))/100 ;
                isktoplam += (isktoplam * Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["İskonto2"].EditedFormattedValue)) / 100 ; 
                isktoplam += (isktoplam * Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["İskonto3"].EditedFormattedValue)) / 100 ;
                brutfiyat = netfiyat-isktoplam;
                kdvtoplam = ((brutfiyat * Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["Kdv"].EditedFormattedValue))/100) *miktar;
                brüttoplam=brutfiyat*miktar;
                geneltoplam = brüttoplam; 
                 
            }
            _tempSiparisDetay.Where(x => x.StokId.ToString() == dataGridView1.Rows[e.RowIndex].Cells["StokId"].Value.ToString()).FirstOrDefault().BrütFiyat = brutfiyat;
            _tempSiparisDetay.Where(x => x.StokId.ToString() == dataGridView1.Rows[e.RowIndex].Cells["StokId"].Value.ToString()).FirstOrDefault().BrütToplam = brüttoplam;
            _tempSiparisDetay.Where(x => x.StokId.ToString() == dataGridView1.Rows[e.RowIndex].Cells["StokId"].Value.ToString()).FirstOrDefault().NetToplam = nettoplam;
            _tempSiparisDetay.Where(x => x.StokId.ToString() == dataGridView1.Rows[e.RowIndex].Cells["StokId"].Value.ToString()).FirstOrDefault().İskontoTutarı = isktoplam;
            _tempSiparisDetay.Where(x => x.StokId.ToString() == dataGridView1.Rows[e.RowIndex].Cells["StokId"].Value.ToString()).FirstOrDefault().KdvTutarı = kdvtoplam;
            _tempSiparisDetay.Where(x => x.StokId.ToString() == dataGridView1.Rows[e.RowIndex].Cells["StokId"].Value.ToString()).FirstOrDefault().NetFiyat = birimfiyat;

            dataGridView1.Rows[e.RowIndex].Cells["BrütFiyat"].Value = decimal.Round(brutfiyat, 2, MidpointRounding.ToEven);
            dataGridView1.Rows[e.RowIndex].Cells["NetToplam"].Value = decimal.Round(nettoplam, 2, MidpointRounding.ToEven);
            dataGridView1.Rows[e.RowIndex].Cells["BrütToplam"].Value = decimal.Round(brüttoplam, 2, MidpointRounding.ToEven);
            dataGridView1.Rows[e.RowIndex].Cells["İskontoTutarı"].Value = decimal.Round(isktoplam * miktar, 2, MidpointRounding.ToEven);
            TBBrutToplam.Text = decimal.Round(_tempSiparisDetay.Sum(x => x.BrütToplam), 2, MidpointRounding.ToEven).ToString();
            TBIskontoToplam.Text = decimal.Round(_tempSiparisDetay.Sum(x => x.İskontoTutarı), 2, MidpointRounding.ToEven).ToString();
            TBKdvTutari.Text = decimal.Round(_tempSiparisDetay.Sum(x => x.KdvTutarı), 2, MidpointRounding.ToEven).ToString();
            TBGenelToplam.Text = decimal.Round(_tempSiparisDetay.Sum(x => x.BrütToplam + x.KdvTutarı), 2, MidpointRounding.ToEven).ToString();
            TBAraToplam.Text = decimal.Round(_tempSiparisDetay.Sum(x => x.NetToplam), 2, MidpointRounding.ToEven).ToString();
            dataGridView1.Refresh();


        }
    }
}
