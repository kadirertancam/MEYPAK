using DevExpress.XtraEditors;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.IdentityModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEYPAK.PRL.KULLANICI
{
    public partial class FKullaniciTanim : XtraForm
    {
        public FKullaniciTanim()
        {
            InitializeComponent();
            userServis= new GenericWebServis<MPUSER>();
        }
        GenericWebServis<MPUSER> userServis;
        private void FKullaniciTanim_Load(object sender, EventArgs e)
        {
            if (!MPKullanici.Roller.Contains("ADMIN"))
            {
                MessageBox.Show("Bu Sayfaya Erişim Yetkiniz Bulunmamaktadır!");
                this.Close();
            } 

            userServis.Data(ServisList.UserGetServis);
           
            gridControl1.DataSource = userServis.obje.Select(x=> new
            {
                x.AD,
                x.SOYAD,
               KULLANICIADI=x.UserName,
               EMAIL=x.Email,
            });
        }
    }
}
