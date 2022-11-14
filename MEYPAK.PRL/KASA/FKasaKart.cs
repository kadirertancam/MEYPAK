using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.KASA;
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

namespace MEYPAK.PRL.KASA
{
    public partial class FKasaKart : Form
    {
       GenericWebServis<PocoKASA> _kasaServis;
        GenericWebServis<PocoPARABIRIM> _parabirimServis;
        public FKasaKart()
        {
            InitializeComponent();
            _kasaServis = new GenericWebServis<PocoKASA>();
            _kasaServis.Data(ServisList.KasaListeServis);
             gridControl1.DataSource = _kasaServis.obje;
            _parabirimServis = new GenericWebServis<PocoPARABIRIM>();
            _parabirimServis.Data(ServisList.ParaBirimiListeServis);
            CBParaBirim.Properties.DataSource = _parabirimServis.obje.Select(x=> x.adi);
        }

       
        private void BTNKaydet_Click(object sender, EventArgs e)
        {
            _kasaServis.Data(ServisList.KasaEkleServis, new PocoKASA()
            {
                adi = TBAdi.Text,
                aciklama = TBAciklama.Text,
                kod = TBKod.Text,
                parabirimid = _parabirimServis.obje.Where(x => x.adi == CBParaBirim.EditValue.ToString()).FirstOrDefault().id,
                tarih = (DateTime)DTPTarih.EditValue,
                tutar = Convert.ToInt32(TBTutar.Text),
                durum = Convert.ToByte(CEAktif.EditValue),
            }) ;

        }
    }
}
