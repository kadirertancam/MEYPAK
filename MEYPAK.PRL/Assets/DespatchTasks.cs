
using ServiceReference11;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_İrsaliyeDemo_v1._0._0
{
    class DespatchTasks
    {


        public static DespatchTasks Instance = new DespatchTasks();


        public DespatchIntegrationClient CreateClient()
        {
            var username = "Uyumsoft";
            var password = "Uyumsoft";
            var serviceuri = "https://efatura-test.uyumsoft.com.tr/services/DespatchIntegration";


            DespatchIntegrationClient client = new DespatchIntegrationClient();
            client.Endpoint.Address = new System.ServiceModel.EndpointAddress(serviceuri);
            client.ClientCredentials.UserName.UserName = username;
            client.ClientCredentials.UserName.Password = password;
            return client;
        }
    }


}
