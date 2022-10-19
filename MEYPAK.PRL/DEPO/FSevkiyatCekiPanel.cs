using MEYPAK.BLL.Assets;
using MEYPAK.BLL.DEPO;
using MEYPAK.BLL.STOK;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.DAL.Concrete.EntityFramework.Repository;
using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels;
using MEYPAK.Entity.PocoModels.DEPO;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Depo;
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
            _tempStok = _tempPocoStok.obje;        } 
        
     
        List<PocoSTOK> _tempStok;
        PocoSTOK _Stok;
        public PocoDEPOEMIR _tempEmir;
        PocoSTOKSEVKIYATLIST _tempStokSevkiyatList;
        public List<PocoSTOKSEVKIYATLIST> _tempList; 
        private void button1_Click(object sender, EventArgs e)
        {
           _Stok= StaticContext._stokServis.Getir(x => x.ID.ToString() == comboBox1.SelectedValue.ToString()).FirstOrDefault();
            _tempStokSevkiyatList = new PocoSTOKSEVKIYATLIST()
            {
                STOKID = _Stok.ID,
                EMIRID = _tempEmir.ID,
                DEPOID = _tempEmir.MPSIPARIS.DEPOID,
                MIKTAR = 0,
                SIPARISMIKTARI = _tempEmir.MPSIPARIS.MPSIPARISDETAYList.Where(x => x.STOKID.ToString() == comboBox1.SelectedValue.ToString()).FirstOrDefault().MIKTAR,
                BIRIMID = _Stok.MPSTOKOLCUBRList.Where(x => x.NUM == 1).Select(x => x.MPOLCUBR.ID).FirstOrDefault(),
             //    MPOLCUBR = _Stok.MPSTOKOLCUBRList.Where(x => x.NUM == 1).Select(x => x.MPOLCUBR).FirstOrDefault(),
                MPDEPOEMIR=_tempEmir,
                MPSTOK=_Stok,


            };
            _tempList.Add(_tempStokSevkiyatList);
            if (dataGridView1.DataSource != null)
            {
                dataGridView1.DataSource = null;
            }
            dataGridView1.DataSource = _tempList.Select(x=> new PocoStokSevkiyatList()
            {
                StokAdı = x.MPSTOK.ADI,
                StokKodu = x.MPSTOK.KOD,
                Birim = x.MPOLCUBR.ADI,
                Miktar = x.MIKTAR,
                ID = x.STOKID,
                MPSTOK=_Stok
            }).ToList(); 
        }

        //private void comboBox1_TextChanged(object sender, EventArgs e)
        //{

        //    //comboBox1.DataSource= (from aa in _stokServis.Listele() where aa.KOD.StartsWith(comboBox1.Text) select aa).ToList();
        //}

        private void FSevkiyatCekiPanel_Load(object sender, EventArgs e)
        {
            // _tempList.Add(new PocoStokSevkiyatList());
            dataGridView1.DataSource = _tempList.Select(x => new PocoStokSevkiyatList { StokKodu = x.MPSTOK.KOD, StokAdı = x.MPSTOK.ADI, Birim = "0" }).ToList();
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox1.DisplayMember = "KOD";
            comboBox1.ValueMember = "ID";
            comboBox1.DataSource = _tempStok.Select(x => new { KOD = x.KOD, ID = x.ID }).ToList(); 

            //comboBox1.AutoCompleteCustomSource=(_tempStok.Select(x=> new { x.KOD,x.ID }).ToArray()); 


        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<PocoStokSevkiyatList> aaa = (List<PocoStokSevkiyatList>) dataGridView1.DataSource;
            int _id;
            foreach (var item in aaa)
            {
                _id = StaticContext._stokServis.Getir(x => x.KOD == item.StokKodu).FirstOrDefault().ID;
                StaticContext._stokSevkiyatListServis.OnYukle();
                StaticContext._stokSevkiyatListServis.EkleyadaGuncelle(new PocoSTOKSEVKIYATLIST()
                {

                    STOKID =_id,
                    EMIRID = _tempEmir.ID,
                    BIRIMID = StaticContext._siparisDetayServis.Getir(x=>x.SIPARISID==_tempEmir.SIPARISID && x.STOKID==_id).FirstOrDefault().BIRIMID,
                    MIKTAR = item.Miktar,
                    DEPOID = _tempEmir.MPSIPARIS.DEPOID,
                    SIRKETID = 0,
                    SIPARISMIKTARI = _tempEmir.MPSIPARIS.MPSIPARISDETAYList.Where(x => x.STOKID == _id).Sum(x => x.MIKTAR),
                    SIPARISDETAYID=_tempList.Where(x=>x.MPSIPARISDETAY.STOKID==_id && x.EMIRID==_tempEmir.ID ).FirstOrDefault().MPSIPARISDETAY.ID,
                    SUBEID=0,
                    KULLANICIID=0,SEVKEMRIHARID= _tempEmir.MPSIPARISSEVKEMRIHAR.Where(x => x.MPSIPARISDETAY.STOKID.ToString() == _id.ToString() && x.EMIRID == _tempEmir.ID).FirstOrDefault().ID
                });
            }
        }
    }
}
