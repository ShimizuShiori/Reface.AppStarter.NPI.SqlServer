using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reface.AppStarter.NPI;
using Reface.AppStarter.NPI.SqlServer.Configs;
using Reface.AppStarter.UnitTests;

namespace Tests
{
    [TestClass]
    public class SqlServerDbConnectionContextProviderTest : TestClassBase<TestAppModule>
    {
        [TestMethod]
        public void CreateSqlServerDbConnectionContextProvider()
        {
            IDbConnectionContextProvider provider = this.ComponentContainer.CreateComponent<IDbConnectionContextProvider>();
            Assert.IsNotNull(provider);
        }

        [TestMethod]
        public void SqlServerConfigIsNotNull()
        {
            var config = this.ComponentContainer.CreateComponent<SqServerConfig>();
            Assert.IsNotNull(config);
        }
    }
}
