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
            ServiceReference1.EArchiveWithHoldingInformation tt = new ServiceReference1.EArchiveWithHoldingInformation();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            ServiceReference1.IntegrationClient ýntegrationClient = new ServiceReference1.IntegrationClient();
            ýntegrationClient.ClientCredentials.UserName.UserName = "Gunduz";
            ýntegrationClient.ClientCredentials.UserName.Password = "iJAfhKSU";
            ServiceReference1.WhoAmIInfo bb = new WhoAmIInfo();

            SystemUsersResponse res = ýntegrationClient.GetEInvoiceUsersAsync(new PagedQueryContext()
            {
                PageIndex = 0,
                PageSize = 999999,
            }).Result;
            
        }
    }
}