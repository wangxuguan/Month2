using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Month2
{
    [Dependency(ReplaceServices = true)]
    public class Month2BrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Month2";
    }
}
