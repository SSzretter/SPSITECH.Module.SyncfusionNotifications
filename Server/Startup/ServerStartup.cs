using Microsoft.AspNetCore.Builder; 
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Oqtane.Infrastructure;
using Syncfusion.Blazor;

namespace SPSITECH.Module.SyncfusionNotifications.Startup
{
    public class ServerStartup : IServerStartup
    {
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Register Syncfusion license  Get a free license here:  https://www.syncfusion.com/products/communitylicense

            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false,
                reloadOnChange: true);


            var Configuration = builder.Build();
            var SyncfusionLicense = Configuration.GetSection("SyncfusionLicense");
            if (SyncfusionLicense != null)
            {
                Syncfusion.Licensing.SyncfusionLicenseProvider
                    .RegisterLicense(SyncfusionLicense.Value);
            }
        }

        public void ConfigureMvc(IMvcBuilder mvcBuilder)
        {
            // not implemented
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSyncfusionBlazor();
            services.AddSingleton<ToastService>();
           
        }
    }
}
