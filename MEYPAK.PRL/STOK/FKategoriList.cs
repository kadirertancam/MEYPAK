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
            TreeViewiDoldur();
        }


        public void TreeViewiDoldur()
        {
            var data = _kategoriServis.Listele();
            TreeNode ustNode = new TreeNode("Kategoriler");
            treeView1.Nodes.Add(TreeViewDon(ref ustNode, data, 0));
        }


        TreeNode TreeViewDon(ref TreeNode ustNode, List<MPKATEGORI> data, int ustid = 0)
        {
            foreach (var item in data.Where(x => x.UstId == ustid))
            {
                var A = ustNode.Nodes.Add(item.ID.ToString(), item.Acıklama);

                if (_kategoriServis.Listele().Where(x => x.UstId == item.ID).Count() > 0)
                {
                    A = TreeViewDon(ref A, data, item.ID);
                }
            }
            return ustNode;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode.Name != "" && treeView1.SelectedNode != null)
            {
                MPKATEGORI mPKATEGORI = new MPKATEGORI()
                {
                    Acıklama = TBAcıklama.Text,
                    UstId = Convert.ToInt32(treeView1.SelectedNode.Name.ToString())

                };
                _kategoriServis.Ekle(mPKATEGORI);
                MessageBox.Show("Başarıyla Eklendi");
            }
            else
            {
                MessageBox.Show("Lütfen alt kategori eklemek istediğiniz kategoriyi seçiniz.");
            }
        }

        private void BTNYeniKategori_Click(object sender, EventArgs e)
        {
            if (TBAcıklama.Text != null && TBAcıklama.Text != "")
            {
                MPKATEGORI mPKATEGORI = new MPKATEGORI()
                {
                    Acıklama = TBAcıklama.Text,
                    UstId = 0
                };
                _kategoriServis.Ekle(mPKATEGORI);
                MessageBox.Show("Başarıyla Eklendi");
            }
            else
            {
                MessageBox.Show("Lütfen Yeni Kategori için bir isim giriniz.");
            }

        }
    }
}
