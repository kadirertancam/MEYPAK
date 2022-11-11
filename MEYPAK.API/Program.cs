using AutoMapper.Extensions.ExpressionMapping;
using MEYPAK.BLL.DEPO;
using MEYPAK.BLL.HIZMET;
using MEYPAK.BLL.IRSALIYE;
using MEYPAK.BLL.PERSONEL;
using MEYPAK.BLL.STOK;
using MEYPAK.DAL.Abstract.DepoDal;
using MEYPAK.DAL.Abstract.HizmetDal;
using MEYPAK.DAL.Abstract.IrsaliyeDal;
using MEYPAK.DAL.Abstract.PersonelDal;
using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.DAL.Concrete.EntityFramework.Repository;
using MEYPAK.DAL.Concrete.EntityFramework.Repository.IrsaliyeRepo;
using MEYPAK.Entity.Mappings;
using MEYPAK.Interfaces.Depo;
using MEYPAK.Interfaces.Hizmet;
using MEYPAK.Interfaces.IRSALIYE;
using MEYPAK.Interfaces.Personel;
using MEYPAK.Interfaces.Stok;
using MEYPAK.Entity.IdentityModels;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using MEYPAK.DAL.Abstract.SiparisDal;
using MEYPAK.Interfaces.Siparis;
using MEYPAK.BLL.SIPARIS;
using MEYPAK.DAL.Abstract.AracDal;
using MEYPAK.DAL.Concrete.EntityFramework.Repository.AracRepo;
using MEYPAK.Interfaces.Arac;
using MEYPAK.BLL.ARAC;
using MEYPAK.DAL.Abstract.CariDal;
using MEYPAK.Interfaces.Cari;
using MEYPAK.BLL.CARI;
using Microsoft.AspNetCore.Identity;
using MEYPAK.DAL.Abstract.ParametreDal;
using MEYPAK.DAL.Concrete.EntityFramework.Repository.ParametreRepo;
using MEYPAK.Interfaces.Parametre;
using MEYPAK.BLL.PARAMETRE;
using System.Data.Entity;
using MEYPAK.Entity.Models.PERSONEL;
using MEYPAK.DAL.Concrete.EntityFramework.Repository.PersonelRepo;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//MaplemeAyarlarý

//builder.Services.AddControllers(options => options.SuppressImplicitRequiredAttributeForNonNullableReferenceTypes = true);
builder.Services.AddDbContext<MEYPAKContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("MyCon"));
});

builder.Services.AddIdentity<MPUSER, MPROLE>(options =>
{
    options.User.RequireUniqueEmail = true;
    options.Password.RequiredLength = 5;
    options.Password.RequireLowercase = false;
    options.Password.RequireUppercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireDigit = false;
    options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789_@.";
}).AddDefaultTokenProviders().AddEntityFrameworkStores<MEYPAKContext>();

builder.Services.AddControllersWithViews()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
        options.JsonSerializerOptions.WriteIndented = true;
        options.JsonSerializerOptions.PropertyNamingPolicy = null;

    });

builder.Services.AddSession();
builder.Services.AddAutoMapper(x =>
{
    x.AddExpressionMapping(); //expressionlari maplemek içindir
    x.AddProfile(typeof(Maps));
});



#region Parametre
builder.Services.AddScoped<IParaBirimDal, EFParaBirimRepo>();
builder.Services.AddScoped<IParaBirimServis, ParaBirimManager>();
#endregion
#region Cari

builder.Services.AddScoped<ICariHarDal, EFCariHarRepo>();
builder.Services.AddScoped<ICariHarServis, CariHarManager>();

builder.Services.AddScoped<ICariKartDal, EFCariKartRepo>();
builder.Services.AddScoped<ICariKartServis, CariKartManager>();

builder.Services.AddScoped<IAdresListDal, EFADRESLISTREPO>();
builder.Services.AddScoped<IAdresListServis, AdresListManager>();

builder.Services.AddScoped<ICariAltHesDal, EFCariAltHesRepo>();
builder.Services.AddScoped<ICariAltHesServis,CariAltHesManager>();
 
#endregion
#region STOK_Scoped_Islemleri

builder.Services.AddScoped<IStokDal, EFStokRepo>();
builder.Services.AddScoped<IStokServis, StokManager>();

builder.Services.AddScoped<IStokHarDal, EFStokHareketRepo>();
builder.Services.AddScoped<IStokHarServis, StokHarManager>();

builder.Services.AddScoped<IStokFiyatListDal, EFStokFiyatListRepo>();
builder.Services.AddScoped<IStokFiyatListServis, StokFiyatListManager>();

builder.Services.AddScoped<IStokFiyatListHarDal, EFStokFiyatListHarRepo>();
builder.Services.AddScoped<IStokFiyatListHarServis, StokFiyatListHarManager>();

builder.Services.AddScoped<IStokKasaDal, EFStokKasaRepo>();
builder.Services.AddScoped<IStokKasaServis, StokKasaManager>();

builder.Services.AddScoped<IStokKategoriDal, EFStokKategoriRepo>();
builder.Services.AddScoped<IStokKategoriServis, StokKategoriManager>();

builder.Services.AddScoped<IStokMarkaDal, EFStokMarkaRepo>();
builder.Services.AddScoped<IStokMarkaServis, StokMarkaManager>();

builder.Services.AddScoped<IStokOlcuBrDal, EFStokOlcuBrRepo>();
builder.Services.AddScoped<IStokOlcuBrServis, StokOlcuBrManager>();

builder.Services.AddScoped<IStokSayimDal, EFStokSayimRepo>();
builder.Services.AddScoped<IStokSayimServis, StokSayimManager>();

builder.Services.AddScoped<IStokSayimHarDal, EFStokSayimHarRepo>();
builder.Services.AddScoped<IStokSayimHarServis, StokSayimHarManager>();

builder.Services.AddScoped<IHizmetDal, EFHizmetRepo>();
builder.Services.AddScoped<IHizmetServis, HizmetManager>();

builder.Services.AddScoped<IOlcuBrDal, EFOlcuBrRepo>();
builder.Services.AddScoped<IOlcuBrServis, OlcuBrManager>();


#endregion
#region DEPO_Scoped_Islemleri
builder.Services.AddScoped<IDepoDal, EFDepoRepo>();
builder.Services.AddScoped<IDepoServis, DepoManager>();

builder.Services.AddScoped<IDepoCekiListDal, EFDepoCekiListRepo>();
builder.Services.AddScoped<IDepoCekiListServis, DepoCekiListManager>();

builder.Services.AddScoped<IDepoEmirDal, EFDepoEmirRepo>();
builder.Services.AddScoped<IDepoEmirServis, DepoEmirManager>();

builder.Services.AddScoped<IDepoTransferDal, EFDepoTransferRepo>();
builder.Services.AddScoped<IDepoTransferServis, DepoTransferManager>();

builder.Services.AddScoped<IDepoTransferHarDal, EFDepoTransferHarRepo>();
builder.Services.AddScoped<IDepoTransferHarServis, DepoTransferHarManager>();

builder.Services.AddScoped<IStokMalKKabulListDal, EFStokMalKabulList>();
builder.Services.AddScoped<IStokMalKabulListServis, StokMalKabulListManager>();

builder.Services.AddScoped<IStokSevkiyatListDal, EFStokSevkiyatListRepo>();
builder.Services.AddScoped<IStokSevkiyatListServis, StokSevkiyatListManager>();

builder.Services.AddScoped<IStokMalKKabulListDal, EFStokMalKabulList>();
builder.Services.AddScoped<IStokMalKabulListServis, StokMalKabulListManager>();

#endregion
#region IRSALIYE_Scoped_Islemleri

builder.Services.AddScoped<IIrsaliyeDal, EFIrsaliyeRepo>();
builder.Services.AddScoped<IIrsaliyeServis, IrsaliyeManager>();

builder.Services.AddScoped<IIrsaliyeDetayDal, EFIrsaliyeDetayRepo>();
builder.Services.AddScoped<IIrsaliyeDetayServis, IrsaliyeDetayManager>();

#endregion
#region HIZMET_Scoped_Islemleri

builder.Services.AddScoped<IHizmetDal, EFHizmetRepo>();
builder.Services.AddScoped<IHizmetServis, HizmetManager>();

#endregion
#region PERSONEL_Scoped_Islemleri

builder.Services.AddScoped<IPersonelDal, EFPersonelRepo>();
builder.Services.AddScoped<IPersonelServis, PersonelManager>();

builder.Services.AddScoped<IPersonelDepartmanDal, EFPersonelDepartmanRepo>();
builder.Services.AddScoped<IPersonelDepartmanServis, PersonelDepartmanManager>();

builder.Services.AddScoped<IPersonelGorevDal, EFPersonelGorevRepo>();
builder.Services.AddScoped<IPersonelGorevServis, PersonelGorevManager>();

builder.Services.AddScoped<IPersonelZimmetDal, EFPersonelZimmetRepo>();
builder.Services.AddScoped<IPersonelZimmetServis, PersonelZimmetManager>();
#endregion
#region SIPARIS_Scoped_Islemleri
builder.Services.AddScoped<ISiparisDal, EFSiparisRepo>();
builder.Services.AddScoped<ISiparisServis, SiparisManager>();

builder.Services.AddScoped<ISiparisDetayDal, EFSiparisDetayRepo>();
builder.Services.AddScoped<ISiparisDetayServis, SiparisDetayManager>();

builder.Services.AddScoped<ISiparisSevkEmriHarDal, EFSiparisSevkEmriHarRepo>();
builder.Services.AddScoped<ISiparisSevkEmriHarServis, SiparisSevkEmriHarManager>();



#endregion
#region ARAC_Scoped_Islemleri
builder.Services.AddScoped<IAracDal, EFAracRepo>();
builder.Services.AddScoped<IAracServis, AracManager>();

#endregion





builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();
app.UseSession();
app.UseDeveloperExceptionPage();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseAuthentication(); //Login ve logout iþlemlerinde  
app.UseAuthorization();

app.MapControllers();

app.Run();



