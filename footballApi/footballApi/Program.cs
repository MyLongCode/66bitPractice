using Api.SignalR.Hubs;
using Dal;
using Dal.EF;
using Logic;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseNpgsql(connectionString));
builder.Services.TryAddLogic();
builder.Services.TryAddDal();
builder.Services.AddSignalR();

var app = builder.Build();


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Footballer}/{action=Index}/{id?}");
app.MapHub<FootballerHub>("/hub");

app.Run();
