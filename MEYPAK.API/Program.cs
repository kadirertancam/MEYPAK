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
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Interfaces.Depo;
using MEYPAK.Interfaces.Hizmet;
using MEYPAK.Interfaces.IRSALIYE;
using MEYPAK.Interfaces.Personel;
using MEYPAK.Interfaces.Stok;
using Microsoft.AspNetCore.OData;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Routing;
using MEYPAK.DAL.Abstract.SiparisDal;
using MEYPAK.Interfaces.Siparis;
using MEYPAK.BLL.SIPARIS;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//Odata add to parameter /?$select=id
builder.Services.AddControllers().AddOData(opt => opt.EnableQueryFeatures());

//MaplemeAyarlar�
builder.Services.AddAutoMapper(x =>
{
    x.AddExpressionMapping(); //expressionlari maplemek i�indir
    x.AddProfile(typeof(Maps));
});
builder.Services.AddControllers(options => options.SuppressImplicitRequiredAttributeForNonNullableReferenceTypes = true);
builder.Services.AddDbContext<MEYPAKContext>(options =>
{
    
    options.UseSqlServer(builder.Configuration.GetConnectionString("MyCon"));
});


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
builder.Services.AddScoped<IDepoServis, DepoManager>();

builder.Services.AddScoped<IDepoEmirDal, EFDepoEmirRepo>();
builder.Services.AddScoped<IDepoEmirServis, DepoEmirManager>();

builder.Services.AddScoped<IDepoTransferDal, EFDepoTransferRepo>();
builder.Services.AddScoped<IDepoTransferServis, DepoTransferManager>();

builder.Services.AddScoped<IDepoTransferHarDal, EFDepoTransferHarRepo>();
builder.Services.AddScoped<IDepoTransferHarServis, DepoTransferHarManager>();


builder.Services.AddScoped<IStokSevkiyatListDal, EFStokSevkiyatListRepo>();
builder.Services.AddScoped<IStokSevkiyatListServis, StokSevkiyatListManager>();


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
#endregion
#region SIPARIS_Scoped_Islemleri
builder.Services.AddScoped<ISiparisDal, EFSiparisRepo>();
builder.Services.AddScoped<ISiparisServis, SiparisManager>();

builder.Services.AddScoped<ISiparisDetayDal, EFSiparisDetayRepo>();
builder.Services.AddScoped<ISiparisDetayServis, SiparisDetayManager>();

builder.Services.AddScoped<ISiparisSevkEmriHarDal, EFSiparisSevkEmriHarRepo>();
builder.Services.AddScoped<ISiparisSevkEmriHarServis, SiparisSevkEmriHarManager>();

#endregion

builder.Services.AddControllers().AddJsonOptions(x => x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();
app.UseDeveloperExceptionPage();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();



