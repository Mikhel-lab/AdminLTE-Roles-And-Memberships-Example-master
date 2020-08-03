using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(coderush.Areas.Identity.IdentityHostingStartup))]
namespace coderush.Areas.Identity
{
	public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}