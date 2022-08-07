using test.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace test.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class testPageModel : AbpPageModel
{
    protected testPageModel()
    {
        LocalizationResourceType = typeof(testResource);
    }
}
