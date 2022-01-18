using Month2.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Month2
{
    [DependsOn(
        typeof(Month2EntityFrameworkCoreTestModule)
        )]
    public class Month2DomainTestModule : AbpModule
    {

    }
}