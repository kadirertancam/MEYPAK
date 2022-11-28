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
using DevExpress.XtraEditors;
using MEYPAK.Interfaces;
using Newtonsoft.Json;
using System.IO;
using System.Net.Http;

namespace MEYPAK.PRL.STOK
{
    public partial class FSayimIsle : XtraForm
    {
        public FSayimIsle()
        {
            InitializeComponent();

            _stokSayimServis = new GenericWebServis<PocoSTOKSAYIM>();
            _stokHarServis = new GenericWebServis<PocoSTOKHAR>();
            _stokSayimHarServis = new GenericWebServis<PocoSTOKSAYIMHAR>();
            _stokServis = new GenericWebServis<PocoSTOK>();
        }

        #region Tanımlar
        GenericWebServis<PocoSTOKSAYIM> _stokSayimServis;
        GenericWebServis<PocoSTOKSAYIMHAR> _stokSayimHarServis;
        GenericWebServis<PocoSTOKHAR> _stokHarServis;
        GenericWebServis<PocoSTOK> _stokServis;
        public PocoSTOKSAYIM _tempSayim;
        public int _id;


        #endregion

        #region Metotlar

        private void BTSayimSec_Properties_Click(object sender, EventArgs e)
        {
            FSayimList fSayimList = new FSayimList(this.Tag.ToString(), "SayimIsle");
            fSayimList.ShowDialog();
            if (_tempSayim != null)
            {
                BTSayimSec.Text = _tempSayim.aciklama;
                DTSayimTar.EditValue = _tempSayim.sayimtarihi;
                TBDurum.Text = _tempSayim.durum == 0 ? "Onaylanmadı" : "Onaylandı";

            }
        }

        private void BTSayimIsle_Click(object sender, EventArgs e)
        {
            if (_tempSayim != null)
            {
                _stokSayimHarServis.Data(ServisList.StokSayimHarListeServis);
                foreach (var item in _stokSayimHarServis.obje.Where(x => x.stoksayimid == _tempSayim.id))
                {
                    _stokHarServis.Data(ServisList.StokHarListeServis);
                    List < PocoSTOKHAR > stokharlist = _stokHarServis.obje.Where(x => x.stokid == item.stokid&&x.depoid==_tempSayim.depoid).ToList();
                    decimal a =  item.miktar - (stokharlist.Where(x => x.io == 1 && x.depoid == item.depoid && x.kayittipi==0).Sum(x => x.miktar) - stokharlist.Where(x => x.io == 0 && x.depoid == item.depoid && x.kayittipi == 0).Sum(x => x.miktar)) ;
                    _stokHarServis.Data(ServisList.StokHarEkleServis,new PocoSTOKHAR()
                    {    
                        hareketturu = 7,
                        birim = item.birimid,
                        stokid = item.stokid,
                        depoid = item.depoid,
                        sayimid = item.stoksayimid,
                        miktar = a <0 ? a*-1: a,
                        io = a >0 ? 1 : 0,
                    });
                }
                _tempSayim.durum = 1;
                _stokSayimServis.Data(ServisList.StokSayimEkleServis,_tempSayim);
                TBDurum.Text = "Onaylandı";
                MessageBox.Show("Sayım başarıyla işlendi.");
            }
            else
            {
                MessageBox.Show("İşlenecek Sayım bulunamadı. Lütfen bir cari seçiniz!");
            }



            //_stokServis.Data(ServisList.StokListeServis);
            //_stokSayimServis.Data(ServisList.StokSayimListeServis);
            //foreach (var item in _stokSayimServis.obje.Where(x => x.sayimtarihi == (DateTime)DTSayimTar.EditValue && x.aciklama == BTSayimSec.Text))
            //{
            //    foreach (var item2 in _stokSayimHarServis.obje.Where(x => item.id == x.stoksayimid))
            //    {
            //        _stokHarServis.Data(ServisList.StokHarEkleServis, new PocoSTOKHAR()
            //        {
            //            stokid = item2.stokid,
            //            aciklama = "Sayım",
            //            miktar = item2.miktar,
            //            birim = item2.birimid,
            //            hareketturu = 7,
            //            depoid = item.depoid,
            //            netfiyat = item2.fiyat,
            //            kdv = _stokServis.obje.Where(z => z.id == item2.stokid).FirstOrDefault().aliskdv,
            //            kayittipi = 0,
            //            io = 1,
            //            sayimid = item.id
            //        });
            //    }
            //    item.durum = 1;
            //    _stokSayimServis.Data(ServisList.StokSayimEkleServis, item);


        }

        private void BTKaldir_Click(object sender, EventArgs e)
        {
            if (_tempSayim != null)
            {
                _stokSayimServis.Data(ServisList.StokSayimListeServis);
                _stokHarServis.Data(ServisList.StokHarListeServis);

                foreach (var item in _stokHarServis.obje.Where(z => z.kayittipi==0 && z.sayimid == _tempSayim.id))
                {
                    _stokHarServis.Data(ServisList.StokHarDeleteByIdServis, id: item.id.ToString(),method: HttpMethod.Post); 
                }
                _tempSayim.durum = 0;
                _stokSayimServis.Data(ServisList.StokSayimEkleServis,_tempSayim);
                TBDurum.Text = "Onaylanmadı";
                MessageBox.Show("Sayım İşlemi Başarıyla Kaldırıldı!");
            }
        }






        #endregion

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
