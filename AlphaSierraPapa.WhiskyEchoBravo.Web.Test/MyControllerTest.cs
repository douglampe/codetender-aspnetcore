using AlphaSierraPapa.WhiskyEchoBravo.Web.Test.Internal;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace AlphaSierraPapa.WhiskyEchoBravo.Web.Test
{
  public class MyControllerTest : IClassFixture<TestWebApplicationFactory<Startup>>
  {
    private TestWebApplicationFactory<Startup> _factory;
    public MyControllerTest(TestWebApplicationFactory<Startup> factory)
    {
      _factory = factory;
    }

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(4, 5, 9)]
    [InlineData(6, -7, -1)]
    public async Task TestMyControllerMyMethod(int a, int b, int result)
    {
      var client = _factory.CreateClient();

      var response = await client.GetAsync($"/api/myroute/{a}/{b}").ConfigureAwait(false);

      Assert.Equal(HttpStatusCode.OK, response.StatusCode);

      var responseContent = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

      Assert.Equal(result, int.Parse(responseContent));
    }
  }
}
