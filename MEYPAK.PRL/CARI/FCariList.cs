using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.CARI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEYPAK.PRL.CARI
{
    public partial class FCariList : Form
    {
        string _form;
        public FCariList(string form="")
        {
            InitializeComponent();
            _form = form;
            _cariServis = new GenericWebServis<PocoCARIKART>();
            _cariKart = (FCariKart)Application.OpenForms["FCariKart"];
            _cariHareket = (FCariHareket)Application.OpenForms["FCariHareket"];
        }
        GenericWebServis<PocoCARIKART> _cariServis;
        FCariKart _cariKart;
        FCariHareket _cariHareket;
        private void FCariList_Load(object sender, EventArgs e)
        {
            _cariServis.Data(ServisList.CariListeServis);
            GCCariList.DataSource = _cariServis.obje.Select(x=> new
            {
                ID=x.ID,
                CARIKODU=x.KOD,
                CARIUNVAN=x.UNVAN,
                VERGIDAIRESI=x.VERGIDAIRESI,
                VERGINO=x.VERGINO,
                x.IL,x.ILCE,x.GRUPKODU,x.KATEGORI,x.TELEFON,x.CEPTEL,x.EPOSTA
            });
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (_form == "carikart")
                _cariKart._tempCariKart = _cariServis.obje.Where(x => x.ID.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
            if(_form=="carihar")
                _cariHareket._tempCARIKART= _cariServis.obje.Where(x => x.ID.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
            this.Close();
        }
    }
}
