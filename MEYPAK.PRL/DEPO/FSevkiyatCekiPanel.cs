using MEYPAK.BLL.DEPO;
using MEYPAK.BLL.STOK;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.DAL.Concrete.EntityFramework.Repository;
using MEYPAK.Entity.Models;
using MEYPAK.Entity.PocoModels;
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
        public FSevkiyatCekiPanel()
        {
            InitializeComponent();
            _tempStokSevkiyatList = new MPSTOKSEVKİYATLİST();
            _tempStok = StaticContext._stokServis.Listele();
            _tempList = new List<MPSTOKSEVKİYATLİST>(); 
        } 
        
     
        List<MPSTOK> _tempStok;
        MPSTOK _Stok;
        public MPDEPOEMIR _tempEmir;
        MPSTOKSEVKİYATLİST _tempStokSevkiyatList;
        List<MPSTOKSEVKİYATLİST> _tempList; 
        private void button1_Click(object sender, EventArgs e)
        {
           _Stok= StaticContext._stokServis.Getir(x => x.ID.ToString() == comboBox1.SelectedValue.ToString()).FirstOrDefault();
            _tempStokSevkiyatList = new MPSTOKSEVKİYATLİST()
            {
                STOKID = _Stok.ID,
                EMIRID = _tempEmir.ID,
                DEPOID = _tempEmir.MPSIPARIS.DEPOID,
                MIKTAR = 0,
                SIPARISMIKTARI = _tempEmir.MPSIPARIS.MPSIPARISDETAY.Where(x => x.STOKID.ToString() == comboBox1.SelectedValue.ToString()).FirstOrDefault().MIKTAR,
                BIRIMID = _Stok.MPSTOKOLCUBR.Where(x => x.NUM == 1).Select(x => x.MPOLCUBR.ID).FirstOrDefault(),
                MPOLCUBR = _Stok.MPSTOKOLCUBR.Where(x => x.NUM == 1).Select(x => x.MPOLCUBR).FirstOrDefault(),
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
            dataGridView1.DataSource = new List<PocoStokSevkiyatList>(); 
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
            foreach (var item in (List<PocoStokSevkiyatList>)dataGridView1.DataSource)
            {

                StaticContext._stokSevkiyatListServis.Ekle(new MPSTOKSEVKİYATLİST()
                {

                    STOKID = item.MPSTOK.ID,
                    EMIRID = _tempEmir.ID,
                    BIRIMID = item.MPSTOK.MPSTOKOLCUBR.Where(x => x.MPOLCUBR.ADI.ToString() == item.Birim).Select(x => x.MPOLCUBR.ID).FirstOrDefault(),
                    MIKTAR = item.Miktar,
                    DEPOID = _tempEmir.MPSIPARIS.DEPOID,
                    SIRKETID = 0,
                    SIPARISMIKTARI = _tempEmir.MPSIPARIS.MPSIPARISDETAY.Where(x => x.STOKID == item.MPSTOK.ID).Sum(x => x.MIKTAR),
                    SUBEID=0,
                    KULLANICIID=0
                });
            }
        }
    }
}
