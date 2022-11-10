using DevExpress.XtraEditors;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.PERSONEL;
using MEYPAK.Interfaces.Personel;
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
    public partial class FPersonelKart : Form
    {
        GenericWebServis<PocoPERSONELDEPARTMAN> _personelDepartmanServis;
        GenericWebServis<PocoPERSONELGOREV> _personelGorevServis;

        public FPersonelKart()
        {
            _personelGorevServis = new GenericWebServis<PocoPERSONELGOREV>();
            _personelDepartmanServis = new GenericWebServis<PocoPERSONELDEPARTMAN>();
            InitializeComponent();
            CombolarıDoldur();



        }


   



        private void lookUpEdit2_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {//GOREV
            if (e.Button.Caption == "Ekle")
            {
                _personelGorevServis.Data(ServisList.PersonelGorevEkleServis, new PocoPERSONELGOREV()
                {

                    adi = sender.GetType().GetProperty("AutoSearchText").GetValue(sender).ToString()
                });
                MessageBox.Show(sender.GetType().GetProperty("AutoSearchText").GetValue(sender).ToString() + " Başarıyla Eklendi");
            }
        }

        private void lookUpEdit1_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {//DEPARTMAN
            if (e.Button.Caption == "Ekle")
            {
                _personelDepartmanServis.Data(ServisList.PersonelDepartmanEkleServis, new PocoPERSONELDEPARTMAN()
                {
                    adi = sender.GetType().GetProperty("AutoSearchText").GetValue(sender).ToString()
                });
                MessageBox.Show(sender.GetType().GetProperty("AutoSearchText").GetValue(sender).ToString() + " Başarıyla Eklendi");
            }
        }


        void CombolarıDoldur()
        {
            _personelDepartmanServis.Data(ServisList.PersonelDepartmanListeServis);
            CBDepartman.Properties.DataSource = _personelDepartmanServis.obje;
            CBDepartman.Properties.DisplayMember = "adi";
            CBDepartman.Properties.ValueMember = "id";

            _personelGorevServis.Data(ServisList.PersonelGorevListeServis);
            CBGorev.Properties.DataSource = _personelGorevServis.obje;
            CBGorev.Properties.DisplayMember = "adi";
            CBGorev.Properties.ValueMember = "id";
        }
    }
}
