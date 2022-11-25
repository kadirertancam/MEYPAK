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
using System.Net.Http;

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

        public PocoDEPO _tempDepo;
        GenericWebServis<PocoDEPO> _depoServis ;

        void Doldur()
        {
            if (_tempDepo != null)
            {
                
                TBKod.Text = _tempDepo.depokodu;
                TBAdi.Text = _tempDepo.depoadi;
                TBAciklama.Text = _tempDepo.aciklama;
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




        private void FDepoKart_Load(object sender, EventArgs e)
        {
            gridiDoldur();
        }

        void gridiDoldur()
        {
            _depoServis.Data(ServisList.DepoListeServis);
            GCDepoKart.DataSource = _depoServis.obje.Where(x => x.kayittipi == 0);
            gridView1.Columns["id"].Visible = false;
        }

        private void BTDepoKartEkle_Click(object sender, EventArgs e)
        {
            if (_tempDepo!=null && _tempDepo.id>0)
            {
            _depoServis.Data(ServisList.DepoEkleServis, (new PocoDEPO()
            {
                id = _tempDepo.id,
                depokodu = TBKod.Text,
                depoadi = TBAdi.Text,
                aciklama = TBAciklama.Text,

            }));
                gridiDoldur();
                Temizle(this.Controls);
                MessageBox.Show($"{_tempDepo.depoadi} adlı depo başarıyla güncellendi!");

                _tempDepo = null;
            }
            else
            {
                _depoServis.Data(ServisList.DepoEkleServis, (new PocoDEPO()
                {
                    depokodu = TBKod.Text,
                    depoadi = TBAdi.Text,
                    aciklama = TBAciklama.Text,

                }));
                gridiDoldur();
                MessageBox.Show($"{TBAdi.Text} adlı depo başarıyla eklendi!");
                Temizle(this.Controls);
                _tempDepo = null;
                
            }

        }

        private void BTDepoKartSec_Click(object sender, EventArgs e)
        {
            fDepoList = new FDepoList("FDepoKart");
            fDepoList.ShowDialog();
            Doldur();

        }

        private void BTDepoKartSil_Click(object sender, EventArgs e)
        {
            if (_tempDepo != null && _tempDepo.id > 0)
            {
                _depoServis.Data(ServisList.DepoDeleteByIdServis,id: _tempDepo.id.ToString(), method: HttpMethod.Post);
                Temizle(this.Controls);
                MessageBox.Show($"{_tempDepo.depoadi} adlı depo başarıyla silindi!");
                _tempDepo = null;
                gridiDoldur();
            }
            else
            {
                MessageBox.Show("Silinecek depo bulunamadı!");
                Temizle(this.Controls);
            }
        }

        private void GCDepoKart_DoubleClick(object sender, EventArgs e)
        {
            _tempDepo = _depoServis.obje.Where(x =>  x.id == Convert.ToInt32(gridView1.GetFocusedRowCellValue("id"))).FirstOrDefault();
            Doldur();
        }

        private void BTDepoTemizle_Click(object sender, EventArgs e)
        {
            Temizle(this.Controls);
            _tempDepo = null;
        }
    }
}
