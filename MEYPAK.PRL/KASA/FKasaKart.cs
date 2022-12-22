using DevExpress.CodeParser;
using DevExpress.XtraEditors;
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
    public partial class FKasaKart : XtraForm
    {
        GenericWebServis<PocoKASA> _kasaServis;
        GenericWebServis<PocoPARABIRIM> _parabirimServis;
        PocoKASA _tempkasa;
        public FKasaKart()
        {
            InitializeComponent();
            _kasaServis = new GenericWebServis<PocoKASA>();
            _parabirimServis = new GenericWebServis<PocoPARABIRIM>();
            _parabirimServis.Data(ServisList.ParaBirimiListeServis);
            CBParaBirim.Properties.DataSource = _parabirimServis.obje.Select(x => new { ADI=x.adi ,ID=x.id }).ToList();
            CBParaBirim.Properties.ValueMember = "ID";
            CBParaBirim.Properties.DisplayMember = "ADI";
            KasalariGetir();
        }



       
        private void BTNKaydet_Click(object sender, EventArgs e)
        {
            _kasaServis.Data(ServisList.KasaEkleServis, new PocoKASA()
            {
                adi = TBAdi.Text,
                aciklama = TBAciklama.Text,
                kod = TBKod.Text,
                parabirimid = _parabirimServis.obje.Where(x => x.id == Convert.ToInt32(CBParaBirim.EditValue)).FirstOrDefault().id,
                tarih = (DateTime)DTPTarih.EditValue,
              
                durum = Convert.ToByte(CEAktif.EditValue)
            });
            MessageBox.Show("Kasa Başarıyla Eklendi.");
            KasalariGetir();
        }

        void KasalariGetir()
        {
            _kasaServis.Data(ServisList.KasaListeServis);
            gridControl1.DataSource = _kasaServis.obje;
        }
        void KasayıDoldur()
        {
            if (_tempkasa!=null)
            {
                TBAdi.Text = _tempkasa.adi;
                TBAciklama.Text = _tempkasa.aciklama;
                TBKod.Text = _tempkasa.kod;
               
                DTPTarih.EditValue = _tempkasa.tarih;
                CEAktif.Checked = _tempkasa.durum !=0 ? true:false;
                CBParaBirim.EditValue = _tempkasa.parabirimid;
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            _tempkasa = _kasaServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("id").ToString()).FirstOrDefault();
            KasayıDoldur();
        }
    }
}
