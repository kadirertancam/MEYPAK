using DevExpress.Utils.Gesture;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Depo;
using MEYPAK.Interfaces.Stok;
using MEYPAK.PRL.CARI;
using DevExpress.XtraReports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MEYPAK.Entity.PocoModels.CARI;

namespace MEYPAK.PRL.STOK.Raporlar
{
    public partial class FStokFiyatRaporu : XtraForm
    {
        public FStokFiyatRaporu(string tag = "", string islem = "")
        {
            InitializeComponent();
          
            _stokFiyatServis = new GenericWebServis<PocoSTOKFIYAT>();
            _cariServis = new GenericWebServis<PocoCARIKART>();
            _form = tag;
            _islem = islem;
        }
        string _form, _islem;
        #region Tanımlar
        GenericWebServis<PocoSTOK> _stokServis;
        GenericWebServis<PocoSTOKFIYAT> _stokFiyatServis;
        GenericWebServis<PocoCARIKART> _cariServis;
        public PocoSTOK _tempStok;
        public PocoCARIKART _tempCariKart;
        public PocoSTOKFIYATHAR _tempStokFiyatHar;
       
        #endregion

        #region Metotlar

        void Doldur()
        {
            _stokFiyatServis.Data(ServisList.StokFiyatListeServis);
            _cariServis.Data(ServisList.CariListeServis);
            DGStokFiyatRpr.DataSource = _stokFiyatServis.obje.Where(x => x.kayittipi == 0 ).Select(x => new
            {
                ID = x.id,
                KAYITTARİHİ =x.olusturmatarihi,
                FİYATLİSTESİADI = x.adi,
                AÇIKLAMA = x.aciklama,
                CARİADI = _cariServis.obje.Where(X=>x.kayittipi == 0).Select(x=> x.kod).FirstOrDefault(),
                BASLANGIÇTARİHİ = x.baslangictarihi,
                BİTİŞTARİHİ = x.bitistarihi,
                FİRMAID =x.firmaid,
                ŞUBEID = x.subeid,
                GÜNCELLEMETARİHİ =x.guncellemetarihi

            });
            DGStokFiyatRpr.Refresh();
            DGStokFiyatRpr.RefreshDataSource();
        }
       
        private void FStokFiyatRaporu_Load(object sender, EventArgs e)
        {
            Doldur();
            
        }

        private void BTCariSec_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FCariList fCariList = new FCariList(this.Tag.ToString(), "FStokFiyatRaporu");
            fCariList.ShowDialog();
            
        }

        private void BTRaporla_Click(object sender, EventArgs e)
        {
            
        }

        //private void selectedColumnsButton_Click(object sender, System.EventArgs e)
        //{
        //    Int32 selectedColumnCount = gridView1.Columns
        //        .GetColumnCount(DataGridViewElementStates.Selected);
        //    if (selectedColumnCount > 0)
        //    {
        //        System.Text.StringBuilder sb = new System.Text.StringBuilder();

        //        for (int i = 0; i < selectedColumnCount; i++)
        //        {
        //            sb.Append("Column: ");
        //            sb.Append(gridView1.SelectAll[i].Index
        //                .ToString());
        //            sb.Append(Environment.NewLine);
        //        }

        //        sb.Append("Total: " + selectedColumnCount.ToString());
        //        MessageBox.Show(sb.ToString(), "Selected Columns");
        //    }
        //}

        #endregion



    }
}
