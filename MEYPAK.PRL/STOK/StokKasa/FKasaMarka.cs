using MEYPAK.BLL.Assets;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels.STOK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEYPAK.PRL.STOK.StokKasa
{
    public partial class FKasaMarka : Form
    {
        public FKasaMarka()
        {
            InitializeComponent();
            _stokKasaMarakServis = new GenericWebServis<PocoSTOKKASAMARKA>();
        }
        GenericWebServis<PocoSTOKKASAMARKA> _stokKasaMarakServis;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            _stokKasaMarakServis.Data(ServisList.StokKasaMarkaEkleServis,new PocoSTOKKASAMARKA()
            {
                adi=textEdit1.Text,
                kod=textEdit2.Text
            });


        }
    }
}
