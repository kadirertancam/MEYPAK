using DevExpress.Text.Interop;
using MEYPAK.BLL.Assets;
using MEYPAK.DAL.Abstract.CariDal;
using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Entity.PocoModels.CARI;
using MEYPAK.Entity.PocoModels.DEPO;
using MEYPAK.Entity.PocoModels.PARAMETRE;
using MEYPAK.Entity.PocoModels.SIPARIS;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Cari;
using MEYPAK.Interfaces.Depo;
using MEYPAK.Interfaces.Stok;
using MEYPAK.PRL.PARAMETRELER;
using MEYPAK.PRL.STOK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEYPAK.PRL.CARI
{
    public partial class FCariAltHesap : Form
    {
      
        public FCariAltHesap()
        {
            InitializeComponent();
            _cariAltHesapServis = new GenericWebServis<PocoCARIALTHES>();
            _parabirIMServis = new GenericWebServis<PocoPARABIRIM>();
            _parabirIMServis.Data(ServisList.ParaBirimiListeServis);
            CBDoviz.Properties.DataSource = _parabirIMServis.obje.Select(x => x.adi).ToList();
        }

        #region Tanımlar

        GenericWebServis<PocoCARIALTHES> _cariAltHesapServis;
        GenericWebServis<PocoPARABIRIM> _parabirIMServis;

        #endregion

        #region Metotlar

        public void Temizle(Control.ControlCollection ctrlCollection) //Formdaki textboxları temizler
        {

            foreach (Control ctrl in ctrlCollection)
            {
                if (ctrl is TextBoxBase)
                {
                    if (ctrl.Name != "TBCariAdi")
                        ctrl.Text = String.Empty;
                }
                else
                {
                    Temizle(ctrl.Controls);
                }
            }

        }
         void Doldur()
        {
            
            _cariAltHesapServis.Data(ServisList.CariAltHesListeServis);
            _parabirIMServis.Data(ServisList.ParaBirimiListeServis);
            DGAltHesap.DataSource = "";
            DGAltHesap.DataSource = _cariAltHesapServis.obje;
            CBDoviz.Properties.DataSource = _parabirIMServis.obje;

        }
        private void FCariAltHesap_Load(object sender, EventArgs e)
        {

           // DGAltHesapYapilandir();
            CBDoviz.EditValue = 0;
        }
        
        private void BTKaydet_Click(object sender, EventArgs e)
        {

            try
            {
                _cariAltHesapServis.Data(ServisList.CariAltHesEkleServis, new PocoCARIALTHES()
                {
                    adi = TBCariAdi.Text,
                    aktif = CBAktif.Checked==true?1:0,
                    dovizid = _parabirIMServis.obje.Where(x=>x.adi==CBDoviz.EditValue.ToString()).FirstOrDefault().id
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        void DGAltHesapYapilandir()
        {
            DGAltHesap.Name = "DGAltHesap";
            DGAltHesap.Text = "Döviz";
        }
        private void BTSil_Click(object sender, EventArgs e)
        {
           // _cariAltHesapServis.Data(ServisList.DepoSilServis, _cariAltHesapServis.obje.Where(x => x.id == Convert.ToInt32(DGAltHesap.GetFocusedRowCellValue("id"))).FirstOrDefault());
        }

        private void CBDoviz_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

#endregion
    }
}
