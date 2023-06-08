using DevExpress.XtraEditors;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.IdentityModels;
using MEYPAK.Entity.PocoModels.PARAMETRE;
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
  
    public partial class FSeriYetkilendirmeTanim : XtraForm
    {
        public FSeriYetkilendirmeTanim()
        {
            InitializeComponent();
            _seriServis = new GenericWebServis<PocoSERI>();
            userServis = new GenericWebServis<MPUSER>();
            _seriYetkiServis = new GenericWebServis<PocoSERIYETKI>();
        }
        GenericWebServis<PocoSERI> _seriServis;
        GenericWebServis<MPUSER> userServis;
        GenericWebServis<PocoSERIYETKI> _seriYetkiServis;
        FSeriList _seriList;
        public PocoSERI _seritemp;

        //TODO: Kullanıcı Yapısı Kurgulandıktan Sonra Bakılacakss
        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FSeriTanim_Load(object sender, EventArgs e)
        {
            _seriServis.Data(ServisList.SeriListeServis);
            userServis.Data(ServisList.UserGetServis);
            lookUpEdit1.Properties.DataSource = userServis.obje.Select(x => new KullaniciList
            {
                 ID = x.Id,
                KULLANICIADI = x.UserName,
            });
            lookUpEdit1.Properties.PopulateColumns();
            lookUpEdit1.Properties.Columns["ID"].Visible = false;
            lookUpEdit1.Properties.DisplayMember = "KULLANICIADI";
            lookUpEdit1.Properties.ValueMember = "ID";
        }

        private void BESeri_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void BTSeriKaydet_Click(object sender, EventArgs e)
        {
            _seriYetkiServis.Data(ServisList.SeriYetkiEkleServis, new PocoSERIYETKI()
            {
                kullaniciid = lookUpEdit1.EditValue.ToString(),
                seriid = _seritemp.id,
                userid = MPKullanici.ID,

            });
        }

        private void BESeri_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            _seriList = new FSeriList(this.Tag.ToString(), "FSeriYetkilendirme");
            _seriList.ShowDialog();
            if (_seritemp != null)
                BESeri.Text = _seritemp.SERINO;
        }
    }
    public class KullaniciList
    {
        public string ID { get; set; }
        public string KULLANICIADI { get; set; }
    }
}
