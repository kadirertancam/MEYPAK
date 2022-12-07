using DevExpress.XtraEditors;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels;
using MEYPAK.Entity.PocoModels.DEPO;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Depo;
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

namespace MEYPAK.PRL.STOK.Raporlar
{
    public partial class FStokHareketRaporu : XtraForm
    {
        public FStokHareketRaporu(string tag = "", string islem = "")
        {
            InitializeComponent();
            _stokServis = new GenericWebServis<PocoSTOK>();
            _stokHarServis = new GenericWebServis<PocoSTOKHAR>();
            _stokOlcuBrServis = new GenericWebServis<PocoSTOKOLCUBR>();
            _depoServis = new GenericWebServis<PocoDEPO>();
            _form = tag;
            _islem = islem;
        }
        
        #region Tanımlar
        string _form, _islem;
        public PocoSTOK _tempStok;
        public PocoSTOKHAR _tempStokHar;
        GenericWebServis<PocoSTOK> _stokServis;
        GenericWebServis<PocoSTOKHAR> _stokHarServis;
        GenericWebServis<PocoSTOKOLCUBR> _stokOlcuBrServis;
        GenericWebServis<PocoDEPO> _depoServis;
        #endregion

        #region Metotlar
        private void BTStokSec_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            _tempStok = null;
            FStokList fStokList = new FStokList(this.Tag.ToString(), "stokhar");
            fStokList.ShowDialog();
            Doldur();
        }

        private void FStokHareketRaporu_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        void Doldur()
        {
            _stokHarServis.Data(ServisList.StokHarListeServis);
            _stokOlcuBrServis.Data(ServisList.StokOlcuBrListeServis);
            _depoServis.Data(ServisList.DepoListeServis);
           
           
                DGStokHareketRpr.DataSource = _stokHarServis.obje.Where(x => x.kayittipi == 0).Select(x => new PocoStokHareketListesi()
                {
                    STOKID = x.stokid,
                    Acıklama = x.aciklama,
                    BelgeNo = x.belgE_NO,
                    //Birim = _stokOlcuBrServis.obje.Where(z => z.id == x.id).FirstOrDefault().id,
                    BrutToplam = x.bruttoplam, 
                    Cikis = x.io == 0 ? x.miktar : 0,
                    Giris = x.io == 1 ? x.miktar : 0,
                    Depo = _depoServis.obje.Where(z => z.id == x.depoid).FirstOrDefault().depoadi,
                    HareketTuru = x.hareketturu == 1 ? "Satış Fatura" : x.hareketturu == 2 ? "Alış Fatura" : x.hareketturu == 3 ? "Satış Irsaliye" : x.hareketturu == 4 ? "Alış Irsaliye" : x.hareketturu == 5 ? "Satış Fatura Iade" : x.hareketturu == 6 ? "Alış Fatura Iade" : x.hareketturu == 7 ? "Satış Irsalye Iade" : x.hareketturu == 8 ? "Alış Irsaliye Iade" : x.hareketturu == 9 ? "Muhtelif" : x.hareketturu == 10 ? "DAT" : x.hareketturu == 11 ? "Sayim" : "Muhtelif",
                    NetFiyat = x.netfiyat,
                    NetToplam = x.nettoplam,
                    Tarih = x.olusturmatarihi
                });
                gridView1.Columns["STOKID"].Visible = false;
                gridView1.RefreshData();
                // _tempStok = null;


            }
            //_stokServis.Data(ServisList.StokListeServis);
            //_stokHarServis.Data(ServisList.StokHarListeServis);
            //DGStokHareketRpr.DataSource = _stokHarServis.obje.Where(x => x.kayittipi == 0).Select(x => new
            //{
            //    ID = x.id,
            //    //STOKID = x.id,
            //    AÇIKLAMA = x.aciklama,
            //    BELGENO = x.belgE_NO,

            //});
            //DGStokHareketRpr.Refresh();
            //DGStokHareketRpr.RefreshDataSource();
        }
        #endregion
    }

