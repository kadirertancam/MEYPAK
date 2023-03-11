using DevExpress.XtraEditors;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.DEPO;
using MEYPAK.Entity.PocoModels.MUSTAHSIL;
using MEYPAK.PRL.SIPARIS.Raporlar;
using MEYPAK.PRL.STOK.Raporlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEYPAK.PRL.SIPARIS
{
    public partial class FMustahsilList : XtraForm
    {
        public FMustahsilList(string tag = "", string islem = "")
        {
            InitializeComponent();
            _form = tag;
            _islem = islem;
        }
        #region TANIMLAR
        FMustahsil fMustahsil;
        GenericWebServis<PocoMUSTAHSIL> mustahsilServis;
        GenericWebServis<PocoDEPO> depoServis;
        GenericWebServis<PocoMUSTAHSILCARI> mustahsilCariServis;
        string _form, _islem;
        #endregion

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (_islem=="FMustahsil")
            {
                if(fMustahsil!=null)
                    fMustahsil._tempFatura = mustahsilServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
            }
            this.Close();
        }

        private void FMustahsilList_Load(object sender, EventArgs e)
        {
            mustahsilServis = new GenericWebServis<PocoMUSTAHSIL>();
            depoServis = new GenericWebServis<PocoDEPO>();
            mustahsilCariServis = new GenericWebServis<PocoMUSTAHSILCARI>();
            foreach (Form  frm in Application.OpenForms)
            {
                if (_form == frm.Tag)
                {

                    if (frm.Name.Contains("FMustahsil"))
                        fMustahsil = (FMustahsil)frm;
                }
            }

            mustahsilServis.Data(ServisList.MustahsilListeServis);
            depoServis.Data(ServisList.DepoListeServis);
            mustahsilCariServis.Data(ServisList.MustahsilCariListeServis);
            gridControl1.DataSource = mustahsilServis.obje.Select(x => new
            {
                ID = x.id,
                MAKBUZNO = x.belgeno,
                MUSCARI = mustahsilCariServis.obje.Where(y=> y.id==x.mustahsilcariid).FirstOrDefault().ADISOYADI,
                TUTAR = x.geneltoplam,
                TARIH = x.faturatarihi,
                DEPO = depoServis.obje.Where(y => y.id == x.depoid).FirstOrDefault().aciklama,
            }) ;
            gridView1.Columns["ID"].Visible = false;
           gridControl1.RefreshDataSource();
        }
    }
}
