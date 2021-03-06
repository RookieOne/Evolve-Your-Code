﻿using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Data;
using NHibernate.Cache;

namespace FluentInterfaces.FluentNHibernate
{
    public class FluentNHibernateExample
    {
        public void Example()
        {
            MsSqlConfiguration.MsSql2005
                .ConnectionString(c => c
                                           .Server("server")
                                           .Database("database")
                                           .Username("username")
                                           .Password("password"));

            Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2005
                              .ConnectionString(c => c.FromAppSetting("connectionString"))
                              .Cache(c => c.UseQueryCache()
                                              .ProviderClass<HashtableCacheProvider>())
                              .ShowSql())
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Entity>())
                .BuildSessionFactory();
        }
    }
}