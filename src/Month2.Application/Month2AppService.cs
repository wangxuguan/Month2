using System;
using System.Collections.Generic;
using System.Text;
using Month2.Localization;
using Volo.Abp.Application.Services;

namespace Month2
{
    /* Inherit your application services from this class.
     */
    public abstract class Month2AppService : ApplicationService
    {
        protected Month2AppService()
        {
            LocalizationResource = typeof(Month2Resource);
        }
    }
}
