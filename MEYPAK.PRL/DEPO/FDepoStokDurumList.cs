using DevExpress.XtraEditors;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels;
using MEYPAK.Entity.PocoModels.DEPO;
using MEYPAK.Entity.PocoModels.STOK;
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

namespace MEYPAK.PRL.DEPO
{
    public partial class FDepoStokDurumList : XtraForm
    {
        public FDepoStokDurumList(string StokKodu)
        {
            InitializeComponent();
            _stokKodu = StokKodu;
            _stokServis = new GenericWebServis<PocoSTOK>();
            _depoServis = new GenericWebServis<PocoDEPO>();
            _stokHarServis = new GenericWebServis<PocoSTOKHAR>();
        }
        string _stokKodu;
        GenericWebServis<PocoSTOK> _stokServis;
        GenericWebServis<PocoSTOKHAR> _stokHarServis;
        GenericWebServis<PocoDEPO> _depoServis;
        List<DepoDurumList> depoDurumLists;

        private void FDepoStokDurumList_Load(object sender, EventArgs e)
        {
            _stokServis.Data(ServisList.StokListeServis);
            _stokHarServis.Data(ServisList.StokHarListeServis);
            _depoServis.Data(ServisList.DepoListeServis);
            var _tempStok = _stokServis.obje.Where(x => x.kod == _stokKodu && x.kayittipi == 0).FirstOrDefault();
            gridControl1.DataSource = _depoServis.obje.Where(x=>x.kayittipi==0).Select(x => new { DepoAdı=x.depoadi,StokKodu=_tempStok.kod,StokAdı=_tempStok.adi,Miktar=_stokHarServis.obje.Where(z => z.depoid == x.id && z.io==1 && z.stokid==_tempStok.id&& z.kayittipi==0).Sum(z => z.miktar)- _stokHarServis.obje.Where(z => z.depoid == x.id && z.io==0 && z.stokid==_tempStok.id&& z.kayittipi==0).Sum(z => z.miktar) });
           
        }
    }
}
