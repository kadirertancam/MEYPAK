using e_İrsaliyeDemo_v1._0._0;
using ServiceReference11;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.PRL.Assets
{
    class DespatchTasks2
    {
        public static DespatchTasks2 Instance = new DespatchTasks2();


        public DespatchIntegrationClient CreateClient()
        {
            var username = "Gunduz";
            var password = "iJAfhKSU";
            var serviceuri = "https://efatura.uyumsoft.com.tr/services/DespatchIntegration";


            DespatchIntegrationClient client = new DespatchIntegrationClient();
            client.Endpoint.Address = new System.ServiceModel.EndpointAddress(serviceuri);
            client.ClientCredentials.UserName.UserName = username;
            client.ClientCredentials.UserName.Password = password;
            return client;
        }
    }
}
