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

namespace MEYPAK.PRL.PERSONEL
{
    public partial class FPersonelParametre : XtraForm
    {
        public FPersonelParametre()
        {
            InitializeComponent();
            personelParServis = new GenericWebServis<PocoPERSONELPARAMETRE>();
        }
        GenericWebServis<PocoPERSONELPARAMETRE> personelParServis;

        private void BTNPersonelKaydet_Click(object sender, EventArgs e)
        {
            int a = 0;
            if (int.TryParse(TBAvans.EditValue.ToString(),out a) && a!=0)
            {
                personelParServis.Data(ServisList.AdresListServis, new PocoPERSONELPARAMETRE()
                {
                    AVANSKATI = (!(bool)TSAvans.EditValue) ? Convert.ToInt32(TBAvans.EditValue) : personelParServis.obje.FirstOrDefault().AVANSKATI,
                    AVANSKATIrequired = !(bool)TSAvans.EditValue,
                    AVANSMIKTAR= (bool)TSAvans.EditValue? Convert.ToInt32(TBAvans.EditValue):personelParServis.obje.FirstOrDefault().AVANSMIKTAR,
                    AVANSMIKTARrequired= (bool)TSAvans.EditValue,
                });
            }
            else
                MessageBox.Show("Geçerli bir avans parametresi giriniz!");
        }
    }
}
