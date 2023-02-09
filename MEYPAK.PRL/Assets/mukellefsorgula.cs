using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using OPTYPE.HizliTeknoloji;



namespace MEYPAK.PRL.Assets
{
    public class mukellefsorgula
    {
        public MukellefOutput sorgu(string vkntc)
        {
            String MeslekMensubKey = "0109c0c1e9694109a1e3d1b6b01f6d7f";


            string VergiNo = vkntc;
            VergiNo = VergiNo.Replace(" ", "");

            MukellefOutput mukellefOutput= new MukellefOutput();
            try
            {
                //APP CONFIG OLMAYANLAR İÇİN
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                BasicHttpBinding basicHttpBinding = new BasicHttpBinding();
                basicHttpBinding.Security.Mode = BasicHttpSecurityMode.Transport;
                basicHttpBinding.Name = "BasicHttpBinding_IHizliService";
                basicHttpBinding.MaxBufferPoolSize = 2147483647L;
                basicHttpBinding.MaxBufferSize = 2147483647;
                basicHttpBinding.MaxReceivedMessageSize = 2147483647L;
                EndpointAddress endpointAddress = new EndpointAddress(new Uri("https://econnect.hizliteknoloji.com.tr/Services/HizliService.svc"), new AddressHeader[0]);
                string kullaniciAdi = "admin_006334";
                string sifre = "wBWwKaZ0";

                HizliServiceClient hizliServiceClient = new HizliServiceClient(basicHttpBinding, endpointAddress);
                OperationContextScope operationContextScope = new OperationContextScope(hizliServiceClient.InnerChannel);
                try
                {
                    HttpRequestMessageProperty httpRequestMessageProperty = new HttpRequestMessageProperty();
                    httpRequestMessageProperty.Headers.Add("username", kullaniciAdi);
                    httpRequestMessageProperty.Headers.Add("password", sifre);
                    OperationContext.Current.OutgoingMessageProperties[HttpRequestMessageProperty.Name] = httpRequestMessageProperty;
                    MukellefBilgisi mukellefBilgisi = new MukellefBilgisi()
                    {
                        vknTckn = VergiNo,
                        meslekMensubuKey = MeslekMensubKey
                    };
                    mukellefOutput = hizliServiceClient.MukellefBilgisiSorgulama(mukellefBilgisi);



                }
                catch (Exception ex)
                {

                }
            }
            catch (Exception)
            {

            }
            return mukellefOutput;


        }
    }
}
