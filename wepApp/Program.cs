using wepApp.Controllers;
using wepApp.Models; 
using Microsoft.Extensions.DependencyInjection;
using services;

namespace wepApp
{
    public class Startup
    {
       

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews().AddNewtonsoftJson();

            services.AddScoped<IMyService, MyServices>();
        }

        
    }
}