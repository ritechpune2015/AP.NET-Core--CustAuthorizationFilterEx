using CustAuthorizationFilterEx.Models;
using CustAuthorizationFilterEx.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContextPool<CompanyContext>(
	opt => opt.UseSqlServer(
		builder.Configuration.GetConnectionString("scon")
		));
builder.Services.AddScoped<IProduct,ProductRepo>();
builder.Services.AddScoped<IUser, UserRepo>();

var app = builder.Build();

app.MapControllerRoute(
	name: "areas",
	pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
app.MapDefaultControllerRoute();
app.Run();
