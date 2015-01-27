using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using StructureMap.Configuration.DSL;
using System.Configuration;

namespace Quiz.Repositorio
{
    public class NhibernateRegistry : Registry
    {
        public NhibernateRegistry()
        {
            For<ISessionFactory>().Singleton().Use(ObterSessionFactory());
            For<ISession>().HybridHttpOrThreadLocalScoped().Use(
                x => x.GetInstance<ISessionFactory>().OpenSession());
        }

        private static ISessionFactory ObterSessionFactory()
        {
            return Fluently.Configure()
                .Database(
                    MySQLConfiguration.Standard.ConnectionString(ConfigurationManager.AppSettings["Mapeamento_BD"]).ShowSql()
                )
                .Mappings(c => c.FluentMappings.AddFromAssemblyOf<Dominio.Entidade.TipoConta>())
                .ExposeConfiguration(config => new SchemaExport(config).Create(false, true))
                .BuildSessionFactory();
        }
    }
}
