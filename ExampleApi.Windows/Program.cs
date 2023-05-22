using Microsoft.AspNetCore.Hosting;

namespace ExampleApi.Windows
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            StartHost();
        }

        private static void StartHost()
        {
            var host = WebHostBuilder.GetHost().Build();
            host.Run();
        }       
    }
}
