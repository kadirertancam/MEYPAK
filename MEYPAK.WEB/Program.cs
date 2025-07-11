using MEYPAK.WEB.Controllers.DefaultController;
{

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
            name: "default",
            pattern: "{controller=Default}/{action=Index}/{id?}");
    }
    );
    app.Run();
}