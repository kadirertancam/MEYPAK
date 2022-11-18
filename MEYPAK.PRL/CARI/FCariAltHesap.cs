using DevExpress.Mvvm.POCO;
using DevExpress.Text.Interop;
using DevExpress.XtraEditors;
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
using MEYPAK.Interfaces.Personel;
using MEYPAK.Interfaces.Stok;
using MEYPAK.PRL.PARAMETRELER;
using MEYPAK.PRL.STOK;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEYPAK.PRL.CARI
{
    public partial class FCariAltHesap : XtraForm
    {

        string islemtipi = "Kayıt";
        public FCariAltHesap()
        {
            InitializeComponent();
            _tempAltHesap = new PocoCARIALTHES();
            _cariAltHesapServis = new GenericWebServis<PocoCARIALTHES>();
            _parabirIMServis = new GenericWebServis<PocoPARABIRIM>();
            _parabirIMServis.Data(ServisList.ParaBirimiListeServis);
            CBDoviz.Properties.DataSource = _parabirIMServis.obje.Select(x => new { ID=x.id,ADI=x.adi }).ToList(); //comboxun içini parabirim formundan doldurur
            CBDoviz.Properties.ValueMember= "ID";
            CBDoviz.Properties.DisplayMember = "ADI";
        }


        #region Tanımlar
        ADRESOBJECT.Root _adresObje;
        GenericWebServis<PocoCARIALTHES> _cariAltHesapServis;
        GenericWebServis<PocoPARABIRIM> _parabirIMServis;
        PocoCARIALTHES _tempAltHesap;

        #endregion

        #region Metotlar
        private void FCariAltHesap_Load(object sender, EventArgs e)
        {
            DataGridDoldur();
            CombolariDoldur();
            CBDoviz.EditValue = 0; 
        }
        int id;
        
        private void BTSil_Click(object sender, EventArgs e)
        {
           
            _cariAltHesapServis.Data(ServisList.CariAltHesListeServis);
            _cariAltHesapServis.Data(ServisList.CariAltHesSilServis, null, null, _cariAltHesapServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).ToList());
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
                ID=x.id, 
                AltHesapKodu=x.kod,
                Adı=x.adi, 
                DövizTürü=_parabirIMServis.obje.Where(z=>z.id==x.dovizid).FirstOrDefault().adi.ToString(),//Labellama
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
                    dovizid = _parabirIMServis.obje.Where(x => x.adi.ToString() == CBDoviz.Text.ToString()).FirstOrDefault().id,
             
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
        
   
        void CombolariDoldur()
        {
            _cariAltHesapServis.Data(ServisList.CariAltHesListeServis);
            // CBDoviz.Properties.DataSource = _parabirIMServis.obje.Select(x => new { x.id, x.adi });
            string path = Application.StartupPath + "/il-ilce.json";
            using (FileStream s = File.Open(path, FileMode.Open))
            using (StreamReader sr = new StreamReader(s))
                while (!sr.EndOfStream)
                {

                    _adresObje = JsonConvert.DeserializeObject<ADRESOBJECT.Root>(sr.ReadToEnd());


                    CBIl.Properties.DataSource = _adresObje.data.Select(x => x.il_adi);
                   

                }

        }
        void AltHesapBilgileriniGetir()
        {
            if (_tempAltHesap!=null)
            {
                id = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
                TBKodu.Text = gridView1.GetFocusedRowCellValue("AltHesapKodu").ToString();
                TBAdi.Text = gridView1.GetFocusedRowCellValue("Adı").ToString();
                CBDoviz.EditValue=_tempAltHesap.dovizid;
                CBAktif1.EditValue = _tempAltHesap.aktif;
            }
        }


        #endregion

        private void DGAltHesap_DoubleClick(object sender, EventArgs e)
        {
            _tempAltHesap = _cariAltHesapServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
            AltHesapBilgileriniGetir();
        }

        private void CBIl_EditValueChanged(object sender, EventArgs e)
        {
            CBIlce.Properties.DataSource = _adresObje.data.Where(x => x.il_adi == CBIl.EditValue.ToString()).Select(x => x.ilceler.Select(z => z.ilce_adi).ToList()).FirstOrDefault();
        }
    }
}
