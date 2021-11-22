using WebNewsAggregator.Repositories;
using WebNewsAggregator.Services;
using WebNewsAggregator.Services.Interfaces;
using WebNewsAggregator.Services.Interfaces.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<IWebNewsSourceService, WebNewsSourceService>();
builder.Services.AddTransient<IWebNewsSourceRepo, WebNewsSourceRepo>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
