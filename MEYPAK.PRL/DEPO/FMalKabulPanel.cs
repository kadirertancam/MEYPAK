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
            _stokSevkiyatList = new GenericWebServis<PocoSTOKSEVKIYATLIST>();
            _stokServis = new GenericWebServis<PocoSTOK>();
            _stokMalKabulListServis = new GenericWebServis<PocoSTOKMALKABULLIST>();
            _olcuBrServis = new GenericWebServis<PocoOLCUBR>();
        }
        DataGridViewButtonColumn DGVTopla;
        List<PocoSIPARIS> _tempSiparis;
        FSevkiyatCekiPanel _sevkiyatCekiPanel;
        List<PocoSIPARISDETAY> _tempSTOKSEVK;
        List<PocoSIPARISDETAY> _tempSiparisDetay;
        GenericWebServis<PocoSIPARIS> _siparisServis;
        GenericWebServis<PocoSTOK> _stokServis;
        GenericWebServis<PocoDEPOEMIR> _depoEmirServis;
        GenericWebServis<PocoSIPARISDETAY> _siparisDetayServis;
        GenericWebServis<PocoSIPARISSEVKEMIRHAR> _siparisSevkEmriHarServis;
        GenericWebServis<PocoSTOKSEVKIYATLIST> _stokSevkiyatList;
        GenericWebServis<PocoSTOKMALKABULLIST> _stokMalKabulListServis;
        GenericWebServis<PocoOLCUBR> _olcuBrServis;
        private Dictionary<TabPage, Color> TabColors = new Dictionary<TabPage, Color>();
        private void FMalKabulPanel_Load(object sender, EventArgs e)
        {
            _siparisServis.Data(ServisList.SiparisListeServis);
            _depoEmirServis.Data(ServisList.DepoEmirListeServis);
            dataGridView1.DataSource = _siparisServis.obje.Where(x=>x.TIP==1).Select(x => new { x.SEVKIYATTARIHI, x.BELGENO, x.CARIADI }).ToList();
            DGVTopla.Name = "DGVTopla";
            DGVTopla.HeaderText = "Toplama";
            DGVTopla.DisplayIndex = 3;
            DGVTopla.FlatStyle = FlatStyle.Flat;
            DGVTopla.CellTemplate.Style.ForeColor = Color.Aqua;
            DGVTopla.CellTemplate.Style.SelectionForeColor = Color.Aqua;
            DGVTopla.Text = "Toplama";
            DGVTopla.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(DGVTopla);
            dataGridView1.Columns["DGVTopla"].DefaultCellStyle.ForeColor = Color.Aqua;
            _siparisServis.Data(ServisList.SiparisListeServis);

            dataGridView2.DataSource = _depoEmirServis.obje.Select(x => new { x.ID, BELGENO = _siparisServis.obje.Where(z => z.ID == x.SIPARISID).FirstOrDefault().BELGENO, x.MIKTAR, CARIADI = _siparisServis.obje.Where(z => z.ID == x.SIPARISID).FirstOrDefault().CARIADI, DEPO = _siparisServis.obje.Where(z => z.ID == x.SIPARISID).FirstOrDefault().DEPOID, x.TIP, x.DURUM }).ToList();
            dataGridView2.Refresh();

        }
        MPDEPOEMIR a;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _siparisDetayServis.Data(ServisList.SiparisDetayListeServis);
            _siparisServis.Data(ServisList.SiparisListeServis);
            _stokServis.Data(ServisList.StokListeServis);
            _stokMalKabulListServis.Data(ServisList.StokMalKabulListListeServis);
            _olcuBrServis.Data(ServisList.OlcuBrListeServis);
            _stokSevkiyatList.Data(ServisList.StokSevkiyatListListeServis);
            var tempsiparis = _siparisServis.obje.Where(x => x.BELGENO == dataGridView1.Rows[e.RowIndex].Cells["BELGENO"].Value.ToString()).FirstOrDefault();
            var tempsipdetay = _siparisDetayServis.obje.Where(x => x.SIPARISID == tempsiparis.ID);
            _tempSiparisDetay = tempsipdetay.ToList();

            if (dataGridView1.Columns[e.ColumnIndex].Name == "DGVTopla")
            {
                int i = 1;
                _depoEmirServis.Data(ServisList.DepoEmirEkleServis, new PocoDEPOEMIR()
                {
                    SIPARISID = _siparisServis.obje.Where(x => x.BELGENO == dataGridView1.Rows[e.RowIndex].Cells["BELGENO"].Value.ToString()).FirstOrDefault().ID,
                    MIKTAR = _tempSiparisDetay.Sum(x => x.MIKTAR),
                    SIRA = i,
                    TARIH = DateTime.Now,
                    TIP = 0,   /// TOPLAMA EMRİ TIPI OUTPUT =0 INPUT=1
                    DURUM = 1,
                    DEPOID = _siparisServis.obje.Where(x => x.BELGENO == dataGridView1.Rows[e.RowIndex].Cells["BELGENO"].Value.ToString()).FirstOrDefault().DEPOID,
                    ACIKLAMA = "",



                });


                _depoEmirServis.Data(ServisList.DepoEmirListeServis);
                dataGridView2.DataSource = _depoEmirServis.obje.Select(x => new { x.ID, _siparisServis.obje.Where(z => x.SIPARISID == z.ID).FirstOrDefault().BELGENO, x.MIKTAR, CARIADI = _siparisServis.obje.Where(z => z.ID == x.SIPARISID).FirstOrDefault().CARIADI, _siparisServis.obje.Where(z => z.ID == x.SIPARISID).FirstOrDefault().DEPOID, x.TIP, x.DURUM }).ToList();
                dataGridView2.Refresh();
                foreach (var item in _tempSiparisDetay.Where(x => x.HAREKETDURUMU == 0).ToList())
                {
                    item.HAREKETDURUMU = 1;
                    _siparisDetayServis.Data(ServisList.SiparisDetayEkleServis, item);


                    _siparisSevkEmriHarServis.Data(ServisList.SiparisSevkEmriHarEkleServis, new PocoSIPARISSEVKEMIRHAR()
                    {
                        EMIRMIKTARI = item.MIKTAR,
                        SIPARISID = item.SIPARISID,
                        SIPARISKALEMID = item.ID,
                        EMIRID = _depoEmirServis.obje.Where(x => x.SIPARISID == item.SIPARISID).FirstOrDefault().ID,
                        SIPARISMIKTARI = item.MIKTAR,
                        KULLANICIID = 0,
                        TARIH = DateTime.Now,
                        TIP = 0,

                    });
                    _stokSevkiyatList.Data(ServisList.StokSevkiyatListEkleServis, new PocoSTOKSEVKIYATLIST()
                    {
                        BIRIMID = item.BIRIMID,
                        DEPOID = _siparisServis.obje.Where(x => x.ID == item.SIPARISID).FirstOrDefault().DEPOID,
                        EMIRID = _depoEmirServis.obje.Where(x => x.SIPARISID == item.SIPARISID).FirstOrDefault().ID,
                        MIKTAR = item.MIKTAR,
                        STOKID = item.STOKID,
                        SEVKEMRIHARID = _siparisSevkEmriHarServis.obje2.ID,
                        SIPARISDETAYID = item.SIPARISID

                    });
                    _stokSevkiyatList.Data(ServisList.StokSevkiyatListListeServis);
                    _siparisSevkEmriHarServis.Data(ServisList.SiparisSevkEmriHarListeServis);
                    dataGridView3.DataSource = _siparisSevkEmriHarServis.obje.Select(x =>
                    new {
                        BELGENO = _siparisServis.obje.Where(z => z.ID == x.SIPARISID).FirstOrDefault().BELGENO,
                        KOD = _stokServis.obje.Where(c => c.ID == item.STOKID).FirstOrDefault().KOD,
                        ADI = item.STOKADI,
                        x.EMIRID,
                        x.SIPARISMIKTARI,
                        x.EMIRMIKTARI,
                        KALANMIKTAR = _stokSevkiyatList.obje.Where(z => z.EMIRID == x.EMIRID && z.SIPARISDETAYID
                        == x.SIPARISKALEMID).GroupBy(x => new {
                            _stokServis.obje.Where(z => z.ID == x.STOKID).FirstOrDefault().KOD,
                            item.STOKADI,
                            BIRIM = _olcuBrServis.obje.Where(z => z.ID == x.BIRIMID).FirstOrDefault().ADI,
                            x.SIPARISMIKTARI
                        }).Select(x => x.Select(x => x.SIPARISMIKTARI).FirstOrDefault()
                            - x.Sum(z => z.MIKTAR)).FirstOrDefault()
                    }).ToList();
                    dataGridView3.Refresh();
                    i++;
                }

            }
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _depoEmirServis.Data(ServisList.DepoEmirListeServis);
            var tempp = _depoEmirServis.obje.Where(x => x.ID.ToString() == dataGridView2.Rows[e.RowIndex].Cells["ID"].Value.ToString());
            _tempSTOKSEVK = tempp.Select(x => _siparisDetayServis.obje.Where(z => z.SIPARISID == x.SIPARISID).ToList()).FirstOrDefault();
            _sevkiyatCekiPanel = new FSevkiyatCekiPanel();
            _stokSevkiyatList.Data(ServisList.StokSevkiyatListListeServis);

            _sevkiyatCekiPanel._tempEmir = tempp.FirstOrDefault();
            _sevkiyatCekiPanel._tempList = _stokSevkiyatList.obje.Select(x => new PocoSTOKSEVKIYATLIST() { MPSTOK = _stokServis.obje.Where(z => z.ID == x.STOKID).FirstOrDefault(), MPSIPARISDETAY = _siparisDetayServis.obje.Where(z => z.ID == x.SIPARISDETAYID).FirstOrDefault(), SIPARISMIKTARI = x.MIKTAR, DEPOID = x.DEPOID, BIRIMID = x.BIRIMID, EMIRID = int.Parse(dataGridView2.Rows[e.RowIndex].Cells["ID"].Value.ToString()), SIPARISDETAYID = x.ID, STOKID = x.STOKID }).ToList();

            _sevkiyatCekiPanel.ShowDialog();
            var tempp2 = _stokSevkiyatList.obje.Where(x => x.EMIRID.ToString() == dataGridView2.Rows[e.RowIndex].Cells["ID"].Value.ToString()).GroupBy(x => new { x.MPSTOK.KOD, x.MPSTOK.ADI, BIRIM = x.MPOLCUBR.ADI, x.SIPARISMIKTARI }).Select(x => new { KOD = x.Select(x => x.MPSTOK.KOD).FirstOrDefault(), ADI = x.Select(x => x.MPSTOK.ADI).FirstOrDefault(), MIKTAR = x.Sum(z => z.MIKTAR), SIPARISMIKTARI = x.Select(x => x.SIPARISMIKTARI).FirstOrDefault(), KALANMIKTAR = x.Select(x => x.SIPARISMIKTARI).FirstOrDefault() - x.Sum(z => z.MIKTAR), BIRIM = x.Select(x => x.MPOLCUBR.ADI).FirstOrDefault() }).ToList();
            dataGridView4.DataSource = tempp2;
            dataGridView3.DataSource = _siparisSevkEmriHarServis.obje.Select(x =>
            new {
                BELGENO = _siparisServis.obje.Where(z => z.ID == x.SIPARISID).FirstOrDefault().BELGENO,
                KOD = _siparisDetayServis.obje.Where(z => z.SIPARISID == x.SIPARISID).Select(c => _stokServis.obje.Where(v => v.ID == c.STOKID).Select(v => v.KOD).FirstOrDefault()).FirstOrDefault() == null ? "" : "1",
                ADI = _siparisDetayServis.obje.Where(z => z.SIPARISID == x.SIPARISID).Select(c => _stokServis.obje.Where(v => v.ID == c.STOKID).Select(v => v.ADI).FirstOrDefault()).FirstOrDefault() == null ? "" : "1",
                x.EMIRID,
                x.SIPARISMIKTARI,
                x.EMIRMIKTARI,
                KALANMIKTAR = _stokMalKabulListServis.obje.Where(z => z.EMIRID == x.EMIRID && z.SIPARISDETAYID == x.SIPARISKALEMID).
                GroupBy(x => new { x.MPSTOK.KOD, x.MPSTOK.ADI, BIRIM = x.MPOLCUBR.ADI, x.SIPARISMIKTARI }).
                Select(x => x.Select(x => x.SIPARISMIKTARI).FirstOrDefault() - x.Sum(z => z.MIKTAR)).FirstOrDefault()
            }).ToList(); 
        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // if (Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells["DURUM"].Value)==1)
            _stokSevkiyatList.Data(ServisList.StokSevkiyatListListeServis);
            _stokServis.Data(ServisList.StokListeServis);
            _siparisSevkEmriHarServis.Data(ServisList.SiparisSevkEmriHarListeServis);
            _siparisServis.Data(ServisList.SiparisListeServis);
            _siparisDetayServis.Data(ServisList.SiparisDetayListeServis);

            if (_stokSevkiyatList.obje.Count > 0)
            {
                var tempp = _stokSevkiyatList.obje.Where(x => x.EMIRID.ToString() == dataGridView2.Rows[e.RowIndex].Cells["ID"].Value.ToString()).GroupBy(x => new { x.MPSTOK.KOD, x.MPSTOK.ADI, BIRIM = x.MPOLCUBR.ADI, x.SIPARISMIKTARI }).Select(x => new { KOD = x.Select(x => x.MPSTOK.KOD).FirstOrDefault(), ADI = x.Select(x => x.MPSTOK.ADI).FirstOrDefault(), MIKTAR = x.Sum(z => z.MIKTAR), SIPARISMIKTARI = x.Select(x => x.SIPARISMIKTARI).FirstOrDefault(), KALANMIKTAR = x.Select(x => x.SIPARISMIKTARI).FirstOrDefault() - x.Sum(z => z.MIKTAR), BIRIM = x.Select(x => x.MPOLCUBR.ADI).FirstOrDefault() }).ToList();
                dataGridView4.DataSource = tempp;
            }
            _stokMalKabulListServis.Data(ServisList.StokMalKabulListListeServis);
            dataGridView3.DataSource = _siparisSevkEmriHarServis.obje.Select(x =>
            new {
                BELGENO = _siparisServis.obje.Where(z => z.ID == x.SIPARISID).FirstOrDefault().BELGENO,
                KOD = _siparisDetayServis.obje.Where(z => z.SIPARISID == x.SIPARISID).Select(c => _stokServis.obje.Where(v => v.ID == c.STOKID).Select(v => v.KOD).FirstOrDefault()).FirstOrDefault() == null ? "" : "1",
                ADI = _siparisDetayServis.obje.Where(z => z.SIPARISID == x.SIPARISID).Select(c => _stokServis.obje.Where(v => v.ID == c.STOKID).Select(v => v.ADI).FirstOrDefault()).FirstOrDefault() == null ? "" : "1",
                x.EMIRID,
                x.SIPARISMIKTARI,
                x.EMIRMIKTARI,
                KALANMIKTAR = _stokMalKabulListServis.obje.Where(z => z.EMIRID == x.EMIRID && z.SIPARISDETAYID == x.SIPARISKALEMID).
                GroupBy(x => new { x.MPSTOK.KOD, x.MPSTOK.ADI, BIRIM = x.MPOLCUBR.ADI, x.SIPARISMIKTARI }).
                Select(x => x.Select(x => x.SIPARISMIKTARI).FirstOrDefault() - x.Sum(z => z.MIKTAR)).FirstOrDefault()
            }).ToList();
            dataGridView3.Refresh();

        }
    }
}
