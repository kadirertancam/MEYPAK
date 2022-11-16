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
        string islemtipi = "Kayıt";
        
        public FStokKasaPanel()
        {
            InitializeComponent();
            _kasaServis = new GenericWebServis<PocoSTOKKASA>();
        }

        #region Tanımlar
        GenericWebServis<PocoSTOKKASA>_kasaServis;
        #endregion

        #region Metotlar
        private void BTKaydet_Click(object sender, EventArgs e)
        {
            _kasaServis.Data(ServisList.StokKasaEkleServis, new PocoSTOKKASA
            {
                kasaadi = TBKod.Text,
                aciklama = TBAciklama.Text,
                kasakodu = TBAdi.Text,
                olusturmatarihi = DateTime.Now,
            });
            MessageBox.Show("Kasa Başarıyla Eklendi.");
            Doldur();
        }

        private void FKasaPanel_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        void Doldur()
        {
            _kasaServis.Data(ServisList.StokKasaListeServis);
            DGKasaPanel.DataSource = _kasaServis.obje.Where(x => x.kayittipi == 0).Select(x => new
            {
                ID = x.id,
                Kodu = x.kasakodu,
                Adı = x.kasaadi,
                Açıklama = x.aciklama,
                OluşturmaTarihi = x.olusturmatarihi

            });
            DGKasaPanel.Refresh();
            DGKasaPanel.RefreshDataSource();

        }

        private void BTSil_Click(object sender, EventArgs e)
        {
            _kasaServis.Data(ServisList.KasaListeServis);
            _kasaServis.Data(ServisList.KasaSilServis, null, null, _kasaServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).ToList());
            MessageBox.Show("Silme işlemi Başarılı");
            Doldur();
        }

        #endregion
    }
}
