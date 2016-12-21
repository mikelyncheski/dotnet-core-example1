using System.IO;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;


namespace Example1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
                   .AddCommandLine(args)
                   .AddEnvironmentVariables();

            var host = new WebHostBuilder()
                            .UseContentRoot(Directory.GetCurrentDirectory())
                            .UseKestrel()
                            .UseStartup<Startup>()
                            .UseConfiguration(builder.Build())
                            .Build();

            host.Run();
        }
    }
}
