using NHibernate;

namespace MVP_example.DataAccess.nHibernate
{
    static class Factory
    {
        private const string AzureConnectionString = "Server=tcp:irktykc7ce.database.windows.net,1433;Database=Garden;User ID=Ed@irktykc7ce;Password=P@ssw0rd;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        private static ISessionFactory _sessionFactory;
        
        public static ISession OpenSession()
        {
            if (_sessionFactory == null)
            {
                _sessionFactory = FluentNHibernate.Cfg.Fluently.Configure()
                    .Database(GetDatabaseConfiguration())
                    .Mappings((x) => x.FluentMappings.AddFromAssemblyOf<Model.Model>()
                        .Conventions.Setup((y) => y.Add(FluentNHibernate.Conventions.Helpers.AutoImport.Never())))
                    .BuildSessionFactory();
            }
            return _sessionFactory.OpenSession();
        }

        public static FluentNHibernate.Cfg.Db.MsSqlConfiguration GetDatabaseConfiguration()
        {
            var configuration =
                FluentNHibernate.Cfg.Db.MsSqlConfiguration.MsSql2012.ConnectionString(AzureConnectionString);
#if DEBUG
            configuration.ShowSql();
            configuration.FormatSql();
#endif
            return configuration;
        }

    }
}
