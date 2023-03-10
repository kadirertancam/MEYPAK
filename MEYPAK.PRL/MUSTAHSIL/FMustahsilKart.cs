using DevExpress.XtraEditors;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.MUSTAHSIL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEYPAK.PRL.MUSTAHSIL
{
    public partial class FMustahsilKart : XtraForm
    {
        public FMustahsilKart()
        {
            InitializeComponent();
            mustahsilServis = new GenericWebServis<PocoMUSTAHSIL>();
        }
        GenericWebServis<PocoMUSTAHSIL> mustahsilServis;
        public PocoMUSTAHSIL tempMustahsil;
        private void BTKaydet_Click(object sender, EventArgs e)
        {

            if (TBTcNo.Text.Length == 11)
            {
                if (TBMustahsilAdi.Text != "" && TBMustahsilSoyad.Text != "")
                {
                    DialogResult dialogResult = tempMustahsil != null ? MessageBox.Show($"{tempMustahsil}'kimlik numaralı müstahsilin bilgilerini güncellemek istediğinize emin misiniz?", "Müstahsil Güncelleme", MessageBoxButtons.YesNo) : MessageBox.Show($"{TBTcNo.Text}'kimlik numaralı yeni bir müstahsil eklemek istediğinize emin misiniz?", "Müstahsil Tanımlama", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        mustahsilServis.Data(ServisList.MustahsilEkleServis, new PocoMUSTAHSIL()
                        {
                            
                        });
                        MessageBox.Show($"{TBTcNo.Text}'kimlik numaralı müstahsil başarıyla eklendi!");
                    }
                }
                else
                    MessageBox.Show("Gerekli Alanları doldurmadan Müstahsil Ekeleyemezsiniz!");
            }
            else
                MessageBox.Show("TC Kimlik numarası 11 karakterden oluşmalı ve sadece rakamlardan oluşmalıdır.");
        }
    }
}
