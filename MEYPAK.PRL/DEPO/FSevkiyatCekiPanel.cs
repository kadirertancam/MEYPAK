using MEYPAK.BLL.Assets;
using MEYPAK.BLL.DEPO;
using MEYPAK.BLL.STOK;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.DAL.Concrete.EntityFramework.Repository;
using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Entity.Models.SIPARIS;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels;
using MEYPAK.Entity.PocoModels.DEPO;
using MEYPAK.Entity.PocoModels.SIPARIS;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Depo;
using MEYPAK.Interfaces.Siparis;
using MEYPAK.Interfaces.Stok;
using MEYPAK.PRL.Assets;
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
    public partial class FSevkiyatCekiPanel : Form
    {
        GenericWebServis<PocoSTOK> _tempPocoStok;
        public FSevkiyatCekiPanel()
        {
            InitializeComponent();
            _tempStokSevkiyatList = new PocoSTOKSEVKIYATLIST();
            _tempPocoStok = new GenericWebServis<PocoSTOK>();
            _tempPocoStok.Data(ServisList.StokListeServis);
            _tempStok = _tempPocoStok.obje;
            _stokServis = new GenericWebServis<PocoSTOK>();
            _olcuBrServis = new GenericWebServis<PocoOLCUBR>();
            _depoServis = new GenericWebServis<PocoDEPO>();
            _siparisDetayServis = new GenericWebServis<PocoSIPARISDETAY>();
            _siparisSevkEmriHar = new GenericWebServis<PocoSIPARISSEVKEMIRHAR>(); 
            _depoCekiListServis = new GenericWebServis<PocoDEPOCEKILIST>();
            _stokSevkiyatListServis = new GenericWebServis<PocoSTOKSEVKIYATLIST>();


        }  
        GenericWebServis<PocoDEPOCEKILIST> _depoCekiListServis;
        GenericWebServis<PocoSTOK> _stokServis;
        GenericWebServis<PocoOLCUBR> _olcuBrServis;
        GenericWebServis<PocoDEPO> _depoServis;
        GenericWebServis<PocoSIPARISDETAY> _siparisDetayServis;
        GenericWebServis<PocoSIPARISSEVKEMIRHAR> _siparisSevkEmriHar;
        GenericWebServis<PocoSTOKSEVKIYATLIST> _stokSevkiyatListServis;
        List<PocoSTOK> _tempStok;
        PocoSTOK _Stok;
        public PocoDEPOEMIR _tempEmir;
        PocoSTOKSEVKIYATLIST _tempStokSevkiyatList;
        
        public List<PocoDEPOCEKILIST> _tempList; 
        private void button1_Click(object sender, EventArgs e)
        { 


            //_stokServis.Data(ServisList.StokListeServis);
            //_Stok = _tempPocoStok.obje.Where(x => x.ID.ToString() == comboBox1.SelectedValue.ToString()).FirstOrDefault();
            //_tempStokSevkiyatList = new PocoSTOKSEVKIYATLIST()
            //{
            //    STOKID = _Stok.ID,
            //    EMIRID = _tempEmir.ID,
            //    DEPOID = _tempEmir.MPSIPARIS.DEPOID,
            //    MIKTAR = 0,
            //    SIPARISMIKTARI = _tempEmir.MPSIPARIS.MPSIPARISDETAYList.Where(x => x.STOKID.ToString() == comboBox1.SelectedValue.ToString()).FirstOrDefault().MIKTAR,
            //    BIRIMID = _Stok.MPSTOKOLCUBR.Where(x => x.NUM == 1).Select(x => x.MPOLCUBR.ID).FirstOrDefault(),
            // //    MPOLCUBR = _Stok.MPSTOKOLCUBRList.Where(x => x.NUM == 1).Select(x => x.MPOLCUBR).FirstOrDefault(),
            //    MPDEPOEMIR=_tempEmir,
            //    MPSTOK=_Stok,


            //};
            //_tempList.Add(_tempStokSevkiyatList);
            //if (dataGridView1.DataSource != null)
            //{
            //    dataGridView1.DataSource = null;
            //}
            //dataGridView1.DataSource = _tempList.Select(x=> new PocoStokSevkiyatList()
            //{
            //    StokAdı = x.MPSTOK.ADI,
            //    StokKodu = x.MPSTOK.KOD,
            //    Birim = x.MPOLCUBR.ADI,
            //    Miktar = x.MIKTAR,
            //    ID = x.STOKID,
            //    MPSTOK=_Stok
            //}).ToList(); 
        }

        //private void comboBox1_TextChanged(object sender, EventArgs e)
        //{

        //    //comboBox1.DataSource= (from aa in _stokServis.Listele() where aa.KOD.StartsWith(comboBox1.Text) select aa).ToList();
        //}

        private void FSevkiyatCekiPanel_Load(object sender, EventArgs e)
        {
            _stokServis.Data(ServisList.StokListeServis);
            _olcuBrServis.Data(ServisList.OlcuBrListeServis);
            // _tempList.Add(new PocoStokSevkiyatList());
            gridControl1.DataSource = 
                _tempList.Select(x => new CekiPanelList { ID= x.id,StokKodu = _stokServis.obje.Where(z=>x.stokid==z.id).FirstOrDefault().kod, StokAdı = _stokServis.obje.Where(z => x.stokid == z.id).FirstOrDefault().adi, Birim = _olcuBrServis.obje.Where(z=>z.id==x.birimid).FirstOrDefault().adi,Miktar=x.miktar });
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox1.DisplayMember = "KOD";
            comboBox1.ValueMember = "id";
            comboBox1.DataSource = _tempStok.Select(x => new { KOD = x.kod, ID = x.id }).ToList(); 

            //comboBox1.AutoCompleteCustomSource=(_tempStok.Select(x=> new { x.KOD,x.ID }).ToArray()); 


        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
         
        }

        private void BTKaydet_Click(object sender, EventArgs e)
        {
            _siparisDetayServis.Data(ServisList.SiparisDetayListeServis);
            _siparisSevkEmriHar.Data(ServisList.SiparisSevkEmriHarListeServis); 
            int _id;
            for (int i = 0; i < gridView1.RowCount; i++) 
            {
                _id = _stokServis.obje.Where(x => x.kod == gridView1.GetRowCellValue(i,"StokKodu")).FirstOrDefault().id;

                _depoCekiListServis.Data(ServisList.DepoCekiListEkleServis,new PocoDEPOCEKILIST()
                {
                    id= Convert.ToInt32(gridView1.GetRowCellValue(i, "ID").ToString()),
                    stokid = _id, 
                    birimid = _siparisDetayServis.obje.Where(x => x.siparisid == _tempEmir.siparisid && x.stokid == _id).FirstOrDefault().birimid,
                    miktar = Convert.ToDecimal(gridView1.GetRowCellValue(i, "Miktar")),
                    isemriid=_tempEmir.id,depoid=_tempEmir.depoid

                    
                });
            }
            _depoCekiListServis.Data(ServisList.DepoCekiListListeServis);
            _stokSevkiyatListServis.Data(ServisList.StokSevkiyatListListeServis);
            var taaa = _stokSevkiyatListServis.obje.Where(x =>  x.emirid == _tempEmir.id);
            foreach (var item in taaa)
            {
                _stokSevkiyatListServis.Data(ServisList.StokSevkiyatListEkleServis,
                    new PocoSTOKSEVKIYATLIST()
                    {
                        id = item.id,
                        miktar = item.miktar,
                        birimid = item.birimid,
                        depoid = item.depoid,
                        emirid = item.emirid,
                        eskiid = item.eskiid,
                        guncellemetarihi = item.guncellemetarihi,
                        kayittipi = item.kayittipi,
                        kullaniciid = item.kullaniciid,
                        olusturmatarihi = item.olusturmatarihi,
                        sevkemriharid = item.sevkemriharid,
                        siparisdetayid = item.siparisdetayid,
                        siparismiktari = item.siparismiktari,
                        sirketid = item.sirketid,
                        stokid = item.stokid,
                        subeid = item.subeid,
                        kalanmiktar = item.miktar - _depoCekiListServis.obje.Where(x => x.stokid == item.stokid && x.isemriid == item.emirid).FirstOrDefault().miktar
                    });
            }
            this.Close();
        }
    }
}
