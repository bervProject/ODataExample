using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace ODataExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateWebHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webHost =>
            {
                webHost.ConfigureKestrel(options =>
                {
                    options.AllowSynchronousIO = true;
                }).UseStartup<Startup>();
            });
    }
}
