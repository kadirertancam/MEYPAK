using MEYPAK.BLL.STOK;
using MEYPAK.DAL.Concrete.EntityFramework.Repository;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Interfaces.Stok;
using MEYPAK.PRL.Assets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.BLL.Assets;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Windows.Input;
using MEYPAK.Entity.Models.SIPARIS;
using MEYPAK.PRL.DEPO;
using MEYPAK.PRL.SIPARIS;

namespace MEYPAK.PRL.STOK
{
    public partial class FKategoriList : Form
    {
        FStokKart fStokKart;
        string _form;
        string _islem;
        GenericWebServis<PocoSTOKKATEGORI> _kategoriServis;
        public FKategoriList(string form = "", string islem = "")
        {
            InitializeComponent();
            this._form = form;
            this._islem = islem;
            _kategoriServis = new GenericWebServis<PocoSTOKKATEGORI>();
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
                }
            }
        }


        public void TreeViewiDoldur()
        {
            treeView1.Nodes.Clear();
            _kategoriServis.Data(ServisList.StokKategoriListeServis);
            TreeNode ustNode = new TreeNode("Kategoriler");
            treeView1.Nodes.Add(TreeViewDon(ref ustNode, _kategoriServis.obje.Where(x=> x.kayittipi ==0).ToList(), 0));
        }


        TreeNode TreeViewDon(ref TreeNode ustNode, List<PocoSTOKKATEGORI> data, int ustid = 0)
        {
            foreach (var item in data.Where(x => x.ustId == ustid))
            {
                var A = ustNode.Nodes.Add(item.id.ToString(), item.acıklama);

                if (_kategoriServis.obje.Where(x => x.ustId == item.id && x.kayittipi==0).Count() > 0)
                {
                    A = TreeViewDon(ref A, data, item.id);
                }
            }
            return ustNode;
        }

      
       
        private void treeView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (_islem == "stokkart")
                {
                    if (treeView1.SelectedNode.Name != "" && treeView1.SelectedNode != null)
                    {
                        if (fStokKart != null)
                        {
                            fStokKart._tempKategori = _kategoriServis.obje.Where(x => x.id == Convert.ToInt32(treeView1.SelectedNode.Name)).FirstOrDefault();
                            this.Close();
                        }
                    }
                }
            }
            
        }

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
                TreeViewiDoldur();
            }
            else
            {
                MessageBox.Show("Yeni Kategori bilgisi giriniz..");
            }
        }

        private void BTAltKateEkle_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode.Name != "" && treeView1.SelectedNode != null)
            {
                PocoSTOKKATEGORI mPKATEGORI = new PocoSTOKKATEGORI()
                {
                    acıklama = TBKategoriAdi.Text,
                    ustId = Convert.ToInt32(treeView1.SelectedNode.Name.ToString())

                };
                _kategoriServis.Data(ServisList.StokKategoriEkleServis, mPKATEGORI);

                MessageBox.Show("Alt Kategori Başarıyla Eklendi");
                TreeViewiDoldur();


            }
            else
            {
                MessageBox.Show("Alt Kategori eklemek istediğiniz kategoriyi seçiniz.");
            }
        }
    }
}
