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
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.STOK;
using DevExpress.XtraEditors;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Interfaces.Depo;
using MEYPAK.Entity.PocoModels.DEPO;
using MEYPAK.Entity.Models.SIPARIS;
using MEYPAK.PRL.DEPO;
using MEYPAK.PRL.IRSALIYE;
using MEYPAK.PRL.SIPARIS;

namespace MEYPAK.PRL.STOK
{
    public partial class FSayimList : XtraForm
    {
        public FSayimList(string form = "", string islem = "")
        {
            _islem = islem;
            _form = form;
            InitializeComponent();
            _stokSayimServis = new GenericWebServis<PocoSTOKSAYIM>();
            _depoServis = new GenericWebServis<PocoDEPO>();
            
        }
        string _form;
        string _islem;
        GenericWebServis<PocoSTOKSAYIM> _stokSayimServis ;
        GenericWebServis<PocoDEPO> _depoServis;
        FSayimIsle fSayimIsle;
        private void FSayimList_Load(object sender, EventArgs e)
        {

            foreach (Form frm in Application.OpenForms)
            {
                if (_form == frm.Tag)
                {
                    if (frm.Name.Contains("FSayimIsle"))
                        fSayimIsle = (FSayimIsle)frm;
             
                }
            }


            _stokSayimServis.Data(ServisList.StokSayimListeServis);
            _depoServis.Data(ServisList.DepoListeServis);
            DGSayimList.DataSource = _stokSayimServis.obje.Where(x => x.kayittipi == 0).Select(x => new
            {
                ID = x.id,
                SayimTarihi = x.sayimtarihi,
                Depo = _depoServis.obje.Where(y => y.id == x.depoid).Count() > 0 ? _depoServis.obje.Where(y => y.id == x.depoid).FirstOrDefault().depoadi : "",
                Açıklama = x.aciklama,
                Durum = x.durum == 0 ? "Onaylanmadı" : "Onaylandı"
            });
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DateTime dt = Convert.ToDateTime(gridView1.GetFocusedRowCellValue("SAYIMTARIHI").ToString());
            string aciklama = gridView1.GetFocusedRowCellValue("ACIKLAMA").ToString();
            fSayimIsle._tempSayim = _stokSayimServis.obje.Where(x => x.aciklama== aciklama.ToString() ).FirstOrDefault();
            fSayimIsle._id = int.Parse(gridView1.GetFocusedRowCellValue("SAYIMTARIHI").ToString());
            this.Close();
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

        private void DGSayimList_DoubleClick(object sender, EventArgs e)
        {
            if (_islem=="SayimIsle")
            {
                fSayimIsle._tempSayim = _stokSayimServis.obje.Where(x=> x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
            }


            this.Close();
        }
    }
}
