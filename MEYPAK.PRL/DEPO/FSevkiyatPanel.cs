using MEYPAK.BLL.Assets;
using MEYPAK.BLL.DEPO;
using MEYPAK.BLL.SIPARIS;
using MEYPAK.BLL.STOK;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.DAL.Concrete.EntityFramework.Repository;
using MEYPAK.Entity.Models;
using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Entity.Models.SIPARIS;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels;
using MEYPAK.Entity.PocoModels.DEPO;
using MEYPAK.Entity.PocoModels.SIPARIS;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Depo;
using MEYPAK.Interfaces.Siparis;
using MEYPAK.Interfaces.Stok;
using MEYPAK.PRL.Assets;
using MEYPAK.PRL.Assets.Scripts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEYPAK.PRL.DEPO
{
    public partial class FSevkiyatPanel : Form
    {
        public FSevkiyatPanel()
        {
            InitializeComponent();
            _siparisServis = new GenericWebServis<PocoSIPARIS>();
            // this.tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            // this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
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
        public GenericWebServis<PocoSIPARIS> _siparisServis;
        public GenericWebServis<PocoSTOK> _stokServis;
        public GenericWebServis<PocoDEPOEMIR> _depoEmirServis;
        public GenericWebServis<PocoSIPARISDETAY> _siparisDetayServis;
        public GenericWebServis<PocoSIPARISSEVKEMIRHAR> _siparisSevkEmriHarServis;
        public GenericWebServis<PocoSTOKSEVKIYATLIST> _stokSevkiyatList;
        public GenericWebServis<PocoSTOKMALKABULLIST> _stokMalKabulListServis;
        public GenericWebServis<PocoOLCUBR> _olcuBrServis;

        #region TabControl Tasarım
        private Dictionary<TabPage, Color> TabColors = new Dictionary<TabPage, Color>();
        private void SetTabHeader(TabPage page, Color color)
        {
            TabColors[page] = color;
            tabControl1.Invalidate();
        }
        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            //using (Brush br = new SolidBrush(TabColors[tabControl1.TabPages[e.Index]]))
            //{
            //    e.Graphics.FillRectangle(br, e.Bounds);
            //    SizeF sz = e.Graphics.MeasureString(tabControl1.TabPages[e.Index].Text, e.Font);
            //    e.Graphics.DrawString(tabControl1.TabPages[e.Index].Text, e.Font, Brushes.Black, e.Bounds.Left + (e.Bounds.Width - sz.Width) / 2, e.Bounds.Top + (e.Bounds.Height - sz.Height) / 2 + 1);

            //    Rectangle rect = e.Bounds;
            //    rect.Offset(0, 1);
            //    rect.Inflate(0, -1);
            //    e.Graphics.DrawRectangle(Pens.DarkGray, rect);
            //    e.DrawFocusRectangle();
            //}
            //tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //tabControl1.CreateGraphics().FillRectangle(new SolidBrush(Color.DarkGray), tabControl1.Bounds);

        }
        #endregion
        private void FSevkiyatPanel_Load(object sender, EventArgs e)
        {
        
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
            _depoEmirServis.Data(ServisList.DepoEmirListeServis);
            dataGridView1.DataSource =  _siparisServis.obje.Where(x => x.tip == 0).Select(x => new { x.sevkiyattarihi, x.belgeno, x.cariadi }).ToList();
            _siparisServis.Data(ServisList.SiparisListeServis);
            
            dataGridView2.DataSource =  _depoEmirServis.obje.Select(x => new { x.id, BELGENO = _siparisServis.obje.Where(z => z.id == x.siparisid).FirstOrDefault().belgeno, x.miktar, CARIADI = _siparisServis.obje.Where(z => z.id == x.siparisid).FirstOrDefault().cariadi, DEPO = _siparisServis.obje.Where(z => z.id == x.siparisid).FirstOrDefault().depoid, x.tip, x.durum }).ToList();
            dataGridView2.Refresh();



        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _siparisDetayServis.Data(ServisList.SiparisDetayListeServis);
            _siparisServis.Data(ServisList.SiparisListeServis);
            _stokServis.Data(ServisList.StokListeServis);
            _stokMalKabulListServis.Data(ServisList.StokMalKabulListListeServis);
            _olcuBrServis.Data(ServisList.OlcuBrListeServis);
            _stokSevkiyatList.Data(ServisList.StokSevkiyatListListeServis);
            var tempsiparis= _siparisServis.obje.Where(x => x.belgeno == dataGridView1.Rows[e.RowIndex].Cells["BELGENO"].Value.ToString()).FirstOrDefault();
            var tempsipdetay=_siparisDetayServis.obje.Where(x => x.SIPARISID == tempsiparis.id);
            _tempSiparisDetay = tempsipdetay.ToList();

            if (dataGridView1.Columns[e.ColumnIndex].Name == "DGVTopla")
            {
                int i= 1;
                  _depoEmirServis.Data(ServisList.DepoEmirEkleServis,new PocoDEPOEMIR()
                {
                    siparisid = _siparisServis.obje.Where(x => x.belgeno == dataGridView1.Rows[e.RowIndex].Cells["BELGENO"].Value.ToString()).FirstOrDefault().id,
                    miktar = _tempSiparisDetay.Sum(x=>x.MIKTAR),
                    sira = i,
                    tarih = DateTime.Now,
                    tip = 0,   /// TOPLAMA EMRİ TIPI OUTPUT =0 INPUT=1
                    durum = 1,
                    depoid = _siparisServis.obje.Where(x => x.belgeno == dataGridView1.Rows[e.RowIndex].Cells["BELGENO"].Value.ToString()).FirstOrDefault().depoid,
                    aciklama = "",



                });

                
                _depoEmirServis.Data(ServisList.DepoEmirListeServis);
                dataGridView2.DataSource =_depoEmirServis.obje.Select(x => new { x.id, _siparisServis.obje.Where(z=>x.siparisid==z.id).FirstOrDefault().belgeno, x.miktar,  CARIADI=_siparisServis.obje.Where(z=>z.id==x.siparisid).FirstOrDefault().cariadi, _siparisServis.obje.Where(z => z.id == x.siparisid).FirstOrDefault().depoid, x.tip, x.durum }).ToList();
                dataGridView2.Refresh();
                foreach (var item in _tempSiparisDetay.Where(x=>x.HAREKETDURUMU==0).ToList())
                {
                    item.HAREKETDURUMU = 1;
                     _siparisDetayServis.Data(ServisList.SiparisDetayEkleServis,item);
                 
                    
                    _siparisSevkEmriHarServis.Data(ServisList.SiparisSevkEmriHarEkleServis,new PocoSIPARISSEVKEMIRHAR()
                    {
                        EMIRMIKTARI = item.MIKTAR,
                        SIPARISID = item.SIPARISID,
                        SIPARISKALEMID = item.id,
                        EMIRID= _depoEmirServis.obje.Where(x=>x.siparisid==item.SIPARISID).FirstOrDefault().id,
                        SIPARISMIKTARI = item.MIKTAR,
                        KULLANICIID = 0,
                        TARIH = DateTime.Now,
                        TIP=0,

                    });
                    _stokSevkiyatList.Data(ServisList.StokSevkiyatListEkleServis, new PocoSTOKSEVKIYATLIST()
                    {
                        birimid = item.BIRIMID,
                        depoid = _siparisServis.obje.Where(x => x.id == item.SIPARISID).FirstOrDefault().depoid,
                        emirid = _depoEmirServis.obje.Where(x => x.siparisid == item.SIPARISID).FirstOrDefault().id,
                        miktar = item.MIKTAR,
                        stokid = item.STOKID,
                        sevkemriharid = _siparisSevkEmriHarServis.obje2.id,siparisdetayid=item.SIPARISID

                    });
                    _stokSevkiyatList.Data(ServisList.StokSevkiyatListListeServis);
                    _siparisSevkEmriHarServis.Data(ServisList.SiparisSevkEmriHarListeServis);
                    dataGridView3.DataSource = _siparisSevkEmriHarServis.obje.Select(x => 
                    new { BELGENO = _siparisServis.obje.Where(z => z.id == x.SIPARISID).FirstOrDefault().belgeno,
                        KOD = _stokServis.obje.Where(c => c.id == item.STOKID).FirstOrDefault().kod, 
                        ADI = item.STOKADI, 
                        x.EMIRID, x.SIPARISMIKTARI, x.EMIRMIKTARI,
                        KALANMIKTAR = _stokSevkiyatList.obje.Where(z => z.emirid == x.EMIRID && z.siparisdetayid
                        == x.SIPARISKALEMID).GroupBy(x => new { _stokServis.obje.Where(z=>z.id==x.stokid).FirstOrDefault().kod,
                            item.STOKADI, BIRIM = _olcuBrServis.obje.Where(z=>z.id==x.birimid).FirstOrDefault().adi,
                            x.siparismiktari }).Select(x => x.Select(x => x.siparismiktari).FirstOrDefault() 
                            - x.Sum(z => z.miktar)).FirstOrDefault() }).ToList();
                    dataGridView3.Refresh();
                    i++;
            }
                 
        }
           
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
                var tempp = _stokSevkiyatList.obje.Where(x => x.emirid.ToString() == dataGridView2.Rows[e.RowIndex].Cells["id"].Value.ToString()).GroupBy(x => new { x.mpstok.kod, x.mpstok.adi, BIRIM = x.mpolcubr.adi, x.siparismiktari }).Select(x => new { KOD = x.Select(x => x.mpstok.kod).FirstOrDefault(), ADI = x.Select(x => x.mpstok.adi).FirstOrDefault(), MIKTAR = x.Sum(z => z.miktar), SIPARISMIKTARI = x.Select(x => x.siparismiktari).FirstOrDefault(), KALANMIKTAR = x.Select(x => x.siparismiktari).FirstOrDefault() - x.Sum(z => z.miktar), BIRIM = x.Select(x => x.mpolcubr.adi).FirstOrDefault() }).ToList();
                dataGridView4.DataSource = tempp;
            }
            _stokMalKabulListServis.Data(ServisList.StokMalKabulListListeServis);
            dataGridView3.DataSource = _siparisSevkEmriHarServis.obje.Select(x => 
            new { BELGENO=_siparisServis.obje.Where(z=>z.id==x.SIPARISID).FirstOrDefault().belgeno,
                KOD=  _siparisDetayServis.obje.Where(z=> z.SIPARISID==x.SIPARISID).Select(c=> _stokServis.obje.Where(v=>v.id==c.STOKID).Select(v=>v.kod).FirstOrDefault()).FirstOrDefault() == null ? "" : "1", 
                ADI=  _siparisDetayServis.obje.Where(z => z.SIPARISID == x.SIPARISID).Select(c => _stokServis.obje.Where(v => v.id == c.STOKID).Select(v => v.adi).FirstOrDefault()).FirstOrDefault()==null?"":"1",
                x.EMIRID, x.SIPARISMIKTARI, x.EMIRMIKTARI,
                KALANMIKTAR = _stokMalKabulListServis.obje.Where(z => z.emirid == x.EMIRID && z.siparisdetayid == x.SIPARISKALEMID).
                GroupBy(x => new { x.mpstok.kod, x.mpstok.adi, BIRIM = x.mpolcubr.adi, x.siparismiktari }).
                Select(x => x.Select(x => x.siparismiktari).FirstOrDefault() - x.Sum(z => z.miktar)).FirstOrDefault() }).ToList();
            dataGridView3.Refresh();

    }

    private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
    {
            
        }

        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
          
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _depoEmirServis.Data(ServisList.DepoEmirListeServis);
            var tempp = _depoEmirServis.obje.Where(x => x.id.ToString() == dataGridView2.Rows[e.RowIndex].Cells["id"].Value.ToString());
            _tempSTOKSEVK = tempp.Select(x => _siparisDetayServis.obje.Where(z => z.SIPARISID == x.siparisid).ToList()).FirstOrDefault();
          _sevkiyatCekiPanel = new FSevkiyatCekiPanel();
            _stokSevkiyatList.Data(ServisList.StokSevkiyatListListeServis);

            _sevkiyatCekiPanel._tempEmir = tempp.FirstOrDefault();
            _sevkiyatCekiPanel._tempList = _stokSevkiyatList.obje.Select(x => new PocoSTOKSEVKIYATLIST() { mpstok = _stokServis.obje.Where(z=>z.id==x.stokid).FirstOrDefault(),mpsiparisdetay=_siparisDetayServis.obje.Where(z=>z.id==x.siparisdetayid).FirstOrDefault(), siparismiktari = x.miktar, depoid = x.depoid, birimid = x.birimid, emirid = int.Parse(dataGridView2.Rows[e.RowIndex].Cells["id"].Value.ToString()), siparisdetayid = x.id, stokid = x.stokid }).ToList();

            _sevkiyatCekiPanel.ShowDialog();
            var tempp2 = _stokSevkiyatList.obje.Where(x => x.emirid.ToString() == dataGridView2.Rows[e.RowIndex].Cells["id"].Value.ToString()).GroupBy(x => new { x.mpstok.kod, x.mpstok.adi, BIRIM = x.mpolcubr.adi, x.siparismiktari }).Select(x => new { KOD = x.Select(x => x.mpstok.kod).FirstOrDefault(), ADI = x.Select(x => x.mpstok.adi).FirstOrDefault(), MIKTAR = x.Sum(z => z.miktar), SIPARISMIKTARI = x.Select(x => x.siparismiktari).FirstOrDefault(), KALANMIKTAR = x.Select(x => x.siparismiktari).FirstOrDefault() - x.Sum(z => z.miktar), BIRIM = x.Select(x => x.mpolcubr.adi).FirstOrDefault() }).ToList();
            dataGridView4.DataSource = tempp2;
            dataGridView3.DataSource = _siparisSevkEmriHarServis.obje.Select(x =>
            new {
                BELGENO = _siparisServis.obje.Where(z => z.id == x.SIPARISID).FirstOrDefault().belgeno,
                KOD = _siparisDetayServis.obje.Where(z => z.SIPARISID == x.SIPARISID).Select(c => _stokServis.obje.Where(v => v.id == c.STOKID).Select(v => v.kod).FirstOrDefault()).FirstOrDefault() == null ? "" : "1",
                ADI = _siparisDetayServis.obje.Where(z => z.SIPARISID == x.SIPARISID).Select(c => _stokServis.obje.Where(v => v.id == c.STOKID).Select(v => v.adi).FirstOrDefault()).FirstOrDefault() == null ? "" : "1",
                x.EMIRID,
                x.SIPARISMIKTARI,
                x.EMIRMIKTARI,
                KALANMIKTAR = _stokMalKabulListServis.obje.Where(z => z.emirid == x.EMIRID && z.siparisdetayid == x.SIPARISKALEMID).
                GroupBy(x => new { x.mpstok.kod, x.mpstok.adi, BIRIM = x.mpolcubr.adi, x.siparismiktari }).
                Select(x => x.Select(x => x.siparismiktari).FirstOrDefault() - x.Sum(z => z.miktar)).FirstOrDefault()
            }).ToList();

        }
    }
}
