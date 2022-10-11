using MEYPAK.Entity.Models;
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
    public partial class FIrsaliyeOlustur : Form
    {
       public List<MPSIPARISDETAY> _tempSiparisDetay = new List<MPSIPARISDETAY>();
        public FIrsaliyeOlustur()
        {
            InitializeComponent();
        }

        private void FIrsaliyeOlustur_Load(object sender, EventArgs e)
        {
            // siparis detayı irsaliye detaya çevir.
        }
    }
}
