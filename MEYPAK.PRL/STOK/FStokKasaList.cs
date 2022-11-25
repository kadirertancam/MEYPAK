using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using MEYPAK.BLL.Assets;
using MEYPAK.BLL.STOK;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.DAL.Concrete.EntityFramework.Repository;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels;
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
        FFatura ffatura;
        GenericWebServis<PocoSTOKKASA> _kasaServis;
        GenericWebServis<PocoSTOKKASAMARKA> _stokKasaMarka;
        string _islem;
        string _form, num;
        List<ListKasaList> _temp;
        public FStokKasaList(string form, string islem = "", string num = "", List<ListKasaList> temp = null)
        {
            InitializeComponent();
            this._islem = islem;
            this._form = form;
            this.num = num;
            _temp = temp;
            _stokKasaMarka = new GenericWebServis<PocoSTOKKASAMARKA>();
            _kasaServis = new GenericWebServis<PocoSTOKKASA>();
        }

        private void FKasaList_Load(object sender, EventArgs e)
        {
            _stokKasaMarka.Data(ServisList.StokKasaMarkaListeServis);
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
                    if (frm.Name.Contains("FFatura"))
                        ffatura = (FFatura)frm;
                }
            }

            _kasaServis.Data(ServisList.StokKasaListeServis);
            var ss_temp = _kasaServis.obje.Where(x => x.kayittipi == 0).Select(x => new KasaList { KASAID = x.id, MARKA = _stokKasaMarka.obje.Where(z => z.id == x.markaid).FirstOrDefault().adi, KASAADI = x.kasaadi, MIKTAR = 0 });
            GCKasaList.DataSource = ss_temp;
                int satir = 0;
            if(_temp!=null)
            if (_temp.Count>0)
            {
                foreach (var item in ss_temp)
                {

                    foreach (var item2 in _temp.Where(x => x.num.ToString() == this.num).FirstOrDefault().KasaList)
                    {
                        if (item2.KASAID.ToString() == gridView1.GetRowCellValue(satir, "KASAID").ToString())
                        {
                            gridView1.SelectRow(satir);
                                gridView1.SetRowCellValue(satir, "MIKTAR", item2.MIKTAR);
                        }

                    }
                    satir++;
                }
            }
            gridView1.Columns["KASAID"].Visible = false;
            GridColumn MARKA = gridView1.Columns["MARKA"];
            gridView1.SortInfo.ClearAndAddRange(new[] {
                new GridColumnSortInfo(MARKA , DevExpress.Data.ColumnSortOrder.Ascending)
            }, 1);
            gridView1.ExpandAllGroups();
            this.ActiveControl = textEdit1;

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
        List<KasaList> ttt = new List<KasaList>();

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            gridView1.ApplyFindFilter(textEdit1.EditValue.ToString());
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

                        temp += gridView1.GetRowCellValue(item, "KASAADI").ToString() + "=>" + gridView1.GetRowCellValue(item, "MIKTAR").ToString() + ";";
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

                if (fSatisIrsaliye != null)
                {
                    fSatisIrsaliye._tempKasaList.Clear();
                    foreach (var item in gridView1.GetSelectedRows())
                    {
                        if (fSatisIrsaliye._tempKasaList.Where(x => x.KASAID == int.Parse(gridView1.GetRowCellValue(item, "ID").ToString())).Count() == 0)
                            fSatisIrsaliye._tempKasaList.Add(new KasaList()
                            {
                                KASAADI = gridView1.GetRowCellValue(item, "KASAADI").ToString(),
                                MIKTAR = int.Parse(gridView1.GetRowCellValue(item, "MIKTAR").ToString()),
                                KASAID = int.Parse(gridView1.GetRowCellValue(item, "ID").ToString()),
                            });
                        else
                        {
                            fSatisIrsaliye._tempKasaList.Where(x => x.KASAID == int.Parse(gridView1.GetRowCellValue(item, "ID").ToString())).FirstOrDefault().MIKTAR = int.Parse(gridView1.GetRowCellValue(item, "MIKTAR").ToString());
                        }
                        //temp += gridView1.GetRowCellValue(item, "KASAADI").ToString() + "=>" + gridView1.GetRowCellValue(item, "MIKTAR").ToString() + ";";
                    }

                }
            }
            else if (_islem == "FFatura")
            {

                if (ffatura != null)
                {
                    ttt.Clear();
                    ffatura._tempKasaList.Clear();
                    foreach (var item in gridView1.GetSelectedRows())
                    {
                        if (item != -1)
                        {
                            ttt.Add(new KasaList()
                            {
                                MARKA = gridView1.GetRowCellValue(item, "MARKA").ToString(),
                                KASAADI = gridView1.GetRowCellValue(item, "KASAADI").ToString(),
                                MIKTAR = int.Parse(gridView1.GetRowCellValue(item, "MIKTAR").ToString()),
                                KASAID = int.Parse(gridView1.GetRowCellValue(item, "KASAID").ToString()),
                            });
                        }
                        //temp += gridView1.GetRowCellValue(item, "KASAADI").ToString() + "=>" + gridView1.GetRowCellValue(item, "MIKTAR").ToString() + ";";
                    }
                    if (ffatura._kasaaa.Where(x => x.num.ToString() == this.num).Count() == 0)
                        ffatura._kasaaa.Add(new ListKasaList()
                        {
                            num = int.Parse(num),
                            KasaList = ttt
                        });
                    else
                    {
                        ffatura._kasaaa.Where(x => x.num.ToString() == this.num).FirstOrDefault().KasaList = ttt;
                    }

                }
            }

        }
    }
}
