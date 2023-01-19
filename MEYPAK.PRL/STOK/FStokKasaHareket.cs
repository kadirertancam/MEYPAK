using DevExpress.XtraEditors;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.CARI;
using MEYPAK.Entity.PocoModels.DEPO;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.PRL.Assets;
using System.Data;

namespace MEYPAK.PRL.STOK
{
    public partial class FStokKasaHareket : XtraForm
    {
        public FStokKasaHareket()
        {
            InitializeComponent();
            _stokKasaMarkaServis = new GenericWebServis<PocoSTOKKASAMARKA>();
            _stokKasaHarCariLists = new List<StokKasaHarCariList>();
            _cariServis = new GenericWebServis<PocoCARIKART>();
            _cariHarServis = new GenericWebServis<PocoCARIHAR>();
            _stokKasaHarServis = new GenericWebServis<PocoSTOKKASAHAR>();
            _stokKasaServis = new GenericWebServis<PocoSTOKKASA>();
            _tempSTOKKASAHAR = new PocoSTOKKASAHAR();
            _depoServis = new GenericWebServis<PocoDEPO>();
        }
        GenericWebServis<PocoCARIHAR> _cariHarServis;
        GenericWebServis<PocoCARIKART> _cariServis;
        GenericWebServis<PocoSTOKKASAMARKA> _stokKasaMarkaServis;
        GenericWebServis<PocoSTOKKASAHAR> _stokKasaHarServis;
        GenericWebServis<PocoDEPO> _depoServis;
        GenericWebServis<PocoSTOKKASA> _stokKasaServis;
        List<StokKasaHarCariList> _stokKasaHarCariLists;
        PocoSTOKKASAHAR _tempSTOKKASAHAR;


        private void FStokKasaHareket_Load(object sender, EventArgs e)
        {
            _stokKasaMarkaServis.Data(ServisList.StokKasaMarkaListeServis);
            _stokKasaServis.Data(ServisList.StokKasaListeServis);
            _stokKasaHarServis.Data(ServisList.StokKasaHarListeServis);

            gridControl2.DataSource = _stokKasaMarkaServis.obje.Select(x => new
            {
                ID = x.id,
                ADI = x.adi,
                MMIKTAR = MarkaMiktarGetir(x.id),
            });

            //foreach (var item in _stokKasaMarkaServis.obje)
            //{
            //    var edsa = (_stokKasaServis.obje.Where(v => v.markaid == item.id).Count() > 0 ? _stokKasaHarServis.obje.Where(c => c.kasaid == _stokKasaServis.obje.Where(v => v.markaid == item.id).FirstOrDefault().id).Sum(c => c.io == 1 ? c.miktar : c.miktar * -1) : 0);
            //    var a = _stokKasaServis.obje.Where(v => v.markaid == item.id).Count();
            //    var sadsa = _stokKasaHarServis.obje.Where(c => c.kasaid == _stokKasaServis.obje.Where(v => v.markaid == item.id).FirstOrDefault().id);
            //}

            gridControl2.RefreshDataSource();
            DTPTarih.EditValue = DateTime.Now;
        }

        decimal MarkaMiktarGetir(int id)
        {
            if (_stokKasaServis.obje.Where(v => v.markaid == id).Count() == 0)
                return 0;
            else
            {
                decimal girdi = 0;
                decimal cikti = 0;
                foreach (var item in _stokKasaServis.obje.Where(v => v.markaid == id))
                {

                    cikti += _stokKasaHarServis.obje.Where(c => c.kasaid == item.id && c.io == 0).Sum(x => x.miktar);
                    girdi += _stokKasaHarServis.obje.Where(c => c.kasaid == item.id && c.io == 1).Sum(x => x.miktar);
                }
                return (girdi - cikti);
            }
        }

        private void tileView1_Click(object sender, EventArgs e)
        {
            _stokKasaMarkaServis.Data(ServisList.StokKasaMarkaListeServis);
            _stokKasaServis.Data(ServisList.StokKasaListeServis);
            gridControl3.DataSource = _stokKasaServis.obje.Where(x => x.markaid.ToString() == tileView1.GetFocusedRowCellValue("ID").ToString()).Select(x => new
            {
                ID = x.id,
                KASATIP = x.kasaadi,
                MIKTAR = (_stokKasaHarServis.obje.Where(c => c.kasaid == x.id && c.io == 1).Sum(x => x.miktar) - _stokKasaHarServis.obje.Where(c => c.kasaid == x.id && c.io == 0).Sum(x => x.miktar))
            });
            gridControl4.DataSource = "";
            gridControl4.RefreshDataSource();
        }
        string test;
        string cariid = "";
        string kasaid = "";
        private void tileView2_Click(object sender, EventArgs e)
        {
            _stokKasaHarCariLists.Clear();
            _cariServis.Data(ServisList.CariListeServis);
            _cariHarServis.Data(ServisList.CariHarListeServis);
            _stokKasaHarServis.Data(ServisList.StokKasaHarListeServis);
            test = tileView2.GetFocusedRowCellValue("ID").ToString();
            foreach (var item in _stokKasaHarServis.obje.Where(x => x.kasaid.ToString() == test).Select(x => x.cariid).GroupBy(x => x))
            {
                _stokKasaHarCariLists.Add(new StokKasaHarCariList()
                {
                    CARIID = item.FirstOrDefault(),
                    DEPOID = 0,
                    ADI = _cariServis.obje.Where(x => x.id == item.FirstOrDefault()).FirstOrDefault().unvan,

                });
            }
            _depoServis.Data(ServisList.DepoListeServis);
            foreach (var item in _depoServis.obje)
            {
                _stokKasaHarCariLists.Add(new StokKasaHarCariList()
                {
                    ADI = item.depoadi,
                    CARIID = 0,
                    DEPOID = item.id,


                });
            }


            gridControl4.DataSource = _stokKasaHarCariLists.Select(x => new
            {
                CARIID = x.CARIID,
                DEPOID = x.DEPOID,
                FIRMA = x.ADI,
                MMMIKTAR = (_stokKasaHarServis.obje.Where(c => c.cariid == x.CARIID && c.io == 1 && c.kasaid.ToString()==test).Sum(x => x.miktar) - _stokKasaHarServis.obje.Where(c => c.cariid == x.CARIID && c.io == 0&&c.kasaid.ToString() == test).Sum(x => x.miktar))

            });
            gridControl4.RefreshDataSource();
        }

        private void tileView3_Click(object sender, EventArgs e)
        {


            try
            {
                _stokKasaHarServis.Data(ServisList.StokKasaHarListeServis);
                cariid = tileView3.GetFocusedRowCellValue("CARIID").ToString();
                
                kasaid = tileView2.GetFocusedRowCellValue("ID").ToString();
                gridControl1.DataSource = _stokKasaHarServis.obje.Where(x => x.cariid.ToString() == cariid  && x.kasaid.ToString() == kasaid).Select(x => new
                {
                    ID=x.id,
                    TARIH = x.olusturmatarihi,
                    BELGENO = x.belge_no,
                    CIKISMIKTARI = _stokKasaHarServis.obje.Where(z => z.cariid.ToString() == cariid.ToString() && z.kasaid.ToString() == kasaid.ToString() && z.belge_no == x.belge_no).Sum(z => z.io == 0 ? z.miktar : 0),
                    GIRISMIKTARI = _stokKasaHarServis.obje.Where(z => z.cariid.ToString() == cariid.ToString() && z.kasaid.ToString() == kasaid.ToString() && z.belge_no == x.belge_no).Sum(z => z.io == 1 ? z.miktar : 0)
                });
                //gridControl1.DataSource = temp.GroupBy(x => new { x.TARIH, x.BELGENO, x.CIKISMIKTARI, x.GIRISMIKTARI }).Select(x => x.Select(z => new { z.TARIH, z.BELGENO, z.CIKISMIKTARI, z.GIRISMIKTARI }).ToList()).FirstOrDefault();
                gridView1.Columns["ID"].Visible = false;
                gridControl1.RefreshDataSource();
            }
            catch (Exception)
            {

            }

        }

        //private void simpleButton1_Click(object sender, EventArgs e)
        //{                                                           

        //}
        void temizle()
        {
            TBMiktar.Text = String.Empty;
            TBBelgeNo.Text = String.Empty;
            TBAciklama.Text = String.Empty;
            _tempSTOKKASAHAR = new PocoSTOKKASAHAR();
        }
        void Doldur(PocoSTOKKASAHAR stokkasahar)
        {
            TBBelgeNo.Text = stokkasahar.belge_no;
            TBMiktar.Text = "0";

        }
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
           
            _tempSTOKKASAHAR = _stokKasaHarServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
            Doldur(_tempSTOKKASAHAR);
        }

        private void BTKaydet_Click(object sender, EventArgs e)
        {
            _tempSTOKKASAHAR.io = 1;
            _tempSTOKKASAHAR.miktar = Convert.ToDecimal(TBMiktar.Text);
            _tempSTOKKASAHAR.id = 0;
            _stokKasaHarServis.Data(ServisList.StokKasaHarEkleServis, _tempSTOKKASAHAR);
            _stokKasaHarServis.Data(ServisList.StokKasaHarListeServis);

            cariid = tileView3.GetFocusedRowCellValue("ID").ToString();
            kasaid = tileView2.GetFocusedRowCellValue("ID").ToString();
            gridControl1.DataSource = _stokKasaHarServis.obje.Where(x => x.cariid.ToString() == cariid && x.io == 0 && x.kasaid.ToString() == kasaid).Select(x => new
            {
                ID = x.id,
                TARIH = x.olusturmatarihi,
                BELGENO = x.belge_no,
                CIKISMIKTARI = _stokKasaHarServis.obje.Where(z => z.cariid.ToString() == cariid.ToString() && z.kasaid.ToString() == kasaid.ToString() && z.belge_no == x.belge_no).Sum(z => z.io == 0 ? z.miktar : 0),
                GIRISMIKTARI = _stokKasaHarServis.obje.Where(z => z.cariid.ToString() == cariid.ToString() && z.kasaid.ToString() == kasaid.ToString() && z.belge_no == x.belge_no).Sum(z => z.io == 1 ? z.miktar : 0)
            });
            gridView1.Columns["ID"].Visible= false;
            gridControl1.RefreshDataSource();
            temizle();
        }
    }
}
