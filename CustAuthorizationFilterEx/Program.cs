using CustAuthorizationFilterEx.Models;
using CustAuthorizationFilterEx.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDistributedMemoryCache();
builder.Services.AddControllersWithViews();
builder.Services.AddDbContextPool<CompanyContext>(
	opt => opt.UseSqlServer(
		builder.Configuration.GetConnectionString("scon")
		));
builder.Services.AddScoped<IProduct,ProductRepo>();
builder.Services.AddScoped<IUser, UserRepo>();
//builder.Services.AddSession(); //default configuration
builder.Services.AddSession(opt => {
	opt.IdleTimeout = TimeSpan.FromMinutes(10);
	opt.Cookie.IsEssential = true;
	opt.Cookie.HttpOnly = true;
});

var app = builder.Build();
app.UseSession();
app.MapControllerRoute(
	name: "areas",
	pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
app.MapDefaultControllerRoute();
app.Run();
