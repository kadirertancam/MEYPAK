using MEYPAK.BLL.Assets;
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
    public partial class EFaturaParams : Form
    {
        public EFaturaParams()
        {
            InitializeComponent();
            eFaturaParamsServis = new GenericWebServis<PocoEFATURAPARAMS>();
        }
        GenericWebServis<PocoEFATURAPARAMS> eFaturaParamsServis;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            eFaturaParamsServis.Data(ServisList.EFaturaParamsListeServis);
            if (eFaturaParamsServis.obje.Count > 0)
                eFaturaParamsServis.Data(ServisList.EFaturaParamsEkleServis, new PocoEFATURAPARAMS()
                {
                    id = 1,
                    kuladi = yeniTextEdit1.Text,
                    sifre = yeniTextEdit2.Text, 
                    userid = MPKullanici.ID,
                });
            else
                eFaturaParamsServis.Data(ServisList.EFaturaParamsEkleServis, new PocoEFATURAPARAMS()
                { 
                    kuladi = yeniTextEdit1.Text,
                    sifre = yeniTextEdit2.Text,
                    userid=MPKullanici.ID,
                });
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            eFaturaParamsServis.Data(ServisList.EFaturaParamsListeServis);
            if (eFaturaParamsServis.obje.Count > 0)
                eFaturaParamsServis.Data(ServisList.EFaturaParamsGuncelleServis, new PocoEFATURAPARAMS()
                {
                    id = 1,
                    kuladi = yeniTextEdit1.Text,
                    sifre = yeniTextEdit2.Text,
                    userid = MPKullanici.ID,
                });
            else
                eFaturaParamsServis.Data(ServisList.EFaturaParamsEkleServis, new PocoEFATURAPARAMS()
                {
                    kuladi = yeniTextEdit1.Text,
                    sifre = yeniTextEdit2.Text,
                    userid = MPKullanici.ID,
                });
        }
    }
}
