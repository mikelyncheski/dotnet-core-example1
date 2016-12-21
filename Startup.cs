using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;


namespace Example1
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseMvc();

            // Handler of last Resort
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync($"Could not find request {context.Request.Path}. The Time is {DateTime.Now.ToString("hh:mm:ss tt")}.  Have a nice day.");
            });
        }
    }
}