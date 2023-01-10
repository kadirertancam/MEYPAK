using DevExpress.XtraEditors;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels;
using MEYPAK.Entity.PocoModels.CARI;
using MEYPAK.Entity.PocoModels.CEKSENET;
using MEYPAK.Interfaces.Cari;
using MEYPAK.PRL.CARI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEYPAK.PRL.CEKSENET
{
    public partial class FFirmaSenetTanim : XtraForm
    {
        public FFirmaSenetTanim()
        {
            InitializeComponent();
            _firmaSenetServis = new GenericWebServis<PocoFIRMASENETSB>();
            _cariKartServis= new GenericWebServis<PocoCARIKART>();
            _tempSenetKalem = new List<PocoFIRMASENETSB>();
        }
        GenericWebServis<PocoFIRMASENETSB> _firmaSenetServis;
        GenericWebServis<PocoCARIKART> _cariKartServis;
        PocoFIRMASENETSB _tempFirmaSenet;
        List<PocoFIRMASENETSB> _tempSenetKalem;
       public PocoCARIKART _tempCari;

        private void BTKaydet_Click(object sender, EventArgs e)
        {
            _firmaSenetServis.Data(ServisList.FirmaSenetSBListeServis);
            _cariKartServis.Data(ServisList.CariListeServis);
            foreach (var item in _tempSenetKalem)
            {
                if (item != new PocoFIRMASENETSB())
                {
                    _firmaSenetServis.Data(ServisList.FirmaSenetSBEkleServis,new PocoFIRMASENETSB()
                    {

                    });
                }
            }
        }

        void GridiYapilandir()
        {
            _tempSenetKalem.Add(new PocoFIRMASENETSB());
            DGFirmaSenet.DataSource = _tempSenetKalem;
        }

        private void FFirmaSenetTanim_Load(object sender, EventArgs e)
        {
            GridiYapilandir();
        }

        private void gridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                _tempSenetKalem.Add(new PocoFIRMASENETSB());
                DGFirmaSenet.RefreshDataSource();
            }
        }

        private void BTCariSec_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FCariList _cariList = new FCariList(this.Tag.ToString(), "FFirmaSenetTanim");
            _cariList.ShowDialog();

            if (_tempCari!=null)
            {
                TBCariAdi.Text = _tempCari.unvan;
                BTCariSec.Text = _tempCari.kod;
            }
        }
    }
}
