using MEYPAK.BLL.STOK;
using MEYPAK.DAL.Concrete.EntityFramework.Repository;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Interfaces.Stok;
using MEYPAK.PRL.Assets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.Models.STOK;
using DevExpress.XtraEditors;
using MEYPAK.Entity.PocoModels.FORMYETKI;
using MEYPAK.Entity.Models.FORMYETKI;

namespace MEYPAK.PRL.STOK
{
    public partial class FOlcuBrKart : XtraForm
    {
        string islemtipi = "Kayıt";
        public FOlcuBrKart()
        {
            InitializeComponent();
            _OlcuBrServis = new GenericWebServis<PocoOLCUBR>();
            _StokOlcuBrServis = new GenericWebServis<PocoSTOKOLCUBR>();
        }
        GenericWebServis<PocoOLCUBR> _OlcuBrServis ;
        GenericWebServis<PocoSTOKOLCUBR> _StokOlcuBrServis ;
        PocoFORMYETKI formyetki = MPKullanici.YetkiGetir(AllForms.OLCUBIRIMTANIM.ToString());
        private void FStokOlcuBrKart_Load(object sender, EventArgs e)
        {
            DataGridDoldur();
        }
        int id;
      
        void DataGridDoldur()
        {
            _OlcuBrServis.Data(ServisList.OlcuBrListeServis); 
            DGOlcuBirim.DataSource = _OlcuBrServis.obje.Where(x=>x.kayittipi==0).Select(x=> new 
            {
                ID=x.id,
                BirimAdı=x.adi,
                Birim=x.birim,
                OluşturmaTarihi=x.olusturmatarihi});
            DGOlcuBirim.Refresh();
            DGOlcuBirim.RefreshDataSource();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            TBAdi.Text = gridView1.GetFocusedRowCellValue("BirimAdı").ToString();
            TBOlcuBirim.Text = gridView1.GetFocusedRowCellValue("Birim").ToString();
            islemtipi = "Güncelleme";
        }

        private void BTKaydet_Click(object sender, EventArgs e)
        {
            if (formyetki.EKLE==true)
            {

          
            if (islemtipi == "Kayıt")
            {
                if (_OlcuBrServis.obje.Where(x=>x.kayittipi==0 && x.adi == TBAdi.Text).Count()==0)
                {
                _OlcuBrServis.Data(ServisList.OlcuBrEkleServis, (new PocoOLCUBR()
                {
                    adi = TBAdi.Text,
                    birim = TBOlcuBirim.Text,
                    userid = MPKullanici.ID,
                }));
                }
                else
                {
                    MessageBox.Show("Bu isimde zaten bir Ölçü Birim Bulunmaktadır!");
                }

            }
            else
                _OlcuBrServis.Data(ServisList.OlcuBrEkleServis, (new PocoOLCUBR()
                {
                    id = id,
                    adi = TBAdi.Text,
                    birim = TBOlcuBirim.Text,
                    userid = MPKullanici.ID,
                }));
            MessageBox.Show("Kayıt Başarılı.");
            id = 0;
            DataGridDoldur();
            }
            MessageBox.Show("Kayıt Eklemek için yetkiniz bulunmamaktadır! Lütfen Yöneticinize başvurunuz.");
        }
         
        private void BTSil_Click(object sender, EventArgs e)
        {
            _OlcuBrServis.Data(ServisList.OlcuBrListeServis);
            _StokOlcuBrServis.Data(ServisList.StokOlcuBrListeServis);
            if (_StokOlcuBrServis.obje.Where(x=> x.olcubrid.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).Count()==0)
            {
                _OlcuBrServis.Data(ServisList.OlcuBrSilServis, null, null, _OlcuBrServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).ToList());
                MessageBox.Show("Silme Başarılı");
                DGOlcuBirim.DataSource = _OlcuBrServis.obje.Where(x => x.kayittipi == 0);
                DataGridDoldur();
            }
            else
            {
                MessageBox.Show("Stok ile bağlantılı olan ölçü birim silinemez! ");
            }
           
        }

       

    }
}