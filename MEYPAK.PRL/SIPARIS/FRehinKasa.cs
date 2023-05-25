using DevExpress.XtraTab;
using MEYPAK.Entity.PocoModels;
using MEYPAK.Entity.PocoModels.FATURA;
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
    public partial class FRehinKasa : Form
    {
        public FRehinKasa(PocoFATURA _tempFaturas = null, List<PocoFaturaKalem> _tempFaturaDetays = null, List<ListKasaList> _tempkasa = null )
        {
            InitializeComponent();
            fatura=_tempFaturas;
            faturakalem = _tempFaturaDetays; 
        }
        PocoFATURA fatura;
        List<PocoFaturaKalem> faturakalem;
        List<ListKasaList> kasaList;
        private void FRehinKasa_Load(object sender, EventArgs e)
        {
          var kasalar=  faturakalem.Where(x => x.Tipi == "KASA");
            gridControl1.DataSource = kasalar.Select(x => new KasaTEMP { KASAKOD = x.StokKodu, KASAADI = x.StokAdı, ADET = x.Safi, FIYAT = 0 })
        ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var main = (Main)Application.OpenForms["Main"];
            XtraTabPage page = new XtraTabPage();
            FAlisFatura ffatura = new FAlisFatura(fatura, faturakalem,null, 1);
            page.Name = "TPAlisFatura" + main.i;
            page.Text = "Alış Fatura Tanım";
            page.Tag = "TPAlisFatura" + main.i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            main.Anasayfa.TabPages.Add(page);
            main.Anasayfa.SelectedTabPage = page;

            ffatura.TopLevel = false;
            ffatura.AutoScroll = true;
            ffatura.Dock = DockStyle.Fill;
            ffatura.Tag = "TPAlisFatura" + main.i;
            page.Controls.Add(ffatura);
            ffatura.Show();
            main.i++;
            this.Close();
        }
    }
    public class KasaTEMP
    {
        public string KASAKOD { get; set; }
        public string KASAADI { get; set; }
        public decimal ADET { get; set; }
        public decimal FIYAT { get; set; }
    }
}
