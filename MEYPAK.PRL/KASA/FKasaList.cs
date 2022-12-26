using MEYPAK.BLL.Assets;
using MEYPAK.Interfaces.Personel;
using MEYPAK.PRL.PERSONEL.Raporlar;
using MEYPAK.PRL.PERSONEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MEYPAK.Entity.PocoModels.KASA;

namespace MEYPAK.PRL.KASA
{
    public partial class FKasaList : Form
    {
        public FKasaList(string tag ="",string form="")
        {
            InitializeComponent();
            _tag  = tag;
            _form = form;
            kasaServis = new GenericWebServis<PocoKASA>();
        }
        string _tag;
        string _form;
        GenericWebServis<PocoKASA> kasaServis;
        FKasaHareket fKasaHareket;

        private void FKasaList_Load(object sender, EventArgs e)
        {
            kasaServis.Data(ServisList.KasaListeServis);
            GCKasa.DataSource = kasaServis.obje;
            gridView1.Columns["id"].Visible = false;
         

            foreach (Form frm in Application.OpenForms)
            {
                if (_tag == frm.Tag)
                {
                    if (frm.Name.Contains("FKasaHareket"))
                        fKasaHareket = (FKasaHareket)frm;
                
                }
            }
        }

        private void GCKasa_DoubleClick(object sender, EventArgs e)
        {
            if (_form == "FKasaHareket")
            {
                fKasaHareket._tempKasa = kasaServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("id").ToString()).FirstOrDefault();
            }
            this.Close();
        }
    }
}
