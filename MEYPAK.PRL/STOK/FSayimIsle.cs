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
            _stokSayimHarServis = new GenericWebServis<PocoSTOKSAYIMHAR>();
            _stokServis = new GenericWebServis<PocoSTOK>();
        } 
        GenericWebServis<PocoSTOKSAYIM> _stokSayimServis ; 
        GenericWebServis<PocoSTOKSAYIMHAR> _stokSayimHarServis ; 
        GenericWebServis<PocoSTOKHAR> _stokHarServis ; 
        GenericWebServis<PocoSTOK> _stokServis ; 
        public PocoSTOKSAYIM _tempSayim;
        public int _id;
        FSayimList fSayimList;
        private void button2_Click(object sender, EventArgs e)
        {
            _stokServis.Data(ServisList.StokListeServis);
            _stokSayimServis.Data(ServisList.StokSayimListeServis);
            foreach (var item in _stokSayimServis.obje.Where(x=>x.sayimtarihi ==dateTimePicker1.Value && x.aciklama==TBSayimAciklama.Text))
            { 
                foreach (var item2 in _stokSayimHarServis.obje.Where(x=>item.id==x.stoksayimid))
                {

                
                _stokHarServis.Data(ServisList.StokHarEkleServis,new PocoSTOKHAR()
                {
                    stokid =item2.stokid,
                    aciklama="Sayım",
                    miktar=item2.miktar,
                    birim=item2.birimid,
                    hareketturu=7,
                    depoid=item.depoid,
                    netfiyat=item2.fiyat,
                    kdv= _stokServis.obje.Where(z => z.id == item2.stokid).FirstOrDefault().aliskdv,
                    kayittipi=0,
                    io=1,
                    sayimid=item.id
                            });
                }
                item.durum = 1;
                _stokSayimServis.Data(ServisList.StokSayimEkleServis,item);
            }
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            fSayimList.ShowDialog();
            if (_tempSayim != null)
            {
                TBSayimAciklama.Text = _tempSayim.aciklama;
                dateTimePicker1.Value = _tempSayim.sayimtarihi;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _stokSayimServis.Data(ServisList.StokSayimListeServis);
            _stokHarServis.Data(ServisList.StokHarListeServis);

            foreach (var item2 in _stokSayimHarServis.obje.Where(z=>z.stoksayimid==_stokSayimServis.obje.Where(x => x.sayimtarihi == dateTimePicker1.Value && x.aciklama == TBSayimAciklama.Text).FirstOrDefault().id))
            {
                var _temp = _stokHarServis.obje.Where(x => x.stokid == item2.stokid && x.sayimid == item2.id).ToList();
                if(_temp.Count() > 0)
                {
                    _stokHarServis.Data(ServisList.StokHarSilServis,null,null, _temp);
                }

            }



        }

       
    } 
}
