using DevExpress.XtraEditors;
using MEYPAK.BLL.Assets;
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
        GenericWebServis<PocoHIZMET> _hizmetServis;
        public FHizmetKart()
        {
            InitializeComponent();
            _hizmetServis = new GenericWebServis<PocoHIZMET>();
        }

        void Doldur()
        {
            BTHizmetSec.Text = _tempHizmet.kod;
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
                _hizmetServis.Data(ServisList.HizmetEkleServis , new PocoHIZMET()
                {
                    kod = BTHizmetSec.Text,
                    adi = TBHizmetAdi.Text,
                    //grupkodu
                    //kategori
                });
            }
            else 
            {
                MessageBox.Show("Hizmet Kodu Girmeden Hizmet Ekleyemezsiniz!");
            }
        }
    }
}
