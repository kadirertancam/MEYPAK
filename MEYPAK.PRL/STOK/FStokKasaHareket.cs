using DevExpress.XtraEditors;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.CARI;
using MEYPAK.Entity.PocoModels.STOK;
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
    public partial class FStokKasaHareket : XtraForm
    {
        public FStokKasaHareket()
        {
            InitializeComponent();
            _stokKasaMarkaServis = new GenericWebServis<PocoSTOKKASAMARKA>();
            _stokKasaHarCariLists = new List<StokKasaHarCariList>();
        }
        GenericWebServis<PocoCARIHAR> _cariHarServis;
        GenericWebServis<PocoCARIKART> _cariServis;
        GenericWebServis<PocoSTOKKASAMARKA> _stokKasaMarkaServis;
        GenericWebServis<PocoSTOKKASAHAR> _stokKasaHarServis;
        List<StokKasaHarCariList> _stokKasaHarCariLists;
        private void listBoxControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void FStokKasaHareket_Load(object sender, EventArgs e)
        {
            _stokKasaMarkaServis.Data(ServisList.StokKasaMarkaListeServis);
            gridControl2.DataSource = _stokKasaMarkaServis.obje.Select(x=>new { KASAID=x.id ,ADI = x.adi }); 
        }

        private void tileView1_Click(object sender, EventArgs e)
        {
            _cariServis.Data(ServisList.CariListeServis);
            _cariHarServis.Data(ServisList.CariHarListeServis);
            _stokKasaHarServis.Data(ServisList.StokKasaHarListeServis);
            //foreach (var item in _stokKasaHarServis.obje.Where(x=>x.kasaid==grid))
            //{
            //    _stokKasaHarCariLists.Add(new StokKasaHarCariList()
            //    {
            //        CARIID = item.id,
            //        ADI=_cariServis.obje.Where(x=>x.id==item.id).FirstOrDefault().adi 
            //    });
            //}
            gridControl3.DataSource=_stokKasaHarCariLists;
        }
    }
}
