using MEYPAK.BLL.DEPO;
using MEYPAK.BLL.STOK;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.DAL.Concrete.EntityFramework.Repository;
using MEYPAK.Entity.Models;
using MEYPAK.Interfaces.Depo;
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

namespace MEYPAK.PRL.DEPO
{
    public partial class FSevkiyatCekiPanel : Form
    {
        public FSevkiyatCekiPanel()
        {
            InitializeComponent();
        }
        static MEYPAKContext context=NinjectFactory.CompositionRoot.Resolve<MEYPAKContext>();
        IStokServis _stokServis = new StokManager(new EFStokRepo(context));
        IStokSevkiyatListServis _stokSevkiyatListServis = new StokSevkiyatListManager(new EFStokSevkiyatList(context));
        List<MPSTOK> _tempStok;
        List<MPSTOK> _Stok;
        public MPDEPOEMIR _tempEmir;
        private void button1_Click(object sender, EventArgs e)
        {
            _stokSevkiyatListServis.Ekle(new MPSTOKSEVKİYATLİST()
            {
                STOKID = int.Parse(comboBox1.SelectedValue.ToString()),
                EMIRID=_tempEmir.ID,
                DEPOID=_tempEmir.MPSIPARIS.DEPOID,
                MIKTAR=0,
                SIPARISMIKTARI=_tempEmir.MPSIPARIS.MPSIPARISDETAY.Where(x=>x.STOKID.ToString()== comboBox1.SelectedValue.ToString()).FirstOrDefault().MIKTAR,
                BIRIMID= _tempEmir.MPSIPARIS.MPSIPARISDETAY.Where(x => x.STOKID.ToString() == comboBox1.SelectedValue.ToString()).FirstOrDefault().BIRIMID,
                


            });
        }

        //private void comboBox1_TextChanged(object sender, EventArgs e)
        //{

        //    //comboBox1.DataSource= (from aa in _stokServis.Listele() where aa.KOD.StartsWith(comboBox1.Text) select aa).ToList();
        //}

        private void FSevkiyatCekiPanel_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource= _tempStok = _stokServis.Listele();
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox1.DisplayMember = "KOD";
            comboBox1.ValueMember = "ID";
            comboBox1.DataSource= _tempStok.Select(x => new{KOD=x.KOD,ID=x.ID }).ToList();
            //comboBox1.AutoCompleteCustomSource=(_tempStok.Select(x=> new { x.KOD,x.ID }).ToArray()); 
          
            
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
   
           
        }
    }
}
