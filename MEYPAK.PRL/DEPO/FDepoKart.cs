using MEYPAK.BLL.DEPO;
using MEYPAK.DAL.Concrete.EntityFramework.Repository;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Interfaces.Depo;
using MEYPAK.PRL.Assets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Entity.PocoModels.DEPO;
using MEYPAK.BLL.Assets;

namespace MEYPAK.PRL.DEPO
{
    public partial class FDepoKart : Form
    {
        public FDepoKart()
        {
            InitializeComponent();
            _depoServis = new GenericWebServis<PocoDEPO>();
        }
        FDepoList fDepoList;
        int id=0;
        public PocoDEPO _tempDepo;
        GenericWebServis<PocoDEPO> _depoServis ;

        void Doldur()
        {
            if (_tempDepo != null)
            {
                _depoServis = new GenericWebServis<PocoDEPO>();
               BTKodSec.Text = _tempDepo.depokodu; //? 
                TBAdi.Text = _tempDepo.depoadi;
                TBAciklama.Text = _tempDepo.aciklama;
                id = _tempDepo.id;
                _tempDepo = null;
            }
        }
        public void Temizle(Control.ControlCollection ctrlCollection)           //Formdaki Textboxları temizle
        {
            foreach (Control ctrl in ctrlCollection)
            {
                if (ctrl is TextBoxBase)
                { 
                        ctrl.Text = String.Empty;
                }
                else
                {
                    Temizle(ctrl.Controls);
                }
            }
        }


        private void BTEkle_Click(object sender, EventArgs e)
        {
            _depoServis.Data(ServisList.DepoEkleServis,(new PocoDEPO()
            {
                id = id,
                depokodu = BTKodSec.EditValue.ToString(),
                depoadi = TBAdi.Text,
                aciklama =TBAciklama.Text,
                
            }));
            _depoServis.Data(ServisList.DepoListeServis);
            DGDepoKart.DataSource = _depoServis.obje;
            Temizle(this.Controls);
        }
        
        private void BTKodSec_Click(object sender, EventArgs e)
        {
            fDepoList = new FDepoList("FDepoKart");
            fDepoList.ShowDialog();
            Doldur();
        }

        private void FDepoKart_Load(object sender, EventArgs e)
        {
            _depoServis.Data(ServisList.DepoListeServis);
            DGDepoKart.DataSource = _depoServis.obje;
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _tempDepo = _depoServis.obje.Where(x => x.depokodu == gridView1.GetFocusedRowCellValue("depokodu").ToString()).FirstOrDefault();
            Doldur();
        }

        private void BTSil_Click(object sender, EventArgs e)
        {
            _depoServis.Data(ServisList.DepoSilServis,(_depoServis.obje.Where(x => x.id == Convert.ToInt32(gridView1.GetFocusedRowCellValue("id"))).FirstOrDefault()));
        }
    }
}
