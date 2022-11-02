using MEYPAK.BLL.Assets;
using MEYPAK.BLL.STOK;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.DAL.Concrete.EntityFramework.Repository;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Stok;
using MEYPAK.PRL.Assets;
using MEYPAK.PRL.SIPARIS;
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
    public partial class FKasaList : Form
    {
        FStokKart fStokKart;
        FMusteriSiparis fSiparis;
        FSatınAlmaSiparis fSatınAlmaSiparis;
        GenericWebServis<PocoSTOKKASA> _kasaServis;
        string _islem;
        public FKasaList(string islem = "")
        {
            InitializeComponent();
            this._islem = islem;
            _kasaServis = new GenericWebServis<PocoSTOKKASA>();
        }
        
        private void FKasaList_Load(object sender, EventArgs e)
        {   _kasaServis.Data(ServisList.StokKasaListeServis);
            GCKasaList.DataSource = _kasaServis.obje.Where(x=>x.kayittipi==0).Select(x=> new { x.id,x.KASAADI});
            fStokKart = (FStokKart)Application.OpenForms["FStokKart"];
            fSiparis = (FMusteriSiparis)Application.OpenForms["FMusteriSiparis"];
            fSatınAlmaSiparis = (FSatınAlmaSiparis)Application.OpenForms["FSatınAlmaSiparis"];

        }
        private void dataGridView1_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            _kasaServis.Data(ServisList.StokKasaListeServis);
            if (_islem == "Stok")
            {
                if (fStokKart != null)
                    fStokKart._tempKasa = _kasaServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
            }
            else if (_islem == "musterisiparis")
            {
                if (fSiparis != null)
                    fSiparis.gridView1.SetFocusedRowCellValue("KasaAdı", _kasaServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault().KASAADI);
            }
            else if (_islem == "SatinAlmaSiparis")
            {
                if (fSatınAlmaSiparis != null)
                    fSatınAlmaSiparis._tempKasa = _kasaServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
            }

            this.Close();
        }
    }
}
