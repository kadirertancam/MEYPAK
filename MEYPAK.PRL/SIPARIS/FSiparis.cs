using MEYPAK.BLL.STOK;
using MEYPAK.DAL.Concrete.EntityFramework.Repository;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.DAL.Concrete.EntityFramework.Repository;
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
        private void FSiparis_Load(object sender, EventArgs e)
        {

        }

        void DataGrideSiparisleriGetir()
        {
            dataGridView1.DataSource = _siparisServis.Listele().ToList();
        }

        private void BTKaydet_Click(object sender, EventArgs e)
        {
            //_siparisServis.EkleyadaGuncelle(new Entity.Models.MPSIPARIS()
            //{
            //    ACIKLAMA = TBAciklama.Text,
            //    KUR = Convert.ToDecimal(TBKur.Text),
            //    BELGENO = TBBelgeNo.Text
            //    //DEPOID = _depoServis.Getir(x => x.DEPOADI == CBDepo.SelectedValue).FirstOrDefault().ID,


            //}
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
    }
}
