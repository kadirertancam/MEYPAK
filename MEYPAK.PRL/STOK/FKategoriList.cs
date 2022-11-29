using System.Data;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.BLL.Assets;
using MEYPAK.PRL.CARI;
using MEYPAK.Entity.PocoModels.CARI;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList;
using DevExpress.XtraGrid.Views.Grid;
using System.Net.Http;

namespace MEYPAK.PRL.STOK
{
    public partial class FKategoriList : XtraForm
    {
        FStokKart fStokKart;
        FCariKart fCariKart;
        string _form;
        string _islem;

        public FKategoriList(string form = "", string islem = "")
        {
            InitializeComponent();
            this._form = form;
            this._islem = islem;
            _kategoriServis = new GenericWebServis<PocoSTOKKATEGORI>();

        }

        #region Tanımlar
        GenericWebServis<PocoSTOKKATEGORI> _kategoriServis;

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
                    if (frm.Name.Contains("FStokKart"))
                        fStokKart = (FStokKart)frm;
                    if (frm.Name.Contains("FCariKart"))
                        fCariKart = (FCariKart)frm;
                }

            }
            _kategoriServis.Data(ServisList.StokKategoriListeServis);
        }
        public void TreeViewiDoldur()
        {
            treeView.Nodes.Clear();
            _kategoriServis.Data(ServisList.StokKategoriListeServis);
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
                dataTable.Rows.Add(item.id, item.ustId, item.acıklama);
            }
            treeView.DataSource = dataTable;
        }


        TreeNode TreeViewDon(ref TreeNode ustNode, List<PocoSTOKKATEGORI> data, int ustid = 0)
        {
            foreach (var item in data.Where(x => x.ustId == ustid))
            {
                var A = ustNode.Nodes.Add(item.id.ToString(), item.acıklama);


                if (_kategoriServis.obje.Where(x => x.ustId == item.id && x.kayittipi == 0).Count() > 0)
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
                PocoSTOKKATEGORI mPKATEGORI = new PocoSTOKKATEGORI()
                {
                    acıklama = TBKategoriAdi.Text,
                    ustId = 0
                };
                _kategoriServis.Data(ServisList.StokKategoriEkleServis, mPKATEGORI);
                MessageBox.Show("Yeni Kategori Başarıyla Eklendi");
                Temizle(this.Controls);
                TreeViewiDoldur();
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
                TreeListMultiSelection selectedNodes = treeView.Selection;
                PocoSTOKKATEGORI mPKATEGORI = new PocoSTOKKATEGORI()
                {
                    acıklama = TBKategoriAdi.Text,
                    ustId = _kategoriServis.obje.Where(x => x.kayittipi == 0 && x.acıklama == selectedNodes[0].GetValue(treeView.Columns[0]).ToString()).FirstOrDefault().id

                };
                _kategoriServis.Data(ServisList.StokKategoriEkleServis, mPKATEGORI);

                MessageBox.Show("Alt Kategori Başarıyla Eklendi");
                Temizle(this.Controls);
                TreeViewiDoldur();


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
                if (_kategoriServis.obje.Where(x=>x.kayittipi==0&& x.ustId == _kategoriServis.obje.Where(x => x.kayittipi == 0 && x.acıklama == selectedNodes[0].GetValue(treeView.Columns[0]).ToString()).FirstOrDefault().id).Count()>0)
                {
                    foreach (var item in _kategoriServis.obje.Where(x => x.kayittipi == 0 && x.ustId == _kategoriServis.obje.Where(x => x.kayittipi == 0 && x.acıklama == selectedNodes[0].GetValue(treeView.Columns[0]).ToString()).FirstOrDefault().id))
                    {
                        _kategoriServis.Data(ServisList.StokKategoriDeleteByIdServis, id: item.id.ToString(), method: HttpMethod.Post);
                    }
                    _kategoriServis.Data(ServisList.StokKategoriDeleteByIdServis, id: _kategoriServis.obje.Where(x => x.kayittipi == 0 && x.acıklama == selectedNodes[0].GetValue(treeView.Columns[0]).ToString()).FirstOrDefault().id.ToString(), method: HttpMethod.Post);
                    MessageBox.Show("Seçili Kategori ve tüm Alt Kategorileri Başarıyla silindi!");
                    TreeViewiDoldur();
                }
                else
                {
                    _kategoriServis.Data(ServisList.StokKategoriDeleteByIdServis, id: _kategoriServis.obje.Where(x => x.kayittipi == 0 && x.acıklama == selectedNodes[0].GetValue(treeView.Columns[0]).ToString()).FirstOrDefault().id.ToString(), method: HttpMethod.Post);
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
                if (_islem == "stokkart")
                {
                    if (fStokKart != null)
                    {
                        fStokKart._tempKategori = _kategoriServis.obje.Where(x => x.kayittipi == 0 && x.acıklama == selectedNodes[0].GetValue(treeView.Columns[0]).ToString()).FirstOrDefault();
                        this.Close();
                    }
                }
                else if (_islem == "carikart")
                {
                    if (fCariKart != null)
                    {
                        fCariKart._tempCariStOKKATEGORI = _kategoriServis.obje.Where(x => x.kayittipi == 0 && x.acıklama == selectedNodes[0].GetValue(treeView.Columns[0]).ToString()).FirstOrDefault();
                        this.Close();
                    }
                }

            }
        }
    }
}
