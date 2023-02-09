using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
using MEYPAK.Entity.PocoModels.CARI;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.PRL.Assets;
using MEYPAK.PRL.CARI;
using MEYPAK.PRL.STOK;
using ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace MEYPAK.PRL.E_ISLEMLER
{
    public partial class EFATURA : DevExpress.XtraEditors.XtraForm
    {
        ServiceReference1.IntegrationClient ıntegrationClient = new ServiceReference1.IntegrationClient();
        ServiceReference2.BasicIntegrationClient basicIntegration = new ServiceReference2.BasicIntegrationClient();
        ServiceReference1.WhoAmIInfo bb;
        public PocoSTOK _tempStok;
        public PocoCARIKART _tempCari;
        public EFATURA() 
        {
            InitializeComponent();

            ıntegrationClient.ClientCredentials.UserName.UserName = "Gunduz";
            ıntegrationClient.ClientCredentials.UserName.Password = "iJAfhKSU";
            bb = new WhoAmIInfo();
            DTPBastar.Text = DateTime.Now.AddDays(-1).ToString();
            DTPBittar.Text = DateTime.Now.ToString();


        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
           

        }

        private void gridView1_Click(object sender, EventArgs e)
        {
        }
        InvoiceResponse tempp;
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            
            tempp = ıntegrationClient.GetInboxInvoiceAsync(gridView1.GetFocusedRowCellValue("ETTNO").ToString()).Result; 
            RepositoryItemButtonEdit repositoryItemButtonEdit = new RepositoryItemButtonEdit();
            repositoryItemButtonEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            repositoryItemButtonEdit.NullText = "";
            repositoryItemButtonEdit.NullValuePrompt = "";
            repositoryItemButtonEdit.Buttons[0].Caption = "SEÇ";
            repositoryItemButtonEdit.Buttons[0].Kind = ButtonPredefines.Glyph;
            repositoryItemButtonEdit.Buttons[0].Shortcut = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.Enter);
            repositoryItemButtonEdit.ButtonClick += RepositoryItemButtonEdit_ButtonClick;
            gridControl2.DataSource = tempp.Value.Invoice.InvoiceLine.Select(x => new FaturaDetailList {SIRA=int.Parse(x.ID.Value) ,KOD = "", ADI = x.Item.Name.Value, MIKTAR = x.InvoicedQuantity.Value, BIRIM = x.InvoicedQuantity.unitCode, NETFIYAT = x.Price.PriceAmount.Value, TUTAR = x.Price.PriceAmount.Value * x.InvoicedQuantity.Value });
            
            gridView2.Columns["KOD"].ColumnEdit = repositoryItemButtonEdit; 
        }
        InboxInvoiceListResponse res;
        RepositoryItemButtonEdit repositoryItemButtonEdit3;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
           
            if (CBArsiv.Checked)
            {
                res = ıntegrationClient.GetInboxInvoiceListAsync(new InboxInvoiceListQueryModel
                {
                    PageIndex = 0,
                    PageSize = 9999999,
                    CreateStartDate = DTPBastar.DateTime,
                    CreateEndDate = DTPBittar.DateTime,
                    IsArchived=true
                    ,InvoiceIds= new string[] { "05BD86C1-56F7-4FDA-B78D-7806FAB75A5F" }
                }).Result;
            }
            else
            {
                res = ıntegrationClient.GetInboxInvoiceListAsync(new InboxInvoiceListQueryModel
                {
                    PageIndex = 0,
                    PageSize = 9999999,
                    CreateStartDate = DTPBastar.DateTime,
                    CreateEndDate = DTPBittar.DateTime, 
                }).Result;

            }
           
            RepositoryItemButtonEdit repositoryItemButtonEdit = new RepositoryItemButtonEdit();
            repositoryItemButtonEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            repositoryItemButtonEdit.NullText = "";
            repositoryItemButtonEdit.NullValuePrompt = "";
            repositoryItemButtonEdit.Buttons[0].Caption = "Faturalaştır";
            repositoryItemButtonEdit.Buttons[0].Kind = ButtonPredefines.Glyph;
            repositoryItemButtonEdit.Buttons[0].Shortcut = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.Enter);

            RepositoryItemButtonEdit repositoryItemButtonEdit2 = new RepositoryItemButtonEdit();
            repositoryItemButtonEdit2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            repositoryItemButtonEdit2.NullText = "";
            repositoryItemButtonEdit2.NullValuePrompt = "";
            repositoryItemButtonEdit2.Buttons[0].Caption = "Basım";
            repositoryItemButtonEdit2.Buttons[0].Kind = ButtonPredefines.Glyph;
            repositoryItemButtonEdit2.Buttons[0].Shortcut = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.Enter);
            repositoryItemButtonEdit2.ButtonClick += RepositoryItemButtonEdit2_ButtonClick;

            repositoryItemButtonEdit3 = new RepositoryItemButtonEdit();
            repositoryItemButtonEdit3.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            repositoryItemButtonEdit3.NullText = "";
            repositoryItemButtonEdit3.NullValuePrompt = "";
            repositoryItemButtonEdit3.Buttons[0].Caption = "Seç";
            repositoryItemButtonEdit3.Buttons[0].Kind = ButtonPredefines.Glyph;
            repositoryItemButtonEdit3.Buttons[0].Shortcut = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.Enter);
            repositoryItemButtonEdit3.ButtonClick += RepositoryItemButtonEdit3_ButtonClick; ;


            if (res.Value.Items != null)
                gridControl1.DataSource = res.Value.Items.Select(x => new EFaturaGelenTask { SEC = false, ID = x.InvoiceId, CARISEC = "", FATURALASTIR = "", BASIM = "", VKNTCK = x.TargetTcknVkn, CARIADI = x.TargetTitle, BELGENO = x.InvoiceId, TARIH = x.CreateDateUtc, VADETARIHI = x.ExecutionDate, TUTAR = x.TaxExclusiveAmount, KDV = x.TaxTotal, FATURATIP = x.Type.ToString(), ARSIVLENMIS = x.IsArchived, TIP = x.InvoiceTipType.ToString(), ETTNO = x.DocumentId, DURUM = x.StatusCode == 1000 ? "ONAYLANDI" : "BEKLEMEDE" });
            else
                gridControl1.DataSource = new List<EFaturaGelenTask>();

            gridView1.Columns["FATURALASTIR"].ColumnEdit = repositoryItemButtonEdit; 
            gridView1.Columns["BASIM"].ColumnEdit = repositoryItemButtonEdit2; 
            gridView1.Columns["CARISEC"].ColumnEdit = repositoryItemButtonEdit3; 
            
        }

        private void RepositoryItemButtonEdit3_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            FCariList carilist = new FCariList(this.Tag.ToString(), "EFaturaGelenKutu");
            carilist.ShowDialog(); 
            gridView1.SetFocusedRowCellValue("CARISEC", _tempCari.kod); 
        }

        private void RepositoryItemButtonEdit2_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            System.IO.File.WriteAllBytes("Fatura.pdf", ıntegrationClient.GetInboxInvoicePdfAsync(gridView1.GetFocusedRowCellValue("ETTNO").ToString()).Result.Value.Data);
            Thread.Sleep(500);
            var p = new Process();
            p.StartInfo = new ProcessStartInfo(Application.StartupPath+"Fatura.pdf")
            {
                UseShellExecute = true
            };
            p.Start();

        }

        private void RepositoryItemButtonEdit_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            FStokList stoklist = new FStokList(this.Tag.ToString(),"EFaturaGelenKutu");
            stoklist.ShowDialog();
            gridView2.SetFocusedRowCellValue("KOD", _tempStok.kod);
        }

        private void gridView2_MasterRowEmpty(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            FaturaDetailList respinbox = view.GetRow(e.RowHandle) as FaturaDetailList;
            if (respinbox != null)
            {
                if(tempp.Value.Invoice.InvoiceLine.Where(x => respinbox.SIRA.ToString() == x.ID.Value).Any(x => x.Item.AdditionalItemIdentification!=null))
                e.IsEmpty = tempp.Value.Invoice.InvoiceLine.Where(x => respinbox.SIRA.ToString() == x.ID.Value).Select(x => x.Item.AdditionalItemIdentification.Count()).FirstOrDefault() > 0 ? false : true;
            }

        }

        private void gridView2_MasterRowGetChildList(object sender, MasterRowGetChildListEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            FaturaDetailList respinbox = view.GetRow(e.RowHandle) as FaturaDetailList;
            if (respinbox != null)
            {
                if (tempp.Value.Invoice.InvoiceLine.Where(x => respinbox.SIRA.ToString() == x.ID.Value).Any(x => x.Item.AdditionalItemIdentification != null))
                if (tempp.Value.Invoice.InvoiceLine.Where(x => respinbox.SIRA.ToString() == x.ID.Value).Any(x => x.Item.AdditionalItemIdentification.Where(x=>x.ID.schemeID=="KUNYENO").Count()>0))
                    e.ChildList = tempp.Value.Invoice.InvoiceLine.Where(x => respinbox.SIRA.ToString() == x.ID.Value).Select(x => new { KUNYE = x.Item.AdditionalItemIdentification.Where(z => z.ID.schemeID == "KUNYENO").FirstOrDefault().ID.Value }).ToList();
            }

        }

        private void gridView2_MasterRowGetRelationCount(object sender, MasterRowGetRelationCountEventArgs e)
        {
            if(tempp!=null)
            if (tempp.Value.Invoice.InvoiceLine.Where(x => x.Item.AdditionalItemIdentification != null).Count() > 0)
                e.RelationCount = 1;
            else
                e.RelationCount = 0;

        }

        private void gridView2_MasterRowGetRelationName(object sender, MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "Detay";
        }

        private void gridView1_RowStyle(object sender, RowStyleEventArgs e)
        {
            string quantity = Convert.ToString(gridView1.GetRowCellValue(e.RowHandle, "DURUM"));

            if (quantity == "ONAYLANDI")
            {
                e.Appearance.BackColor = Color.LightGreen;
            }
            else
            { 
            }
        }
    }
}