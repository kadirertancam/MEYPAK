using DevExpress.Mvvm.POCO;
using DevExpress.Text.Interop;
using MEYPAK.BLL.Assets;
using MEYPAK.DAL.Abstract.CariDal;
using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels;
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

        string islemtipi = "Kayıt";
        public FCariAltHesap()
        {
            InitializeComponent();
            _tempAltHesap = new PocoCARIALTHES();
            _tempAltHesap = new PocoCARIALTHES();
            _cariAltHesapServis = new GenericWebServis<PocoCARIALTHES>();
            _parabirIMServis = new GenericWebServis<PocoPARABIRIM>();
            _parabirIMServis.Data(ServisList.ParaBirimiListeServis);
            CBDoviz.Properties.DataSource = _parabirIMServis.obje.Select(x => x.adi).ToList(); //comboxun içini parabirim formundan doldurur
        }

        
        #region Tanımlar

        GenericWebServis<PocoCARIALTHES> _cariAltHesapServis;
        GenericWebServis<PocoPARABIRIM> _parabirIMServis;
        public PocoCARIALTHES _tempAltHesap;

        #endregion

        #region Metotlar
        private void FCariAltHesap_Load(object sender, EventArgs e)
        {
            DataGridDoldur();
            //CBDoviz.EditValue = 0;
        }
        int id;
        
        private void BTSil_Click(object sender, EventArgs e)
        {
           
            _cariAltHesapServis.Data(ServisList.CariAltHesListeServis);
            _cariAltHesapServis.Data(ServisList.CariAltHesSilServis, null, null, _cariAltHesapServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("id").ToString()).ToList());
            MessageBox.Show("Silme işlemi Başarılı");
            DataGridDoldur();
        }
        public void Temizle(Control.ControlCollection ctrlCollection) //Formdaki textboxları temizler
        {

            foreach (Control ctrl in ctrlCollection)
            {
                if (ctrl is TextBoxBase)
                {
                    if (ctrl.Name != "TBAdi")
                    {
                        ctrl.Text = String.Empty;
                    }

                    else if (ctrl.Name != "TBKodu")
                    {
                        ctrl.Text = String.Empty;
                    }

                    else if (ctrl.Name != "CBDoviz")
                    {
                        ctrl.Text = String.Empty;
                    }


                }
                else
                {
                    Temizle(ctrl.Controls);
                }
            }

        }
        void DataGridDoldur()
        {
            
            _cariAltHesapServis.Data(ServisList.CariAltHesListeServis);
            DGAltHesap.DataSource = _cariAltHesapServis.obje.Where(x=> x.kayittipi == 0).Select(x => new { 
                //ID=x.id, 
                AltHesapKodu=x.kod,
                Adı=x.adi, 
                DovizTürü=_parabirIMServis.obje.Where(z=>z.id==x.dovizid).FirstOrDefault().adi.ToString(),//Labellama
                OluşturmaTarihi=x.olusturmatarihi });
            DGAltHesap.Refresh();
            DGAltHesap.RefreshDataSource();

        }
       
        private void BTKaydet_Click(object sender, EventArgs e)
        {
            if (islemtipi == "Kayıt")
            {
                _cariAltHesapServis.Data(ServisList.CariAltHesEkleServis, (new PocoCARIALTHES()
                {
                    adi = TBAdi.Text,
                    kod = TBKodu.Text,
                    dovizid =_parabirIMServis.obje.Where(x => x.adi.ToString() == CBDoviz.Text.ToString()).FirstOrDefault().id,
                    

                }));

            }
            else
                _cariAltHesapServis.Data(ServisList.CariAltHesEkleServis, (new PocoCARIALTHES()
                {
                    id = id,
                    adi = TBAdi.Text,
                    kod= TBKodu.Text,
                    dovizid = _parabirIMServis.obje.Where(x => x.adi.ToString()  == CBDoviz.Text.ToString()).FirstOrDefault().id,
                    

                })); 
            MessageBox.Show("Kayıt işlemi Başarılı!");
            id = 0;
            DataGridDoldur();

        }
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(gridView1.GetFocusedRowCellValue("id").ToString());
            TBAdi.Text = gridView1.GetFocusedRowCellValue("adi").ToString();
            TBKodu.Text = gridView1.GetFocusedRowCellValue("kod").ToString();
            CBDoviz.Text = gridView1.GetFocusedRowCellValue("dovizid").ToString();
            CBAktif.Text = gridView1.GetFocusedRowCellValue("aktif").ToString();

        }

        #endregion

    }
}
