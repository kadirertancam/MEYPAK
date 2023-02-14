using DevExpress.XtraEditors;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.CARI;
using MEYPAK.Entity.PocoModels.CEKSENET;
using MEYPAK.Interfaces.CekSenet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEYPAK.PRL.CEKSENET.Müşteri.Çek
{
    public partial class FMusteriCekListe : XtraForm
    {
        public FMusteriCekListe(string form = "", string islem = "")
        {
            InitializeComponent();
            _islem = islem;
            _form = form;
            _cariServis = new GenericWebServis<PocoCARIKART>();
            _musteriCekServis = new GenericWebServis<PocoMUSTERICEKSB>();
        }
        string _islem;
        string _form;
        FMusteriCekCariCiro fMusteriCekCariCiro;
        FMusteriCekProtesto fMusteriCekProtesto;
        FMusteriCekTahsilat fMusteriCekTahsilat;
        FMusteriCekTeminat fMusteriCekTeminat;
        GenericWebServis<PocoMUSTERICEKSB> _musteriCekServis;
        GenericWebServis<PocoCARIKART> _cariServis;
        GenericWebServis<PocoMUSTERICEKHAR> _musteriCekHarServis;

        private void FMusteriCekListe_Load(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (_form == frm.Tag)
                {
                    if (frm.Name.Contains("FMusteriCekCariCiro"))
                        fMusteriCekCariCiro = (FMusteriCekCariCiro)frm;
                    if (frm.Name.Contains("FMusteriCekProtesto"))
                        fMusteriCekProtesto = (FMusteriCekProtesto)frm;
                    if (frm.Name.Contains("FMusteriCekTahsilat"))
                        fMusteriCekTahsilat = (FMusteriCekTahsilat)frm;
                    if (frm.Name.Contains("FMusteriCekTeminat"))
                        fMusteriCekTeminat = (FMusteriCekTeminat)frm;

                    _musteriCekServis.Data(ServisList.MusteriCekSBListeServis);
                    _cariServis.Data(ServisList.CariListeServis);
                 
                    gridControl1.DataSource = _musteriCekServis.obje.Where(x=> x.ISLEM==0).Select(x=> new
                    {
                        x.id,
                        x.BORDRONO,
                        x.CEKNO,
                        _cariServis.obje.Where(y=> y.id == x.CARIID).FirstOrDefault().unvan ,
                        x.TUTAR,
                        x.VADETARIH
                    });
                    gridView1.Columns["id"].Visible = false;
                }
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            if (_islem == "FMusteriCekCariCiro")
                fMusteriCekCariCiro._tempCek = _musteriCekServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("id").ToString()).FirstOrDefault();
            if (_islem == "FMusteriCekProtesto")
                fMusteriCekProtesto._tempCek = _musteriCekServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("id").ToString()).FirstOrDefault();

            this.Close();
        }
    }
}
