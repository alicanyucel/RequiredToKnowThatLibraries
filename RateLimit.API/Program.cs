using AspNetCoreRateLimit;
using System.Configuration;
using Microsoft.Extensions.DependencyInjection;

internal class Program
{

    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        IConfiguration _configuration;
        void ConfigureServices(IConfiguration configuration)
        {
            _configuration = configuration;
            //In here, We can read JWT pair on a class in the appsetting.json
            builder.Services.AddOptions();
            //This method getting us requests hold in the memory
            builder.Services.AddMemoryCache();
            builder.Services.Configure<IpRateLimitOptions>(configuration.GetSection("IpRateLimiting"));
            builder.Services.Configure<IpRateLimitPolicies>(configuration.GetSection("IpRateLimitPolicies"));
            builder.Services.Configure<ClientRateLimitOptions>(configuration.GetSection("ClientRateLimiting"));
            builder.Services.Configure<ClientRateLimitPolicies>(configuration.GetSection("ClientRateLimitPolicies"));
            //If my application has 1 instance can use Memorycache method but has one or many instance DistributeCache method
            builder.Services.AddSingleton<IIpPolicyStore, MemoryCacheIpPolicyStore>();
            builder.Services.AddSingleton<IRateLimitCounterStore, MemoryCacheRateLimitCounterStore>();
            builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            builder.Services.AddSingleton<IRateLimitConfiguration, RateLimitConfiguration>();
            builder.Services.AddSingleton<IClientPolicyStore, MemoryCacheClientPolicyStore>();
        }

        // Add services to the container.

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        //var ipPolicyStore = app.Services.GetRequiredService<IIpPolicyStore>();
        //ipPolicyStore.SeedAsync().GetAwaiter().GetResult();
        var clientPolicyStore = app.Services.GetRequiredService<IClientPolicyStore>();
        clientPolicyStore.SeedAsync().GetAwaiter().GetResult();


        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }
        app.UseClientRateLimiting();

        app.UseIpRateLimiting();

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}