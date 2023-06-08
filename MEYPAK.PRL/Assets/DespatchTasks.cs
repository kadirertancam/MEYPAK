
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.PARAMETRE;
using MEYPAK.Interfaces.Parametre;
using MEYPAK.PRL;
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
        public DespatchTasks()
        {
            efaturaParamsServis = new GenericWebServis<PocoEFATURAPARAMS>();
            main = (Main)Application.OpenForms["Main"];
        }

        public static DespatchTasks Instance = new DespatchTasks();
        GenericWebServis<PocoEFATURAPARAMS> efaturaParamsServis;
        Main main;
        public DespatchIntegrationClient CreateClient()
        {
            efaturaParamsServis.Data(ServisList.EFaturaParamsListeServis);
            var username = efaturaParamsServis.obje.Where(x => x.depoid == main.DEPOID).FirstOrDefault().kuladi;
            var password = efaturaParamsServis.obje.Where(x => x.depoid == main.DEPOID).FirstOrDefault().sifre;
            var serviceuri = "https://efatura.uyumsoft.com.tr/services/DespatchIntegration";
            //var username = "Uyumsoft";
            //var password = "Uyumsoft";
            //var serviceuri = "https://efatura-test.uyumsoft.com.tr/services/BasicIntegration";

            DespatchIntegrationClient client = new DespatchIntegrationClient();
            client.Endpoint.Address = new System.ServiceModel.EndpointAddress(serviceuri);
            client.ClientCredentials.UserName.UserName = username;
            client.ClientCredentials.UserName.Password = password;
            return client;
        }
    }


}
