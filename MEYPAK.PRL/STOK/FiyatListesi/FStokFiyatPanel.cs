using DevExpress.ClipboardSource.SpreadsheetML;

using DevExpress.Utils;
using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Entity.Models.PARAMETRE;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels.CARI;
using MEYPAK.Entity.PocoModels.PARAMETRE;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Depo;
using MEYPAK.Interfaces.Parametre;
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


namespace MEYPAK.PRL.STOK.FiyatListesi
{
    public partial class FStokFiyatPanel : XtraForm
    {
        public FStokFiyatPanel(PocoSTOKFIYAT tempStokFiyat, string form = "", string islemtipi = "")
        {
            InitializeComponent();
            this._islemtipi = islemtipi;
            this._form = form;
            _tempStokFiyat = tempStokFiyat;
            stokFiyatHarServis = new GenericWebServis<PocoSTOKFIYATHAR>();
            stokFiyatServis = new GenericWebServis<PocoSTOKFIYAT>();
            cariServis = new GenericWebServis<PocoCARIKART>();
            paraBirimServis = new GenericWebServis<PocoPARABIRIM>();
            stokServis = new GenericWebServis<PocoSTOK>();
            kategoriServis = new GenericWebServis<PocoSTOKKATEGORI>();
            _olcubrServis = new GenericWebServis<PocoOLCUBR>();
        }

        #region Tanımlar
        string _islemtipi;
        string _form;

        GenericWebServis<PocoSTOKFIYATHAR> stokFiyatHarServis;
        GenericWebServis<PocoSTOKFIYAT> stokFiyatServis;
        GenericWebServis<PocoCARIKART> cariServis;
        GenericWebServis<PocoPARABIRIM> paraBirimServis;
        GenericWebServis<PocoSTOK> stokServis;
        GenericWebServis<PocoSTOKKATEGORI> kategoriServis;
        GenericWebServis<PocoOLCUBR> _olcubrServis;
        PocoSTOKFIYAT _tempStokFiyat;

        #endregion

        private void FStokFiyatPanel_Load(object sender, EventArgs e)
        {

            cariServis.Data(ServisList.StokFiyatListeServis);
            stokFiyatHarServis.Data(ServisList.StokFiyatHarListeServis);
            kategoriServis.Data(ServisList.StokKategoriListeServis);
            paraBirimServis.Data(ServisList.ParaBirimiListeServis);
            stokServis.Data(ServisList.StokListeServis);
            _olcubrServis.Data(ServisList.OlcuBrListeServis);
            DTBaslangicTar.EditValue = _tempStokFiyat.baslangictarihi;
            DTBitisTar.EditValue = _tempStokFiyat.bitistarihi;
            TBCariKodu.Text = _tempStokFiyat.cariid.ToString();
            TBAciklama.Text = _tempStokFiyat.aciklama;
            TBAdi.Text = _tempStokFiyat.adi;

            DataTable datatb = new DataTable();
            DataColumn STOKID = new DataColumn("STOKID", typeof(int));
            datatb.Columns.Add(STOKID);
            DataColumn STOKADI = new DataColumn("STOKADI", typeof(string));
            datatb.Columns.Add(STOKADI);
            DataColumn KATEGORİ = new DataColumn("KATEGORİ", typeof(string));
            datatb.Columns.Add(KATEGORİ);
            DataColumn BİRİM = new DataColumn("BİRİM", typeof(string));
            datatb.Columns.Add(BİRİM);
            DataColumn FİYAT = new DataColumn("FİYAT", typeof(decimal));
            datatb.Columns.Add(FİYAT);

            datatb.Columns[0].ColumnMapping = MappingType.Hidden;

            //DataGridde bu alanlarda yalnızca okuma yapılır
            STOKID.ReadOnly = true;
            STOKADI.ReadOnly = true;
            KATEGORİ.ReadOnly = true;
            BİRİM.ReadOnly = true;


            foreach (var item in stokServis.obje.Where(x => x.kayittipi == 0))
            {
                datatb.Rows.Add(item.id,
                    item.adi,
                    kategoriServis.obje.Where(x => x.id == item.kategoriid).FirstOrDefault().acıklama,
                    _olcubrServis.obje.Where(x => x.id == item.olcubR1).FirstOrDefault().adi,
                    stokFiyatHarServis.obje.Where(x => x.kayittipi == 0 && x.stokfiyatid == _tempStokFiyat.id && x.stokid == item.id).Count() > 0 ?
                    stokFiyatHarServis.obje.Where(x => x.kayittipi == 0 && x.stokfiyatid == _tempStokFiyat.id && x.stokid == item.id).FirstOrDefault().fiyat : 0.00

                );
            }
            DGStokFiyatPanel.DataSource = datatb;
        }

        private void BTCik_Click(object sender, EventArgs e)
        {
            MessageBoxButtons.CancelTryContinue.Equals(false);
            this.Close();
        }

        private void BTKaydet_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                DataRowView row = gridView1.GetRow(i) as DataRowView;
                if (row != null && Convert.ToDecimal(row.Row.ItemArray[4]) > 0)
                {
                    stokFiyatHarServis.Data(ServisList.StokFiyatHarEkleServis, new PocoSTOKFIYATHAR()
                    {
                        id = stokFiyatHarServis.obje.Where(x => x.stokid == Convert.ToInt32(row.Row.ItemArray[0]) && x.stokfiyatid == _tempStokFiyat.id).Count() > 0 ? stokFiyatHarServis.obje.Where(x => x.stokid == Convert.ToInt32(row.Row.ItemArray[0]) && x.stokfiyatid == _tempStokFiyat.id).FirstOrDefault().id : 0,
                        stokfiyatid = _tempStokFiyat.id,
                        stokid = Convert.ToInt32(row.Row.ItemArray[0]),
                        fiyat = Convert.ToDecimal(row.Row.ItemArray[4]),
                        userid = MPKullanici.ID,
                    });
                }
            }
            MessageBox.Show("Stok Fiyat Başarıyla Kaydedildi");
        }
    }
}
