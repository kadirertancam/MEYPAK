using DevExpress.XtraEditors;
using DevExpress.XtraTreeList;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.PRL.CARI;
using MEYPAK.PRL.CARI.Raporlar;
using MEYPAK.PRL.SIPARIS.Raporlar;
using MEYPAK.PRL.STOK.Raporlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEYPAK.PRL.STOK
{
    public partial class FHizmetKategoriList : XtraForm
    {
        FHizmetKart fHizmetKart;
        string _form;
        string _islem;
        public FHizmetKategoriList(string form = "", string islem = "")
        {
            InitializeComponent();
            this._form = form;
            this._islem = islem;
            _kategoriServis = new GenericWebServis<PocoHIZMETKATEGORI>();
        }

        #region Tanımlar
        GenericWebServis<PocoHIZMETKATEGORI> _kategoriServis;
        FCariRaporu fCariRaporu;


        #endregion

        #region Metotlar
        public void Temizle(Control.ControlCollection ctrlCollection)           //Formdaki Textboxları temizle
        {
            foreach (Control ctrl in ctrlCollection)
            {
                if (ctrl is TextBoxBase)
                {
                    ctrl.Text = String.Empty;
                }
                else
                {
                    Temizle(ctrl.Controls);
                }
            }

        }

        private void FKategoriList_Load(object sender, EventArgs e)
        {
            TreeViewiDoldur();
            foreach (Form frm in Application.OpenForms)
            {
                if (_form == frm.Tag)
                {
                    if (frm.Name.Contains("FHizmetKart"))
                        fHizmetKart = (FHizmetKart)frm;
                    if (frm.Name.Contains("FCariRaporu"))
                        fCariRaporu = (FCariRaporu)frm;
                }

            }
            _kategoriServis.Data(ServisList.HizmetKategoriListeServis);
        }
        public void TreeViewiDoldur()
        {
            treeView.Nodes.Clear();
            _kategoriServis.Data(ServisList.HizmetKategoriListeServis);
            TreeNode ustNode = new TreeNode("Kategoriler");

            DataTable dataTable = new DataTable();
            DataColumn ID = new DataColumn("ID", typeof(int));
            dataTable.Columns.Add(ID);
            DataColumn USTID = new DataColumn("USTID", typeof(int));
            dataTable.Columns.Add(USTID);
            DataColumn ADI = new DataColumn("ADI", typeof(string));
            dataTable.Columns.Add(ADI);



            foreach (var item in _kategoriServis.obje.Where(x => x.kayittipi == 0))
            {
                dataTable.Rows.Add(item.id, item.ustid, item.adi);
            }
            treeView.DataSource = dataTable;

            treeView.BestFitColumns();
        }


        TreeNode TreeViewDon(ref TreeNode ustNode, List<PocoSTOKKATEGORI> data, int ustid = 0)
        {
            foreach (var item in data.Where(x => x.ustId == ustid))
            {
                var A = ustNode.Nodes.Add(item.id.ToString(), item.acıklama);


                if (_kategoriServis.obje.Where(x => x.ustid == item.id && x.kayittipi == 0).Count() > 0)
                {
                    A = TreeViewDon(ref A, data, item.id);
                }
            }
            return ustNode;
        }



        //private void treeView_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (e.KeyChar == (char)Keys.Enter)
        //    {
        //        if (_islem == "stokkart")
        //        {
        //            if (treeView.SelectedNode.Name != "" && treeView.SelectedNode != null)
        //            {
        //                if (fStokKart != null)
        //                {
        //                    fStokKart._tempKategori = _kategoriServis.obje.Where(x => x.id == Convert.ToInt32(treeView.SelectedNode.Name)).FirstOrDefault();
        //                    this.Close();
        //                }
        //            }
        //        }
        //        else if (_islem == "carikart")
        //        {
        //            if (treeView.SelectedNode.Name != "" && treeView.SelectedNode != null)
        //            {
        //                if (fCariKart != null)
        //                {
        //                    fCariKart._tempCariStOKKATEGORI = _kategoriServis.obje.Where(x => x.id == Convert.ToInt32(treeView.SelectedNode.Name)).FirstOrDefault();
        //                    this.Close();
        //                }
        //            }
        //        }
        //    }

        //}

        private void BTYeniEkle_Click(object sender, EventArgs e)
        {
            if (TBKategoriAdi.Text != null && TBKategoriAdi.Text != "")
            {
                if (_kategoriServis.obje.Where(x => x.kayittipi == 0 && x.adi == TBKategoriAdi.Text).Count() == 0)
                {
                    PocoHIZMETKATEGORI mPKATEGORI = new PocoHIZMETKATEGORI()
                    {
                        adi = TBKategoriAdi.Text,
                        ustid = 0
                    };
                    _kategoriServis.Data(ServisList.HizmetKategoriEkleServis, mPKATEGORI);
                    MessageBox.Show("Yeni Kategori Başarıyla Eklendi");
                    Temizle(this.Controls);
                    TreeViewiDoldur();
                }
                else
                {
                    MessageBox.Show("Aynı İsimde böyle bir kategori zaten mevcut!");
                }
            }
            else
            {
                MessageBox.Show("Yeni Kategori bilgisi giriniz..");
            }
        }

        private void BTAltKateEkle_Click(object sender, EventArgs e)
        {
            if (treeView.Selection != null)
            {
                if (_kategoriServis.obje.Where(x => x.kayittipi == 0 && x.adi == TBKategoriAdi.Text).Count() == 0)
                {
                    TreeListMultiSelection selectedNodes = treeView.Selection;
                    PocoHIZMETKATEGORI mPKATEGORI = new PocoHIZMETKATEGORI()
                    {
                        adi = TBKategoriAdi.Text,
                        ustid = _kategoriServis.obje.Where(x => x.kayittipi == 0 && x.adi == selectedNodes[0].GetValue(treeView.Columns[0]).ToString()).FirstOrDefault().id

                    };
                    _kategoriServis.Data(ServisList.HizmetKategoriEkleServis, mPKATEGORI);

                    MessageBox.Show("Alt Kategori Başarıyla Eklendi");
                    Temizle(this.Controls);
                    TreeViewiDoldur();
                }
                else
                {
                    MessageBox.Show("Aynı İsimde böyle bir kategori zaten mevcut!");
                }
            }
            else
            {
                MessageBox.Show("Alt Kategori eklemek istediğiniz kategoriyi seçiniz.");
            }
        }

        private void BtnKategoriSil_Click(object sender, EventArgs e)
        {
            if (treeView.Selection != null)
            {
                TreeListMultiSelection selectedNodes = treeView.Selection;
                if (_kategoriServis.obje.Where(x => x.kayittipi == 0 && x.ustid == _kategoriServis.obje.Where(x => x.kayittipi == 0 && x.adi == selectedNodes[0].GetValue(treeView.Columns[0]).ToString()).FirstOrDefault().id).Count() > 0)
                {
                    foreach (var item in _kategoriServis.obje.Where(x => x.kayittipi == 0 && x.ustid == _kategoriServis.obje.Where(x => x.kayittipi == 0 && x.adi == selectedNodes[0].GetValue(treeView.Columns[0]).ToString()).FirstOrDefault().id))
                    {
                        _kategoriServis.Data(ServisList.HizmetKategoriDeleteByIdServis, id: item.id.ToString(), method: HttpMethod.Post);
                    }
                    _kategoriServis.Data(ServisList.HizmetKategoriDeleteByIdServis, id: _kategoriServis.obje.Where(x => x.kayittipi == 0 && x.adi == selectedNodes[0].GetValue(treeView.Columns[0]).ToString()).FirstOrDefault().id.ToString(), method: HttpMethod.Post);
                    MessageBox.Show("Seçili Kategori ve tüm Alt Kategorileri Başarıyla silindi!");
                    TreeViewiDoldur();
                }
                else
                {
                    _kategoriServis.Data(ServisList.HizmetKategoriDeleteByIdServis, id: _kategoriServis.obje.Where(x => x.kayittipi == 0 && x.adi == selectedNodes[0].GetValue(treeView.Columns[0]).ToString()).FirstOrDefault().id.ToString(), method: HttpMethod.Post);
                    MessageBox.Show("Başarıyla silindi!");
                    TreeViewiDoldur();

                }

            }
            else
            {
                MessageBox.Show("Silmek İstediğiniz Kategoriyi Seçiniz!");
            }

        }

        #endregion



        private void treeView_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && treeView.Selection != null)
            {
                TreeListMultiSelection selectedNodes = treeView.Selection;
                if (_islem == "hizmetkart")
                {
                    if (fHizmetKart != null)
                    {
                        fHizmetKart._tempHizmetKategori = _kategoriServis.obje.Where(x => x.kayittipi == 0 && x.adi == selectedNodes[0].GetValue(treeView.Columns[0]).ToString()).FirstOrDefault();
                        this.Close();
                    }

                }

            }
        }

        private void BTSec_Click(object sender, EventArgs e)
        {
            if (treeView.Selection != null)
            {
                TreeListMultiSelection selectedNodes = treeView.Selection;
                if (_islem == "hizmetkart")
                {
                    if (fHizmetKart != null)
                        fHizmetKart._tempHizmetKategori = _kategoriServis.obje.Where(x => x.kayittipi == 0 && x.adi == selectedNodes[0].GetValue(treeView.Columns[0]).ToString()).FirstOrDefault();
                    
                }
                if (_islem == "FCariRaporu")
                {
                    if (fCariRaporu != null)
                        fCariRaporu._tempHizmetKategori = _kategoriServis.obje.Where(x => x.kayittipi == 0 && x.adi == selectedNodes[0].GetValue(treeView.Columns[0]).ToString()).FirstOrDefault();
                     
                }
                this.Close();

            }
        }

        private void treeView_CustomDrawNodeButton(object sender, CustomDrawNodeButtonEventArgs e)
        {
            Rectangle rect = Rectangle.Inflate(e.Bounds, -1, -2);
            Brush backBrush; Bitmap bt;
            if (e.Expanded == true)
            {
                bt = new Bitmap(Properties.Resources.kategorieksi);
            }
            else
                bt = new Bitmap(Properties.Resources.kategoriarti);
            //bt.LockBits(rect,System.Drawing.Imaging.ImageLockMode.ReadWrite,System.Drawing.Imaging.PixelFormat.Format64bppArgb);
            for (int i = 0; i < e.Bounds.Width; i++)
            {
                for (int j = 0; j < e.Bounds.Height; j++)
                {
                    Color cl = bt.GetPixel(i, j);
                    backBrush = new SolidBrush(cl);

                    e.Cache.FillRectangle(backBrush, e.Bounds.X + i, e.Bounds.Y + j, 1, 1);

                }

            }
            #region yorum
            // painting background
            //Brush backBrush = e.Cache.GetGradientBrush(rect, Color.Black, Color.LightSkyBlue,
            //  LinearGradientMode.ForwardDiagonal);

            //e.Cache.FillRectangle(backBrush, rect);
            // painting borders
            //e.Cache.DrawRectangle(e.Cache.GetPen(Color.LightGray), rect);
            // determining the character to display
            //string displayCharacter = e.Expanded ? "-" : "+";
            //formatting the output character
            //StringFormat outCharacterFormat = e.Appearance.GetStringFormat();
            //outCharacterFormat.Alignment = StringAlignment.Center;
            //outCharacterFormat.LineAlignment = StringAlignment.Center;

            //painting the character
            //e.Appearance.FontSizeDelta = -2;
            //e.Appearance.FontStyleDelta = FontStyle.Bold;
            //e.Cache.DrawString(displayCharacter, e.Appearance.Font,
            //    e.Cache.GetSolidBrush(Color.White), rect, outCharacterFormat);

            // prohibiting default painting
            #endregion
            e.Handled = true;
        }
    }
}
