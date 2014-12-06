using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using FluentNHibernateSessionMagic.DataLayer;

namespace FluentNHibernateSessionMagic
{
	public class MSSQLSessionFactory
	{
		private static ISessionFactory _sessionFactory;
		private static ISessionFactory SessionFactory
		{
			get
			{
				if (_sessionFactory == null)
				{
					string serverInstance = "YOURSERVERINSTANCE";

					_sessionFactory = Fluently.Configure()
					.Database(MsSqlConfiguration.MsSql2005
					.ConnectionString("Server=" + serverInstance + ";Initial Catalog=sampledata;Integrated Security=True"))
					.Mappings(m => m.FluentMappings.Add<DepartmentMap>())
					.Mappings(m => m.FluentMappings.Add<StoreMap>())
					.ExposeConfiguration(config =>
					{
						SchemaExport schemaExport = new SchemaExport(config);
					})
					.BuildSessionFactory();
				}
				return _sessionFactory;
			}
		}
		public static SessionWrapper OpenSession()
		{
			return new SessionWrapper(SessionFactory.OpenSession());
		}
	}
}
