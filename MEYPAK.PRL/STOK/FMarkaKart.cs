using MEYPAK.BLL.Assets;
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
            _markaServis = new GenericWebServis<PocoSTOKMARKA>();
        }
        #region Tanımlar
        GenericWebServis<PocoSTOKMARKA> _markaServis ;
        PocoSTOKMARKA _tempMarka;
        int id = 0;
        #endregion
        private void FMarkaKart_Load(object sender, EventArgs e)
        {
            _markaServis.Data(ServisList.StokMarkaListeServis);
           dataGridView1.DataSource= _markaServis.obje;
        }

        private void BTKaydet_Click(object sender, EventArgs e)
        {

            _markaServis.Data(ServisList.StokMarkaEkleServis, (new PocoSTOKMARKA()
            {
                ID = id,
                ADI = TBMarkaAdi.Text,
                ACIKLAMA = TBAciklama.Text,
                KAYITTIPI = 0
            }));
               
                    MessageBox.Show("Başarılı.");
                id = 0;
                _tempMarka = null; 
                Temizle(this.Controls);

            _markaServis.Data(ServisList.StokMarkaListeServis);
            dataGridView1.DataSource = _markaServis.obje;

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _tempMarka = _markaServis.obje.Where(x=>x.ID.ToString()==dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()).FirstOrDefault();
            TBMarkaAdi.Text = _tempMarka.ADI;
            TBAciklama.Text = _tempMarka.ACIKLAMA;
            id = _tempMarka.ID;
        }

        private void BTSil_Click(object sender, EventArgs e)
        {
            if(_tempMarka!=null)
            _markaServis.Data(ServisList.StokMarkaSilServis,null,"filter=ID eq"+ _tempMarka.ID);
            _markaServis.Data(ServisList.StokMarkaListeServis);
            dataGridView1.DataSource= _markaServis.obje;
            
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
