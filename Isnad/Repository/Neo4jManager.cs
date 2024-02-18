using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    using System;
    using Neo4j.Driver;

    public class Neo4jDatabaseManager : IDisposable
    {
        bool _disposed = false;
        private IDriver _driver;

        public Neo4jDatabaseManager(string uri, string user, string password)
        {
            _driver = GraphDatabase.Driver(uri, AuthTokens.Basic(user, password));
        }

        public IAsyncSession GetSession()
        {
            return _driver.AsyncSession();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
            {
                return;
            }
            if (disposing)
            {
                _driver?.Dispose();
            }
            _disposed = true;
        }
    }

}
