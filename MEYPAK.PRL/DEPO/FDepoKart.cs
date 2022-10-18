using MEYPAK.BLL.DEPO;
using MEYPAK.DAL.Concrete.EntityFramework.Repository;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Interfaces.Depo;
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
using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Entity.PocoModels.DEPO;

namespace MEYPAK.PRL.DEPO
{
    public partial class FDepoKart : Form
    {
        public FDepoKart()
        {
            InitializeComponent();
        }
        FDepoList fDepoList;
        int id=0;
        public PocoDEPO _tempDepo;
        IDepoServis _depoServis ;

        void Doldur()
        {
            if (_tempDepo != null)
            {
                TBKod.Text = _tempDepo.DEPOKODU;
                TBAdi.Text = _tempDepo.DEPOADI;
                TBAciklama.Text = _tempDepo.ACIKLAMA;
                id = _tempDepo.ID;
                _tempDepo = null;
            }
        }
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


        private void BTEkle_Click(object sender, EventArgs e)
        {
            _depoServis.EkleyadaGuncelle(new PocoDEPO()
            {
                ID= id,
                DEPOKODU = TBKod.Text,
                DEPOADI = TBAdi.Text,
                ACIKLAMA=TBAciklama.Text,
                
            });
            dataGridView1.DataSource = _depoServis.Listele();
            Temizle(this.Controls);
        }
        
        private void BTSec_Click(object sender, EventArgs e)
        {
            fDepoList = new FDepoList("FDepoKart");
            fDepoList.ShowDialog();
            Doldur();
        }

        private void FDepoKart_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _depoServis.Listele();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _tempDepo = _depoServis.Getir(x => x.DEPOKODU == dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString()).FirstOrDefault();
            Doldur();
        }

        private void BTSil_Click(object sender, EventArgs e)
        {
            _depoServis.Sil(_depoServis.Getir(x => x.ID == Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value)));
        }
    }
}
