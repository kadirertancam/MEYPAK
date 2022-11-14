using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.PRL.DEPO;
using MEYPAK.PRL.SIPARIS;
using MEYPAK.PRL.STOK;
using MEYPAK.PRL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MEYPAK.Entity.PocoModels.CARI;
using MEYPAK.Entity.PocoModels.PARAMETRE;
using MEYPAK.Interfaces.Parametre;
using MEYPAK.Interfaces.Stok;

namespace MEYPAK.PRL.CARI
{
    public partial class FAltHesapList : Form
    {
        FCariAltHesap fCariAltHesap;
        int id;
        string _form, _islem;

        public FAltHesapList(string form="", string islem = "")
        {
            InitializeComponent();
            this._islem = islem;
            this._form = form;
            _cariAltHesServis = new GenericWebServis<PocoCARIALTHES>();
            _cariAltHesServis.Data(ServisList.CariAltHesListeServis);
            _parabirIMServis = new GenericWebServis<PocoPARABIRIM>();
            _parabirIMServis.Data(ServisList.ParaBirimiListeServis);
        }
        GenericWebServis<PocoCARIALTHES> _cariAltHesServis;
        GenericWebServis<PocoPARABIRIM> _parabirIMServis;
        Form tempForm;

        private void gridView1_CellDoubleClick(object sender, EventArgs e)
        {
            _cariAltHesServis.Data(ServisList.CariAltHesListeServis);
            if (_islem == "carialthesap")
            {
                if (fCariAltHesap != null)
                    fCariAltHesap._tempAltHesap = _cariAltHesServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("id").ToString()).FirstOrDefault();
            }
            this.Close();
        }

        private void AltHesapList_Load(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (_form == frm.Tag)
                {
                    if (frm.Name.Contains("FCariAltHesap"))
                        fCariAltHesap = (FCariAltHesap)frm;
                }
            }
            _cariAltHesServis.Data(ServisList.CariAltHesListeServis);
            _parabirIMServis.Data(ServisList.ParaBirimiListeServis);
            DGAltHesap.DataSource = _cariAltHesServis.obje.Where(x => x.kayittipi == 0).Select(x => new
            {
                x.id,
                x.adi,
                x.kod,
                Doviz = _parabirIMServis.obje.Where(z => z.id == x.dovizid).FirstOrDefault().adi.ToString(),//Labellama
                x.olusturmatarihi
            });

       
        }

        
    }
}

