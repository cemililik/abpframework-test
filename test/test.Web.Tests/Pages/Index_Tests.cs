using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace test.Pages;

public class Index_Tests : testWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
