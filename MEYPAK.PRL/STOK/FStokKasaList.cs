using DevExpress.XtraEditors;
using MEYPAK.BLL.Assets;
using MEYPAK.BLL.STOK;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.DAL.Concrete.EntityFramework.Repository;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Stok;
using MEYPAK.PRL.Assets;
using MEYPAK.PRL.DEPO;
using MEYPAK.PRL.IRSALIYE;
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

namespace MEYPAK.PRL.STOK
{
    public partial class FStokKasaList : XtraForm
    {
        FMusteriSiparis fSiparis;
        FSatinAlmaSiparis fSatınAlmaSiparis;
        FSatisIrsaliye fSatisIrsaliye;
        GenericWebServis<PocoSTOKKASA> _kasaServis;
        string _islem;
        string _form;
        public FStokKasaList(string form,string islem = "")
        {
            InitializeComponent();
            this._islem = islem;
            this._form = form;
            _kasaServis = new GenericWebServis<PocoSTOKKASA>();
        }
        
        private void FKasaList_Load(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (_form == frm.Tag)
                {
                    if (frm.Name.Contains("FSatisIrsaliye"))
                        fSatisIrsaliye = (FSatisIrsaliye)frm;
                    if (frm.Name.Contains("FMusteriSiparis"))
                        fSiparis = (FMusteriSiparis)frm;
                    if (frm.Name.Contains("FSatinAlmaSiparis"))
                        fSatınAlmaSiparis = (FSatinAlmaSiparis)frm;
                }
            }

            _kasaServis.Data(ServisList.StokKasaListeServis);
            GCKasaList.DataSource = _kasaServis.obje.Where(x=>x.kayittipi==0).Select(x=> new KasaList { ID=x.id,KASAADI=x.kasaadi,MIKTAR= 0});
 

        }
        

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            //string temp = "";
            //_kasaServis.Data(ServisList.StokKasaListeServis);
            //if (_islem == "Stok")
            //{
            //    if (fStokKart != null)
            //        fStokKart._tempKasa = _kasaServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("id").ToString()).FirstOrDefault();
            //}
            //else if (_islem == "musterisiparis")
            //{
            //    if (fSiparis != null)
            //    {
            //        foreach (var item in _kasaServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("id").ToString()))
            //        {
            //            temp += item.kasaadi + "=>";
            //        }
            //        fSiparis.gridView1.SetFocusedRowCellValue("KasaAdı", temp);
            //    }
            //}
            //else if (_islem == "SatinAlmaSiparis")
            //{
            //    if (fSatınAlmaSiparis != null)
            //        fSatınAlmaSiparis._tempKasa = _kasaServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("id").ToString()).FirstOrDefault();
            //}

            //this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string temp = "";
            _kasaServis.Data(ServisList.StokKasaListeServis);
            if (_islem == "musterisiparis")
            {
                if (fSiparis != null)
                {
                    foreach (var item in gridView1.GetSelectedRows())
                    {
                        
                        temp += gridView1.GetRowCellValue(item, "KASAADI").ToString() + "=>" + gridView1.GetRowCellValue(item, "MIKTAR").ToString() + ";" ;
                    }
                    fSiparis.gridView1.SetFocusedRowCellValue("KasaAdı", temp);
                }
            }
            else if (_islem == "SatinAlmaSiparis")
            {
                if (fSatınAlmaSiparis != null)
                {
                    foreach (var item in gridView1.GetSelectedRows())
                    {

                        temp += gridView1.GetRowCellValue(item, "KASAADI").ToString() + "=>" + gridView1.GetRowCellValue(item, "MIKTAR").ToString() + ";";
                    }
                    fSatınAlmaSiparis.gridView1.SetFocusedRowCellValue("KasaAdı", temp);
                }
            }
            else if (_islem == "SatisIrsaliye")
            {
                if (fSatınAlmaSiparis != null)
                {
                    foreach (var item in gridView1.GetSelectedRows())
                    {

                        temp += gridView1.GetRowCellValue(item, "KASAADI").ToString() + "=>" + gridView1.GetRowCellValue(item, "MIKTAR").ToString() + ";";
                    }
                    fSatisIrsaliye.gridView1.SetFocusedRowCellValue("KasaAdı", temp);
                }
            }
    
        }
    }
}
