using Hangfire;
using HangFire.Web.Services;

var builder = WebApplication.CreateBuilder(args);

IConfiguration _configuration;

void ConfigureServices(IConfiguration configuration)
{
_configuration = configuration;

// Add services to the container.
builder.Services.AddControllersWithViews();
    builder.Services.AddHangfire(config =>
    {
        config.UseSqlServerStorage(configuration.GetConnectionString("HangfireConnection"));
    });

builder.Services.AddScoped<IEmailSender, EmailSender>();
builder.Services.AddHangfireServer();
}

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

app.MapHangfireDashboard("/hangfire");

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
