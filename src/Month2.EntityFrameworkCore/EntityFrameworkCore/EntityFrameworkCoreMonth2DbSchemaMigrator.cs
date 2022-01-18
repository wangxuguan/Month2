using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Month2.Data;
using Volo.Abp.DependencyInjection;

namespace Month2.EntityFrameworkCore
{
    public class EntityFrameworkCoreMonth2DbSchemaMigrator
        : IMonth2DbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreMonth2DbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the Month2DbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<Month2DbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
