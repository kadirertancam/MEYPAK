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

namespace MEYPAK.PRL.STOK.Raporlar
{
    public partial class FStokFiyatRaporu : XtraForm
    {
        public FStokFiyatRaporu(string tag = "", string islem = "")
        {
            InitializeComponent();
            _stokServis = new  GenericWebServis<PocoSTOK>();
            _stokServis.Data(ServisList.StokListeServis);
            _stokFiyatServis = new GenericWebServis<PocoSTOKFIYAT>();
            _stokFiyatServis.Data(ServisList.StokFiyatListeServis);
            _stokFiyatHarServis = new GenericWebServis<PocoSTOKFIYATHAR>();
            _stokFiyatHarServis.Data(ServisList.StokFiyatHarListeServis);
            _form = tag;
            _islem = islem;
        }
        string _form, _islem;
        #region Tanımlar
        GenericWebServis<PocoSTOK> _stokServis;
        GenericWebServis<PocoSTOKFIYAT> _stokFiyatServis;
        GenericWebServis<PocoSTOKFIYATHAR> _stokFiyatHarServis;

        public PocoSTOK _tempStok;
        public PocoSTOKFIYAT _tempStokFiyat;
        public PocoSTOKFIYATHAR _tempStokFiyatHar;
        #endregion

        #region Metotlar

        void Doldur()
        {
            _stokFiyatServis.Data(ServisList.StokFiyatListeServis);
            DGStokFiyatRpr.DataSource = _stokFiyatServis.obje.Where(x => x.kayittipi == 0 ).Select(x => new
            {
                ID = x.id,
                FİYATLİSTESİ = x.adi,
                ACIKLAMA = x.aciklama,
                BASLANGICTARİHİ = x.baslangictarihi,
                BİTİSTARİHİ = x.bitistarihi,

            });
            DGStokFiyatRpr.Refresh();
            DGStokFiyatRpr.RefreshDataSource();
        }
        private void BTStokSec_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            FStokList fStokList = new FStokList(this.Tag.ToString(), "FStokFiyatRaporu");
            fStokList.ShowDialog();
        }

        private void FStokFiyatRaporu_Load(object sender, EventArgs e)
        {
            Doldur();
            
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
