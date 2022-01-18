using Month2.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Month2.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class Month2Controller : AbpControllerBase
    {
        protected Month2Controller()
        {
            LocalizationResource = typeof(Month2Resource);
        }
    }
}