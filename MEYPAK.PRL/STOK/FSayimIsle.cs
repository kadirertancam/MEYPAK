using MEYPAK.BLL.STOK;
using MEYPAK.DAL.Concrete.EntityFramework.Repository;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.DAL.Concrete.EntityFramework.Repository;
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
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.BLL.Assets;

namespace MEYPAK.PRL.STOK
{
    public partial class FSayimIsle : Form
    {
        public FSayimIsle()
        {
            InitializeComponent();
            fSayimList = new FSayimList();
            _stokSayimServis = new GenericWebServis<PocoSTOKSAYIM>();
            _stokHarServis = new GenericWebServis<PocoSTOKHAR>(); 
        } 
        GenericWebServis<PocoSTOKSAYIM> _stokSayimServis ; 
        GenericWebServis<PocoSTOKHAR> _stokHarServis ; 
        public PocoSTOKSAYIM _tempSayim;
        public int _id;
        FSayimList fSayimList;
        private void button2_Click(object sender, EventArgs e)
        {
            _stokSayimServis.Data(ServisList.StokSayimListeServis);
            foreach (var item in _stokSayimServis.obje.Where(x=>x.SAYIMTARIHI==dateTimePicker1.Value && x.ACIKLAMA==textBox1.Text))
            { 
                foreach (var item2 in item.MPSTOKSAYIMHAR)
                {

                
                _stokHarServis.Data(ServisList.StokHarEkleServis,new PocoSTOKHAR()
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
                _stokSayimServis.Data(ServisList.StokSayimEkleServis,item);
            }
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            fSayimList.ShowDialog();
            if (_tempSayim != null)
            {
                textBox1.Text = _tempSayim.ACIKLAMA;
                dateTimePicker1.Value = _tempSayim.SAYIMTARIHI;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _stokSayimServis.Data(ServisList.StokSayimListeServis);
            _stokHarServis.Data(ServisList.StokHarListeServis);

            foreach (var item2 in _stokSayimServis.obje.Where(x => x.SAYIMTARIHI == dateTimePicker1.Value && x.ACIKLAMA == textBox1.Text).FirstOrDefault().MPSTOKSAYIMHAR)
            {
                var _temp = _stokHarServis.obje.Where(x => x.STOKID == item2.STOKID && x.SAYIMID == item2.ID).ToList();
                if(_temp.Count() > 0)
                {
                    _stokHarServis.Data(ServisList.StokHarSilServis,null,null, _temp);
                }

            }



        }
    } 
}
