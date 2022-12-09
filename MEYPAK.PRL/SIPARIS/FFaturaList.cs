using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels;
using MEYPAK.Entity.PocoModels.FATURA;
using MEYPAK.Entity.PocoModels.IRSALIYE;
using MEYPAK.Interfaces.IRSALIYE;
using MEYPAK.Interfaces.Stok;
using MEYPAK.PRL.IRSALIYE;
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

namespace MEYPAK.PRL.SIPARIS
{
    public partial class FFaturaList : XtraForm
    {
        public FFaturaList(string tag = "", string islem = "")
        {
            InitializeComponent();
            _form = tag;
            _islem = islem;
        }

        string _form, _islem;
        int i = 0;

        #region Tanımlar
        FFatura ffatura;
        FStokKasaHareketRaporu fStokKasaHareketRaporu;
        FStokHareketRaporu fStokHareketRaporu;
        Main main;
        GenericWebServis<PocoFATURA> _faturaServis;

        #endregion

        #region Metotlar
        private void FFaturaList_Load(object sender, EventArgs e)
        {
            _faturaServis = new GenericWebServis<PocoFATURA>();
            if (this.Tag == null)
            {
                foreach (Form frm in Application.OpenForms)
                {
                    if (_form == frm.Tag)
                    {
                        if (frm.Name.Contains("FFatura"))
                            ffatura = (FFatura)frm;
                        if (frm.Name.Contains("FStokKasaHareketRaporu"))
                            fStokKasaHareketRaporu = (FStokKasaHareketRaporu)frm;
                        if (frm.Name.Contains("FStokHareketRaporu"))
                            fStokHareketRaporu = (FStokHareketRaporu)frm;
                    }
                }
            }
            else
            {
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.Name.Contains("Main"))
                        main = (Main)frm;
                }
            }
            _faturaServis.Data(ServisList.FaturaListeServis);
            if (_islem == "FFatura")
                gridControl1.DataSource = _faturaServis.obje.Where(x => x.tip == 0).Select(x => new
                {
                    ID = x.id,
                    x.faturatarihi,
                    x.belgeno,
                    x.cariadi,
                    x.althesapid,
                    x.depoid,
                    x.geneltoplam
                });
            if (_islem == "FAlisFatura")
                gridControl1.DataSource = _faturaServis.obje.Where(x => x.tip == 1).Select(x => new
                {
                    ID = x.id,
                    x.faturatarihi,
                    x.belgeno,
                    x.cariadi,
                    x.althesapid,
                    x.depoid,
                    x.geneltoplam
                }); 
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            _faturaServis.Data(ServisList.FaturaListeServis);
            if (this.Tag == null)
            {
                if (_islem == "FFatura")
                {
                    if (ffatura != null)
                    {
                        ffatura._tempFatura = _faturaServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
                    }

                }
                this.Close();
            }
            else
            {
                XtraTabPage page = new XtraTabPage();
                ffatura = new FFatura();
                page.Name = "TPFatura2" + i;
                page.Text = "Fatura Tanım";
                page.Tag = "TPFatura2" + i;
                page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;

                main.xtraTabControl1.TabPages.Add(page);
                main.xtraTabControl1.SelectedTabPage = page;

                ffatura.TopLevel = false;
                ffatura.AutoScroll = true;
                ffatura.Tag = "TPFatura2" + i;
                ffatura.Dock = DockStyle.Fill;
                page.Controls.Add(ffatura);
                ffatura._tempFatura = _faturaServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
                ffatura.Show();
                i++;
            }
        }

        #endregion
    }
}

