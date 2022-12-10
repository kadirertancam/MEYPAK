using DevExpress.XtraTab.ViewInfo;
using DevExpress.XtraTab;
using MEYPAK.BLL.Assets;
using MEYPAK.BLL.STOK;
using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.DAL.Concrete.EntityFramework.Repository;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Stok;
using MEYPAK.PRL.Assets;
using MEYPAK.PRL.Assets.Scripts;
using MEYPAK.PRL.DEPO;
using MEYPAK.PRL.SIPARIS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MEYPAK.Entity.PocoModels.CARI;
using MEYPAK.PRL.CARI;
using MEYPAK.PRL.IRSALIYE;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.Design;
using MEYPAK.PRL.STOK.Raporlar;

namespace MEYPAK.PRL.STOK
{
    public partial class FStokList : XtraForm
    {
        FStokKart fSTOKKART;
        FStokHareket fStokHareket;
        FStokSayimPanel fStokSayimPanel;
        FStokFiyatRaporu fStokFiyatRaporu;
        FMusteriSiparis fSiparis;
        FSatinAlmaSiparis _fSatınAlmaSiparis;
        FDepolarArasıTransferHar fDepolarArasıHar;
        FSatisIrsaliye fSatisIrsaliye;
        FAlisIrsaliye fAlisIrsaliye;
        FAlisFatura fAlisFatura;
        FFatura ffatura;
        FStokHareketRaporu fStokHareketRaporu;
        FStokListesiRaporu fStokListesiRaporu;
        Main main;
        int id;
        string _islem;
        string _form;
        public FStokList(string form = "", string islem = "")
        {
            InitializeComponent();
            this._islem = islem;
            this._form = form;

            _OlcuBrServis = new GenericWebServis<PocoOLCUBR>();
            _kategoriServis = new GenericWebServis<PocoSTOKKATEGORI>();

              _stokServis = new GenericWebServis<PocoSTOK>();
            _stokMarka = new GenericWebServis<PocoSTOKMARKA>();

        }
        GenericWebServis<PocoSTOK> _stokServis;
        GenericWebServis<PocoSTOKKATEGORI>_kategoriServis;
      
        GenericWebServis<PocoOLCUBR> _OlcuBrServis;
        GenericWebServis<PocoSTOKMARKA> _stokMarka;
        Form tempForm;
        int i = 0;
        private void FStokList_Load(object sender, EventArgs e)
        {
            
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name.Contains("Main"))
                    main = (Main)frm;
                if (_form == frm.Tag)
                {
                    
                    
                    if (frm.Name.Contains("FStokKart"))
                        fSTOKKART = (FStokKart)frm;
                    if (frm.Name.Contains("FDepolarArasıTransferHar"))
                        fDepolarArasıHar = (FDepolarArasıTransferHar)frm;
                    if (frm.Name.Contains("FMusteriSiparis"))
                        fSiparis = (FMusteriSiparis)frm;
                    if (frm.Name.Contains("FSatinAlmaSiparis"))
                        _fSatınAlmaSiparis = (FSatinAlmaSiparis)frm;
                    if (frm.Name.Contains("SatisIrsaliye"))
                        fSatisIrsaliye = (FSatisIrsaliye)frm;
                    if (frm.Name.Contains("AlisIrsaliye"))
                        fAlisIrsaliye = (FAlisIrsaliye)frm;
                    if (frm.Name.Contains("FFatura"))
                        ffatura = (FFatura)frm;
                    if (frm.Name.Contains("FAlisFatura"))
                        fAlisFatura = (FAlisFatura)frm;
                    if (frm.Name.Contains("FStokFiyatRaporu"))
                        fStokFiyatRaporu = (FStokFiyatRaporu)frm;
                    if (frm.Name.Contains("FStokHareketRaporu"))
                        fStokHareketRaporu = (FStokHareketRaporu)frm;
                    else if (frm.Name.Contains("FStokHareket"))
                        fStokHareket = (FStokHareket)frm;
                    if (frm.Name.Contains("FStokListesiRaporu"))
                        fStokListesiRaporu = (FStokListesiRaporu)frm;



                }
            }
            _stokMarka.Data(ServisList.StokMarkaListeServis);
            _stokServis.Data(ServisList.StokListeServis);
            _OlcuBrServis.Data(ServisList.OlcuBrListeServis);
            _kategoriServis.Data(ServisList.StokKategoriListeServis);
           
            DGStokList.DataSource = _stokServis.obje.Where(x => x.kayittipi == 0).Select(x => new
            {
                ID = x.id,
                KOD = x.kod,
                ADI = x.adi,
                GRUPKODU = x.grupkodu,
                KATEGORI = _kategoriServis.obje.Where(y=>y.id == x.kategoriid).FirstOrDefault().acıklama,
                OLCUBR = _OlcuBrServis.obje.Where(y=>y.id==x.olcubR1).FirstOrDefault().adi,
                MARKA = _stokMarka.obje.Where(z => z.id == x.markaid).Select(z => z.adi).FirstOrDefault()
            }).ToList();

            DGStokList.RefreshDataSource();
        }

        void Kaydet() {
            if (this.Tag == null)
            {

                if (_islem == "stokkart")
                {
                    if (fSTOKKART != null)
                        fSTOKKART._tempStok = _stokServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
                }
                else if (_islem == "stokhar")
                {
                    if (fStokHareket != null)
                        fStokHareket._tempStok = _stokServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
                }

                else if (_islem == "FMusteriSiparis")
                {
                    if (fSiparis != null)
                        fSiparis._tempStok = _stokServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
                }
                else if (_islem == "FDepolarArasıTransferHar")
                {
                    if (fDepolarArasıHar != null)
                        fDepolarArasıHar._tempStok = _stokServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
                }
                else if (_islem == "FSatinAlmaSiparis")
                {
                    if (_fSatınAlmaSiparis != null)
                        _fSatınAlmaSiparis._tempStok = _stokServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();

                }
                else if (_islem == "SatisIrsaliye")
                {
                    if (fSatisIrsaliye != null)
                        fSatisIrsaliye._tempStok = _stokServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();

                }
                else if (_islem == "AlisIrsaliye")
                {
                    if (fAlisIrsaliye != null)
                        fAlisIrsaliye._tempStok = _stokServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();

                }
                else if (_islem == "FFatura")
                {
                    if (ffatura != null)
                        ffatura._tempStok = _stokServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
                }
                else if (_islem == "FAlisFatura")
                {
                    if (fAlisFatura != null)
                        fAlisFatura._tempStok = _stokServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
                }
                else if (_islem == "FStokFiyatRaporu")
                {
                    if (fStokFiyatRaporu != null)
                        fStokFiyatRaporu._tempStok = _stokServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
                }
                else if (_islem == "FStokHareketRaporu")
                {
                    if (fStokHareketRaporu != null)
                        fStokHareketRaporu._tempStok = _stokServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
                }
                else if (_islem == "FStokListesiRaporu")
                {
                    if (fStokListesiRaporu != null)
                        fStokListesiRaporu._tempStok = _stokServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
                }

                this.Close();
            }
            else
            {
                XtraTabPage page = new XtraTabPage();
                fSTOKKART = new FStokKart();
                page.Name = "TPStokKart" + i;
                page.Text = "Stok Kart";
                page.Tag = "TPStokKart2" + i;
                page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;

                main.xtraTabControl1.TabPages.Add(page);
                main.xtraTabControl1.SelectedTabPage = page;

                fSTOKKART.TopLevel = false;
                fSTOKKART.AutoScroll = true;
                fSTOKKART.Tag = "TPStokKart2" + i;
                fSTOKKART.Dock = DockStyle.Fill;
                page.Controls.Add(fSTOKKART);
                fSTOKKART._tempStok = _stokServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
                fSTOKKART.Show();
                i++;
            }
        }
        private void DGStok_CellDoubleClick(object sender, EventArgs e)
        {
            Kaydet();
        }

        private void gridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)Keys.Enter)
            {
                Kaydet();
            }
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }




        //private void DGStok_CellDoubleClick(object sender, EventArgs e)
        //{
        //    _stokServis.Data(ServisList.StokSayimListeServis);
        //    if (_islem == "stoksayimpanel")
        //    {
        //        if (fStokSayimPanel != null)
        //            fStokSayimPanel._tempStok = _stokServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
        //    }
        //    this.Close();
        //}
    }
}
