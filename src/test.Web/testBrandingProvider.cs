using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace test.Web;

[Dependency(ReplaceServices = true)]
public class testBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "test";
}
