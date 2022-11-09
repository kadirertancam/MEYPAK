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
    public partial class FParaBirimi : Form
    {
        public FParaBirimi()
        {
            InitializeComponent();
            _paraBirimServis = new GenericWebServis<PocoPARABIRIM>();
        }
        GenericWebServis<PocoPARABIRIM> _paraBirimServis;
        private void BTKaydet_Click(object sender, EventArgs e)
        {
          // _paraBirimServis.Data(ServisList);
        }

      
    }
}
