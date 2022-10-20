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
using MEYPAK.Interfaces.Depo;
using MEYPAK.Interfaces.Siparis;
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
        }
        DataGridViewButtonColumn DGVTopla; 
        List<PocoSIPARIS> _tempSiparis;
        FSevkiyatCekiPanel _sevkiyatCekiPanel;
        List<PocoSIPARISDETAY> _tempSTOKSEVK;
        List<PocoSIPARISDETAY> _tempSiparisDetay;
        GenericWebServis<PocoSIPARIS> _siparisServis;
        GenericWebServis<PocoDEPO> _depoEmirServis;

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
            dataGridView1.DataSource = StaticContext._siparisServis.Listele().Select(x => new { x.SEVKIYATTARIHI, x.BELGENO, x.CARIADI }).ToList();
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
            dataGridView2.DataSource = StaticContext._depoEmirServis.Listele().Select(x => new { x.ID, x.MPSIPARIS.BELGENO, x.MIKTAR, x.MPSIPARIS.CARIADI, x.MPSIPARIS.DEPOID, x.TIP, x.DURUM }).ToList();
            dataGridView2.Refresh();


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _tempSiparisDetay = StaticContext._siparisDetayServis.Listele().Where(x => x.MPSIPARIS.BELGENO.ToString() == dataGridView1.Rows[e.RowIndex].Cells["BELGENO"].Value.ToString()).ToList();

            if (dataGridView1.Columns[e.ColumnIndex].Name == "DGVTopla")
            {
                int i= 1;
                var a = StaticContext._depoEmirServis.Ekle(new PocoDEPOEMIR()
                {
                    SIPARISID = _siparisServis.obje.Where(x => x.BELGENO == dataGridView1.Rows[e.RowIndex].Cells["BELGENO"].Value.ToString()).FirstOrDefault().ID,
                    MIKTAR = _tempSiparisDetay.Sum(x=>x.MIKTAR),
                    SIRA = i,
                    TARIH = DateTime.Now,
                    TIP = 0,   /// TOPLAMA EMRİ TIPI OUTPUT =0 INPUT=1
                    DURUM = 1,
                    DEPOID = _siparisServis.obje.Where(x => x.BELGENO == dataGridView1.Rows[e.RowIndex].Cells["BELGENO"].Value.ToString()).FirstOrDefault().DEPOID,
                    ACIKLAMA = "",



                });
                dataGridView2.DataSource = StaticContext._depoEmirServis.Listele().Select(x => new { x.ID, x.MPSIPARIS.BELGENO, x.MIKTAR, x.MPSIPARIS.CARIADI, x.MPSIPARIS.DEPOID, x.TIP, x.DURUM }).ToList();
                dataGridView2.Refresh();
                foreach (var item in _tempSiparisDetay.Where(x=>x.HAREKETDURUMU==0).ToList())
                {
                    item.HAREKETDURUMU = 1;
                    StaticContext._siparisDetayServis.Guncelle(item);
                 
                    
                    StaticContext._siparisSevkEmriHarServis.Ekle(new PocoSIPARISSEVKEMIRHAR()
                    {
                        EMIRMIKTARI = item.MIKTAR,
                        SIPARISID = a.SIPARISID,
                        SIPARISKALEMID = item.ID,
                        EMIRID=a.ID,
                        SIPARISMIKTARI = item.MIKTAR,
                        KULLANICIID = 0,
                        TARIH = DateTime.Now,
                        TIP=0,

                    });


                    dataGridView3.DataSource = StaticContext._siparisSevkEmriHarServis.Listele().Select(x => new {x.MPSIPARIS.BELGENO, x.MPSIPARISDETAY.MPSTOK.KOD, x.MPSIPARISDETAY.MPSTOK.ADI, x.EMIRID, x.SIPARISMIKTARI, x.EMIRMIKTARI, KALANMIKTAR = StaticContext._stokMalKabulListServis.Listele().Where(z => z.EMIRID == x.EMIRID && z.SIPARISDETAYID == x.SIPARISKALEMID).GroupBy(x => new { x.MPSTOK.KOD, x.MPSTOK.ADI, BIRIM = x.MPOLCUBR.ADI, x.SIPARISMIKTARI }).Select(x => x.Select(x => x.SIPARISMIKTARI).FirstOrDefault() - x.Sum(z => z.MIKTAR)).FirstOrDefault() }).ToList();
                    dataGridView3.Refresh();
                    i++;
            }
                 
        }
           
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
    {
            // if (Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells["DURUM"].Value)==1)
            if (StaticContext._stokSevkiyatListServis.Listele().Count > 0)
                dataGridView4.DataSource = StaticContext._stokSevkiyatListServis.Getir(x => x.EMIRID.ToString() == dataGridView2.Rows[e.RowIndex].Cells["ID"].Value.ToString()).GroupBy(x => new { x.MPSTOK.KOD, x.MPSTOK.ADI, BIRIM = x.MPOLCUBR.ADI, x.SIPARISMIKTARI }).Select(x => new { KOD = x.Select(x => x.MPSTOK.KOD).FirstOrDefault(), ADI = x.Select(x => x.MPSTOK.ADI).FirstOrDefault(), MIKTAR = x.Sum(z => z.MIKTAR), SIPARISMIKTARI = x.Select(x => x.SIPARISMIKTARI).FirstOrDefault(), KALANMIKTAR = x.Select(x => x.SIPARISMIKTARI).FirstOrDefault() - x.Sum(z => z.MIKTAR), BIRIM = x.Select(x => x.MPOLCUBR.ADI).FirstOrDefault() }).ToList();

            dataGridView3.DataSource = StaticContext._siparisSevkEmriHarServis.Listele().Select(x => new { x.MPSIPARIS.BELGENO, x.MPSIPARISDETAY.MPSTOK.KOD, x.MPSIPARISDETAY.MPSTOK.ADI, x.EMIRID, x.SIPARISMIKTARI, x.EMIRMIKTARI, KALANMIKTAR = StaticContext._stokMalKabulListServis.Listele().Where(z => z.EMIRID == x.EMIRID && z.SIPARISDETAYID == x.SIPARISKALEMID).GroupBy(x => new { x.MPSTOK.KOD, x.MPSTOK.ADI, BIRIM = x.MPOLCUBR.ADI, x.SIPARISMIKTARI }).Select(x => x.Select(x => x.SIPARISMIKTARI).FirstOrDefault() - x.Sum(z => z.MIKTAR)).FirstOrDefault() }).ToList();
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
            _tempSTOKSEVK = StaticContext._depoEmirServis.Listele().Where(x => x.ID.ToString() == dataGridView2.Rows[e.RowIndex].Cells["ID"].Value.ToString()).Select(x => x.MPSIPARIS.MPSIPARISDETAYList.ToList()).FirstOrDefault();
          _sevkiyatCekiPanel = new FSevkiyatCekiPanel();
            _sevkiyatCekiPanel._tempEmir = StaticContext._depoEmirServis.Getir(x => x.ID.ToString() == dataGridView2.Rows[e.RowIndex].Cells["ID"].Value.ToString()).FirstOrDefault();
            _sevkiyatCekiPanel._tempList = _tempSTOKSEVK.Select(x => new PocoSTOKSEVKIYATLIST() { MPSTOK = x.MPSTOK,MPSIPARISDETAY=x, SIPARISMIKTARI = x.MIKTAR, DEPOID = x.MPSIPARIS.DEPOID, BIRIMID = x.BIRIMID, EMIRID = int.Parse(dataGridView2.Rows[e.RowIndex].Cells["ID"].Value.ToString()), SIPARISDETAYID = x.ID, STOKID = x.STOKID }).ToList();

            _sevkiyatCekiPanel.ShowDialog();
            dataGridView4.DataSource = StaticContext._stokSevkiyatListServis.Getir(x => x.EMIRID.ToString() == dataGridView2.Rows[e.RowIndex].Cells["ID"].Value.ToString()).GroupBy(x => new { x.MPSTOK.KOD, x.MPSTOK.ADI, BIRIM = x.MPOLCUBR.ADI, x.SIPARISMIKTARI }).Select(x => new { KOD = x.Select(x => x.MPSTOK.KOD).FirstOrDefault(), ADI = x.Select(x => x.MPSTOK.ADI).FirstOrDefault(), MIKTAR = x.Sum(z => z.MIKTAR), SIPARISMIKTARI = x.Select(x => x.SIPARISMIKTARI).FirstOrDefault(), KALANMIKTAR = x.Select(x => x.SIPARISMIKTARI).FirstOrDefault() - x.Sum(z => z.MIKTAR), BIRIM = x.Select(x => x.MPOLCUBR.ADI).FirstOrDefault() }).ToList();
            dataGridView3.DataSource = StaticContext._siparisSevkEmriHarServis.Listele().Select(x => new { x.MPSIPARIS.BELGENO, x.MPSIPARISDETAY.MPSTOK.KOD,x.MPSIPARISDETAY.MPSTOK.ADI, x.EMIRID, x.SIPARISMIKTARI, x.EMIRMIKTARI, KALANMIKTAR = x.MPSTOKSEVKIYATLIST.Where(z=>z.STOKID==x.MPSIPARISDETAY.STOKID).Sum(x=>x.SIPARISMIKTARI)- x.MPSTOKSEVKIYATLIST.Where(z => z.STOKID == x.MPSIPARISDETAY.STOKID).Sum(x => x.MIKTAR) }).ToList();

        }
    }
}
