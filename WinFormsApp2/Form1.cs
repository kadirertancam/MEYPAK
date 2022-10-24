using ServiceReference1;
using ServiceReference2;
using System.Net;
using System.ServiceModel.Security;
using System.ServiceModel;
using System.Text;
using System.Windows.Forms.Design;
using static System.Net.WebRequestMethods;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {

            BasicHttpBinding basicHttpBinding = null;
            EndpointAddress endpointAddress = null;
            ChannelFactory<IAService> factory = null;
            IAService serviceProxy = null;
            try
            {
                basicHttpBinding = new BasicHttpBinding(BasicHttpSecurityMode.Transport);
                basicHttpBinding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Basic;
                endpointAddress = new EndpointAddress(new Uri("https://hks.hal.gov.tr/WebServices/UrunService.svc?wsdl"));
                factory = new ChannelFactory<IAService>(basicHttpBinding, endpointAddress);

                factory.Credentials.UserName.UserName = "usrn";
                factory.Credentials.UserName.Password = "passw";
                serviceProxy = factory.CreateChannel();

                using (var scope = new OperationContextScope((IContextChannel)serviceProxy))
                {
                    var result = await serviceProxy.getSomethingAsync("id").ConfigureAwait(false);
                }

                factory.Close();
                ((ICommunicationObject)serviceProxy).Close();
            }
            catch (MessageSecurityException ex)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                // *** ENSURE CLEANUP (this code is at the WCF GitHub page *** \\
                CloseCommunicationObjects((ICommunicationObject)serviceProxy, factory);
            }





        }
    }
}