using MEYPAK.BLL.STOK;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.DAL.Concrete.EntityFramework.Repository;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels.STOK;
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

namespace MEYPAK.PRL.STOK
{
    public partial class FMarkaKart : Form
    {
        public FMarkaKart()
        {
            InitializeComponent();
        }
        #region Tanımlar
        IStokMarkaServis _markaServis ;
        PocoSTOKMARKA _tempMarka;
        int id = 0;
        #endregion
        private void FMarkaKart_Load(object sender, EventArgs e)
        {
           dataGridView1.DataSource= _markaServis.Listele();
        }

        private void BTKaydet_Click(object sender, EventArgs e)
        {
             
                if (_markaServis.EkleyadaGuncelle(new PocoSTOKMARKA()
                {
                    ID=id,
                    ADI = TBMarkaAdi.Text,
                    ACIKLAMA = TBAciklama.Text,
                    KAYITTIPI = 0
                }) != Interfaces.Durum.başarısız)
                {
                    MessageBox.Show("Başarılı.");
                id = 0;
                _tempMarka = null; 
                Temizle(this.Controls);

            } 
            dataGridView1.DataSource = _markaServis.Listele();

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _tempMarka = _markaServis.Getir(x=>x.ID.ToString()==dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()).FirstOrDefault();
            TBMarkaAdi.Text = _tempMarka.ADI;
            TBAciklama.Text = _tempMarka.ACIKLAMA;
            id = _tempMarka.ID;
        }

        private void BTSil_Click(object sender, EventArgs e)
        {
            if(_tempMarka!=null)
            _markaServis.Sil(x => x.ID == _tempMarka.ID);
            
            dataGridView1.DataSource= _markaServis.Listele();
            
        }


        public void Temizle(Control.ControlCollection ctrlCollection)           //Formdaki Textboxları temizle
        {
            foreach (Control ctrl in ctrlCollection)
            {
                if (ctrl is TextBoxBase)
                {
                    if (ctrl.Name != "TBStokKodu")
                        ctrl.Text = String.Empty;
                }
                else
                {
                    Temizle(ctrl.Controls);
                }
            }
        }

    }
}
