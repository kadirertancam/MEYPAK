using DevExpress.XtraEditors;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.Models.FORMYETKI;
using MEYPAK.Entity.PocoModels.FORMYETKI;
using MEYPAK.Entity.PocoModels.STOK;
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
    public partial class FHizmetKart : XtraForm
    {
        public PocoHIZMET _tempHizmet;
        public PocoHIZMETKATEGORI _tempHizmetKategori;
        GenericWebServis<PocoHIZMET> _hizmetServis;
        GenericWebServis<PocoHIZMETKATEGORI> _hizmetKategoriServis;
      
        public FHizmetKart()
        {
            InitializeComponent();
            _hizmetServis = new GenericWebServis<PocoHIZMET>();
            _hizmetKategoriServis= new GenericWebServis<PocoHIZMETKATEGORI>();
            _hizmetKategoriServis.Data(ServisList.HizmetKategoriListeServis);
        }

        void Doldur()
        {
            BTHizmetSec.Text = _tempHizmet.kod;
            TBHizmetAdi.Text = _tempHizmet.adi;
        
            TBAlısKod.Text = _tempHizmet.muhalis;
            TBSatisKod.Text = _tempHizmet.muhsatis;
            TBIadeKod.Text = _tempHizmet.muhiade;
            _tempHizmetKategori = _hizmetKategoriServis.obje.Where(x => x.id == _tempHizmet.kategoriid).FirstOrDefault();
            if (_tempHizmetKategori!=null)
            BTKategoriSec.Text = _tempHizmetKategori.adi;
        }

        private void BTHizmetSec_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FHizmetList fHizmetList = new FHizmetList(this.Tag.ToString(), "hizmetkart");
            fHizmetList.ShowDialog();
            if (_tempHizmet != null)
                if (_tempHizmet.id > 0)
                    Doldur();
        }

        private void BTStokKartiKaydet_Click(object sender, EventArgs e)
        {
          
            if (BTHizmetSec.Text != "")
            {
                if (_tempHizmetKategori!=null && BTKategoriSec.Text!="")
                {
                _hizmetServis.Data(ServisList.HizmetEkleServis , new PocoHIZMET()
                {
                    kod = BTHizmetSec.Text,
                    adi = TBHizmetAdi.Text,
                    //grupkodu
                    kategoriid = _tempHizmetKategori.id ,
                    muhalis = TBAlısKod.Text,
                    muhsatis = TBSatisKod.Text,
                    muhiade = TBIadeKod.Text,
                    userid = MPKullanici.ID
                });
                }
                else
                {
                    MessageBox.Show("Kategori Seçmeden Hizmet Ekleyemezsiniz!");
                }
            }
            else 
            {
                MessageBox.Show("Hizmet Kodu Girmeden Hizmet Ekleyemezsiniz!");
            }
            
         
        }

        private void BTKategoriSec_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FHizmetKategoriList fHizmetKategoriKart = new FHizmetKategoriList(this.Tag.ToString(), "hizmetkart");
            fHizmetKategoriKart.ShowDialog();
            if (_tempHizmetKategori != null)
                BTKategoriSec.Text = _tempHizmetKategori.adi; 
        }

        private void labelControl11_Click(object sender, EventArgs e)
        {

        }
    }
}
