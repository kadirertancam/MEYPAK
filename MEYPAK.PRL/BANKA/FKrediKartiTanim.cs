using DevExpress.XtraEditors;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.BANKA;
using MEYPAK.Interfaces.Banka;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEYPAK.PRL.BANKA
{
    public partial class FKrediKartiTanim : XtraForm
    {
        public FKrediKartiTanim()
        {
            InitializeComponent();
            _krediKartServis = new GenericWebServis<PocoKREDIKART>();
            _bankaServis= new GenericWebServis<PocoBANKA>();
        }
        GenericWebServis<PocoKREDIKART> _krediKartServis;
        GenericWebServis<PocoBANKA> _bankaServis;

        private void BTNKaydet_Click(object sender, EventArgs e)
        {
            _krediKartServis.Data(ServisList.KrediKartEkleServis, new PocoKREDIKART()
            {
                BANKAID = Convert.ToInt32(CBBanka.EditValue),
                KARTNO = TBKartNo.Text,
                ACIKLAMA = TBAciklama.Text,
                AKTIFMI = true,
            }) ;
            GridiDoldur();
        }

        private void FKrediKartiTanim_Load(object sender, EventArgs e)
        {
            ComboyuDoldur();
            GridiDoldur();
        }
        
        void ComboyuDoldur()
        {
            _bankaServis.Data(ServisList.BANKAListeServis);
            CBBanka.Properties.DataSource = _bankaServis.obje.Select(x => new { KOD = x.kod, ADI = x.adi, ID = x.id });
            CBBanka.Properties.DisplayMember = "ADI";
            CBBanka.Properties.ValueMember = "ID";
            CBBanka.Properties.PopulateColumns();
            CBBanka.Properties.Columns["ID"].Visible = false;
           
        }

        void GridiDoldur()
        {
            _krediKartServis.Data(ServisList.KrediKartListeServis);
            gridControl1.DataSource = _krediKartServis.obje;
        }
    }
}
