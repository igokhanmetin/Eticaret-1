using Eticaret.Panel.DatabaseContexts;
using Eticaret.Panel.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<MainDatabaseContext>(options =>
{
    options.UseSqlServer("Server=UY1-07\\SQLEXPRESS; Database=BiMilyoncu; TrustServerCertificate=True; Trusted_Connection=True;");
}, ServiceLifetime.Scoped);

builder.Services.AddScoped<IKategoriService, KategoriService>();
builder.Services.AddScoped<IUrunService, UrunService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
