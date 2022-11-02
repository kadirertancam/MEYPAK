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
            foreach (var item in _stokSayimServis.obje.Where(x=>x.SAYIMTARIHI==dateTimePicker1.Value && x.ACIKLAMA==TBSayimAciklama.Text))
            { 
                foreach (var item2 in item.MPSTOKSAYIMHAR)
                {

                
                _stokHarServis.Data(ServisList.StokHarEkleServis,new PocoSTOKHAR()
                {
                    stokid =item2.STOKID,
                    aciklama="Sayım",
                    miktar=item2.MIKTAR,
                    birim=item2.BIRIMID,
                    hareketturu=7,
                    depoid=item.DEPOID,
                    netfiyat=item2.FIYAT,
                    kdv=item2.MPSTOK.aliskdv,
                    kayittipi=0,
                    io=1,
                    sayimid=item.id
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
                TBSayimAciklama.Text = _tempSayim.ACIKLAMA;
                dateTimePicker1.Value = _tempSayim.SAYIMTARIHI;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _stokSayimServis.Data(ServisList.StokSayimListeServis);
            _stokHarServis.Data(ServisList.StokHarListeServis);

            foreach (var item2 in _stokSayimServis.obje.Where(x => x.SAYIMTARIHI == dateTimePicker1.Value && x.ACIKLAMA == TBSayimAciklama.Text).FirstOrDefault().MPSTOKSAYIMHAR)
            {
                var _temp = _stokHarServis.obje.Where(x => x.stokid == item2.STOKID && x.sayimid == item2.id).ToList();
                if(_temp.Count() > 0)
                {
                    _stokHarServis.Data(ServisList.StokHarSilServis,null,null, _temp);
                }

            }



        }

       
    } 
}
