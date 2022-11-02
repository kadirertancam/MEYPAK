using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.SIPARIS;
using MEYPAK.Interfaces.Stok;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEYPAK.PRL.SIPARIS
{
    public partial class FMusteriSiparisList : Form
    {
        string _islem;
        FMusteriSiparis fmusteriSiparis;
        GenericWebServis<PocoSIPARIS> _mSiparisServis;
        public FMusteriSiparisList(string islem="")
        {
            InitializeComponent();
            _islem = islem;
            _mSiparisServis = new GenericWebServis<PocoSIPARIS>();
        }

        private void FMusteriSiparisList_Load(object sender, EventArgs e)
        {
            fmusteriSiparis = (FMusteriSiparis)Application.OpenForms["FMusteriSiparis"];
            _mSiparisServis.Data(ServisList.SiparisListeServis);
            dataGridView1.DataSource = _mSiparisServis.obje;
        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _mSiparisServis.Data(ServisList.SiparisListeServis);
            if (_islem == "Siparis")
            {
                if (fmusteriSiparis != null)
                {
                    fmusteriSiparis._tempSiparis = _mSiparisServis.obje.Where(x => x.id.ToString() == dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()).FirstOrDefault();
                }

            }
            this.Close();
        }
    }
}
