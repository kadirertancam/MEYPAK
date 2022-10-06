using MEYPAK.BLL.STOK;
using MEYPAK.DAL.Concrete.EntityFramewok.Repository;
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

namespace MEYPAK.PRL.SIPARIS
{
    public partial class FSiparis : Form
    {
        public FSiparis()
        {
            InitializeComponent();
        }

        ISiparisServis _siparisServis = new SiparisManager(new EFSiparisRepo(NinjectFactory.CompositionRoot.Resolve<MEYPAKContext>()));
        List<PocoSiparisKalem> _tempSiparisDetay=new List<PocoSiparisKalem>();
        private void FSiparis_Load(object sender, EventArgs e)
        {
            DataGrideSiparisleriGetir();
        }

        void DataGrideSiparisleriGetir()
        {
            _tempSiparisDetay.Add(new PocoSiparisKalem());
            dataGridView1.DataSource = _tempSiparisDetay; 
        }

        private void BTKaydet_Click(object sender, EventArgs e)
        {
            _siparisServis.EkleyadaGuncelle(new Entity.Models.MPSIPARIS()
            {
                ACIKLAMA = TBAciklama.Text,
                KUR = Convert.ToDecimal(TBKur.Text),
                BELGENO = TBBelgeNo.Text,
                VADETARIHI = DTPVadeTarihi.Value,
                GUNCELLEMETARIHI=DateTime.Now,
                VADEGUNU=Convert.ToInt32(TBSVadeGunu.Text),
             

                //DEPOID = _depoServis.Getir(x => x.DEPOADI == CBDepo.SelectedValue).FirstOrDefault().ID,


            });
            DataGrideSiparisleriGetir();
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
    }
}
