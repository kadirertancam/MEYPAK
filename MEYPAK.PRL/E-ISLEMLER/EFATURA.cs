using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
      
        public EFATURA() 
        {
            InitializeComponent();

            ıntegrationClient.ClientCredentials.UserName.UserName = "Gunduz";
            ıntegrationClient.ClientCredentials.UserName.Password = "iJAfhKSU";
            ServiceReference1.WhoAmIInfo bb = new WhoAmIInfo();

            InboxInvoiceListResponse res = ıntegrationClient.GetInboxInvoiceListAsync(new InboxInvoiceListQueryModel
            {
                PageIndex = 0,
                PageSize = 9999999,
                CreateStartDate = DateTime.Now.AddDays(-1),
                CreateEndDate = DateTime.Now,
            }).Result;
            RepositoryItemButtonEdit repositoryItemButtonEdit = new RepositoryItemButtonEdit();
            repositoryItemButtonEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            repositoryItemButtonEdit.NullText = "";
            repositoryItemButtonEdit.NullValuePrompt = "";
            repositoryItemButtonEdit.Buttons[0].Caption = "Faturalaştır";
            repositoryItemButtonEdit.Buttons[0].Kind = ButtonPredefines.Glyph;
            repositoryItemButtonEdit.Buttons[0].Shortcut = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.Enter);
            var tempp= ıntegrationClient.GetInboxInvoiceAsync(res.Value.Items.LastOrDefault().DocumentId).Result;

           
            gridControl1.DataSource = res.Value.Items.Select(x=> new { FATURALASTIR="",VKNTCK=x.TargetTcknVkn,CARIADI=x.TargetTitle,BELGENO=x.InvoiceId,TARIH=x.CreateDateUtc,VADETARIHI=x.ExecutionDate,TUTAR=x.TaxExclusiveAmount, KDV=x.TaxTotal,FATURATIP=x.Type,TIP=x.InvoiceTipType,ETTNO=x.DocumentId, DURUM = x.StatusCode == 1000 ? "ONAYLANDI" : "BEKLEMEDE" });
            gridView1.Columns["FATURALASTIR"].ColumnEdit = repositoryItemButtonEdit;
            gridView1.Columns["FATURALASTIR"].VisibleIndex = gridView1.Columns.Count ;

        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
           

        }

        private void gridView1_Click(object sender, EventArgs e)
        {
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

            var tempp = ıntegrationClient.GetInboxInvoiceAsync(gridView1.GetFocusedRowCellValue("ETTNO").ToString()).Result; 
            RepositoryItemButtonEdit repositoryItemButtonEdit = new RepositoryItemButtonEdit();
            repositoryItemButtonEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            repositoryItemButtonEdit.NullText = "";
            repositoryItemButtonEdit.NullValuePrompt = "";
            repositoryItemButtonEdit.Buttons[0].Caption = "SEÇ";
            repositoryItemButtonEdit.Buttons[0].Kind = ButtonPredefines.Glyph;
            repositoryItemButtonEdit.Buttons[0].Shortcut = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.Enter);
            gridControl2.DataSource = tempp.Value.Invoice.InvoiceLine.Select(x => new { KOD = "", ADI = x.Item.Name.Value, MIKTAR = x.InvoicedQuantity.Value, BIRIM = x.InvoicedQuantity.unitCode, NETFIYAT = x.Price.PriceAmount.Value, TUTAR = x.Price.PriceAmount.Value * x.InvoicedQuantity.Value });
             
            gridView2.Columns["KOD"].ColumnEdit = repositoryItemButtonEdit; 
        }
    }
}