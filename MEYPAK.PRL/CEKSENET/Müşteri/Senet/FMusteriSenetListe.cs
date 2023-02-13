using DevExpress.XtraEditors;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.CARI;
using MEYPAK.Entity.PocoModels.CEKSENET;
using MEYPAK.PRL.CEKSENET.Müşteri.Çek;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEYPAK.PRL.CEKSENET.Müşteri.Senet
{
    public partial class FMusteriSenetListe : XtraForm
    {
        public FMusteriSenetListe(string form = "", string islem = "")
        {
            InitializeComponent();
            _islem = islem;
            _form = form;
            _cariServis = new GenericWebServis<PocoCARIKART>();
            _musteriSenetServis = new GenericWebServis<PocoMUSTERISENETSB>();
            _musteriSenetHarServis=new GenericWebServis<PocoMUSTERISENETHAR>();
        }
        string _islem;
        string _form;
        FMusteriSenetCariCiro fMusteriSenetCariCiro;
        FMusteriSenetProtesto fMusteriSenetProtesto;
        FMusteriSenetTahsilat fMusteriSenetTahsilat;
        FMusteriSenetTeminat fMusteriSenetTeminat;
        GenericWebServis<PocoMUSTERISENETSB> _musteriSenetServis;
        GenericWebServis<PocoCARIKART> _cariServis;
        GenericWebServis<PocoMUSTERISENETHAR> _musteriSenetHarServis;

        private void FMusteriSenetListe_Load(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name.Contains("FMusteriSenetCariCiro"))
                    fMusteriSenetCariCiro = (FMusteriSenetCariCiro)frm;
                if (frm.Name.Contains("FMusteriSenetProtesto"))
                    fMusteriSenetProtesto = (FMusteriSenetProtesto)frm;
                if (frm.Name.Contains("FMusteriSenetTahsilat"))
                    fMusteriSenetTahsilat = (FMusteriSenetTahsilat)frm;
                if (frm.Name.Contains("FMusteriSenetTeminat"))
                    fMusteriSenetTeminat = (FMusteriSenetTeminat)frm;
            }
            _musteriSenetServis.Data(ServisList.MusteriSenetSBListeServis);
            _cariServis.Data(ServisList.CariListeServis);

            gridControl1.DataSource = _musteriSenetServis.obje.Where(x => x.ISLEM == 0).Select(x => new
            {
                x.id,
                x.BORDRONO,
                x.SENETNO,
                _cariServis.obje.Where(y=> y.id==x.CARIID).FirstOrDefault().unvan,
                x.TUTAR,
                x.VADETARIHI
            }) ;
            gridView1.Columns["id"].Visible = false;

        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            if (_islem == "FMusteriCekCariCiro")
                fMusteriSenetCariCiro._tempCek = _musteriSenetServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("id").ToString()).FirstOrDefault();

            this.Close();
        }
    }
}
