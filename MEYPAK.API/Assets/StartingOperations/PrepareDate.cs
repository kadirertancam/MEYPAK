using MEYPAK.BLL.Assets;
using MEYPAK.BLL.FORMYETKI;
using MEYPAK.Entity.IdentityModels;
using MEYPAK.Entity.Models.FORMYETKI;
using MEYPAK.Entity.PocoModels.FORMYETKI;
using MEYPAK.Entity.PocoModels.PARAMETRE;
using MEYPAK.Interfaces.FormYetki;
using MEYPAK.Interfaces.Parametre;
using Microsoft.AspNetCore.Identity;
using System.Xml;
using System.Xml.Serialization;

namespace MEYPAK.API.Assets.StartingOperations
{
    public static class PrepareDate
    {
        public static IApplicationBuilder PrepareData(this IApplicationBuilder app)
        {
            using var scopedServices = app.ApplicationServices.CreateScope();
            var serviceProvider = scopedServices.ServiceProvider;


            var roleManager = serviceProvider.GetRequiredService<RoleManager<MPROLE>>();
            var formManager = serviceProvider.GetRequiredService<IFormServis>();
            var paraManager = serviceProvider.GetRequiredService<IParaBirimServis>();
            CreateAllRoles(roleManager);
            CreatAllForms(formManager);
            CreateAllCurrency(paraManager);
            return app;
        }
        public static void CreateAllRoles(RoleManager<MPROLE> roleManager)
        {
            try
            {
                string[] allRoles = Enum.GetNames(typeof(AllRoles));
                foreach (string role in allRoles)
                {
                    if (!roleManager.RoleExistsAsync(role).Result)
                    {
                        //eğer o rol yoksa ekle
                        MPROLE r = new MPROLE()
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = role,
                            ACIKLAMA = $"Sistem tarafından otomatik olarak '{role}' rolü oluşturuldu.",
                            OLUSTURMATARIHI = DateTime.Now,
                            GUNCELLEMETARIHI = DateTime.Now,
                        };
                        var result = roleManager.CreateAsync(r).Result;
                    }
                }
            }
            catch (Exception)
            {


            }
        }
        public static void CreatAllForms(IFormServis formManager)
        {
            try
            {
                string[] allForms = Enum.GetNames(typeof(AllForms));
                var formListe = formManager.Listele().Where(x => x.kayittipi == 0).Select(x => x.FORMADI);
                foreach (string form in allForms)
                {
                    if (!formListe.Contains(form))
                    {
                        //eğer o rol yoksa ekle
                        PocoFORM f = new PocoFORM()
                        {
                            FORMADI = form,
                            userid = "API CREATE",
                        };
                        formManager.Ekle(f);
                    }
                }

            }
            catch (Exception)
            {

            }
        }
        public static void CreateAllCurrency(IParaBirimServis paraBirimServis)
        {
            try
            {

                HttpRequestMessage client;
                HttpClient httpClient = new HttpClient();
                client = new HttpRequestMessage(HttpMethod.Post, "https://www.tcmb.gov.tr/kurlar/today.xml");
                client.Headers.Add("Connection", "keep-alive");
                client.Headers.Add("Host", "www.tcmb.gov.tr");
                client.Headers.Add("User-Agent", "CodeGear SOAP 1.3");
                client.Method = HttpMethod.Get;
                httpClient.DefaultRequestHeaders.ExpectContinue = false;
                HttpResponseMessage resp = httpClient.SendAsync(client).Result;
                var aaaa = resp.Content.ReadAsStringAsync().Result.ToString();
                XmlSerializer xmlSerializerHelper  = new XmlSerializer(typeof(Tarih_Date));
                TextReader textReader = new StringReader(aaaa);
                Tarih_Date _tarih_Date = (Tarih_Date)xmlSerializerHelper.Deserialize(textReader);
               
                foreach (var item in _tarih_Date.Currency)
                {
                    if (paraBirimServis.Listele().Where(x => x.adi == item.Isim).Count() == 0)
                        paraBirimServis.EkleyadaGuncelle( new PocoPARABIRIM()
                        {
                            adi = item.Isim,
                            kisaadi = item.Kod,
                            dovizsatis = Convert.ToDecimal(item.ForexSelling == "" ? "0" : item.ForexSelling),
                            dovizalis = item.ForexBuying,
                            dovizefektifalis = Convert.ToDecimal(item.BanknoteBuying == "" ? "0" : item.BanknoteBuying),
                            dovizefektifsatis = Convert.ToDecimal(item.BanknoteSelling == "" ? "0" : item.BanknoteSelling),
                            userid = "APICREATE",
                            aktif=1,

                        });
                  
                }
     

            }
            catch (Exception)
            {

            }
        }
    }
}
