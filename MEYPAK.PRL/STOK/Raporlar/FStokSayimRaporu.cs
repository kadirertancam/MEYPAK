using DevExpress.XtraEditors;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels;
using MEYPAK.Entity.PocoModels.DEPO;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Depo;
using MEYPAK.Interfaces.Parametre;
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

namespace MEYPAK.PRL.STOK.Raporlar
{
    public partial class FStokSayimRaporu : XtraForm
    {
        public FStokSayimRaporu(string tag = "", string islem = "")
        {
            InitializeComponent();
            
            _stokSayimServis = new GenericWebServis<PocoSTOKSAYIM>();
            _depoServis = new GenericWebServis<PocoDEPO>();
            _form = tag;
            _islem = islem;
        }

        #region Tanımlar
        string _form, _islem;
    
        GenericWebServis<PocoSTOKSAYIM> _stokSayimServis;
        GenericWebServis<PocoDEPO> _depoServis;

        
        public PocoDEPO _tempDepo;
        public PocoSTOKSAYIM _tempSayim;
        #endregion

        #region Metotlar
        private void FStokSayimRaporu_Load(object sender, EventArgs e)
        {
            Doldur();
        }


        private void BTDepoSec_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FDepoList fDepoList = new FDepoList(this.Tag.ToString(), "stoksayim");
            fDepoList.ShowDialog();
            if (_tempDepo != null)
                BTDepoSec.Text = _tempDepo.aciklama;

            GridiDoldur(Filtrele());
        }

        private void BTSayimSec_Properties_ButtonClick_1(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FSayimList fSayimList = new FSayimList(this.Tag.ToString(), "FStokSayim");
            fSayimList.ShowDialog();
            if (_tempSayim != null)
                BTSayimSec.Text = _tempSayim.aciklama;

            GridiDoldur(Filtrele());
        }

        void Doldur()
        {
            
            _depoServis.Data(ServisList.DepoListeServis);
            _stokSayimServis.Data(ServisList.StokSayimListeServis);
            GridiDoldur(_stokSayimServis.obje);
            DGStokSayimRpr.RefreshDataSource();
        }


        List<PocoSTOKSAYIM> Filtrele()
        {
            List<PocoSTOKSAYIM> filtre = new List<PocoSTOKSAYIM>();
            if (BTSayimSec.Text != "" && _tempSayim != null)
                filtre.Add(_tempSayim);
            else if (BTDepoSec.Text != "" && _tempDepo != null)
                filtre.AddRange(_stokSayimServis.obje.Where(x => x.depoid == _tempDepo.id));
            else
                return _stokSayimServis.obje;
            return filtre;
        }

        void GridiDoldur(List<PocoSTOKSAYIM> A)
        {
            DGStokSayimRpr.DataSource = A.Select(x => new
            {
                ID = x.id,
                KAYITTARİHİ = x.olusturmatarihi,
                AÇIKLAMA = x.aciklama,
                SAYIMTARİHİ = x.sayimtarihi,
                DEPOADI = _depoServis.obje.Where(y => y.id == x.depoid).Count() > 0 ? _depoServis.obje.Where(y => y.id == x.depoid).FirstOrDefault().depoadi : "",
                DURUM = x.durum,
                FİRMAID = x.firmaid,
                ŞUBEID = x.subeid,
                GÜNCELLENMETARİHİ = x.guncellemetarihi

            }).ToList();
        }

        #endregion

    }
}
        