using MEYPAK.BLL.STOK;
using MEYPAK.DAL.Concrete.EntityFramewok.Repository;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models;
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

namespace MEYPAK.PRL.STOK
{
    public partial class FKategoriList : Form
    {

        int id;
        string _islem;
        public FKategoriList(string islem = "")
        {
            InitializeComponent();
            this._islem = islem;
        }
        IKategoriServis _kategoriServis = new KategoriManager(new EFKategoriRepo(NinjectFactory.CompositionRoot.Resolve<MEYPAKContext>()));
        private void FKategoriList_Load(object sender, EventArgs e)
        {

            TreeViewDoldur();
        }

        void TreeViewDoldur()
        {
            var data = _kategoriServis.Getir(x => x.UstId == 0); // Üst Kategoriler.
            if (data != null)
            {
                foreach (var item in data) // üst kategorileri dönüyor.
                {
                    TreeNode ustNode = new TreeNode(item.Acıklama);
                    ustNode.Tag = item.ID;
                    treeView1.Nodes.Add(ustNode);
                    if (item.UstId == 0
                      && _kategoriServis.Getir(x => x.UstId == item.ID).Count > 0)
                    {
                        bool isOver = false;
                        MPKATEGORI currentBaseCategory = item;

                        while (!isOver)
                        {
                            if (_kategoriServis.Getir(x => x.UstId == currentBaseCategory.ID).Count > 0)
                            {
                                // mevcuttaki ana kategorinin üst kategorisi varmış
                                // onu alalım
                                var altData = _kategoriServis.Getir(x => x.UstId == currentBaseCategory.ID);
                                currentBaseCategory = _kategoriServis.Getir(x => x.UstId == currentBaseCategory.ID).FirstOrDefault();
                                //TEKRAR BAŞA DÖNMELİ..
                                TreeViewDon(ref ustNode, altData);
                                // ustnode değişmeli
                            }
                            else
                            {
                                isOver = true;
                            }
                        }
                    }
                }
            }

            void TreeViewDon(ref TreeNode ustNode, List<MPKATEGORI> data)
            {
                foreach (var item in data)
                {
                    TreeNode altNode = new TreeNode(item.Acıklama);
                    altNode.Tag = item.ID;
                    ustNode.Nodes.Add(altNode);

                }

            }

            List<TreeNode> TreeViewListele(List<TreeNode> node, List<MPKATEGORI> _tempKategori)
            {
                foreach (MPKATEGORI item in _tempKategori)
                {
                    if (item.UstId == 0)
                    {
                        TreeNode treeNode = new TreeNode();
                        treeNode.Nodes.Add(item.Acıklama);
                        treeNode.Tag = item.ID;
                        node.Add(treeNode);
                        var altdata = _kategoriServis.Getir(x => x.UstId == item.ID);
                        return TreeViewListele(node, altdata);
                    }
                    else
                    {
                        TreeNode treeNode = new TreeNode();
                        treeNode.Nodes.Add(item.Acıklama);
                        treeNode.Tag = item.ID;
                        node.Add(treeNode);
                        var altdata = _kategoriServis.Getir(x => x.UstId == item.ID);
                        return TreeViewListele(node, altdata);
                    }
                }
                return node;

            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode.Tag != null)
            {
                //MPKATEGORI mPKATEGORI = new MPKATEGORI()
                //{
                //    UstId = (int)treeView1.SelectedNode.Tag,
                //    Acıklama = textBox1.Text
                //};
                //_kategoriServis.Ekle(mPKATEGORI);
                //treeView1.Nodes.Clear();
                MessageBox.Show(treeView1.SelectedNode.Tag.ToString());
            }
            else
            {
                MessageBox.Show("Lütfen alt kategori eklemek istediğiniz kategoriyi seçiniz.");
            }
        }
    }
}
