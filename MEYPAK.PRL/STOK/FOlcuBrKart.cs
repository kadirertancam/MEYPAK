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
      
        void DataGridDoldur()
        {
            _OlcuBrServis.Data(ServisList.OlcuBrListeServis); 
            DGOlcuBirim.DataSource = _OlcuBrServis.obje.Where(x=>x.kayittipi==0).Select(x=> new {x.id,x.adi,x.birim,x.olusturmatarihi});
            DGOlcuBirim.Refresh();
            DGOlcuBirim.RefreshDataSource();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            TBAdi.Text = gridView1.GetFocusedRowCellValue("adi").ToString();
            TBOlcuBirim.Text = gridView1.GetFocusedRowCellValue("birim").ToString();
            id = int.Parse(gridView1.GetFocusedRowCellValue("id").ToString());
            islemtipi = "Güncelleme";
        }

        private void BTKaydet_Click(object sender, EventArgs e)
        {
            if (islemtipi == "Kayıt")
            {
                _OlcuBrServis.Data(ServisList.OlcuBrEkleServis, (new PocoOLCUBR()
                {
                    adi = TBAdi.Text,
                    birim = TBOlcuBirim.Text,
                }));

            }
            else
                _OlcuBrServis.Data(ServisList.OlcuBrEkleServis, (new PocoOLCUBR()
                {
                    id = id,
                    adi = TBAdi.Text,
                    birim = TBOlcuBirim.Text,
                }));
            MessageBox.Show("Kayıt Başarılı.");
            id = 0;
            DataGridDoldur();
        }

        private void BTSil_Click(object sender, EventArgs e)
        {
            _OlcuBrServis.Data(ServisList.OlcuBrListeServis);
            _OlcuBrServis.Data(ServisList.OlcuBrSilServis,null,null, _OlcuBrServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("id").ToString()).ToList());
            MessageBox.Show("Silme Başarılı");
            DGOlcuBirim.DataSource = _OlcuBrServis.obje.Where(x=> x.kayittipi == 0);
            DataGridDoldur();
        }
    }
}