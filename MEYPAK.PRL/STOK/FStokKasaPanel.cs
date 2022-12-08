using MEYPAK.BLL.Assets;
using MEYPAK.BLL.STOK;
using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.DAL.Concrete.EntityFramework.Repository;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Depo;
using MEYPAK.Interfaces.Kasa;
using MEYPAK.Interfaces.Parametre;
using MEYPAK.Interfaces.Stok;
using MEYPAK.PRL.Assets;
using MEYPAK.PRL.STOK.StokKasa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEYPAK.PRL.STOK
{
    public partial class FStokKasaPanel : Form
    {
      
        public FStokKasaPanel()
        {
            InitializeComponent();
            _kasaServis = new GenericWebServis<PocoSTOKKASA>();
            _tempStokMarka = new PocoSTOKKASAMARKA();
            _stokKasaMarkaServis = new GenericWebServis<PocoSTOKKASAMARKA>();
        }

        #region Tanımlar
        GenericWebServis<PocoSTOKKASA>_kasaServis;
        PocoSTOKKASA _tempStokKasaPanel;
        FStokKasaMarkaList fStokKasaMarkaList;
        GenericWebServis<PocoSTOKKASAMARKA> _stokKasaMarkaServis;
        public PocoSTOKKASAMARKA _tempStokMarka;
      
        #endregion

        #region Metotlar

        public void Temizle(Control.ControlCollection ctrlCollection)           //Formdaki Textboxları temizle
        {
            foreach (Control ctrl in ctrlCollection)
            {
                if (ctrl is TextBoxBase)
                {
                    ctrl.Text = String.Empty;
                }
                else
                {
                    Temizle(ctrl.Controls);
                }
            }

        }

        private void BTKaydet_Click(object sender, EventArgs e)
        {
           
            _kasaServis.Data(ServisList.StokKasaEkleServis, new PocoSTOKKASA
            {
                kasakodu = TBKod.Text,
                kasaadi = TBAdi.Text,
                aciklama = TBAciklama.Text,
                markaid=_tempStokMarka.id,
                aktif =1,
                olusturmatarihi = DateTime.Now,
            });
            MessageBox.Show("Kasa Başarıyla Eklendi.");
            DataGridDoldur();
        }

        private void FKasaPanel_Load(object sender, EventArgs e)
        {
            DataGridDoldur();
            CombolariDoldur();
        }
        int id;
        void DataGridDoldur()
        {
            _kasaServis.Data(ServisList.StokKasaListeServis);
            _stokKasaMarkaServis.Data(ServisList.StokKasaMarkaListeServis);     
            DGKasaPanel.DataSource = _kasaServis.obje.Where(x => x.kayittipi == 0).Select(x => new
            {
                ID = x.id,
                Kodu = x.kasakodu,
                Adı = x.kasaadi,
                Açıklama = x.aciklama,
                markaid=x.markaid,id=x.id,  
                MarkaAdı= x.markaid==0?"":_stokKasaMarkaServis.obje.Where(z=>z.id==x.markaid).FirstOrDefault().adi.ToString(),
                //Aktif =x.aktif,
                OluşturmaTarihi = x.olusturmatarihi

            });
            gridView1.Columns["markaid"].Visible = false;
            gridView1.Columns["id"].Visible = false;
            //DGKasaPanel.Refresh();
            DGKasaPanel.RefreshDataSource();

        }

        void CombolariDoldur()
        {
            _kasaServis.Data(ServisList.StokKasaListeServis);
        }

        void KasaPanelBilgileriniGetir()
        {
            if (_tempStokKasaPanel != null)
            {
                _stokKasaMarkaServis.Data(ServisList.StokKasaMarkaListeServis);
                _tempStokMarka = _stokKasaMarkaServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("markaid").ToString()).FirstOrDefault();
                id = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
                TBKod.Text = gridView1.GetFocusedRowCellValue("Kodu").ToString();
                TBAdi.Text = gridView1.GetFocusedRowCellValue("Adı").ToString();
                buttonEdit1.Text = _stokKasaMarkaServis.obje.Where(z => z.id.ToString() == gridView1.GetFocusedRowCellValue("markaid").ToString()).Count() > 0 ? _stokKasaMarkaServis.obje.Where(z => z.id.ToString() == gridView1.GetFocusedRowCellValue("markaid").ToString()).FirstOrDefault().adi : "";
                TBAciklama.Text = gridView1.GetFocusedRowCellValue("Açıklama").ToString();
                CHBAktif.EditValue = _tempStokKasaPanel.aktif;
            }
        }


        private void BTSil_Click(object sender, EventArgs e)
        {
            if (_tempStokKasaPanel != null && _tempStokKasaPanel.id > 0)
            {
                _kasaServis.Data(ServisList.StokKasaDeleteByIdServis, id: _tempStokKasaPanel.id.ToString(), method: HttpMethod.Post);
                Temizle(this.Controls);
                MessageBox.Show($"{_tempStokKasaPanel.kasaadi} adlı kasa başarıyla silindi!");
                _tempStokKasaPanel = null;
                DataGridDoldur();
            }
            else
            {
                MessageBox.Show("Silinecek kasa bulunamadı!");
                Temizle(this.Controls);
            }


            //_kasaServis.Data(ServisList.StokKasaListeServis);
            //_kasaServis.Data(ServisList.StokKasaSilServis, null, null, _kasaServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).ToList());
            //MessageBox.Show("Silme işlemi Başarılı!");
            //DGKasaPanel.DataSource = _kasaServis.obje.Where(x => x.kayittipi == 0);
            //DataGridDoldur();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            _kasaServis.Data(ServisList.StokKasaListeServis);
            var asda = gridView1.GetFocusedRowCellValue("id").ToString();
            _tempStokKasaPanel = _kasaServis.obje.Where(x => x.id.ToString() == asda).FirstOrDefault();
            KasaPanelBilgileriniGetir();
        }

        private void buttonEdit1_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            fStokKasaMarkaList = new FStokKasaMarkaList(this.Tag.ToString(), "FStokKasa");
            fStokKasaMarkaList.ShowDialog();
            if (_tempStokMarka != null)
            {
                buttonEdit1.Text = _tempStokMarka.kod;
                textEdit1.Text = _tempStokMarka.adi;
            }
        }

        #endregion


    }
}
