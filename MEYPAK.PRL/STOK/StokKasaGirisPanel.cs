using DevExpress.XtraEditors;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.DEPO;
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
    public partial class StokKasaGirisPanel : DevExpress.XtraEditors.XtraForm
    {
        public StokKasaGirisPanel()
        {
            InitializeComponent();
            _stokKasaServis = new GenericWebServis<PocoSTOKKASA>();
            DTPTarih.Text = DateTime.Now.ToString();
            CBDepo.Properties.DataSource = _depoServis.obje.Where(x => x.kayittipi == 0).Select(x => x.depoadi).ToList();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            _stokKasaHarServis.Data(ServisList.StokKasaHarEkleServis, new PocoSTOKKASAHAR()
            {
                belge_no = "",
                cariid = 0,
                faturadetayid = 0,
                faturaid = 0,
                io = 1,
                irsaliyedetayid = 0,
                irsaliyeid = 0,
                kasaid = _tempKasa.id,
                kayittipi = 0,
                miktar = decimal.Parse(TBMiktar.Text),
                sarfdetayid = 0,
                sarfid = 0,
                stokid = 0,
                depoid= _depoServis.obje.Where(x=>x.depoadi==CBDepo.Text).FirstOrDefault().id
            });

        }
        GenericWebServis<PocoSTOKKASA> _stokKasaServis;
        GenericWebServis<PocoDEPO> _depoServis;
        GenericWebServis<PocoSTOKKASAHAR> _stokKasaHarServis;
        FStokKasaList2 _stokKasa;
        public PocoSTOKKASA _tempKasa;
        private void buttonEdit1_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            _stokKasaServis.Data(ServisList.StokKasaListeServis);
            _stokKasa = new FStokKasaList2(this.Tag.ToString(),"StokKasaGirisPanel");
            _stokKasa.ShowDialog();
            TBKasaKoduSec.Text = _tempKasa.kasakodu;
            TBKasaAdi.Text = _tempKasa.kasaadi;

        }

        private void buttonEdit1_Properties_ButtonClick_1(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            

        }
    }
}