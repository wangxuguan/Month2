using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Month2.Data
{
    /* This is used if database provider does't define
     * IMonth2DbSchemaMigrator implementation.
     */
    public class NullMonth2DbSchemaMigrator : IMonth2DbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}