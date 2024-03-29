﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System.IO;

namespace MyCourse
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IApplicationLifetime lifetime)
        {
            if (env.IsEnvironment("Development"))
            {
                app.UseDeveloperExceptionPage();
            
                lifetime.ApplicationStarted.Register(() => {
                    string filepath = Path.Combine(env.ContentRootPath, "bin/reload.txt");
                    File.WriteAllText(filepath, DateTime.Now.ToString());
                });
                
            }
            app.UseStaticFiles();

            //app.UseMvcWithDefaultRoute();
            app.UseMvc(routebuilder =>
            {
                routebuilder.MapRoute("default", "{controller=home}/{action=Index}/{id?}");
            });
        }
    }
}
