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

namespace MEYPAK.PRL.STOK
{
    public partial class FKategoriList : Form
    {
        FStokKart fStokKart;
        int id;
        string _islem;
        GenericWebServis<PocoSTOKKATEGORI> _kategoriServis;
        public FKategoriList(string islem = "")
        {
            InitializeComponent();
            this._islem = islem;
            _kategoriServis = new GenericWebServis<PocoSTOKKATEGORI>();
        }

        private void FKategoriList_Load(object sender, EventArgs e)
        {
            TreeViewiDoldur();
            fStokKart = (FStokKart)Application.OpenForms["FStokKart"];
        }


        public void TreeViewiDoldur()
        {
            treeView1.Nodes.Clear();
            _kategoriServis.Data(ServisList.StokKategoriListeServis);
            TreeNode ustNode = new TreeNode("Kategoriler");
            treeView1.Nodes.Add(TreeViewDon(ref ustNode, _kategoriServis.obje, 0));
        }


        TreeNode TreeViewDon(ref TreeNode ustNode, List<PocoSTOKKATEGORI> data, int ustid = 0)
        {
            foreach (var item in data.Where(x => x.UstId == ustid))
            {
                var A = ustNode.Nodes.Add(item.id.ToString(), item.Acıklama);

                if (_kategoriServis.obje.Where(x => x.UstId == item.id).Count() > 0)
                {
                    A = TreeViewDon(ref A, data, item.id);
                }
            }
            return ustNode;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode.Name != "" && treeView1.SelectedNode != null)
            {
                PocoSTOKKATEGORI mPKATEGORI = new PocoSTOKKATEGORI()
                {
                    Acıklama = TBAciklama.Text,
                    UstId = Convert.ToInt32(treeView1.SelectedNode.Name.ToString())

                };
                _kategoriServis.Data(ServisList.StokKategoriEkleServis, mPKATEGORI);

                MessageBox.Show("Başarıyla Eklendi");
                TreeViewiDoldur();


            }
            else
            {
                MessageBox.Show("Lütfen alt kategori eklemek istediğiniz kategoriyi seçiniz.");
            }
        }

        private void BTNYeniKategori_Click(object sender, EventArgs e)
        {
            if (TBAciklama.Text != null && TBAciklama.Text != "")
            {
                PocoSTOKKATEGORI mPKATEGORI = new PocoSTOKKATEGORI()
                {
                    Acıklama = TBAciklama.Text,
                    UstId = 0
                };
                _kategoriServis.Data(ServisList.StokKategoriEkleServis, mPKATEGORI);
                MessageBox.Show("Başarıyla Eklendi");
            }
            else
            {
                MessageBox.Show("Lütfen Yeni Kategori için bir isim giriniz.");
            }

        }

        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
        
        }

        private void treeView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (_islem == "Stok")
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
    }
}
