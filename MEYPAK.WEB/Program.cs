using MEYPAK.WEB.Controllers.STOKController;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{


    endpoints.MapControllerRoute(
        name: "Stok/Taným/StokEkle",
        pattern: "Stok/Taným/StokEkle",
          new {controller ="STOK", action = "StokEkle"});

    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=STOK}/{action=StokKart}/{id?}");
}
); 
app.Run();
