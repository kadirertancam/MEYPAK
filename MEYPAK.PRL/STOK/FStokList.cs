using MEYPAK.BLL.Assets;
using MEYPAK.BLL.STOK;
using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.DAL.Concrete.EntityFramework.Repository;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Stok;
using MEYPAK.PRL.Assets;
using MEYPAK.PRL.Assets.Scripts;
using MEYPAK.PRL.DEPO;
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
    public partial class FStokList : Form
    {
        FStokKart fSTOKKART;
        FStokHareket fStokHareket;
        FStokSayimPanel fstokSayimPanel;
        FStokFiyatListPanel fstokFiyatListPanel;
        FMusteriSiparis fSiparis;
        FSatınAlmaSiparis _fSatınAlmaSiparis;
        FDepolarArasıTransferHar fDepolarArasıHar;
        int id;
        string _islem;
        public FStokList(string islem="")
        {
            InitializeComponent();
            this._islem = islem;


            _OlcuBrServis = new GenericWebServis<PocoOLCUBR>();
            _OlcuBrServis.Data(ServisList.OlcuBrListeServis);
            _stokOlcuBrServis = new GenericWebServis<PocoSTOKOLCUBR>();
            _stokServis = new GenericWebServis<PocoSTOK>();
        }
        GenericWebServis<PocoSTOK> _stokServis ; 
        GenericWebServis<PocoSTOKOLCUBR> _stokOlcuBrServis ;
        GenericWebServis<PocoOLCUBR> _OlcuBrServis ;
        private void FStokList_Load(object sender, EventArgs e)
        {
            _stokServis.Data(ServisList.StokListeServis);
            gridControl1.DataSource = _stokServis.obje.Select(x => new { x.id, x.kod, x.adi, x.grupkodu, x.olcubR1, x.markaid }).ToList();

            fSTOKKART = (FStokKart)Application.OpenForms["FStokKart"];
            fStokHareket = (FStokHareket)Application.OpenForms["FStokHareket"];
            fstokSayimPanel = (FStokSayimPanel)Application.OpenForms["FStokSayimPanel"];
            fstokFiyatListPanel = (FStokFiyatListPanel)Application.OpenForms["FStokFiyatListPanel"];
            fDepolarArasıHar = (FDepolarArasıTransferHar)Application.OpenForms["FDepolarArasıTransferHar"];
            fSiparis = (FMusteriSiparis)Application.OpenForms["FMusteriSiparis"];
            _fSatınAlmaSiparis= (FSatınAlmaSiparis)Application.OpenForms["FSatınAlmaSiparis"];

        }
        private void dataGridView1_CellDoubleClick(object sender, EventArgs  e)
        {

            _stokServis.Data(ServisList.StokListeServis);
            if (_islem == "stokkart")
            {
                if (fSTOKKART != null)
                    fSTOKKART._tempStok = _stokServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
            }
            else if (_islem == "stoksayimpanel")
            {
                if (fstokSayimPanel != null)
                    fstokSayimPanel._tempStok = _stokServis.obje.Where(x=>x.id.ToString()== gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
            }
            else if (_islem == "stokhar")
            {
                if (fStokHareket != null)
                    fStokHareket._tempStok = _stokServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
            }
            else if (_islem == "stokfiyatlistpanel")
            {
                if (fstokFiyatListPanel != null)
                    fstokFiyatListPanel._tempStok = _stokServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
            }
            else if (_islem == "siparis")
            {
                if (fSiparis != null)
                    fSiparis._tempStok = _stokServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
            }
            else if (_islem == "FDepolarArasıTransferHar")
            {
                if (fDepolarArasıHar != null)
                    fDepolarArasıHar._tempStok = _stokServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
            }else if (_islem == "SatinAlmaSiparis")
            {
                if (_fSatınAlmaSiparis != null)
                    _fSatınAlmaSiparis._tempStok = _stokServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();

            }

            this.Close();
        }

        
    }
}
