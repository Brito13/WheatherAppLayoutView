using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();


app.MapControllers();
app.UseRouting();
app.UseStaticFiles();
//app.MapFallbackToController("Index","Home");
app.UseStatusCodePagesWithReExecute("/Home/Error/{0}");
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.Run();
