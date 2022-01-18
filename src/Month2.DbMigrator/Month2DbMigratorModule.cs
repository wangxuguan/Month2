using Month2.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Month2.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(Month2EntityFrameworkCoreModule),
        typeof(Month2ApplicationContractsModule)
        )]
    public class Month2DbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
