using MEYPAK.BLL.Assets;
using MEYPAK.Entity.Models.STOK;
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
    public partial class FFATURASTOKOLCUESLE : Form
    {
        public FFATURASTOKOLCUESLE()
        {
            InitializeComponent();
            olcuBrServis = new GenericWebServis<MPOLCUBR>();
            faturaOlcuBrServis = new GenericWebServis<MPFATURASTOKOLCUBR>();
        }
        GenericWebServis<MPOLCUBR> olcuBrServis;
        GenericWebServis<MPFATURASTOKOLCUBR> faturaOlcuBrServis;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            faturaOlcuBrServis.Data(ServisList.FATURASTOKOLCUBREkleServis, new MPFATURASTOKOLCUBR()
            {
                OLCUBRID = olcuBrServis.obje.Where(x => x.ADI == lookUpEdit1.Text.ToString()).FirstOrDefault().ID,
                KISA = textEdit1.Text,
                USERID=MPKullanici.ID
            });
        }

        private void FFATURASTOKOLCUESLE_Load(object sender, EventArgs e)
        {
            olcuBrServis.Data(ServisList.OlcuBrListeServis);
            lookUpEdit1.Properties.DataSource = olcuBrServis.obje.Select(x => x.ADI);
        }
    }
}
