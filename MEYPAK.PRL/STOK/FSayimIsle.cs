using MEYPAK.BLL.STOK;
using MEYPAK.DAL.Concrete.EntityFramewok.Repository;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.DAL.Concrete.EntityFramework.Repository;
using MEYPAK.Entity.Models;
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

namespace MEYPAK.PRL.STOK
{
    public partial class FSayimIsle : Form
    {
        public FSayimIsle()
        {
            InitializeComponent();
            fSayimList = new FSayimList();
        }
        IStokSayimServis _stokSayimServis = new StokSayimManager(new EFStokSayimRepo(NinjectFactory.CompositionRoot.Resolve<MEYPAKContext>()));
        IStokSayimHarServis _stokSayimHarServis = new StokSayimHarManager(new EFStokSayimHarRepo(NinjectFactory.CompositionRoot.Resolve<MEYPAKContext>()));
        IStokHarServis _stokHarServis = new StokHarManager(new EFStokHareketRepo(NinjectFactory.CompositionRoot.Resolve<MEYPAKContext>()));
        public MPSTOKSAYIM _tempSayim;
        public int _id;
        FSayimList fSayimList;
        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var item in _stokSayimServis.Listele())
            {
                foreach (var item2 in item.MPSTOKSAYIMHAR)
                {

                
                _stokHarServis.EkleyadaGuncelle(new MPSTOKHAR()
                {
                    STOKID =item2.STOKID,
                    ACIKLAMA="Sayım",
                    MIKTAR=item2.MIKTAR,
                    BIRIM=item2.BIRIMID,
                    HAREKETTURU=7,
                    DEPOID=item.DEPOID,
                    NETFIYAT=item2.FIYAT,
                    KDV=item2.MPSTOK.ALISKDV,
                    KAYITTIPI=0,
                    IO=1,
                    SAYIMID=item.ID
                            });
                }
                item.DURUM = 1;
                _stokSayimServis.EkleyadaGuncelle(item);
            }
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            fSayimList.ShowDialog();
            textBox1.Text = _tempSayim.ACIKLAMA;
            dateTimePicker1.Value = _tempSayim.SAYIMTARIHI;

        }
    }
}
