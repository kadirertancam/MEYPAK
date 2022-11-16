using MEYPAK.BLL.Assets;
using MEYPAK.BLL.STOK;
using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.DAL.Concrete.EntityFramework.Repository;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Parametre;
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
    public partial class FStokKasaPanel : Form
    {
      
        public FStokKasaPanel()
        {
            InitializeComponent();
            _kasaServis = new GenericWebServis<PocoSTOKKASA>();
        }

        #region Tanımlar
        GenericWebServis<PocoSTOKKASA>_kasaServis;
        PocoSTOKKASA _tempStokKasaPanel;
        #endregion

        #region Metotlar
        private void BTKaydet_Click(object sender, EventArgs e)
        {
           
            _kasaServis.Data(ServisList.StokKasaEkleServis, new PocoSTOKKASA
            {
                kasakodu = TBKod.Text,
                kasaadi = TBAdi.Text,
                aciklama = TBAciklama.Text,
                aktif =1,
                olusturmatarihi = DateTime.Now,
            });
            MessageBox.Show("Kasa Başarıyla Eklendi.");
            DataGridDoldur();
        }

        private void FKasaPanel_Load(object sender, EventArgs e)
        {
            DataGridDoldur();
            CombolariDoldur();
        }
        int id;
        void DataGridDoldur()
        {
            _kasaServis.Data(ServisList.StokKasaListeServis);
            DGKasaPanel.DataSource = _kasaServis.obje.Where(x => x.kayittipi == 0).Select(x => new
            {
                ID = x.id,
                Kodu = x.kasakodu,
                Adı = x.kasaadi,
                Açıklama = x.aciklama,
                //Aktif =x.aktif,
                OluşturmaTarihi = x.olusturmatarihi

            });
            DGKasaPanel.Refresh();
            DGKasaPanel.RefreshDataSource();

        }

        void CombolariDoldur()
        {
            _kasaServis.Data(ServisList.KasaListeServis);
        }

        void KasaPanelBilgileriniGetir()
        {
            if (_tempStokKasaPanel != null)
            {
                id = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
                TBKod.Text = gridView1.GetFocusedRowCellValue("Kodu").ToString();
                TBAdi.Text = gridView1.GetFocusedRowCellValue("Adı").ToString();
                TBAciklama.Text = gridView1.GetFocusedRowCellValue("Açıklama").ToString();
                CHBAktif.EditValue = _tempStokKasaPanel.aktif;
            }
        }


        private void BTSil_Click(object sender, EventArgs e)
        {
            _kasaServis.Data(ServisList.KasaListeServis);
            _kasaServis.Data(ServisList.KasaSilServis, null, null, _kasaServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).ToList());
            MessageBox.Show("Silme işlemi Başarılı");
            DataGridDoldur();
        }

        #endregion

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            _tempStokKasaPanel = _kasaServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
            KasaPanelBilgileriniGetir();
        }
    }
}
