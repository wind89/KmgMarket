using System;
using System.Collections.Generic;
using System.Text;

namespace EMarket.DAL
{
    public class DbContextProvider : IDisposable
    {
        public DbContextProvider(AppConfiguration appConfiguration)
        {
            DbContext = new ApplicationDbContext(appConfiguration.ConnectionString);
        }

        public ApplicationDbContext DbContext { get; private set; }

        public void Dispose()
        {
            DbContext.Dispose();
            DbContext = null;
        }
    }
}
