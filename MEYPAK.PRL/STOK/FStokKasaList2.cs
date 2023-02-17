using DevExpress.XtraEditors;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.PRL.IRSALIYE;
using MEYPAK.PRL.SIPARIS;
using MEYPAK.PRL.STOK.Raporlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEYPAK.PRL.STOK
{
    public partial class FStokKasaList2 : XtraForm
    {
        public FStokKasaList2(string form = "", string islem = "")
        {
            InitializeComponent();
            this._islem = islem;
            this._form = form;
            _stokKasaServis = new GenericWebServis<PocoSTOKKASA>();
            _stokKasaMarkaServis = new GenericWebServis<PocoSTOKKASAMARKA>();

        }

        #region Tanımlar
        string _islem;
        string _form;
        GenericWebServis<PocoSTOKKASA> _stokKasaServis;
        GenericWebServis<PocoSTOKKASAMARKA> _stokKasaMarkaServis;
        FStokKasaHareketRaporu fStokKasaHareketRaporu;
        FAlisFatura FAlisFatura;
        FAlisIrsaliye FAlisIrsaliye;
        FStokSarf fStokSarf;
        StokKasaGirisPanel fstokKasaGirisPanel;
        FFatura fFatura;
        #endregion

        private void FStokKasaList2_Load(object sender, EventArgs e)
        {
            _stokKasaServis.Data(ServisList.StokKasaListeServis);
            _stokKasaMarkaServis.Data(ServisList.StokKasaMarkaListeServis);
            DGStokKasaList.DataSource = _stokKasaServis.obje.Where(x => x.kayittipi == 0).Select(x=>new { id=x.id,Marka=_stokKasaMarkaServis.obje.Where(z=>z.id==x.markaid).FirstOrDefault().adi,KasaKodu=x.kasakodu,KasaAdı=x.kasaadi,x.aciklama, });
            foreach (Form frm in Application.OpenForms)
            {
                if (_form == frm.Tag)
                {
                    if (frm.Name.Contains("FStokKasaHareketRaporu"))
                        fStokKasaHareketRaporu = (FStokKasaHareketRaporu)frm;
                    if(frm.Name.Contains("FAlisFatura"))
                        FAlisFatura = (FAlisFatura)frm; 
                    if(frm.Name.Contains("FAlisIrsaliye"))
                        FAlisIrsaliye = (FAlisIrsaliye)frm;
                    if (frm.Name.Contains("FStokSarf"))
                        fStokSarf = (FStokSarf)frm; 
                    if (frm.Name.Contains("StokKasaGirisPanel"))
                        fstokKasaGirisPanel = (StokKasaGirisPanel)frm;
                    if (frm.Name.Contains("FFatura"))
                        fFatura = (FFatura)frm;
                }
            }
            

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (_islem == "FStokKasaHareketRaporu")
            {
                fStokKasaHareketRaporu._tempStokKasa = _stokKasaServis.obje.Where(x => x.kayittipi == 0 && x.id.ToString() == gridView1.GetFocusedRowCellValue("id").ToString()).FirstOrDefault();
            }
            if(_islem=="FAlisFatura")
            {
                FAlisFatura._tempKasa = _stokKasaServis.obje.Where(x => x.kayittipi == 0 && x.id.ToString() == gridView1.GetFocusedRowCellValue("id").ToString()).FirstOrDefault();
            } if(_islem== "FAlisIrsaliye")
            {
                FAlisIrsaliye._tempKasa = _stokKasaServis.obje.Where(x => x.kayittipi == 0 && x.id.ToString() == gridView1.GetFocusedRowCellValue("id").ToString()).FirstOrDefault();
            }
            if (_islem=="FStokSarf")
            {
                fStokSarf._tempKasa = _stokKasaServis.obje.Where(x => x.kayittipi == 0 && x.id.ToString() == gridView1.GetFocusedRowCellValue("id").ToString()).FirstOrDefault();
            }
            if(_islem== "StokKasaGirisPanel")
            {
                fstokKasaGirisPanel._tempKasa = _stokKasaServis.obje.Where(x => x.kayittipi == 0 && x.id.ToString() == gridView1.GetFocusedRowCellValue("id").ToString()).FirstOrDefault();
            }
            if (_islem == "FFatura")
            {
                fFatura._tempKasa = _stokKasaServis.obje.Where(x => x.kayittipi == 0 && x.id.ToString() == gridView1.GetFocusedRowCellValue("id").ToString()).FirstOrDefault();
            }
            this.Close();
        }

        //private void toolStripButton1_Click(object sender, EventArgs e)
        //{
        //    _stokKasaServis.Data(ServisList.StokKasaListeServis);
        //    FMarkaKart fMarkaKart= new FMarkaKart();
        //    FMarkaKart.ShowDialog();
        //    _markaServis.Data(ServisList.StokMarkaListeServis);
        //    gridControl1.DataSource = _markaServis.obje.Where(x => x.kayittipi == 0);
        //}
    }
} 
