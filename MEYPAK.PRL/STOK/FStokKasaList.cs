using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraRichEdit.Design;
using DevExpress.XtraSpreadsheet.Model;
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
using MEYPAK.PRL.STOK.Raporlar;
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
        FAlisIrsaliye fAlisIrsaliye;
        FFatura ffatura;
        FAlisFatura fAlisFatura;
        FStokKasaHareketRaporu fStokKasaHareketRaporu;
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
                    if (frm.Name.Contains("FAlisIrsaliye"))
                        fAlisIrsaliye = (FAlisIrsaliye)frm;
                    if (frm.Name.Contains("FMusteriSiparis"))
                        fSiparis = (FMusteriSiparis)frm;
                    if (frm.Name.Contains("FSatinAlmaSiparis"))
                        fSatınAlmaSiparis = (FSatinAlmaSiparis)frm;
                    if (frm.Name.Contains("FFatura"))
                        ffatura = (FFatura)frm;
                    if (frm.Name.Contains("FAlisFatura"))
                        fAlisFatura = (FAlisFatura)frm;
                    if (frm.Name.Contains("FStokKasaHareketRaporu"))
                        fStokKasaHareketRaporu = (FStokKasaHareketRaporu)frm;
                }
            }

            _kasaServis.Data(ServisList.StokKasaListeServis);
            var ss_temp = _kasaServis.obje.Where(x => x.kayittipi == 0).Select(x => new KasaList { KASAID = x.id, MARKA = _stokKasaMarka.obje.Where(z => z.id == x.markaid).FirstOrDefault().adi, KASAADI = x.kasaadi, MIKTAR = 0 });
            GCKasaList.DataSource = ss_temp;
            gridView1.Columns["ID"].OptionsColumn.ReadOnly= true;
            gridView1.Columns["MARKA"].OptionsColumn.ReadOnly= true;
            gridView1.Columns["KASAADI"].OptionsColumn.ReadOnly= true;
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

        void Kaydet()
        {
            string temp = "";
            _kasaServis.Data(ServisList.StokKasaListeServis);
            if (_islem == "FMusteriSiparis")
            {
                if (fSiparis != null)
                {
                    ttt.Clear();
                    fSiparis._tempKasaList.Clear();
                    foreach (var item in gridView1.GetSelectedRows())
                    {
                        if (item != -1)
                        {
                            ttt.Add(new KasaList()
                            {
                                MARKA = gridView1.GetRowCellValue(item, "MARKA").ToString(),
                                KASAADI = gridView1.GetRowCellValue(item, "KASAADI").ToString(),
                                MIKTAR = decimal.Parse(gridView1.GetRowCellValue(item, "MIKTAR").ToString()),
                                KASAID = int.Parse(gridView1.GetRowCellValue(item, "KASAID").ToString()),
                            });
                        }
                        //temp += gridView1.GetRowCellValue(item, "KASAADI").ToString() + "=>" + gridView1.GetRowCellValue(item, "MIKTAR").ToString() + ";";
                    }
                    if (fSiparis._kasaaa.Where(x => x.num.ToString() == this.num).Count() == 0)
                        fSiparis._kasaaa.Add(new ListKasaList()
                        {
                            num = int.Parse(num),
                            KasaList = ttt
                        });
                    else
                    {
                        fSiparis._kasaaa.Where(x => x.num.ToString() == this.num).FirstOrDefault().KasaList = ttt;
                    }
                }
            }
            else if (_islem == "FSatinAlmaSiparis")
            {
                if (fSatınAlmaSiparis != null)
                {
                    ttt.Clear();
                    fSatınAlmaSiparis._tempKasaList.Clear();
                    foreach (var item in gridView1.GetSelectedRows())
                    {
                        if (item != -1)
                        {
                            ttt.Add(new KasaList()
                            {
                                MARKA = gridView1.GetRowCellValue(item, "MARKA").ToString(),
                                KASAADI = gridView1.GetRowCellValue(item, "KASAADI").ToString(),
                                MIKTAR = decimal.Parse(gridView1.GetRowCellValue(item, "MIKTAR").ToString()),
                                KASAID = int.Parse(gridView1.GetRowCellValue(item, "KASAID").ToString()),
                            });
                        }
                        //temp += gridView1.GetRowCellValue(item, "KASAADI").ToString() + "=>" + gridView1.GetRowCellValue(item, "MIKTAR").ToString() + ";";
                    }
                    if (fSatınAlmaSiparis._kasaaa.Where(x => x.num.ToString() == this.num).Count() == 0)
                        fSatınAlmaSiparis._kasaaa.Add(new ListKasaList()
                        {
                            num = int.Parse(num),
                            KasaList = ttt
                        });
                    else
                    {
                        fSatınAlmaSiparis._kasaaa.Where(x => x.num.ToString() == this.num).FirstOrDefault().KasaList = ttt;
                    }
                }
            }
            else if (_islem == "FSatisIrsaliye")
            {

                if (fSatisIrsaliye != null)
                {
                    ttt.Clear();
                    fSatisIrsaliye._tempKasaList.Clear();
                    foreach (var item in gridView1.GetSelectedRows())
                    {
                        if (item != -1)
                        {
                            ttt.Add(new KasaList()
                            {

                                MARKA = gridView1.GetRowCellValue(item, "MARKA").ToString(),
                                KASAADI = gridView1.GetRowCellValue(item, "KASAADI").ToString(),
                                MIKTAR = decimal.Parse(gridView1.GetRowCellValue(item, "MIKTAR").ToString()),
                                KASAID = int.Parse(gridView1.GetRowCellValue(item, "KASAID").ToString()),
                            });
                        }
                        //temp += gridView1.GetRowCellValue(item, "KASAADI").ToString() + "=>" + gridView1.GetRowCellValue(item, "MIKTAR").ToString() + ";";
                    }
                    if (fSatisIrsaliye._kasaaa.Where(x => x.num.ToString() == this.num).Count() == 0)
                        fSatisIrsaliye._kasaaa.Add(new ListKasaList()
                        {
                            num = int.Parse(num),
                            KasaList = ttt
                        });
                    else
                    {
                        //_kasaa.kasalist ile ttt den kasaid si eşleşen var ise onun idsini alacak. yoksa 0 olarak gönderecek.
                        foreach (var item in ttt)
                        {
                            if (fSatisIrsaliye._kasaaa.Where(x => x.num.ToString() == this.num).FirstOrDefault().KasaList.Where(x => x.KASAID == item.KASAID).Count() > 0)
                            {
                                item.ID = fSatisIrsaliye._kasaaa.Where(x => x.num.ToString() == this.num).FirstOrDefault().KasaList.Where(x => x.KASAID == item.KASAID).FirstOrDefault().ID;
                            }
                        }
                        fSatisIrsaliye._kasaaa.Where(x => x.num.ToString() == this.num).FirstOrDefault().KasaList = ttt;
                    }

                }
            }
            else if (_islem == "FAlisIrsaliye")
            {

                if (fAlisIrsaliye != null)
                {
                    ttt.Clear();
                    fAlisIrsaliye._tempKasaList.Clear();
                    foreach (var item in gridView1.GetSelectedRows())
                    {
                        if (item >0 )
                        {
                            ttt.Add(new KasaList()
                            {

                                MARKA = gridView1.GetRowCellValue(item, "MARKA").ToString(),
                                KASAADI = gridView1.GetRowCellValue(item, "KASAADI").ToString(),
                                MIKTAR = decimal.Parse(gridView1.GetRowCellValue(item, "MIKTAR").ToString()),
                                KASAID = int.Parse(gridView1.GetRowCellValue(item, "KASAID").ToString()),
                            });
                        }
                        //temp += gridView1.GetRowCellValue(item, "KASAADI").ToString() + "=>" + gridView1.GetRowCellValue(item, "MIKTAR").ToString() + ";";
                    }
                    if (fAlisIrsaliye._kasaaa.Where(x => x.num.ToString() == this.num).Count() == 0)
                        fAlisIrsaliye._kasaaa.Add(new ListKasaList()
                        {
                            num = int.Parse(num),
                            KasaList = ttt
                        });
                    else
                    {
                        //_kasaa.kasalist ile ttt den kasaid si eşleşen var ise onun idsini alacak. yoksa 0 olarak gönderecek.
                        foreach (var item in ttt)
                        {
                            if (fAlisIrsaliye._kasaaa.Where(x => x.num.ToString() == this.num).FirstOrDefault().KasaList.Where(x => x.KASAID == item.KASAID).Count() > 0)
                            {
                                item.ID = fAlisIrsaliye._kasaaa.Where(x => x.num.ToString() == this.num).FirstOrDefault().KasaList.Where(x => x.KASAID == item.KASAID).FirstOrDefault().ID;
                            }
                        }
                        fAlisIrsaliye._kasaaa.Where(x => x.num.ToString() == this.num).FirstOrDefault().KasaList = ttt;
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
                                MIKTAR = decimal.Parse(gridView1.GetRowCellValue(item, "MIKTAR").ToString()),
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
                        //_kasaa.kasalist ile ttt den kasaid si eşleşen var ise onun idsini alacak. yoksa 0 olarak gönderecek.
                        foreach (var item in ttt)
                        {
                            if (ffatura._kasaaa.Where(x => x.num.ToString() == this.num).FirstOrDefault().KasaList.Where(x => x.KASAID == item.KASAID).Count() > 0)
                            {
                                item.ID = ffatura._kasaaa.Where(x => x.num.ToString() == this.num).FirstOrDefault().KasaList.Where(x => x.KASAID == item.KASAID).FirstOrDefault().ID;
                            }
                        }
                        ffatura._kasaaa.Where(x => x.num.ToString() == this.num).FirstOrDefault().KasaList = ttt;
                    }

                }
            }
            else if (_islem == "FAlisFatura")
            {

                if (fAlisFatura != null)
                {
                    ttt.Clear();
                    fAlisFatura._tempKasaList.Clear();
                    foreach (var item in gridView1.GetSelectedRows())
                    {
                        if (item != -1)
                        {
                            ttt.Add(new KasaList()
                            {

                                MARKA = gridView1.GetRowCellValue(item, "MARKA").ToString(),
                                KASAADI = gridView1.GetRowCellValue(item, "KASAADI").ToString(),
                                MIKTAR = decimal.Parse(gridView1.GetRowCellValue(item, "MIKTAR").ToString()),
                                KASAID = int.Parse(gridView1.GetRowCellValue(item, "KASAID").ToString()),
                            });
                        }
                        //temp += gridView1.GetRowCellValue(item, "KASAADI").ToString() + "=>" + gridView1.GetRowCellValue(item, "MIKTAR").ToString() + ";";
                    }
                    if (fAlisFatura._kasaaa.Where(x => x.num.ToString() == this.num).Count() == 0)
                        fAlisFatura._kasaaa.Add(new ListKasaList()
                        {
                            num = int.Parse(num),
                            KasaList = ttt
                        });
                    else
                    {
                        //_kasaa.kasalist ile ttt den kasaid si eşleşen var ise onun idsini alacak. yoksa 0 olarak gönderecek.
                        foreach (var item in ttt)
                        {
                            if (fAlisFatura._kasaaa.Where(x => x.num.ToString() == this.num).FirstOrDefault().KasaList.Where(x => x.KASAID == item.KASAID).Count() > 0)
                            {
                                item.ID = fAlisFatura._kasaaa.Where(x => x.num.ToString() == this.num).FirstOrDefault().KasaList.Where(x => x.KASAID == item.KASAID).FirstOrDefault().ID;
                            }
                        }
                        fAlisFatura._kasaaa.Where(x => x.num.ToString() == this.num).FirstOrDefault().KasaList = ttt;
                    }

                }
            }

            this.Close();
        }
        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            gridView1.ApplyFindFilter(textEdit1.EditValue.ToString());
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            gridView1.SelectRow(e.RowHandle);
        }

        private void GCKasaList_KeyPress(object sender, KeyPressEventArgs e)
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

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Kaydet();
        }
    }
}
