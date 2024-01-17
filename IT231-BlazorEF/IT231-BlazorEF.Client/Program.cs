using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace IT231_BlazorEF.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            WebAssemblyHostBuilder builder = WebAssemblyHostBuilder.CreateDefault(args);

            await builder.Build().RunAsync();
        }
    }
}
