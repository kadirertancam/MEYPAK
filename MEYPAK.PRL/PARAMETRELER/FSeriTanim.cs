using DevExpress.XtraEditors;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.Models.PARAMETRE;
using MEYPAK.Entity.PocoModels.PARAMETRE;
using MEYPAK.Interfaces.Parametre;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEYPAK.PRL.PARAMETRELER
{
    public partial class FSeriTanim : XtraForm
    {
        public FSeriTanim(string tag = "", string islem = "")
        {
            InitializeComponent();
            _form = tag;
            _islem = islem;
            _seriServis = new GenericWebServis<PocoSERI>();
            _seriHarServis = new GenericWebServis<PocoSERIHAR>();
        }
        GenericWebServis<PocoSERI> _seriServis;
        GenericWebServis<PocoSERIHAR> _seriHarServis;
        string _form, _islem;

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            CBTip.SelectedIndex = 0;
            _seriServis.Data(ServisList.SeriEkleServis, new PocoSERI()
            {
                SERINO = TBSeri.Text,
                TIP = CBTip.SelectedIndex
            });
            _seriHarServis.Data(ServisList.SeriHarEkleServis, new PocoSERIHAR()
            {
                durum=0,
                seriid=_seriServis.obje2.id,
                serino=2022000000000
            });
            gridControl1.DataSource = _seriServis.obje.Select(x => new { SeriNo = x.SERINO, Tip = x.TIP == 0 ? "E-Fatura" : x.TIP == 1 ? "E-Arşiv" : x.TIP == 2 ? "E-Irsaluye" : "E-Müstahsil" });
            gridControl1.RefreshDataSource(); 
        }

        private void FSeriTanim_Load(object sender, EventArgs e)
        {
            _seriServis.Data(ServisList.SeriListeServis);
            gridControl1.DataSource = _seriServis.obje.Select(x=> new {SeriNo=x.SERINO,Tip=x.TIP==0?"E-Fatura":x.TIP==1?"E-Arşiv":x.TIP==2?"E-Irsaluye":"E-Müstahsil"});
        }
    }
}
