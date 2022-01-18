using Volo.Abp.Modularity;

namespace Month2
{
    [DependsOn(
        typeof(Month2ApplicationModule),
        typeof(Month2DomainTestModule)
        )]
    public class Month2ApplicationTestModule : AbpModule
    {

    }
}