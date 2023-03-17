using DevExpress.Text.Interop;
using DevExpress.XtraEditors;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.Models.FORMYETKI;
using MEYPAK.Entity.PocoModels.PARAMETRE;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Parametre;
using MEYPAK.Interfaces.Stok;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Xml;
using Control = System.Windows.Forms.Control;

namespace MEYPAK.PRL.PARAMETRELER
{
    public partial class FParaBirimi : XtraForm
    {

        string islemtipi = "Kayıt";
        public FParaBirimi()
        {
            InitializeComponent();
            _paraBirimServis = new GenericWebServis<PocoPARABIRIM>();
        }
        GenericWebServis<PocoPARABIRIM> _paraBirimServis;
        Url parabirim;
        Main main;
        private void FParaBirimi_Load(object sender, EventArgs e)
        {
            //  DataGridDoldur();
            main =(Main) Application.OpenForms["Main"];
            DGParaBrm.DataSource = main._tarih_Date.Currency;
        }
       
        int id;

        void DataGridDoldur()
        {
            _paraBirimServis.Data(ServisList.ParaBirimiListeServis);
            DGParaBrm.DataSource = _paraBirimServis.obje.Where(x => x.kayittipi == 0).Select(x => new { x.id, x.adi, x.kisaadi, x.olusturmatarihi });
            DGParaBrm.Refresh();
            DGParaBrm.RefreshDataSource();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            TBParaBrm.Text = gridView1.GetFocusedRowCellValue("adi").ToString();
            TBKisaltma.Text = gridView1.GetFocusedRowCellValue("kisaadi").ToString();
            id = int.Parse(gridView1.GetFocusedRowCellValue("id").ToString());
            islemtipi = "Güncelleme";
        }

        private void BTKaydet_Click(object sender, EventArgs e)
        {
            if (MPKullanici.YetkiGetir(AllForms.PARABIRIMLERI.ToString()).EKLE)
            {
            if (islemtipi == "Kayıt")
            {
                _paraBirimServis.Data(ServisList.ParaBirimiEkleServis, (new PocoPARABIRIM()
                {
                    adi = TBParaBrm.Text,
                    kisaadi = TBKisaltma.Text,
                    aktif=1,
                    userid = MPKullanici.ID,
                }));

            }
            else
                _paraBirimServis.Data(ServisList.ParaBirimiEkleServis, (new PocoPARABIRIM()
                {
                    id = id,
                    adi = TBParaBrm.Text,
                    kisaadi = TBKisaltma.Text,
                    aktif=1,
                    userid = MPKullanici.ID,
                }));
            MessageBox.Show("Kayıt Başarılı.");
            id = 0;
            DataGridDoldur();
            }
            else
                MessageBox.Show(MPKullanici.hata);
        }

        private void BTSil_Click(object sender, EventArgs e)
        {
            if (MPKullanici.YetkiGetir(AllForms.PARABIRIMLERI.ToString()).SIL)
            {
            _paraBirimServis.Data(ServisList.ParaBirimiListeServis);
            _paraBirimServis.Data(ServisList.ParaBirimiSilServis, null, null, _paraBirimServis.obje.Where(x => x.adi.ToString() == gridView1.GetFocusedRowCellValue("adi").ToString()).ToList());
            MessageBox.Show("Silme Başarılı");
            DGParaBrm.DataSource = _paraBirimServis.obje.Where(x => x.kayittipi == 0);
            DataGridDoldur();
            }
            else
                MessageBox.Show(MPKullanici.hata);
        }

        public void Temizle(Control.ControlCollection ctrlCollection) //Formdaki textboxları temizler
        {

            foreach (Control ctrl in ctrlCollection)
            {
                if (ctrl is TextEdit)
                {
                    if (ctrl.Name != "TBParaBrm")
                    {
                        ctrl.Text = String.Empty;
                    }

                    else if (ctrl.Name != "TBKisaltma")
                    {
                        ctrl.Text = String.Empty;
                    }

                }
                else
                {
                    Temizle(ctrl.Controls);
                }
            }

        }

    }

}

