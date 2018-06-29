using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Womb.NameGeneration;
using Womb.Platform;
using Womb.WordResolver;

namespace Womb
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
            services.AddMvc();
            services.AddSingleton<IFileProvider>(new PhysicalFileProvider(Directory.GetCurrentDirectory()));
            services.AddSingleton<IWordResolver, NonCommonWordResolver>();
            services.AddSingleton<IConfiguration>(Configuration);

            services.AddTransient<INameGenerator, DualWordNameGenerator>();
            services.AddTransient<IConnectionStringResolver, ConfigurationConnectionStringResolver>();
            services.AddTransient<ICreationCountRepository, SqlCreationCountRepository>();
            services.AddTransient<ICharacterCreationCountResolver, SqlCharacterCreationCountResolver>();
            services.AddTransient<ICharacterSaver, SqlCharacterSaver>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Character/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Character}/{action=Birth}");
            });
        }
    }
}
