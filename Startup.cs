using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using System.Net.Http;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Collections.ObjectModel;

namespace DeployDemo
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            
        }

        ///
        /// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        ///
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
             //LoggerFactory.AddConsole(Configuration.GetSection("Logging"));
             //LoggerFactory.AddDebug();

             if(env.IsDevelopment())
             {
                 app.UseDeveloperExceptionPage();
                // app.UseDatabaseErrorPage();
                // app.UseBrowserLink();
             }
             else
             {
                 app.UseExceptionHandler("/Home/Error");
             }

             //app.UseStaticFiles();

             //app.UseIdentity();

            //  app.UseMvc(routes =>
            //  {
            //      routes.MapRoute(
            //          name: "default",
            //          template: ""
            //      );
            //  });

            //  app.Run(async (context, next) =>
            //  {
            //      await next.Invoke();
            //  });

             app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello CodeMan!");
            });

        } 
    }
}
