using MEYPAK.BLL.STOK;
using MEYPAK.DAL.Concrete.EntityFramework.Repository;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.DAL.Concrete.EntityFramework.Repository;
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
using static System.Net.Mime.MediaTypeNames;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.Models.STOK;

namespace MEYPAK.PRL.STOK
{
    public partial class FOlcuBrKart : Form
    {
        string islemtipi = "Kayıt";
        public FOlcuBrKart()
        {
            InitializeComponent();
            _OlcuBrServis = new GenericWebServis<PocoOLCUBR>();
        }
        GenericWebServis<PocoOLCUBR> _OlcuBrServis ;
        private void FStokOlcuBrKart_Load(object sender, EventArgs e)
        {
            DataGridDoldur();
        }
        int id;
        private void BTKaydet_Click(object sender, EventArgs e)
        { 
            if (islemtipi == "Kayıt")
            {
                _OlcuBrServis.Data(ServisList.OlcuBrEkleServis, (new PocoOLCUBR()
                {
                    adi = TBOlcuBrAdi.Text,
                    birim = TBOlcuBr.Text,
                }));
               
            }
            else
                 _OlcuBrServis.Data(ServisList.OlcuBrEkleServis, (new PocoOLCUBR()
                 {
                    id = id,
                    adi = TBOlcuBrAdi.Text,
                    birim = TBOlcuBr.Text,
                }));
            MessageBox.Show("Kayıt Başarılı.");
            id = 0;
            DataGridDoldur();
        }

        private void BTSil_Click(object sender, EventArgs e)
        {
            _OlcuBrServis.Data(ServisList.OlcuBrListeServis);
            _OlcuBrServis.Data(ServisList.OlcuBrSilServis,_OlcuBrServis.obje.Where(x => x.id.ToString() == DGOlcuBrKart.CurrentRow.Cells[0].Value.ToString()).FirstOrDefault()) ;
            MessageBox.Show("Silme Başarılı");
           
            DGOlcuBrKart.DataSource = _OlcuBrServis.obje;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TBOlcuBrAdi.Text = DGOlcuBrKart.Rows[e.RowIndex].Cells[3].Value.ToString();
            TBOlcuBr.Text = DGOlcuBrKart.Rows[e.RowIndex].Cells[4].Value.ToString();
            id = int.Parse(DGOlcuBrKart.Rows[e.RowIndex].Cells[0].Value.ToString());
            islemtipi = "Güncelleme";
        }
        void DataGridDoldur()
        {
            _OlcuBrServis.Data(ServisList.OlcuBrListeServis);
            DGOlcuBrKart.DataSource = "";
            DGOlcuBrKart.DataSource = _OlcuBrServis.obje;
        }

    }
}