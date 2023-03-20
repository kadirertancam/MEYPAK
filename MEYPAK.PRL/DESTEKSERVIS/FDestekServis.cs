using DevExpress.XtraEditors;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels.DESTEKSERVIS;
using MEYPAK.Entity.PocoModels.PERSONEL;
using MEYPAK.Interfaces.Personel;
using MEYPAK.Interfaces.Stok;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEYPAK.PRL.DESTEKSERVIS
{
    public partial class FDestekServis : XtraForm
    {
        public FDestekServis()
        {
            _destekServis = new GenericWebServis<PocoDestekServis>();
            _personelDepartmanServis = new GenericWebServis<PocoPERSONELDEPARTMAN>();
            InitializeComponent();
            CombolarıDoldur();
        }

        #region Tanımlar
        PocoDestekServis _tempDestekServis;
        GenericWebServis<PocoDestekServis> _destekServis;
        GenericWebServis<PocoPERSONELDEPARTMAN> _personelDepartmanServis;
        #endregion

        #region Metotlar
        private void FDestekServis_Load(object sender, EventArgs e)
        {
            //DataGridDoldur();
        }
        void PersonelDepartmanComboDoldur()
        {
            _personelDepartmanServis.Data(ServisList.PersonelDepartmanListeServis);
            CBDepartman.Properties.DataSource = _personelDepartmanServis.obje.Where(x => x.kayittipi == 0).Select(x => new { DEPARTMAN = x.adi});
            CBDepartman.Properties.ValueMember = "ID";
            CBDepartman.Properties.DisplayMember = "DEPARTMAN";
        }
        void CombolarıDoldur()
        {
            PersonelDepartmanComboDoldur();
        }


        //void DataGridDoldur()
        //{
        //    _destekServis.Data(ServisList.DestekServisListeServis);
        //    DGDestekServis.DataSource = _destekServis.obje.Where(x => x.kayittipi == 0).Select(x => new
        //    {
        //        ID = x.id,
        //        //Ad = x,
        //        //Birim = x.birim,
        //        //OluşturmaTarihi = x.olusturmatarihi
        //    });
        //    DGDestekServis.Refresh();
        //    DGDestekServis.RefreshDataSource();
        //}
        #endregion
    }

}
