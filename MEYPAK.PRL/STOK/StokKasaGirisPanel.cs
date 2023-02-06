using DevExpress.XtraEditors;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.STOK;
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
    public partial class StokKasaGirisPanel : DevExpress.XtraEditors.XtraForm
    {
        public StokKasaGirisPanel()
        {
            InitializeComponent();
            _stokKasaServis = new GenericWebServis<PocoSTOKKASA>();
            
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }
        GenericWebServis<PocoSTOKKASA> _stokKasaServis;
        FStokKasaList2 _stokKasa;
        public PocoSTOKKASA _tempKasa;
        private void buttonEdit1_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            _stokKasaServis.Data(ServisList.StokKasaListeServis);
            _stokKasa = new FStokKasaList2(this.Tag.ToString(),"StokKasaGirisPanel");
            _stokKasa.ShowDialog();
        }
    }
}