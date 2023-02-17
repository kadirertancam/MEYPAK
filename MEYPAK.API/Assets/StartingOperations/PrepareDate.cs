using MEYPAK.BLL.Assets;
using MEYPAK.BLL.FORMYETKI;
using MEYPAK.Entity.IdentityModels;
using MEYPAK.Entity.Models.FORMYETKI;
using MEYPAK.Entity.PocoModels.FORMYETKI;
using Microsoft.AspNetCore.Identity;

namespace MEYPAK.API.Assets.StartingOperations
{
    public static class PrepareDate
    {
        public static IApplicationBuilder PrepareData(this IApplicationBuilder app)
        {
            using var scopedServices = app.ApplicationServices.CreateScope();
            var serviceProvider = scopedServices.ServiceProvider;

            
            var roleManager = serviceProvider.GetRequiredService<RoleManager<MPROLE>>();
            var formManager = serviceProvider.GetRequiredService<FormManager>();
            CreateAllRoles(roleManager);
            CreatAllForms(formManager);

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
        public static void CreatAllForms(FormManager formManager)
        {
            try
            {
                string[] allForms = Enum.GetNames(typeof(AllForms));
                var formListe = formManager.Listele().Where(x => x.kayittipi == 0).Select(x => x.FORMADI);
                foreach (string form in allForms)
                {
                    if (formListe.Contains(form))
                    {
                        //eğer o rol yoksa ekle
                        PocoFORM f = new PocoFORM()
                        {
                            FORMADI= form,
                        };
                        formManager.Ekle(f);
                    }
                }

            }
            catch (Exception)
            {

            }
        }
    }
}
