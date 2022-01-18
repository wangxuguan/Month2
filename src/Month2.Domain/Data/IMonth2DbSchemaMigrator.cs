using System.Threading.Tasks;

namespace Month2.Data
{
    public interface IMonth2DbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
