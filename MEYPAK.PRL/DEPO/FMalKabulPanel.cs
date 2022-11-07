using DevExpress.Mvvm.Native;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Entity.Models.SIPARIS;
using MEYPAK.Entity.PocoModels;
using MEYPAK.Entity.PocoModels.DEPO;
using MEYPAK.Entity.PocoModels.SIPARIS;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Depo;
using MEYPAK.Interfaces.Siparis;
using MEYPAK.PRL.Assets.Scripts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEYPAK.PRL.DEPO
{
    public partial class FMalKabulPanel : Form
    {
        public FMalKabulPanel()
        {
            InitializeComponent();
            _siparisServis = new GenericWebServis<PocoSIPARIS>();
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(105, 105, 105);
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(105, 105, 105);
            dataGridView2.EnableHeadersVisualStyles = false;
            DGVTopla = new DataGridViewButtonColumn();
            _sevkiyatCekiPanel = new FSevkiyatCekiPanel();
            _depoEmirServis = new GenericWebServis<PocoDEPOEMIR>();
            _siparisDetayServis = new GenericWebServis<PocoSIPARISDETAY>();
            _siparisSevkEmriHarServis = new GenericWebServis<PocoSIPARISSEVKEMIRHAR>(); 
            _stokServis = new GenericWebServis<PocoSTOK>();
            _stokMalKabulListServis = new GenericWebServis<PocoSTOKMALKABULLIST>();
            _olcuBrServis = new GenericWebServis<PocoOLCUBR>();
        }
        DataGridViewButtonColumn DGVTopla;
        List<PocoSIPARIS> _tempSiparis;
        FSevkiyatCekiPanel _sevkiyatCekiPanel;
        List<PocoSIPARISDETAY> _tempSTOKSEVK;
        List<PocoSIPARISDETAY> _tempSiparisDetay;
        public GenericWebServis<PocoSIPARIS> _siparisServis;
        public GenericWebServis<PocoSTOK> _stokServis;
        public GenericWebServis<PocoDEPOEMIR> _depoEmirServis;
        public GenericWebServis<PocoSIPARISDETAY> _siparisDetayServis;
        public GenericWebServis<PocoSIPARISSEVKEMIRHAR> _siparisSevkEmriHarServis; 
        public GenericWebServis<PocoSTOKMALKABULLIST> _stokMalKabulListServis;
        public GenericWebServis<PocoOLCUBR> _olcuBrServis; 
        private void FMalKabulPanel_Load(object sender, EventArgs e)
        {
            //yuklee();
       
           
            //DGVTopla.Name = "DGVTopla";
            //DGVTopla.HeaderText = "Toplama";
            //DGVTopla.DisplayIndex = 3;
            //DGVTopla.FlatStyle = FlatStyle.Flat;
            //DGVTopla.CellTemplate.Style.ForeColor = Color.Aqua;
            //DGVTopla.CellTemplate.Style.SelectionForeColor = Color.Aqua;
            //DGVTopla.Text = "Toplama";
            //DGVTopla.UseColumnTextForButtonValue = true;
            //dataGridView1.Columns.Add(DGVTopla);
            //dataGridView1.Columns["DGVTopla"].DefaultCellStyle.ForeColor = Color.Aqua;

        
        }
        void yuklee()
        { 
           

        }
        MPDEPOEMIR a;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //_siparisDetayServis.Data(ServisList.SiparisDetayListeServis);
            //_siparisServis.Data(ServisList.SiparisListeServis);
            //_stokServis.Data(ServisList.StokListeServis);
            //_stokMalKabulListServis.Data(ServisList.StokMalKabulListListeServis);
            //_olcuBrServis.Data(ServisList.OlcuBrListeServis); 
            //var tempsiparis = _siparisServis.obje.Where(x => x.belgeno == dataGridView1.Rows[e.RowIndex].Cells["belgeno"].Value.ToString()).FirstOrDefault();
            //var tempsipdetay = _siparisDetayServis.obje.Where(x => x.siparisid == tempsiparis.id);
            //_tempSiparisDetay = tempsipdetay.ToList();

            //if (dataGridView1.Columns[e.ColumnIndex].Name == "DGVTopla")
            //{
            //    int i = 1;
            //    _depoEmirServis.Data(ServisList.DepoEmirEkleServis, new PocoDEPOEMIR()
            //    {
            //        siparisid = _siparisServis.obje.Where(x => x.belgeno == dataGridView1.Rows[e.RowIndex].Cells["belgeno"].Value.ToString()).FirstOrDefault().id,
            //        miktar = _tempSiparisDetay.Sum(x => x.miktar),
            //        sira = i,
            //        tarih = DateTime.Now,
            //        tip = 1,   /// TOPLAMA EMRİ TIPI OUTPUT =0 INPUT=1
            //        durum = 1,
            //        depoid = _siparisServis.obje.Where(x => x.belgeno == dataGridView1.Rows[e.RowIndex].Cells["belgeno"].Value.ToString()).FirstOrDefault().depoid,
            //        aciklama = "",



            //    });


            //    _depoEmirServis.Data(ServisList.DepoEmirListeServis);
            //    dataGridView2.DataSource = _depoEmirServis.obje.Select(x => new { x.id, _siparisServis.obje.Where(z => x.siparisid == z.id).FirstOrDefault().belgeno, x.miktar, CARIADI = _siparisServis.obje.Where(z => z.id == x.siparisid).FirstOrDefault().cariadi, _siparisServis.obje.Where(z => z.id == x.siparisid).FirstOrDefault().depoid, x.tip, x.durum }).ToList();
            //    dataGridView2.Refresh();
            //    foreach (var item in _tempSiparisDetay.Where(x => x.hareketdurumu == 0).ToList())
            //    {
            //        item.hareketdurumu = 1;
            //        _siparisDetayServis.Data(ServisList.SiparisDetayEkleServis, item);


            //        _siparisSevkEmriHarServis.Data(ServisList.SiparisSevkEmriHarEkleServis, new PocoSIPARISSEVKEMIRHAR()
            //        {
            //            EMIRMIKTARI = item.miktar,
            //            SIPARISID = item.siparisid,
            //            SIPARISKALEMID = item.id,
            //            EMIRID = _depoEmirServis.obje.Where(x => x.siparisid == item.siparisid).FirstOrDefault().id,
            //            SIPARISMIKTARI = item.miktar,
            //            KULLANICIID = 0,
            //            TARIH = DateTime.Now,
            //            TIP = 1,

            //        });
            //        _stokMalKabulListServis.Data(ServisList.StokMalKabulListEkleServis, new PocoSTOKMALKABULLIST()
            //        {
            //            birimid = item.birimid,
            //            depoid = _siparisServis.obje.Where(x => x.id == item.siparisid).FirstOrDefault().depoid,
            //            emirid = _depoEmirServis.obje.Where(x => x.siparisid == item.siparisid).FirstOrDefault().id,
            //            miktar = item.miktar,
            //            stokid = item.stokid,
            //            malkabulharemriid = _siparisSevkEmriHarServis.obje2.id,
            //            siparisdetayid = item.siparisid

            //        });
            //        _stokMalKabulListServis.Data(ServisList.StokMalKabulListListeServis);
            //        _siparisSevkEmriHarServis.Data(ServisList.SiparisSevkEmriHarListeServis);
            //        dataGridView3.DataSource = _siparisSevkEmriHarServis.obje.Select(x =>
            //        new {
            //            BELGENO = _siparisServis.obje.Where(z => z.id == x.SIPARISID).FirstOrDefault().belgeno,
            //            KOD = _stokServis.obje.Where(c => c.id == item.stokid).FirstOrDefault().kod,
            //            ADI = item.stokadi,
            //            x.EMIRID,
            //            x.SIPARISMIKTARI,
            //            x.EMIRMIKTARI,
            //            KALANMIKTAR = _stokMalKabulListServis.obje.Where(z => z.emirid == x.EMIRID && z.siparisdetayid
            //            == x.SIPARISKALEMID).GroupBy(x => new {
            //                _stokServis.obje.Where(z => z.id == x.stokid).FirstOrDefault().kod,
            //                item.stokadi,
            //                BIRIM = _olcuBrServis.obje.Where(z => z.id == x.birimid).FirstOrDefault().adi,
            //                x.siparismiktari
            //            }).Select(x => x.Select(x => x.siparismiktari).FirstOrDefault()
            //                - x.Sum(z => z.miktar)).FirstOrDefault()
            //        }).ToList();
            //        dataGridView3.Refresh();
            //        i++;
            //    }

            //}
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        //    _depoEmirServis.Data(ServisList.DepoEmirListeServis);
        //    var tempp = _depoEmirServis.obje.Where(x => x.id.ToString() == dataGridView2.Rows[e.RowIndex].Cells["id"].Value.ToString());
        //    _tempSTOKSEVK = tempp.Select(x => _siparisDetayServis.obje.Where(z => z.siparisid == x.siparisid).ToList()).FirstOrDefault();
        //    _sevkiyatCekiPanel = new FSevkiyatCekiPanel();
        //    _stokMalKabulListServis.Data(ServisList.StokMalKabulListListeServis);

        //    _sevkiyatCekiPanel._tempEmir = tempp.FirstOrDefault();
        //    _sevkiyatCekiPanel._tempList = _stokMalKabulListServis.obje.Select(x => new PocoSTOKSEVKIYATLIST() { mpstok = _stokServis.obje.Where(z => z.id == x.stokid).FirstOrDefault(), mpsiparisdetay = _siparisDetayServis.obje.Where(z => z.id == x.siparisdetayid).FirstOrDefault(), siparismiktari = x.miktar, depoid = x.depoid, birimid = x.birimid, emirid = int.Parse(dataGridView2.Rows[e.RowIndex].Cells["id"].Value.ToString()), siparisdetayid = x.id, stokid = x.stokid }).ToList();

        //    _sevkiyatCekiPanel.ShowDialog();
        //    var tempp2 = _stokMalKabulListServis.obje.Where(x => x.emirid.ToString() == dataGridView2.Rows[e.RowIndex].Cells["id"].Value.ToString()).GroupBy(x => new { x.mpstok.kod, x.mpstok.adi, BIRIM = x.mpolcubr.adi, x.siparismiktari }).Select(x => new { KOD = x.Select(x => x.mpstok.kod).FirstOrDefault(), ADI = x.Select(x => x.mpstok.adi).FirstOrDefault(), MIKTAR = x.Sum(z => z.miktar), SIPARISMIKTARI = x.Select(x => x.siparismiktari).FirstOrDefault(), KALANMIKTAR = x.Select(x => x.siparismiktari).FirstOrDefault() - x.Sum(z => z.miktar), BIRIM = x.Select(x => x.mpolcubr.adi).FirstOrDefault() }).ToList();
        //    dataGridView4.DataSource = tempp2;
        //    dataGridView3.DataSource = _siparisSevkEmriHarServis.obje.Select(x =>
        //    new {
        //        BELGENO = _siparisServis.obje.Where(z => z.id == x.SIPARISID).FirstOrDefault().belgeno,
        //        KOD = _siparisDetayServis.obje.Where(z => z.siparisid == x.SIPARISID).Select(c => _stokServis.obje.Where(v => v.id == c.stokid).Select(v => v.kod).FirstOrDefault()).FirstOrDefault() == null ? "" : "1",
        //        ADI = _siparisDetayServis.obje.Where(z => z.siparisid == x.SIPARISID).Select(c => _stokServis.obje.Where(v => v.id == c.stokid).Select(v => v.adi).FirstOrDefault()).FirstOrDefault() == null ? "" : "1",
        //        x.EMIRID,
        //        x.SIPARISMIKTARI,
        //        x.EMIRMIKTARI,
        //        KALANMIKTAR = _stokMalKabulListServis.obje.Where(z => z.emirid == x.EMIRID && z.siparisdetayid == x.SIPARISKALEMID).
        //        GroupBy(x => new { x.mpstok.kod, x.mpstok.adi, BIRIM = x.mpolcubr.adi, x.siparismiktari }).
        //        Select(x => x.Select(x => x.siparismiktari).FirstOrDefault() - x.Sum(z => z.miktar)).FirstOrDefault()
        //    }).ToList(); 
        //}
        //private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        //{

        //    // if (Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells["DURUM"].Value)==1)
        //    _stokMalKabulListServis.Data(ServisList.StokMalKabulListListeServis);
        //    _stokServis.Data(ServisList.StokListeServis);
        //    _siparisSevkEmriHarServis.Data(ServisList.SiparisSevkEmriHarListeServis);
        //    _siparisServis.Data(ServisList.SiparisListeServis);
        //    _siparisDetayServis.Data(ServisList.SiparisDetayListeServis);

        //    if (_stokMalKabulListServis.obje.Count > 0)
        //    {
        //        var tempp = _stokMalKabulListServis.obje.Where(x => x.emirid.ToString() == dataGridView2.Rows[e.RowIndex].Cells["id"].Value.ToString()).GroupBy(x => new { x.mpstok.kod, x.mpstok.adi, BIRIM = x.mpolcubr.adi, x.siparismiktari }).Select(x => new { KOD = x.Select(x => x.mpstok.kod).FirstOrDefault(), ADI = x.Select(x => x.mpstok.adi).FirstOrDefault(), MIKTAR = x.Sum(z => z.miktar), SIPARISMIKTARI = x.Select(x => x.siparismiktari).FirstOrDefault(), KALANMIKTAR = x.Select(x => x.siparismiktari).FirstOrDefault() - x.Sum(z => z.miktar), BIRIM = x.Select(x => x.mpolcubr.adi).FirstOrDefault() }).ToList();
        //        dataGridView4.DataSource = tempp;
        //    }
        //    _stokMalKabulListServis.Data(ServisList.StokMalKabulListListeServis);
        //    dataGridView3.DataSource = _siparisSevkEmriHarServis.obje.Select(x =>
        //    new {
        //        BELGENO = _siparisServis.obje.Where(z => z.id == x.SIPARISID).FirstOrDefault().belgeno,
        //        KOD = _siparisDetayServis.obje.Where(z => z.siparisid == x.SIPARISID).Select(c => _stokServis.obje.Where(v => v.id == c.stokid).Select(v => v.kod).FirstOrDefault()).FirstOrDefault() == null ? "" : "1",
        //        ADI = _siparisDetayServis.obje.Where(z => z.siparisid == x.SIPARISID).Select(c => _stokServis.obje.Where(v => v.id == c.stokid).Select(v => v.adi).FirstOrDefault()).FirstOrDefault() == null ? "" : "1",
        //        x.EMIRID,
        //        x.SIPARISMIKTARI,
        //        x.EMIRMIKTARI,
        //        KALANMIKTAR = _stokMalKabulListServis.obje.Where(z => z.emirid == x.EMIRID && z.siparisdetayid == x.SIPARISKALEMID).
        //        GroupBy(x => new { x.mpstok.kod, x.mpstok.adi, BIRIM = x.mpolcubr.adi, x.siparismiktari }).
        //        Select(x => x.Select(x => x.siparismiktari).FirstOrDefault() - x.Sum(z => z.miktar)).FirstOrDefault()
        //    }).ToList();
        //    dataGridView3.Refresh();

        }

        private void FMalKabulPanel_Activated(object sender, EventArgs e)
        {
          
        }

        private void FMalKabulPanel_Shown(object sender, EventArgs e)
        {
           
        }

        private void FMalKabulPanel_Leave(object sender, EventArgs e)
        {
         
        }
    }
}
