using MEYPAK.BLL.STOK;
using MEYPAK.DAL.Concrete.EntityFramework.Repository;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models;
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
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.STOK;
using DevExpress.XtraEditors;
using DevExpress.Utils;
using MEYPAK.Interfaces.Parametre;
using DevExpress.Text.Interop;
using MEYPAK.Entity.PocoModels.DEPO;
using MEYPAK.Entity.Models.FORMYETKI;

namespace MEYPAK.PRL.STOK
{
    public partial class FStokSayim : XtraForm
    {
        public FStokSayim()
        {
            InitializeComponent();
            _stokSayimServis = new GenericWebServis<PocoSTOKSAYIM>();
            _stokSayimServis.Data(ServisList.StokSayimListeServis);
            _stokSayimHarServis = new GenericWebServis<PocoSTOKSAYIMHAR>();
            _stokSayimHarServis.Data(ServisList.StokSayimHarListeServis);
            _stokServis = new GenericWebServis<PocoSTOK>();
            _stokServis.Data(ServisList.StokListeServis);
            _depoServis = new GenericWebServis<PocoDEPO>();
        }
        GenericWebServis<PocoSTOKSAYIM> _stokSayimServis ;
        GenericWebServis<PocoSTOKSAYIMHAR> _stokSayimHarServis ;
        GenericWebServis<PocoSTOK> _stokServis ;
        GenericWebServis<PocoDEPO> _depoServis;
        FStokSayimPanel stokSayimPanel;
        public PocoSTOKSAYIM _tempStokSayim;

        private void FStokSayim_Load(object sender, EventArgs e)
        {
            CombolariDoldur();
            DataGridDoldur();
        }
        int _tempId = 0;
        private void BTKaydet_Click(object sender, EventArgs e)
        {
            if (MPKullanici.YetkiGetir(AllForms.SAYIMTANIM.ToString()).EKLE==true)
            {
            int a = 0;
            int.TryParse(CBDepo.EditValue!=null?CBDepo.EditValue.ToString():"0", out a);

            if (_depoServis.obje.Where(x=>x.id == a && x.kayittipi==0).Count()>0)
            {
            _stokSayimServis.Data(ServisList.StokSayimEkleServis, (new Entity.PocoModels.STOK.PocoSTOKSAYIM()
            {
                sayimtarihi = Convert.ToDateTime(DTSayimTar.EditValue.ToString()),
                aciklama = TBAciklama.Text,
                depoid = Convert.ToInt32(CBDepo.EditValue),
                userid = MPKullanici.ID,
            }));
            _tempStokSayim = _stokSayimServis.obje2;

                stokSayimPanel = new FStokSayimPanel(_tempStokSayim, this.Tag.ToString());


            stokSayimPanel.ShowDialog();
           DataGridDoldur();
                //stokSayimPanel.sayimId = _stokSayimServis.obje.Where(x => x.aciklama == TBAciklama.Text).FirstOrDefault().id;
                //TBAciklama.Text = "";
                //DTSayimTar.EditValue = DateTime.Now;
            }
            else
            {
                MessageBox.Show("Lütfen Geçerli bir depo seçiniz!");
                }
            }
            else
                MessageBox.Show(MPKullanici.hata);

        }

        private void BTSil_Click(object sender, EventArgs e)
        {
            if (MPKullanici.YetkiGetir(AllForms.SAYIMTANIM.ToString()).SIL==true)
            {
            _stokSayimServis.Data(ServisList.StokSayimListeServis);
            _stokSayimServis.Data(ServisList.StokSayimSilServis, null, null, _stokSayimServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).ToList());
            MessageBox.Show("Silme işlemi Başarılı");
            DataGridDoldur();
            }
            else
                MessageBox.Show(MPKullanici.hata);
        }

        //private void BTDuzenle_Click(object sender, EventArgs e)
        //{
        //    stokSayimPanel = new FStokSayimPanel("düzenle");
        //    var a = _stokSayimHarServis.obje.Where(x => x.stoksayimid == _tempId);
        //    stokSayimPanel._tempStokSayimHarList = a.Select(x => new Entity.PocoModels.PocoStokSayimPanelList() { StokAdı = _stokServis.obje.Where(z => z.id == x.stokid).FirstOrDefault().adi, StokKodu = _stokServis.obje.Where(z => z.id == x.stokid).FirstOrDefault().kod, Birim = _olcuBrServis.obje.Where(z => z.id == x.birimid).FirstOrDefault().adi, Fiyat = x.fiyat, Miktar = x.miktar }).ToList();
        //    stokSayimPanel.ShowDialog();
        //}

        void DataGridDoldur() 
        {
            _depoServis.Data(ServisList.DepoListeServis);
            _stokSayimServis.Data(ServisList.StokSayimListeServis);
            DTSayimTar.EditValue = DateTime.Now;
            DGStokSayim.DataSource = _stokSayimServis.obje.Where(x => x.kayittipi == 0 && x.durum == 0).Select(x => new
            {
                ID = x.id,
                SayimTarihi = x.sayimtarihi,
                Depo = _depoServis.obje.Where(y => y.id == x.depoid).Count() > 0 ? _depoServis.obje.Where(y => y.id == x.depoid).FirstOrDefault().depoadi : "",
                Açıklama = x.aciklama,

            });
            DGStokSayim.Refresh();
            DGStokSayim.RefreshDataSource();

            //gridView1.Columns["firmaid"].Visible = false;
            //gridView1.Columns["subeid"].Visible = false;
            //gridView1.Columns["depoid"].Visible = false;
            //gridView1.Columns["id"].Visible = false;
            //gridView1.Columns["kayittipi"].Visible = false;
            //gridView1.Columns["eskiid"].Visible = false;
            //gridView1.Columns["olusturmatarihi"].Visible = false;
            //gridView1.Columns["guncellemetarihi"].Visible = false;

        }
        private void DGStokSayim_DoubleClick(object sender, EventArgs e)
        {
            _tempStokSayim = _stokSayimServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();

            stokSayimPanel = new FStokSayimPanel(_tempStokSayim, this.Tag.ToString());

            stokSayimPanel.ShowDialog();

        }
        void BilgileriGetir()
        {
            if (_stokSayimServis != null)
            {
                _tempId = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
                DTSayimTar.EditValue = Convert.ToDateTime(gridView1.GetFocusedRowCellValue("SayimTarihi").ToString());
                TBAciklama.Text = gridView1.GetFocusedRowCellValue("Açıklama").ToString();
                CBDepo.EditValue = _depoServis.obje.Where(x => x.depoadi == gridView1.GetFocusedRowCellValue("Depo").ToString()).Count() > 0 ? _depoServis.obje.Where(x => x.depoadi == gridView1.GetFocusedRowCellValue("Depo").ToString()).FirstOrDefault().id : 0;
            }
        }

        void CombolariDoldur()
        {
            _depoServis.Data(ServisList.DepoListeServis);
            CBDepo.Properties.DataSource = _depoServis.obje.Where(x => x.kayittipi == 0 && x.aktif==1).Select(x => new { ID = x.id, ADI = x.depoadi });
            CBDepo.Properties.ValueMember = "ID";
            CBDepo.Properties.DisplayMember = "ADI";
        }

        private void gridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            string quantity = Convert.ToString(gridView1.GetRowCellValue(e.RowHandle, "Durum"));

            if (quantity == "Onaylanmadı")
            {
                e.Appearance.BackColor = Color.Red;
            }
            else
            {
                e.Appearance.BackColor = Color.LightGreen;
            }

        }

        

        private void BTDuzenle_Click(object sender, EventArgs e)
        {

        }
    }
}
