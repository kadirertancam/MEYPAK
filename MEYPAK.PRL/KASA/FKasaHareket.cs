using DevExpress.CodeParser;
using DevExpress.XtraEditors;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.CARI;
using MEYPAK.Entity.PocoModels.FATURA;
using MEYPAK.Entity.PocoModels.KASA;
using MEYPAK.Entity.PocoModels.PARAMETRE;
using MEYPAK.Interfaces.Parametre;
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
    public partial class FKasaHareket : XtraForm
    {
        public FKasaHareket()
        {
            InitializeComponent();
            kasaHarServis=new GenericWebServis<PocoKASAHAR>();
            parabirimServis = new GenericWebServis<PocoPARABIRIM>();    
        }
        GenericWebServis<PocoKASAHAR> kasaHarServis;
        GenericWebServis<PocoPARABIRIM> parabirimServis;
       public PocoKASA _tempKasa;
       public PocoCARIKART _tempCari;
       public PocoFATURA _tempFatura;

        private void FKasaHareket_Load(object sender, EventArgs e)
        {
            parabirimServis.Data(ServisList.ParaBirimiListeServis);
            CBParaBirim.Properties.DataSource = parabirimServis.obje.Select(x => new { ADI = x.adi, ID = x.id });
            CBParaBirim.Properties.DisplayMember = "ADI";
            CBParaBirim.Properties.ValueMember = "ID";
            CBParaBirim.EditValue = 11638;
            radioGroup2.SelectedIndex = 1;
            TBKur.EditValue = 0;
            TBTutar.EditValue = 0;
            DTPTarih.EditValue = DateTime.Now;
        }

        private void BTNCariSec_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void BTNFaturaSec_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void BTNKasaSec_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FKasaList fKasaList = new FKasaList(this.Tag.ToString(),"FKasaHareket");
            fKasaList.ShowDialog();
            if (_tempKasa != null)
                BTNKasaSec.Text = _tempKasa.adi;
        }

        private void radioGroup1_Properties_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            GroupBoxlarıKapat();
            switch (radioGroup1.SelectedIndex)
            {
                case 0:
                    GBCari.Visible = true;
                    GBCari.Enabled = true;
                    break;
                case 1:
                    GBBanka.Visible = true;
                    GBBanka.Enabled = true;
                    break;
                case 2:
                    GBPersonel.Visible = true;
                    GBPersonel.Enabled = true;
                    break;
                case 3:
                    GBMuhtelif.Visible = true;
                    GBMuhtelif.Enabled = true;
                    break;
                case 4:
                    GBMuhasebe.Visible = true;
                    GBMuhasebe.Enabled = true;
                    break;
            }
        }

        void GroupBoxlarıKapat()
        {
            GBBanka.Visible= false;
            GBBanka.Enabled= false;
            GBMuhtelif.Visible = false;
            GBMuhtelif.Enabled = false;
            GBCari.Visible = false;
            GBCari.Enabled = false;
            GBMuhasebe.Visible = false;
            GBMuhasebe.Enabled = false;
            GBPersonel.Visible = false;
            GBPersonel.Enabled = false;
        }

        private void BTNKaydet_Click(object sender, EventArgs e)
        {
            if (_tempKasa!=null)
            {
                switch (radioGroup1.SelectedIndex)
                {
                    case 0: //CARI
                        if (_tempCari!=null && _tempFatura!=null)
                        {
                            kasaHarServis.Data(ServisList.KasaHarEkleServis, new PocoKASAHAR()
                            {
                                CARIID = _tempCari.id,
                                FATURAID = _tempFatura.id,
                                BELGENO = TBBelgeNo.Text,

                                TARIH = Convert.ToDateTime(DTPTarih.EditValue),
                                KASAID = _tempKasa.id,
                                IO =Convert.ToByte(radioGroup2.SelectedIndex),
                                TIP= 0,
                                PARABIRIMID = Convert.ToInt32(CBParaBirim.EditValue),
                                KUR = Convert.ToDecimal(TBKur.EditValue),
                                TUTAR = Convert.ToDecimal(TBTutar.EditValue),
                            }) ;
                        }
                        else
                            MessageBox.Show("Cari veya Fatura Seçmeden Hareket Giremezsiniz!");
                        break;
                    case 1: //BANKA
                        if (true/*tempbanka!=nul*/)
                        {
                            kasaHarServis.Data(ServisList.KasaHarEkleServis, new PocoKASAHAR()
                            {
                                //BANKAHESID = _tempBankaHesap.id,

                                TARIH = Convert.ToDateTime(DTPTarih.EditValue),
                                KASAID = _tempKasa.id,
                                IO = Convert.ToByte(radioGroup2.SelectedIndex),
                                TIP = 1,
                                PARABIRIMID = Convert.ToInt32(CBParaBirim.EditValue),
                                KUR = Convert.ToDecimal(TBKur.EditValue),
                                TUTAR = Convert.ToDecimal(TBTutar.EditValue),
                            }) ;
                        }
                        break;
                    case 2: //PERSONEL
                        if (true/*tempbanka!=nul*/)
                        {
                            kasaHarServis.Data(ServisList.KasaHarEkleServis, new PocoKASAHAR()
                            {

                                TARIH = Convert.ToDateTime(DTPTarih.EditValue),
                                KASAID = _tempKasa.id,
                                IO = Convert.ToByte(radioGroup2.SelectedIndex),
                                TIP = 2,
                                PARABIRIMID = Convert.ToInt32(CBParaBirim.EditValue),
                                KUR = Convert.ToDecimal(TBKur.EditValue),
                                TUTAR = Convert.ToDecimal(TBTutar.EditValue),
                            });
                        }
                        break;
                    case 3: //MUHTELIF
                        if (true/*tempbanka!=nul*/)
                        {
                            kasaHarServis.Data(ServisList.KasaHarEkleServis, new PocoKASAHAR()
                            {

                                TARIH = Convert.ToDateTime(DTPTarih.EditValue),
                                KASAID = _tempKasa.id,
                                IO = Convert.ToByte(radioGroup2.SelectedIndex),
                                TIP = 3,
                                PARABIRIMID = Convert.ToInt32(CBParaBirim.EditValue),
                                KUR = Convert.ToDecimal(TBKur.EditValue),
                                TUTAR = Convert.ToDecimal(TBTutar.EditValue),
                            });
                        }
                        break;
                    case 4: //MUHASEBE
                        if (true)
                        {
                            kasaHarServis.Data(ServisList.KasaHarEkleServis, new PocoKASAHAR()
                            {
                              
                                MUHID =Convert.ToInt32(TBMuhKodu.Text),


                                TARIH = Convert.ToDateTime(DTPTarih.EditValue),
                                KASAID = _tempKasa.id,
                                IO = Convert.ToByte(radioGroup2.SelectedIndex),
                                TIP = 4,
                                PARABIRIMID = Convert.ToInt32(CBParaBirim.EditValue),
                                KUR = Convert.ToDecimal(TBKur.EditValue),
                                TUTAR = Convert.ToDecimal(TBTutar.EditValue),
                            }) ;
                        }
                        break;
                }
            }
            else
                MessageBox.Show("Kasa Seçmeden Hareket Giremezsiniz!");
        }

 
    }
}
