using Microsoft.AspNetCore;

namespace ExampleApi
{
    public class WebHostBuilder
    {
        public static IWebHostBuilder GetHost()
        {
            var host = WebHost.CreateDefaultBuilder()
                .UseStartup<Startup>();
            return host;
        }
    }
}
