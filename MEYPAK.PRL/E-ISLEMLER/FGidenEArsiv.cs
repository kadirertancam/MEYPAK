using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.CARI;
using MEYPAK.Entity.PocoModels.FATURA;
using MEYPAK.Entity.PocoModels.STOK;
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

namespace MEYPAK.PRL.E_ISLEMLER
{
    public partial class FGidenEArsiv : Form
    {
        public FGidenEArsiv()
        {
            InitializeComponent();
        }
        GenericWebServis<PocoCARIKART> cariServis;
        GenericWebServis<PocoFATURA> faturaServis;
        GenericWebServis<PocoFATURADETAY> faturaDetayServis;
        GenericWebServis<PocoSTOK> stokServis;
        GenericWebServis<PocoSTOKMARKA> stokMarkaServis;
        List<EFaturaGidenTask> tempFatura;
        PocoFATURA fattemp;
        PocoCARIKART caritemp;
        PocoFATURADETAY[] fatDetaytemp; //bir faturanın birden fazla kalemi olabilir, dizi tanımlaması yapılır
        PocoSTOK tempStok;
        PocoSTOKMARKA tempStokMarka;
        RepositoryItemLookUpEdit riLookup, riLookup2;
        private void FGidenEArsiv_Load(object sender, EventArgs e)
        {
            stokMarkaServis.Data(ServisList.StokMarkaListeServis);
            stokServis.Data(ServisList.StokListeServis);
            faturaServis.Data(ServisList.FaturaListeServis);
            cariServis.Data(ServisList.CariListeServis);
            faturaDetayServis.Data(ServisList.FaturaDetayListeServis);
            tempFatura = faturaServis.obje.Where(x => x.durum == false).Select(x => new EFaturaGidenTask { SEC = false, ID = x.id.ToString(), FATURALASTIR = "", BASIM = "", VKNTCK = cariServis.obje.Where(z => z.id == x.cariid).FirstOrDefault().vergino, CARIADI = cariServis.obje.Where(z => z.id == x.cariid).FirstOrDefault().unvan, BELGENO = x.belgeno, TARIH = x.faturatarihi, VADETARIHI = x.vadetarihi, TUTAR = x.geneltoplam, KDV = x.kdvtoplam, FATURATIP = "TEMELFATURA", TIP = "SATIS", DURUM = x.durum == true ? "ONAYLANDI" : "BEKLEMEDE" }).ToList();
            gridControl1.DataSource = tempFatura;
            RepositoryItemButtonEdit repositoryItemButtonEdit = new RepositoryItemButtonEdit();
            repositoryItemButtonEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            repositoryItemButtonEdit.NullText = "";
            repositoryItemButtonEdit.NullValuePrompt = "";
            repositoryItemButtonEdit.Buttons[0].Caption = "Faturalaştır";
            repositoryItemButtonEdit.Buttons[0].Kind = ButtonPredefines.Glyph;
            repositoryItemButtonEdit.Buttons[0].Shortcut = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.Enter);
            repositoryItemButtonEdit.ButtonClick += RepositoryItemButtonEdit_ButtonClick1;

            RepositoryItemButtonEdit repositoryItemButtonEdit2 = new RepositoryItemButtonEdit();
            repositoryItemButtonEdit2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            repositoryItemButtonEdit2.NullText = "";
            repositoryItemButtonEdit2.NullValuePrompt = "";
            repositoryItemButtonEdit2.Buttons[0].Caption = "Basım";
            repositoryItemButtonEdit2.Buttons[0].Kind = ButtonPredefines.Glyph;
            repositoryItemButtonEdit2.Buttons[0].Shortcut = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.Enter);
            repositoryItemButtonEdit2.ButtonClick += RepositoryItemButtonEdit2_ButtonClick;

            //TICARIFATURA
            //TEMELFATURA
            //IHRACAT
            //YOLCUBERABERFATURA


            

            //SATIS
            //IADE
            //ISTISNA
            //TEVKIFAT
            //OZELMATRAH
            //IHRACKAYITLI
            //SGK

            DataTable dt1 = new DataTable();

            dt1.Columns.Add("ID", typeof(string));
            dt1.Columns.Add("TIPLER", typeof(string));
            dt1.Rows.Add(1, "SATIS");
            dt1.Rows.Add(1, "IADE");
            dt1.Rows.Add(1, "ISTISNA");
            dt1.Rows.Add(1, "TEVKIFAT");
            dt1.Rows.Add(1, "OZELMATRAH");
            dt1.Rows.Add(1, "IHRACKAYITLI");
            dt1.Rows.Add(1, "SGK"); 

            gridView1.Columns["FATURALASTIR"].ColumnEdit = repositoryItemButtonEdit;
            gridView1.Columns["BASIM"].ColumnEdit = repositoryItemButtonEdit2; 
            gridView1.Columns["TIP"].ColumnEdit = riLookup2;
            gridView1.Columns["ID"].Visible = false;
        }

        private void RiLookup_EditValueChanged(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void RepositoryItemButtonEdit2_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void RepositoryItemButtonEdit_ButtonClick1(object sender, ButtonPressedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
