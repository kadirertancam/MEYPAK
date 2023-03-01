
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.Models.PARAMETRE;
using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EInvoiceDemoProject
{
    public class InvoiceTasks
    {
        public static InvoiceTasks Instance = new InvoiceTasks();

        private InvoiceTasks()
        {
            faturaParamServis = new GenericWebServis<MPEFATURAPARAMS>();
        }
        GenericWebServis<MPEFATURAPARAMS> faturaParamServis;
        public IntegrationClient CreateClient()
        {
            faturaParamServis.Data(ServisList.EFaturaParamsListeServis);

            var username = faturaParamServis.obje.FirstOrDefault().KULADI;
            var password = faturaParamServis.obje.FirstOrDefault().SIFRE;
            var serviceuri = "";
            

            var client = new IntegrationClient();
            client.Endpoint.Address = new System.ServiceModel.EndpointAddress(serviceuri);
            client.ClientCredentials.UserName.UserName = username;
            client.ClientCredentials.UserName.Password = password;
            return client;
        }

        //public bool SaveInvoce(InvoiceType type)
        //{ 
        
        //}
    }
}
