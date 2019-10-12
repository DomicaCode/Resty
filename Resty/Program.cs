using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace Resty.Web
{
    public static class Program
    {
        #region Methods

        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        private static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
                    WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();

        #endregion Methods
    }
}