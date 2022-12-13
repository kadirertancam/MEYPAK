using DevExpress.XtraEditors;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.Models.SIPARIS;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Stok;
using MEYPAK.PRL.DEPO;
using MEYPAK.PRL.IRSALIYE;
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

namespace MEYPAK.PRL.STOK
{
    public partial class FHizmetList : XtraForm
    {
        string _islem;
        string _form;
        FHizmetKart fHizmetKart;
        GenericWebServis<PocoHIZMET> _hizmetservis = new GenericWebServis<PocoHIZMET>();
        public FHizmetList(string form = "", string islem = "")
        {
            InitializeComponent();
            _islem = islem;
            _form = form;
        }

        private void FHizmetList_Load(object sender, EventArgs e)
        {
            _hizmetservis.Data(ServisList.HizmetListeServis);
            gridControl1.DataSource= _hizmetservis.obje.Where(x => x.kayittipi == 0).Select(x=> new
            {
                ID=x.id,
                ADI=x.adi,
                GRUPKODU =x.grupkodu,
                KATEGORİ=x.kategoriid,
            });
            gridView1.Columns["ID"].Visible = false;
            foreach (Form frm in Application.OpenForms)
            {
                if (_form == frm.Tag)
                {
                    if (frm.Name.Contains("FHizmetKart"))
                        fHizmetKart = (FHizmetKart)frm;
                 
                }
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            
            if (_islem == "hizmetkart")
            {
                if (fHizmetKart != null)
                    fHizmetKart._tempHizmet = _hizmetservis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
            }

            this.Close();
        }
    }
}
