using DevExpress.XtraEditors;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.CARI;
using MEYPAK.Entity.PocoModels.PARAMETRE;
using System.Data;

namespace MEYPAK.PRL.CARI
{
    public partial class FCariAltHesap : XtraForm
    {

      
        public FCariAltHesap()
        {
            InitializeComponent();
            _tempAltHesap = new PocoCARIALTHES();
            _cariAltHesapServis = new GenericWebServis<PocoCARIALTHES>();
            _parabirIMServis = new GenericWebServis<PocoPARABIRIM>();
            _cariAltHesCariServis=new GenericWebServis<PocoCARIALTHESCARI>();
            _parabirIMServis.Data(ServisList.ParaBirimiListeServis);
            CBDoviz.Properties.DataSource = _parabirIMServis.obje.Where(x=>x.kayittipi==0).Select(x => new { ID=x.id,ADI=x.adi }).ToList(); //comboxun içini parabirim formundan doldurur
            CBDoviz.Properties.ValueMember= "ID";
            CBDoviz.Properties.DisplayMember = "ADI";
        }


        #region Tanımlar
        ADRESOBJECT.Root _adresObje;
        GenericWebServis<PocoCARIALTHES> _cariAltHesapServis;
        GenericWebServis<PocoPARABIRIM> _parabirIMServis;
        GenericWebServis<PocoCARIALTHESCARI> _cariAltHesCariServis;
        PocoCARIALTHES _tempAltHesap;

        #endregion

        #region Metotlar
        private void FCariAltHesap_Load(object sender, EventArgs e)
        {
            DataGridDoldur();
            CombolariDoldur();
            CBDoviz.EditValue = 0;
        }
  
        
        private void BTSil_Click(object sender, EventArgs e)
        {
            
            _cariAltHesapServis.Data(ServisList.CariAltHesListeServis);
            _cariAltHesCariServis.Data(ServisList.CariAltHesCariListeServis);
            if (_cariAltHesCariServis.obje.Where(x => x.carialthesid == _cariAltHesapServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault().id).Count()==0)
            {
                _cariAltHesapServis.Data(ServisList.CariAltHesSilServis, null, null, _cariAltHesapServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).ToList());
                MessageBox.Show("Silme işlemi Başarılı");
                DataGridDoldur(); 
            }
            else
            {
                MessageBox.Show("Cariye bağlı olan alt hesap silinemez!");
            }
          
           
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
            _parabirIMServis.Data(ServisList.ParaBirimiListeServis);
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
            _parabirIMServis.Data(ServisList.ParaBirimiListeServis);
            if (_tempAltHesap != null && TBKodu.Text != _tempAltHesap.kod)
            {
                _tempAltHesap = null;
            }
            _cariAltHesapServis.Data(ServisList.CariAltHesEkleServis, (new PocoCARIALTHES()
                {
                    id = _tempAltHesap != null ? _tempAltHesap.id : 0,
                    adi = TBAdi.Text,
                    kod = TBKodu.Text,
                    dovizid = _parabirIMServis.obje.Where(x => x.adi.ToString() == CBDoviz.Text.ToString()).FirstOrDefault().id,
                    aktif = CHBAktif.Checked ? 1 : 0

                })) ;


            MessageBox.Show("Kayıt işlemi Başarılı!");
            DataGridDoldur();
            
        }
        
   
        void CombolariDoldur()
        {
            _cariAltHesapServis.Data(ServisList.CariAltHesListeServis);
            // CBDoviz.Properties.DataSource = _parabirIMServis.obje.Select(x => new { x.id, x.adi });
           

        }
        void AltHesapBilgileriniGetir()
        {
            if (_tempAltHesap!=null)
            {
                TBKodu.Text = _tempAltHesap.kod;
                TBAdi.Text = _tempAltHesap.adi;
                CBDoviz.EditValue=_tempAltHesap.dovizid;
                CHBAktif.Checked = _tempAltHesap.aktif == 0 ? false:true ;
            }
        }

        private void DGAltHesap_DoubleClick(object sender, EventArgs e)
        {
            _tempAltHesap = _cariAltHesapServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
            AltHesapBilgileriniGetir();
        }
        #endregion

      

       
    }
}
