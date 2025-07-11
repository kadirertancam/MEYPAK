﻿using DevExpress.Mvvm.POCO;
using DevExpress.Utils.Html;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Tile;
using MEYPAK.BLL.Assets;
using MEYPAK.BLL.DEPO;
using MEYPAK.BLL.SIPARIS;
using MEYPAK.BLL.STOK;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.DAL.Concrete.EntityFramework.Repository;
using MEYPAK.Entity.Models;
using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Entity.Models.FORMYETKI;
using MEYPAK.Entity.Models.SIPARIS;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels;
using MEYPAK.Entity.PocoModels.CARI;
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
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEYPAK.PRL.DEPO
{
    public partial class FMalKabulPanel : XtraForm
    {
        public FMalKabulPanel()
        {
            InitializeComponent();
            _siparisServis = new GenericWebServis<PocoSIPARIS>();
            // this.tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            // this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
            //dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(105, 105, 105);
            //dataGridView1.EnableHeadersVisualStyles = false; 
            DGVTopla = new DataGridViewButtonColumn();
            _malKabulCekiPanel = new FMalKabulCekiPanel();
            _depoEmirServis = new GenericWebServis<PocoDEPOEMIR>();
            _siparisDetayServis = new GenericWebServis<PocoSIPARISDETAY>();
            _siparisMalKabulHarServis = new GenericWebServis<PocoSATINALMAMALKABULEMRIHAR>();
            _stokMalKabulListServis = new GenericWebServis<PocoSTOKMALKABULLIST>();
            _stokServis = new GenericWebServis<PocoSTOK>();
            _olcuBrServis = new GenericWebServis<PocoOLCUBR>();
            _depoServis = new GenericWebServis<PocoDEPO>();
            _depoCekiListServis = new GenericWebServis<PocoDEPOCEKILIST>();
            _stokResimServis = new GenericWebServis<PocoSTOKRESIM>();
            _cariResimServis = new GenericWebServis<PocoCARIRESIM>();
            _cariAltHesapServis= new GenericWebServis<PocoCARIALTHES>();
        }
        DataGridViewButtonColumn DGVTopla;
        List<PocoSIPARIS> _tempSiparis;
        FMalKabulCekiPanel _malKabulCekiPanel;
        FDepoStokDurumList fDepoStokDurumList;
        List<PocoSIPARISDETAY> _tempSTOKSEVK;
        List<PocoSIPARISDETAY> _tempSiparisDetay;
        public GenericWebServis<PocoSIPARIS> _siparisServis;
        public GenericWebServis<PocoCARIRESIM> _cariResimServis;
        public GenericWebServis<PocoSTOK> _stokServis;
        public GenericWebServis<PocoDEPOEMIR> _depoEmirServis;
        public GenericWebServis<PocoSIPARISDETAY> _siparisDetayServis;
        public GenericWebServis<PocoSATINALMAMALKABULEMRIHAR> _siparisMalKabulHarServis; 
        public GenericWebServis<PocoSTOKMALKABULLIST> _stokMalKabulListServis;
        public GenericWebServis<PocoOLCUBR> _olcuBrServis;
        public GenericWebServis<PocoDEPO> _depoServis;
        public GenericWebServis<PocoDEPOCEKILIST> _depoCekiListServis;
        public GenericWebServis<PocoSTOKRESIM> _stokResimServis;
        public GenericWebServis<PocoCARIALTHES> _cariAltHesapServis;
        FDepoIsEmriPanel fDepoIsEmriPanel;

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
        private void FMalKabulPanel_Load(object sender, EventArgs e)
        {

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
            _cariAltHesapServis.Data(ServisList.CariAltHesListeServis);
            _siparisServis.Data(ServisList.SiparisListeServis);
            _depoEmirServis.Data(ServisList.DepoEmirListeServis);
            GCSiparisPanel.DataSource = _siparisServis.obje.Where(x => x.tip == 1).Select(x => new { x.sevkiyattarihi, x.belgeno, x.cariadi }).ToList();
            _siparisServis.Data(ServisList.SiparisListeServis);
            _cariResimServis.Data(ServisList.CariResimListeServis);
            //fSevkiyatPanel.dataGridView2.DataSource = 
            //fSevkiyatPanel.dataGridView2.Refresh();

            tileView1.CustomItemTemplate += TileView1_CustomItemTemplate;

            //Bitmap bt = new Bitmap("C:\\Users\\User\\Desktop\\İCON\\Logolar\\pngwing.com-2.png");
          


            GCSiparisPanel.DataSource = _siparisServis.obje.Where(x => x.tip == 1).Select(x => new { CSevkiyatTarihi = x.sevkiyattarihi, CBelgeNo = x.belgeno, CCariAdi = x.cariadi, CAltCari= _cariAltHesapServis.obje.Where(y => y.id == x.althesapid).FirstOrDefault().adi, CResim = _cariResimServis.obje.Where(c=> c.CARIID==x.cariid).Count()>0? Base64StringToBitmap(_cariResimServis.obje.Where(c => c.CARIID == x.cariid).FirstOrDefault().IMG) : Properties.Resources.CariNullResim }).Reverse().ToList();
            tileView1.ItemCustomize += TileView1_ItemCustomize;
            tileView1.AddNewRow();
            tileView1.UpdateCurrentRow();
            tileView1.ShowEditForm();

        }
        public  Bitmap Base64StringToBitmap(string base64String)
        {
            Bitmap bmpReturn = null;


            byte[] byteBuffer = Convert.FromBase64String(base64String);
            MemoryStream memoryStream = new MemoryStream(byteBuffer);


            memoryStream.Position = 0;


            bmpReturn = (Bitmap)Bitmap.FromStream(memoryStream);


            memoryStream.Close();
            memoryStream = null;
            byteBuffer = null;


            return bmpReturn;
        }
        private void TileView1_CustomItemTemplate(object sender, TileViewCustomItemTemplateEventArgs e)
        {

        }

        private void TileView1_ItemCustomize(object sender, TileViewItemCustomizeEventArgs e)
        {


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _siparisDetayServis.Data(ServisList.SiparisDetayListeServis);
            _siparisServis.Data(ServisList.SiparisListeServis);
            _stokServis.Data(ServisList.StokListeServis);
            _stokMalKabulListServis.Data(ServisList.StokMalKabulListListeServis);
            _olcuBrServis.Data(ServisList.OlcuBrListeServis);
            _stokMalKabulListServis.Data(ServisList.StokMalKabulListListeServis);
            //    var tempsiparis= _siparisServis.obje.Where(x => x.BELGENO == dataGridView1.Rows[e.RowIndex].Cells["BELGENO"].Value.ToString()).FirstOrDefault();
            //    var tempsipdetay=_siparisDetayServis.obje.Where(x => x.SIPARISID == tempsiparis.id);
            //    _tempSiparisDetay = tempsipdetay.ToList();

            //    if (dataGridView1.Columns[e.ColumnIndex].Name == "DGVTopla")
            //    {
            //        int i= 1;
            //          _depoEmirServis.Data(ServisList.DepoEmirEkleServis,new PocoDEPOEMIR()
            //        {
            //            SIPARISID = _siparisServis.obje.Where(x => x.BELGENO == dataGridView1.Rows[e.RowIndex].Cells["BELGENO"].Value.ToString()).FirstOrDefault().id,
            //            MIKTAR = _tempSiparisDetay.Sum(x=>x.MIKTAR),
            //            SIRA = i,
            //            TARIH = DateTime.Now,
            //            TIP = 0,   /// TOPLAMA EMRİ TIPI OUTPUT =0 INPUT=1
            //            DURUM = 1,
            //            DEPOID = _siparisServis.obje.Where(x => x.BELGENO == dataGridView1.Rows[e.RowIndex].Cells["BELGENO"].Value.ToString()).FirstOrDefault().DEPOID,
            //            ACIKLAMA = "",



            //        });


            //        _depoEmirServis.Data(ServisList.DepoEmirListeServis);
            //        dataGridView2.DataSource =_depoEmirServis.obje.Select(x => new { x.id, _siparisServis.obje.Where(z=>x.SIPARISID==z.id).FirstOrDefault().BELGENO, x.MIKTAR,  CARIADI=_siparisServis.obje.Where(z=>z.id==x.SIPARISID).FirstOrDefault().CARIADI, _siparisServis.obje.Where(z => z.id == x.SIPARISID).FirstOrDefault().DEPOID, x.TIP, x.DURUM }).ToList();
            //        dataGridView2.Refresh();
            //        foreach (var item in _tempSiparisDetay.Where(x=>x.HAREKETDURUMU==0).ToList())
            //        {
            //            item.HAREKETDURUMU = 1;
            //             _siparisDetayServis.Data(ServisList.SiparisDetayEkleServis,item);


            //            _siparisMalKabulHarServis.Data(ServisList.SiparisSevkEmriHarEkleServis,new PocoSIPARISSEVKEMIRHAR()
            //            {
            //                EMIRMIKTARI = item.MIKTAR,
            //                SIPARISID = item.SIPARISID,
            //                SIPARISKALEMID = item.id,
            //                EMIRID= _depoEmirServis.obje.Where(x=>x.SIPARISID==item.SIPARISID).FirstOrDefault().id,
            //                SIPARISMIKTARI = item.MIKTAR,
            //                KULLANICIID = 0,
            //                TARIH = DateTime.Now,
            //                TIP=0,

            //            });
            //            _stokMalKabulListServis.Data(ServisList.StokSevkiyatListEkleServis, new PocoSTOKSEVKIYATLIST()
            //            {
            //                BIRIMID = item.BIRIMID,
            //                DEPOID = _siparisServis.obje.Where(x => x.id == item.SIPARISID).FirstOrDefault().DEPOID,
            //                EMIRID = _depoEmirServis.obje.Where(x => x.SIPARISID == item.SIPARISID).FirstOrDefault().id,
            //                MIKTAR = item.MIKTAR,
            //                STOKID = item.STOKID,
            //                SEVKEMRIHARID = _siparisMalKabulHarServis.obje2.id,SIPARISDETAYID=item.SIPARISID

            //            });
            //            _stokMalKabulListServis.Data(ServisList.StokMalKabulListListeServis);
            //            _siparisMalKabulHarServis.Data(ServisList.SiparisSevkEmriHarListeServis);
            //            dataGridView3.DataSource = _siparisMalKabulHarServis.obje.Select(x => 
            //            new { BELGENO = _siparisServis.obje.Where(z => z.id == x.SIPARISID).FirstOrDefault().BELGENO,
            //                KOD = _stokServis.obje.Where(c => c.id == item.STOKID).FirstOrDefault().kod, 
            //                ADI = item.STOKADI, 
            //                x.EMIRID, x.SIPARISMIKTARI, x.EMIRMIKTARI,
            //                KALANMIKTAR = _stokMalKabulListServis.obje.Where(z => z.EMIRID == x.EMIRID && z.SIPARISDETAYID
            //                == x.SIPARISKALEMID).GroupBy(x => new { _stokServis.obje.Where(z=>z.id==x.STOKID).FirstOrDefault().kod,
            //                    item.STOKADI, BIRIM = _olcuBrServis.obje.Where(z=>z.id==x.BIRIMID).FirstOrDefault().adi,
            //                    x.SIPARISMIKTARI }).Select(x => x.Select(x => x.SIPARISMIKTARI).FirstOrDefault() 
            //                    - x.Sum(z => z.MIKTAR)).FirstOrDefault() }).ToList();
            //            dataGridView3.Refresh();
            //            i++;
            //    }

            //}

        }
        public void OnDepoDurumClick(object o, DxHtmlElementMouseEventArgs args)
        {
            fDepoStokDurumList = new FDepoStokDurumList(tileView3.GetFocusedRowCellValue("StokKodu").ToString());
            fDepoStokDurumList.ShowDialog();

        }
        public void onDetailButtonClick(object o, DxHtmlElementMouseEventArgs args)
        {
            var _belgeno = tileView1.GetFocusedRowCellValue("CBelgeNo").ToString();
            _siparisDetayServis.Data(ServisList.SiparisDetayListeServis);
            int i = 1;
            var tempsiparis = _siparisServis.obje.Where(x => x.belgeno == _belgeno).FirstOrDefault();

            fDepoIsEmriPanel = new FDepoIsEmriPanel(tempsiparis.id.ToString(),"",1);
            fDepoIsEmriPanel.ShowDialog();

            _depoEmirServis.Data(ServisList.DepoEmirListeServis);
            _stokServis.Data(ServisList.StokListeServis);
            _stokMalKabulListServis.Data(ServisList.StokMalKabulListListeServis);
            _siparisMalKabulHarServis.Data(ServisList.SatinAlmaMalKabulHarListeServis);
            _stokResimServis.Data(ServisList.StokResimListeServis);
            var belgeno = tileView1.GetFocusedRowCellValue("CBelgeNo").ToString();
            GCIsEmriPanel.DataSource = _depoEmirServis.obje.Where(x => x.siparisid == _siparisServis.obje.Where(z => z.belgeno.ToString() == belgeno).FirstOrDefault().id).Select(x => new TVDepoEmir
            {
                ID = x.id,
                BELGENO = _siparisServis.obje.Where(z => z.id == x.siparisid).FirstOrDefault().belgeno,
                MIKTAR = x.miktar,
                CARIADI = _siparisServis.obje.Where(z => z.id == x.siparisid).FirstOrDefault().cariadi,
                DEPO = _depoServis.obje.Where(u => u.id.ToString() == _siparisServis.obje.Where(z => z.id == x.siparisid).FirstOrDefault().depoid.ToString()).FirstOrDefault().depoadi,
                TIP = 1,
                Renk = "Green",
                DURUM =

          Math.Round(100 - ((_stokMalKabulListServis.obje.Where(z => z.emirid == x.id && z.kayittipi == 0).Sum(z => z.kalanmiktar) * 100) / (_stokMalKabulListServis.obje.Where(z => z.emirid == x.id && z.kayittipi == 0).Sum(c => c.miktar) == 0 ? 1 : _stokMalKabulListServis.obje.Where(z => z.emirid == x.id && z.kayittipi == 0).Sum(c => c.miktar))))
            }).ToList();

            GCIsEmriDetayPanel.DataSource = _siparisMalKabulHarServis.obje.Where(x => x.emirid.ToString() == tileView2.GetFocusedRowCellValue("ID").ToString() && x.kayittipi == 0).Select(x =>
          new
          {
              IEBELGENO = _siparisServis.obje.Where(z => z.id == x.siparisid).FirstOrDefault().belgeno,
              StokKodu = _stokServis.obje.Where(z => z.id == _siparisDetayServis.obje.Where(c => c.id == x.sipariskalemid && c.siparisid == x.siparisid).FirstOrDefault().stokid).FirstOrDefault().kod,
              StokAdi = _stokServis.obje.Where(z => z.id == _siparisDetayServis.obje.Where(c => c.id == x.sipariskalemid && c.siparisid == x.siparisid).FirstOrDefault().stokid).FirstOrDefault().adi,
              EmirNo = x.emirid,
              SiparisMiktari = x.siparismiktari,
              EmirMiktari = x.emirmiktari,
              KalanMiktar = _stokMalKabulListServis.obje.Where(z => z.emirid == x.emirid && z.siparisdetayid == x.sipariskalemid).FirstOrDefault().kalanmiktar
              ,
              Resim = _stokResimServis.obje.Where(z => z.STOKID == _siparisDetayServis.obje.Where(c => c.id == x.sipariskalemid && c.siparisid == x.siparisid).FirstOrDefault().stokid).Count() > 0 ? Base64ToImage(_stokResimServis.obje.Where(z => z.STOKID == _siparisDetayServis.obje.Where(c => c.id == x.sipariskalemid && c.siparisid == x.siparisid).FirstOrDefault().stokid).FirstOrDefault().IMG) : Properties.Resources.StokNullResim
          //x.siparismiktari-x.emirmiktari
          ,DepoButon = bt
          }).ToList();


        }
        public void emriKapatButtonClick(object o, DxHtmlElementMouseEventArgs args)
        {
            MessageBox.Show("TEST");

        }
        
       

        private void tileView2_DoubleClick(object sender, EventArgs e)
        {
            if (tileView2.GetFocusedRowCellValue("BELGENO")!=null)
            {
            var _belgeno = tileView2.GetFocusedRowCellValue("BELGENO").ToString();
            _siparisDetayServis.Data(ServisList.SiparisDetayListeServis);
            int i = 1;
            var tempsiparis = _siparisServis.obje.Where(x => x.belgeno == _belgeno).FirstOrDefault();

            fDepoIsEmriPanel = new FDepoIsEmriPanel(tempsiparis.id.ToString(), tileView2.GetFocusedRowCellValue("ID").ToString(),1);
            fDepoIsEmriPanel.ShowDialog();

            _depoEmirServis.Data(ServisList.DepoEmirListeServis);
            _stokServis.Data(ServisList.StokListeServis);
            _stokMalKabulListServis.Data(ServisList.StokMalKabulListListeServis);
            _siparisMalKabulHarServis.Data(ServisList.SatinAlmaMalKabulHarListeServis);

            GCIsEmriPanel.DataSource = _depoEmirServis.obje.Select(x => new { ID = x.id, _siparisServis.obje.Where(z => x.siparisid == z.id).FirstOrDefault().belgeno, x.miktar, CARIADI = _siparisServis.obje.Where(z => z.id == x.siparisid).FirstOrDefault().cariadi, DEPO = _depoServis.obje.Where(v => v.id == _siparisServis.obje.Where(z => z.id == x.siparisid).FirstOrDefault().depoid).FirstOrDefault().depoadi, x.tip, x.durum }).ToList();
            GCIsEmriPanel.Refresh();
            }

        }
        Bitmap bt;
        private void tileView2_Click(object sender, EventArgs e)
        {
            // if (Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells["DURUM"].Value)==1)
            _stokMalKabulListServis.Data(ServisList.StokMalKabulListListeServis);
            _stokServis.Data(ServisList.StokListeServis);
            _siparisMalKabulHarServis.Data(ServisList.SatinAlmaMalKabulHarListeServis);
            _siparisServis.Data(ServisList.SiparisListeServis);
            _siparisDetayServis.Data(ServisList.SiparisDetayListeServis);
            _olcuBrServis.Data(ServisList.OlcuBrListeServis);



            if (_stokMalKabulListServis.obje.Count > 0)
            {
                //var tempp = _stokMalKabulListServis.obje.Where(x => x.EMIRID.ToString() == dataGridView2.Rows[e.RowIndex].Cells["id"].Value.ToString()).GroupBy(x => new { x.MPSTOK.kod, x.MPSTOK.adi, BIRIM = x.MPOLCUBR.adi, x.SIPARISMIKTARI }).Select(x => new { KOD = x.Select(x => x.MPSTOK.kod).FirstOrDefault(), ADI = x.Select(x => x.MPSTOK.adi).FirstOrDefault(), MIKTAR = x.Sum(z => z.MIKTAR), SIPARISMIKTARI = x.Select(x => x.SIPARISMIKTARI).FirstOrDefault(), KALANMIKTAR = x.Select(x => x.SIPARISMIKTARI).FirstOrDefault() - x.Sum(z => z.MIKTAR), BIRIM = x.Select(x => x.MPOLCUBR.adi).FirstOrDefault() }).ToList();
                //dataGridView4.DataSource = tempp;
            }
            
            //_stokServis.obje.Where(x=> tileView1.GetFocusedRowCellValue()
           bt = new Bitmap(Properties.Resources.icon_02);
            _stokResimServis.Data(ServisList.StokResimListeServis);
            GCIsEmriDetayPanel.DataSource = _siparisMalKabulHarServis.obje.Where(x => x.emirid.ToString() == tileView2.GetFocusedRowCellValue("ID").ToString() && x.kayittipi==0 ).Select(x =>
             new
             {
                 IEBELGENO = _siparisServis.obje.Where(z => z.id == x.siparisid).FirstOrDefault().belgeno,
                 StokKodu = _stokServis.obje.Where(z => z.id == _siparisDetayServis.obje.Where(c => c.id == x.sipariskalemid && c.siparisid == x.siparisid).FirstOrDefault().stokid).FirstOrDefault().kod,
                 StokAdi =  _stokServis.obje.Where(z => z.id == _siparisDetayServis.obje.Where(c => c.id == x.sipariskalemid && c.siparisid == x.siparisid).FirstOrDefault().stokid).FirstOrDefault().adi,
                 EmirNo = x.emirid,
                 SiparisMiktari = x.siparismiktari,
                 EmirMiktari = x.emirmiktari,
                 KalanMiktar = _stokMalKabulListServis.obje.Where(z => z.emirid == x.emirid && z.siparisdetayid == x.sipariskalemid).FirstOrDefault().kalanmiktar
                 ,Resim= _stokResimServis.obje.Where(z => z.STOKID == _siparisDetayServis.obje.Where(c => c.id == x.sipariskalemid && c.siparisid == x.siparisid).FirstOrDefault().stokid).Count()>0? Base64ToImage(_stokResimServis.obje.Where(z=>z.STOKID== _siparisDetayServis.obje.Where(c => c.id == x.sipariskalemid && c.siparisid == x.siparisid).FirstOrDefault().stokid  ).FirstOrDefault().IMG): Properties.Resources.StokNullResim
                 //x.siparismiktari-x.emirmiktari
             ,
                 DepoButon = bt
             }).ToList();
            GCIsEmriDetayPanel.Refresh();
            _depoCekiListServis.Data(ServisList.DepoCekiListListeServis);
            _depoServis.Data(ServisList.DepoListeServis);
            var tempp2 = _depoCekiListServis.obje.Where(x => x.kayittipi == 0 && x.isemriid.ToString() == tileView2.GetFocusedRowCellValue("ID").ToString()).Select(x => new { KOD = _stokServis.obje.Where(z => z.id == x.stokid && z.kayittipi == 0).FirstOrDefault().kod, ADI = _stokServis.obje.Where(z => z.id == x.stokid && z.kayittipi == 0).FirstOrDefault().adi, CKMIKTAR = x.miktar,CBIRIM=_olcuBrServis.obje.Where(z=>z.id==x.birimid).FirstOrDefault().adi,CDEPO=_depoServis.obje.Where(z=>z.id==x.depoid).FirstOrDefault().depoadi });
            GCCekiPanel.DataSource = tempp2;

        }
        public object base64resim;
        public System.Drawing.Image Base64ToImage(string base64String)
        {
            try
            {
                byte[] imageBytes = Convert.FromBase64String(base64String);
                MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
                ms.Write(imageBytes, 0, imageBytes.Length);
                System.Drawing.Image image = System.Drawing.Image.FromStream(ms, true);
                return image;
            }
            catch (Exception)
            {

                return null;
            }

        }
        string b64string = "";
        private void tileView1_Click(object sender, EventArgs e)
        {
            _depoServis.Data(ServisList.DepoListeServis);
            _stokMalKabulListServis.Data(ServisList.StokMalKabulListListeServis);
            var belgeno = tileView1.GetFocusedRowCellValue("CBelgeNo").ToString();
            GCIsEmriPanel.DataSource = _depoEmirServis.obje.Where(x=>x.siparisid==_siparisServis.obje.Where(z=>z.belgeno.ToString()== belgeno).FirstOrDefault().id).Select(x => new TVDepoEmir { ID = x.id, BELGENO = _siparisServis.obje.Where(z => z.id == x.siparisid).FirstOrDefault().belgeno,MIKTAR=x.miktar, CARIADI = _siparisServis.obje.Where(z => z.id == x.siparisid).FirstOrDefault().cariadi, DEPO = _depoServis.obje.Where(u=>u.id.ToString() == _siparisServis.obje.Where(z => z.id == x.siparisid).FirstOrDefault().depoid.ToString()).FirstOrDefault().depoadi, TIP= x.tip,Renk="Green", DURUM= 
                
           Math.Round( 100- ((_stokMalKabulListServis.obje.Where(z => z.emirid == x.id && z.kayittipi==0).Sum(z=>z.kalanmiktar)*100)/ (_stokMalKabulListServis.obje.Where(z => z.emirid == x.id && z.kayittipi == 0).Sum(c => c.miktar)==0? 1: _stokMalKabulListServis.obje.Where(z => z.emirid == x.id && z.kayittipi==0).Sum(c=>c.miktar))))
                }).ToList();

            GCIsEmriDetayPanel.DataSource = "";
            GCCekiPanel.DataSource = "";
            

        }

        private void tileView2_ItemCustomize(object sender, TileViewItemCustomizeEventArgs e)
        {
            var tileView = sender as TileView;
            var task = tileView.GetRow(e.RowHandle) as TVDepoEmir;
            var stripe = e.HtmlElement?.FindElementById("stripe");
            if (stripe != null && task != null)
                stripe.Style.SetBackgroundColor(GetPriorityColor(task.DURUM));
        }
        static string GetPriorityColor(decimal priority)
        {
            if (priority == 0)
                return "@Danger";
            else if (priority > 0 && priority < 99)
                return "@Warning";
            else if (priority == 100)
                return "@Success";
            else
                return "";
        }

        private void tileView3_DoubleClick(object sender, EventArgs e)
        {
            if(MPKullanici.YetkiGetir(AllForms.MALKABUL.ToString()).EKLE == true)
            { 
            if (tileView2.GetFocusedRowCellValue("ID")!=null)
            {
            _siparisDetayServis.Data(ServisList.SiparisDetayListeServis);
            _depoEmirServis.Data(ServisList.DepoEmirListeServis);
            var tempp = _depoEmirServis.obje.Where(x => x.id.ToString() == tileView2.GetFocusedRowCellValue("ID").ToString());
            _tempSTOKSEVK = tempp.Select(x => _siparisDetayServis.obje.Where(z => z.siparisid == x.siparisid).ToList()).FirstOrDefault();
            _malKabulCekiPanel = new FMalKabulCekiPanel();
            _stokMalKabulListServis.Data(ServisList.StokMalKabulListListeServis);
            _olcuBrServis.Data(ServisList.OlcuBrListeServis);
            _malKabulCekiPanel._tempEmir = tempp.FirstOrDefault(); 
                _depoCekiListServis.Data(ServisList.DepoCekiListListeServis);
                if (_depoCekiListServis.obje.Where(x => x.isemriid.ToString() == tileView2.GetFocusedRowCellValue("ID").ToString() && x.kayittipi == 0).Count() == 0)
            {
                foreach (var item in _stokMalKabulListServis.obje.Where(z => z.emirid.ToString() == tileView2.GetFocusedRowCellValue("ID").ToString()))
                {
                    _depoCekiListServis.Data(ServisList.DepoCekiListEkleServis, new PocoDEPOCEKILIST()
                    {
                        birimid = item.birimid,
                        isemriid = item.emirid,
                        miktar = 0,
                        stokid = item.stokid,
                        depoid = item.depoid,
                        userid = MPKullanici.ID,
                    });
                }
            }
            _depoCekiListServis.Data(ServisList.DepoCekiListListeServis);
            _malKabulCekiPanel._tempList = _depoCekiListServis.obje.Where(x => x.isemriid.ToString() == tileView2.GetFocusedRowCellValue("ID").ToString() && x.kayittipi == 0).ToList();
            
            _malKabulCekiPanel.ShowDialog();
                _siparisDetayServis.Data(ServisList.SiparisDetayListeServis);
                _depoEmirServis.Data(ServisList.DepoEmirListeServis); 
                _depoCekiListServis.Data(ServisList.DepoCekiListListeServis);
                var belgeno = tileView1.GetFocusedRowCellValue("CBelgeNo").ToString();
           
                var tempp2 = _depoCekiListServis.obje.Where(x => x.kayittipi == 0 && x.isemriid.ToString() == tileView2.GetFocusedRowCellValue("ID").ToString()).Select(x => new { KOD = _stokServis.obje.Where(z => z.id == x.stokid && z.kayittipi == 0).FirstOrDefault().kod, ADI = _stokServis.obje.Where(z => z.id == x.stokid && z.kayittipi == 0).FirstOrDefault().adi, CKMIKTAR = x.miktar, CBIRIM = _olcuBrServis.obje.Where(z => z.id == x.birimid).FirstOrDefault().adi, CDEPO = _depoServis.obje.Where(z => z.id == x.depoid).FirstOrDefault().depoadi });
                GCCekiPanel.DataSource = tempp2;
                GCIsEmriDetayPanel.DataSource = _siparisMalKabulHarServis.obje.Where(x => x.emirid.ToString() == tileView2.GetFocusedRowCellValue("ID").ToString() && x.kayittipi == 0).Select(x =>
              new
              {
                  IEBELGENO = _siparisServis.obje.Where(z => z.id == x.siparisid).FirstOrDefault().belgeno,
                  StokKodu = _stokServis.obje.Where(z => z.id == _siparisDetayServis.obje.Where(c => c.id == x.sipariskalemid && c.siparisid == x.siparisid).FirstOrDefault().stokid).FirstOrDefault().kod,
                  StokAdi = _stokServis.obje.Where(z => z.id == _siparisDetayServis.obje.Where(c => c.id == x.sipariskalemid && c.siparisid == x.siparisid).FirstOrDefault().stokid).FirstOrDefault().adi,
                  EmirNo = x.emirid,
                  SiparisMiktari = x.siparismiktari,
                  EmirMiktari = x.emirmiktari,
                  KalanMiktar = _stokMalKabulListServis.obje.Where(z => z.emirid == x.emirid && z.siparisdetayid == x.sipariskalemid).FirstOrDefault().kalanmiktar

                  //
                  ,DepoButon= bt
              }).ToList();
            GCIsEmriDetayPanel.Refresh();
                }
                else
                    MessageBox.Show(MPKullanici.hata);
            }
        }
    }
}