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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MEYPAK.PRL.STOK
{
    public partial class FKategoriList : Form
    {
        
        int id;
        string _islem;
        public FKategoriList(string islem="")
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
            var data = _kategoriServis.Listele();
            if (data != null)
            {
                List < TreeNode > treenodes = new List<TreeNode>();
                treenodes= TreeViewListele(treenodes, data);
                TreeNode[] treearray = new TreeNode[treenodes.Count];
                
                TreeNode node = new TreeNode("Kategoriler",treearray);
                treeView1.Nodes.Add(node);

            }
        }

        List<TreeNode> TreeViewListele(List<TreeNode> node,List<MPKATEGORI> _tempKategori)
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode.Tag !=null)
            {
                MPKATEGORI mPKATEGORI = new MPKATEGORI()
                {
                    UstId = (int)treeView1.SelectedNode.Tag,
                    Acıklama = textBox1.Text
                };
                _kategoriServis.Ekle(mPKATEGORI);
                treeView1.Nodes.Clear();
            }
            else
            {
                MessageBox.Show("Lütfen alt kategori eklemek istediğiniz kategoriyi seçiniz.");
            }
        }
    }
}
