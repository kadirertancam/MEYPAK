using DevExpress.DirectX.Common.Direct2D;
using DevExpress.DirectX.Common.DirectWrite;
using DevExpress.XtraEditors;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.CARI;
using MEYPAK.Entity.PocoModels.DEPO;
using MEYPAK.Entity.PocoModels.FATURA;
using MEYPAK.Entity.PocoModels.IRSALIYE;
using MEYPAK.Interfaces.IRSALIYE;
using MEYPAK.Interfaces.Kasa;
using MEYPAK.Interfaces.Stok;
using MEYPAK.PRL.CARI;
using MEYPAK.PRL.DEPO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEYPAK.PRL.SIPARIS.Raporlar
{
    public partial class FFaturaRaporu : XtraForm
    {
        public FFaturaRaporu(string tag = "", string islem = "")
        {
            InitializeComponent();
            _form = tag;
            _islem = islem;
            _faturaServis = new GenericWebServis<PocoFATURA>();
            _cariServis = new GenericWebServis<PocoCARIKART>();
        }

        #region Tanımlar
        string _form, _islem;
        public PocoFATURA _tempFatura;
        public PocoCARIKART _tempCariKart;
        public PocoDEPO _tempDepo;
        public PocoCARIALTHES _tempCARIALTHES;
        public PocoIRSALIYE _tempIrsaliye;
        GenericWebServis<PocoFATURA> _faturaServis;
        GenericWebServis<PocoCARIKART> _cariServis;
        #endregion


        private void BTCariSec_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FCariList fCariList = new FCariList(this.Tag.ToString(), "FFaturaRaporu");
            fCariList.ShowDialog();
            
        }
        private void BTFaturaSec_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FFaturaList ffaturalist = new FFaturaList(this.Tag.ToString(), "FFaturaRaporu");
            ffaturalist.ShowDialog();
           
        }

        private void BTDepoSec_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FDepoList fDepoList = new FDepoList(this.Tag.ToString(), "FFaturaRaporu");
            fDepoList.ShowDialog();
        }

        private void BTAltHesSec_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FAltHesapList fAltHesapList = new FAltHesapList(this.Tag.ToString(), "FFaturaRaporu");
            fAltHesapList.ShowDialog();
        }

        private void BTIrsaliyeSec_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FIrsaliyeList fIrsaliyeList = new FIrsaliyeList(this.Tag.ToString(), "FFaturaRaporu");
            fIrsaliyeList.ShowDialog();
        }

        private void FFaturaRaporu_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        void Doldur()
        {

            _faturaServis.Data(ServisList.FaturaListeServis);
            _cariServis.Data(ServisList.CariListeServis);
            DGFaturaRpr.DataSource = _faturaServis.obje.Select(x => new
            {

                ID = x.id,
                KAYITTARİHİ = x.olusturmatarihi,
                FATURATARİHİ =x.faturatarihi,
                DÖNEM = x.donem,
                SERİNO = x.serino,
                TİPİ = x.tip,
                FATURAADI = x.belgeno,
                AÇIKLAMA =x.aciklama,
                EKAÇIKLAMA = x.ekaciklama,
                CARİKODU = _cariServis.obje.Where(y => y.id == x.id).Count() > 0 ? _cariServis.obje.Where(y => y.id == x.id).FirstOrDefault().unvan : "",
                CARİADI = x.cariadi,
               


               
                

            });
            DGFaturaRpr.Refresh();
            DGFaturaRpr.RefreshDataSource();
        }
       

       
    }
}
