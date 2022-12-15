using DevExpress.XtraEditors;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.STOK;
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
           
        }

        #region Tanımlar
        string _islem;
        string _form;
        GenericWebServis<PocoSTOKKASA> _stokKasaServis;
        FStokKasaHareketRaporu fStokKasaHareketRaporu;
        #endregion

        private void FStokKasaList2_Load(object sender, EventArgs e)
        {
            _stokKasaServis.Data(ServisList.StokKasaListeServis);
            DGStokKasaList.DataSource = _stokKasaServis.obje.Where(x => x.kayittipi == 0);
            foreach (Form frm in Application.OpenForms)
            {
                if (_form == frm.Tag)
                {
                    if (frm.Name.Contains("FStokKasaHareketRaporu"))
                        fStokKasaHareketRaporu = (FStokKasaHareketRaporu)frm;
                }
            }
            

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (_islem == "FStokKasaHareketRaporu")
            {
                fStokKasaHareketRaporu._tempStokKasa = _stokKasaServis.obje.Where(x => x.kayittipi == 0 && x.id.ToString() == gridView1.GetFocusedRowCellValue("id").ToString()).FirstOrDefault();
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
