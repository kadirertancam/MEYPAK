using DevExpress.DirectX.Common.Direct2D;
using DevExpress.DirectX.Common.DirectWrite;
using DevExpress.Utils.MVVM;
using DevExpress.XtraEditors;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Entity.PocoModels.DEPO;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Stok;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEYPAK.PRL.DEPO.Raporlar
{
    public partial class FDepoRaporu : XtraForm
    {
        public FDepoRaporu(string tag = "",string islem = "")
        {
            InitializeComponent();
            _depoServis = new GenericWebServis<PocoDEPO>();
            _form = tag;
            _islem = islem;
        }

        #region Tanımlar
        string _form, _islem;
        GenericWebServis<PocoDEPO> _depoServis;
        public PocoDEPO _tempDepo;

        #endregion

        private void BTDepoSec_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FDepoList fDepoList = new FDepoList(this.Tag.ToString(), "FDepoRaporu");
            fDepoList.ShowDialog();
            if (_tempDepo != null) { 
                BTDepoSec.Text = _tempDepo.depoadi;
            GridiDoldur(Filtrele());
            }

        }

        private void FDepoRaporu_Load(object sender, EventArgs e)
        {
            Doldur();

        }

        void Doldur() { 
            _depoServis.Data(ServisList.DepoListeServis);
            GridiDoldur(_depoServis.obje);
            DGDepoRpr.RefreshDataSource();
        }

        void GridiDoldur(List<PocoDEPO> A)
        {
            DGDepoRpr.DataSource = A.Select(x => new
            {
                ID = x.id,
                KAYITTARİHİ = x.olusturmatarihi,
                DEPOKODU = x.depokodu,
                DEPOADI = x.depoadi,
                AÇIKLAMA = x.aciklama,
                
                ŞİRKETID = x.sirketid,
                GÜNCELLEMETARİHİ = x.guncellemetarihi,

            }).ToList();
        }

        List<PocoDEPO> Filtrele()
        {
            List<PocoDEPO> filtre = new List<PocoDEPO>();
            if (BTDepoSec.Text != "" && _tempDepo != null)
                filtre.Add(_tempDepo);
          
            else
                return _depoServis.obje;

            return filtre;
        }

    }

}

