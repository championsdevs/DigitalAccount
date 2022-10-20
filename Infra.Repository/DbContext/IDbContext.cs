using System.Data;

namespace Infra.Repository.DbContext
{
    public interface IDbContext
    {
        IDbConnection CreateConnection();
    }
}
