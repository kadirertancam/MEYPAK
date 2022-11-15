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
using MEYPAK.Entity.Models.SIPARIS;
using MEYPAK.Entity.Models.STOK;

namespace MEYPAK.PRL.CARI
{
    public partial class FAltHesapList : Form
    {
        FCariKart fCariKart;
        int id;
        string _islem;
        string _form;

        public FAltHesapList(string form="", string islem = "")
        {
            InitializeComponent();
            this._islem = islem;
            this._form = form;

            _cariAltHesapServis = new GenericWebServis<PocoCARIALTHES>();
            _parabirIMServis = new GenericWebServis<PocoPARABIRIM>();
        }
        GenericWebServis<PocoCARIALTHES> _cariAltHesapServis;
        GenericWebServis<PocoPARABIRIM> _parabirIMServis;
        Form tempForm;
        private void FAltHesapList_Load(object sender, EventArgs e)
        {

            foreach (Form frm in Application.OpenForms)
            {
                if (_form == frm.Tag)
                {
                    if (frm.Name.Contains("FCariKart"))
                        fCariKart = (FCariKart)frm;
                    
                }
            }
            _cariAltHesapServis.Data(ServisList.CariListeServis);
            DGAltHesap.DataSource = _cariAltHesapServis.obje.Where(x => x.kayittipi == 0).Select(x => new {
                ID = x.id,
                AltHesapKodu = x.kod,
                Adı = x.adi,
                DövizTürü = _parabirIMServis.obje.Where(z => z.id == x.dovizid).FirstOrDefault().adi.ToString(),//Labellama
                OluşturmaTarihi = x.olusturmatarihi
            });
            DGAltHesap.Refresh();
            DGAltHesap.RefreshDataSource();
            
        }

        private void DGAltHesap_DoubleClick(object sender, EventArgs e)
        {
            _cariAltHesapServis.Data(ServisList.CariAltHesListeServis);
            if (_islem == "carikart")
            {
                if (fCariKart != null)
                    fCariKart._tempCARIALTHES = _cariAltHesapServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
            }
            this.Close();
        }
    }
}

