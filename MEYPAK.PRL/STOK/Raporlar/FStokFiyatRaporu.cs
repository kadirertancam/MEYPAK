using DevExpress.XtraEditors;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.STOK;
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

namespace MEYPAK.PRL.STOK.Raporlar
{
    public partial class FStokFiyatRaporu : XtraForm
    {
        public FStokFiyatRaporu(string tag = "", string islem = "")
        {
            InitializeComponent();
            _stokServis = new  GenericWebServis<PocoSTOK>();
            _stokServis.Data(ServisList.StokListeServis);
            _stokFiyatServis = new GenericWebServis<PocoSTOKFIYAT>();
            _stokFiyatServis.Data(ServisList.StokFiyatListeServis);
            _stokFiyatHarServis = new GenericWebServis<PocoSTOKFIYATHAR>();
            _stokFiyatHarServis.Data(ServisList.StokFiyatHarListeServis);
            _form = tag;
            _islem = islem;
        }
        string _form, _islem;
        #region Tanımlar
        GenericWebServis<PocoSTOK> _stokServis;
        GenericWebServis<PocoSTOKFIYAT> _stokFiyatServis;
        GenericWebServis<PocoSTOKFIYATHAR> _stokFiyatHarServis;

        public PocoSTOK _tempStok;
        public PocoSTOKFIYAT _tempStokFiyat;
        public PocoSTOKFIYATHAR _tempStokFiyatHar;
        #endregion

        #region Metotlar
        private void BTStokSec_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            FStokList fStokList = new FStokList(this.Tag.ToString(), "FStokFiyarRaporu");
            fStokList.ShowDialog();
            //DataGridiYapilandir();

        }

        #endregion

        private void buttonEdit1_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FStokList fStokList = new FStokList(this.Tag.ToString(), "FStokFiyatRaporu");
            fStokList.ShowDialog();
            //DataGridiYapilandir();
        }
    }
}
