using Urunler;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UrunServiceClient client = new UrunServiceClient(UrunServiceClient.EndpointConfiguration.BasicHttpBinding_IUrunService);
            var aa =  client.UrunServiceUrunlerAsync(new BaseRequestMessageOf_UrunlerIstek()
            {
                UserName="4300580693",
                Password="Meypak139",
                 
            });

        }
    }
}