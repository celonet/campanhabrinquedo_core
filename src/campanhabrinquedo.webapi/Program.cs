using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore;

namespace campanhabrinquedo.webapi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            .UseStartup<Startup>()
            .UseDefaultServiceProvider(options => options.ValidateScopes = false)
            .UseUrls("http://localhost:5000")
            .Build();
    }
}
