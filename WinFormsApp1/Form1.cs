using ServiceReference1;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.IntegrationClient �ntegrationClient = new ServiceReference1.IntegrationClient();
            �ntegrationClient.ClientCredentials.UserName.UserName = "Gunduz";
            �ntegrationClient.ClientCredentials.UserName.Password = "iJAfhKSU";
            ServiceReference1.WhoAmIInfo bb = new WhoAmIInfo();

            InboxInvoiceListResponse res = �ntegrationClient.GetInboxInvoiceListAsync(new InboxInvoiceListQueryModel
            {
                PageIndex = 0,
                PageSize = 50,
                CreateStartDate=DateTime.Now.AddDays(-10),
                CreateEndDate=DateTime.Now,
               
                
            }).Result;

            
            ServiceReference1.EArchiveWithHoldingInformation tt = new ServiceReference1.EArchiveWithHoldingInformation();
        }
    }
}