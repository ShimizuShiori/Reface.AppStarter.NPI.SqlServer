using Reface.AppStarter.Attributes;
using Reface.AppStarter.NPI.SqlServer.Configs;
using System.Data.SqlClient;

namespace Reface.AppStarter.NPI.SqlServer
{
    [Component]
    public class SqlServerDbConnectionContextProvider : IDbConnectionContextProvider
    {
        private readonly SqServerConfig config;
        private DbConnectionContext dbConnectionContext;

        public SqlServerDbConnectionContextProvider(SqServerConfig config)
        {
            this.config = config;
            this.dbConnectionContext = new DbConnectionContext(new SqlConnection(config.ConnectionString));
        }

        public DbConnectionContext Provide()
        {
            return this.dbConnectionContext;
        }
    }
}
