using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using CityCoordinate.Core;

namespace CityCoordinate.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            //services.Configure<CityCoordinateDatabaseSettings>(
            //    Configuration.GetSection(nameof(CityCoordinateDatabaseSettings)));

            //services.AddSingleton<ICityCoordinateDatabaseSettings>(sp =>
            //    sp.GetRequiredService<IOptions<CityCoordinateDatabaseSettings>>().Value);
            //services.AddSingleton<CityСoordinate>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddTransient<ICityСoordinateSearcher, OSMCityСoordinateSearcher>();
            services.AddTransient<ICityСoordinateManager, CityСoordinateManager>();

            //services.Configure<CityСoordinateKey>(o => { o.iConfigurationRoot = Configuration; });
            //services.AddTransient<ICityСoordinateRepository, CityСoordinateRepository>();
            services.AddHttpClient();


            //var appConnection = Configuration.RegisterConfig();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
