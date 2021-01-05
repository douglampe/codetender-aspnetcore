using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;

namespace AlphaSierraPapa.WhiskyEchoBravo.Web.Test.Internal
{
  public class TestWebApplicationFactory<T> : WebApplicationFactory<T> where T : class
  {
    protected override IWebHostBuilder CreateWebHostBuilder()
    {
      return WebHost.CreateDefaultBuilder()
        .UseStartup<T>();
    }

    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
      // Load any content from the project folder
      builder.UseSolutionRelativeContentRoot("AlphaSierraPapa.WhiskyEchoBravo.Web.Test");
    }
  }
}
