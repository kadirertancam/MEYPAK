using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using MEYPAK.Entity.Models.STOK;
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

namespace MEYPAK.PRL.STOK.FiyatListesi
{
    public partial class FStokFiyatPanel : XtraForm
    {
        public FStokFiyatPanel(PocoSTOKFIYAT tempstokfiyat, string form = "", string islemtipi = "")
        {
            InitializeComponent();
            this._islemtipi = islemtipi;
            this._form = form;
            _tempstokfiyat = tempstokfiyat;
        }
        string _islemtipi;
        string _form;
        PocoSTOKFIYAT _tempstokfiyat;

    }
}
