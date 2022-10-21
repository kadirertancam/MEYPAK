using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.SIPARIS;
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
        public FMusteriSiparisList(string islem)
        {
            InitializeComponent();
            _islem = islem;
            _mSiparisServis = new GenericWebServis<PocoSIPARIS>();
        }

        private void FMusteriSiparisList_Load(object sender, EventArgs e)
        {
            fmusteriSiparis = (FMusteriSiparis)Application.OpenForms["FMusteriSiparis"];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _mSiparisServis.Data(ServisList.SiparisListeServis);
            if (_islem=="Siparis")
            {
                if (fmusteriSiparis !=null)
                {
                    
                }

            }
                
        }
    }
}
