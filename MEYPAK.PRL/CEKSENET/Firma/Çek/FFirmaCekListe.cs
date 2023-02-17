using DevExpress.XtraEditors;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.CARI;
using MEYPAK.Entity.PocoModels.CEKSENET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEYPAK.PRL.CEKSENET.Firma.Çek
{
    public partial class FFirmaCekListe : XtraForm
    {
        public FFirmaCekListe()
        {
            InitializeComponent();
            _cekFirmaServis = new GenericWebServis<PocoFIRMACEKSB>();
            _cariServis = new GenericWebServis<PocoCARIKART>();
        }
        GenericWebServis<PocoFIRMACEKSB> _cekFirmaServis;
        GenericWebServis<PocoCARIKART> _cariServis;

        private void FirmaCekListe_Load(object sender, EventArgs e)
        {
            _cekFirmaServis.Data(ServisList.FirmaCekSBListeServis);
            _cariServis.Data(ServisList.CariListeServis);
            gridControl1.DataSource = _cekFirmaServis.obje.Select(x=> new
            {
                CekNo=x.CEKNO,
                CekTarih=x.ODEMETARIH,
                CariAdi= _cariServis.obje.Where(y=>y.id== x.CARIID).FirstOrDefault().unvan ,
                Tutar = x.TUTAR
            });
        
        }
    }
}
