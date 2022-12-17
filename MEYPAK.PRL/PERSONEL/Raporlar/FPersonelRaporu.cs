using DevExpress.DirectX.Common.Direct2D;
using DevExpress.DirectX.Common.DirectWrite;
using DevExpress.XtraEditors;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.PERSONEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEYPAK.PRL.PERSONEL.Raporlar
{
    public partial class FPersonelRaporu : XtraForm
    {
        public FPersonelRaporu(string tag = "", string islem ="" )
        {
            InitializeComponent();
            _form = tag;
            _islem = islem;
            _personelServis = new GenericWebServis<PocoPERSONEL>();
        }


        #region Tanımlar
        string _form, _islem;
        GenericWebServis<PocoPERSONEL> _personelServis;
        public PocoPERSONEL _tempPersonel;
        #endregion

        private void FPersonelRaporu_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        void Doldur()
        {

        }

        private void BTPersonelSec_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FPersonelList fPersonelList = new FPersonelList(this.Tag.ToString(), "FPersonelRaporu");
            fPersonelList.ShowDialog();
            if (_tempPersonel != null)
                BTPersonelSec.Text = _tempPersonel.adi;

            //GridiDoldur(Filtrele());

        }

    }
}
