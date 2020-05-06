using DotnetForum.Contracts.Services;
using DotnetForum.WebApi.Database;
using DotnetForum.WebApi.Services;
using Grace.AspNetCore.MVC;
using Grace.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using DotnetForum.Contracts.Repository;

namespace DotnetForum.WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ForumDatabaseContext>(
                options => options.UseSqlite("Data Source=database.db", b => b.MigrationsAssembly("DotnetForum.WebApi")));

            services.AddControllers().AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
            });
        }

        public void ConfigureContainer(IInjectionScope scope)
        {
            scope.SetupMvc();

            scope.Configure(c =>
            {
                c.Export<WeatherForecastService>()
                    .As<IWeatherForecastService>();

                c.Export<RandomizerService>()
                    .As<IRandomizerService>();

                c.Export<IMembershipRepository>()
                    .As<MembershipRepository>();
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
