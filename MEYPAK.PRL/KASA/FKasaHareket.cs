using DevExpress.CodeParser;
using DevExpress.XtraCharts.Designer.Native;
using DevExpress.XtraEditors;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.CARI;
using MEYPAK.Entity.PocoModels.FATURA;
using MEYPAK.Entity.PocoModels.KASA;
using MEYPAK.Entity.PocoModels.PARAMETRE;
using MEYPAK.Entity.PocoModels.PERSONEL;
using MEYPAK.Interfaces.Parametre;
using MEYPAK.PRL.CARI;
using MEYPAK.PRL.PERSONEL;
using MEYPAK.PRL.SIPARIS;
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
            kasaHarServis = new GenericWebServis<PocoKASAHAR>();
            parabirimServis = new GenericWebServis<PocoPARABIRIM>();
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
        }
        GenericWebServis<PocoKASAHAR> kasaHarServis;
        GenericWebServis<PocoPARABIRIM> parabirimServis;

        public PocoKASA _tempKasa;
        public PocoCARIKART _tempCari;
        public PocoFATURA _tempFatura;
        public PocoPERSONEL _tempPersonel;

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
            FCariList fCariList = new FCariList(this.Tag.ToString(), "FKasaHareket");
            fCariList.ShowDialog();
            if (_tempCari != null)
            {
                BTNCariSec.Text = _tempCari.kod;
                TBCariAdi.Text = _tempCari.adi != "" ? _tempCari.adi : _tempCari.unvan;
            }
        }

        private void BTNFaturaSec_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FFaturaList fFaturaList = new FFaturaList(this.Tag.ToString(), "FKasaHareket");
            fFaturaList.ShowDialog();
            //if (_tempFatura != null)
                //BTNFaturaSec.Text = _tempFatura.belgeno;
        }

        private void BTNKasaSec_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FKasaList fKasaList = new FKasaList(this.Tag.ToString(), "FKasaHareket");
            fKasaList.ShowDialog();
            if (_tempKasa != null)
                BTNKasaSec.Text = _tempKasa.adi;
            GridiDoldur();

        }

        private void BTNPersonelSec_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FPersonelList fPersonelList = new FPersonelList(this.Tag.ToString(), "FKasaHareket");
            fPersonelList.ShowDialog();
            if (_tempPersonel != null)
                BTNPersonelSec.Text = _tempPersonel.adisoyadi;
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

        void GridiDoldur()
        {
            if (_tempKasa != null)
            {
                kasaHarServis.Data(ServisList.KasaHarListeServis);
                GCKasaHareket.DataSource = kasaHarServis.obje.Where(x => x.KASAID == _tempKasa.id).Reverse();
            }
            else
            {
                GCKasaHareket.DataSource = "";
            }
        }

        void GroupBoxlarıKapat()
        {
            GBBanka.Visible = false;
            GBBanka.Enabled = false;
            GBMuhtelif.Visible = false;
            GBMuhtelif.Enabled = false;
            GBCari.Visible = false;
            GBCari.Enabled = false;
            GBMuhasebe.Visible = false;
            GBMuhasebe.Enabled = false;
            GBPersonel.Visible = false;
            GBPersonel.Enabled = false;
        }
        void FormuTemizle()
        {
            foreach (var ctrl in panelControl6.Controls)
            {
                BaseEdit editor = ctrl as BaseEdit;
                if (editor != null)
                    editor.EditValue = null;
            }
            foreach (var ctrl in panelControl7.Controls)
            {
                BaseEdit editor = ctrl as BaseEdit;
                if (editor != null)
                    editor.EditValue = null;
            }
            foreach (var ctrl in panelControl2.Controls)
            {
                BaseEdit editor = ctrl as BaseEdit;
                if (editor != null)
                    editor.EditValue = null;
            }
            _tempKasa = null;
            _tempCari = null;
            _tempFatura = null;
            _tempPersonel = null;

        }

        private void BTNKaydet_Click(object sender, EventArgs e)
        {
            if (_tempKasa != null)
            {
                switch (radioGroup1.SelectedIndex)
                {
                    case 0: //CARI
                        if (_tempCari != null)
                        {
                            kasaHarServis.Data(ServisList.KasaHarEkleServis, new PocoKASAHAR()
                            {
                                CARIID = _tempCari.id,
                               

                                TARIH = Convert.ToDateTime(DTPTarih.EditValue),
                                KASAID = _tempKasa.id,
                                IO = Convert.ToByte(radioGroup2.SelectedIndex),
                                TIP = 0,
                                PARABIRIMID = Convert.ToInt32(CBParaBirim.EditValue),
                                KUR = Convert.ToDecimal(TBKur.EditValue),
                                TUTAR = Convert.ToDecimal(TBTutar.EditValue),
                            });
                            MessageBox.Show("Hareket Başarıyla Eklendi.");
                            FormuTemizle();
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
                            });
                            MessageBox.Show("Hareket Başarıyla Eklendi.");
                            FormuTemizle();
                        }
                        break;
                    case 2: //PERSONEL
                        if (_tempPersonel != null)
                        {
                            kasaHarServis.Data(ServisList.KasaHarEkleServis, new PocoKASAHAR()
                            {
                                PERSONELID = _tempPersonel.id,

                                TARIH = Convert.ToDateTime(DTPTarih.EditValue),
                                KASAID = _tempKasa.id,
                                IO = Convert.ToByte(radioGroup2.SelectedIndex),
                                TIP = 2,
                                PARABIRIMID = Convert.ToInt32(CBParaBirim.EditValue),
                                KUR = Convert.ToDecimal(TBKur.EditValue),
                                TUTAR = Convert.ToDecimal(TBTutar.EditValue),
                            });
                            MessageBox.Show("Hareket Başarıyla Eklendi.");
                            FormuTemizle();
                        }
                        else
                            MessageBox.Show("Personel Seçmeden Hareket Giremezsiniz!");
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
                            MessageBox.Show("Hareket Başarıyla Eklendi.");
                            FormuTemizle();
                        }
                        break;
                    case 4: //MUHASEBE
                        if (true)
                        {
                            kasaHarServis.Data(ServisList.KasaHarEkleServis, new PocoKASAHAR()
                            {

                                MUHID = Convert.ToInt32(TBMuhKodu.Text),


                                TARIH = Convert.ToDateTime(DTPTarih.EditValue),
                                KASAID = _tempKasa.id,
                                IO = Convert.ToByte(radioGroup2.SelectedIndex),
                                TIP = 4,
                                PARABIRIMID = Convert.ToInt32(CBParaBirim.EditValue),
                                KUR = Convert.ToDecimal(TBKur.EditValue),
                                TUTAR = Convert.ToDecimal(TBTutar.EditValue),
                            });
                            MessageBox.Show("Hareket Başarıyla Eklendi.");
                            FormuTemizle();
                        }
                        break;
                }
            }
            else
                MessageBox.Show("Kasa Seçmeden Hareket Giremezsiniz!");
        }

        private void gridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            string quantity = Convert.ToString(gridView1.GetRowCellValue(e.RowHandle, "IO"));

            if (quantity == "0")
            {
                e.Appearance.BackColor = Color.Red;
            }
            else
            {
                e.Appearance.BackColor = Color.LightGreen;
            }
        }
    }
}
