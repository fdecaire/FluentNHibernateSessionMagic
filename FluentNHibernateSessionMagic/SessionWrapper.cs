using System;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using NHibernate;
using NHibernate.Engine;
using NHibernate.Linq;
using NHibernate.Stat;
using NHibernate.Type;

namespace FluentNHibernateSessionMagic
{
	public class SessionWrapper : ISession
	{
		private readonly ISession innerSession;

		public SessionWrapper(ISession innerSession)
		{
			this.innerSession = innerSession;
		}

		public void Dispose()
		{
			innerSession.Dispose();
		}

		public void Flush()
		{
			innerSession.Flush();
		}

		public IDbConnection Disconnect()
		{
			return innerSession.Disconnect();
		}

		public void Reconnect()
		{
			innerSession.Reconnect();
		}

		public void Reconnect(IDbConnection connection)
		{
			innerSession.Reconnect(connection);
		}

		public IDbConnection Close()
		{
			return innerSession.Close();
		}

		public void CancelQuery()
		{
			innerSession.CancelQuery();
		}

		public bool IsDirty()
		{
			return innerSession.IsDirty();
		}

		public bool IsReadOnly(object entityOrProxy)
		{
			return innerSession.IsReadOnly(entityOrProxy);
		}

		public void SetReadOnly(object entityOrProxy, bool readOnly)
		{
			innerSession.SetReadOnly(entityOrProxy, readOnly);
		}

		public object GetIdentifier(object obj)
		{
			return innerSession.GetIdentifier(obj);
		}

		public bool Contains(object obj)
		{
			return innerSession.Contains(obj);
		}

		public void Evict(object obj)
		{
			innerSession.Evict(obj);
		}

		public object Load(Type theType, object id, LockMode lockMode)
		{
			return innerSession.Load(theType, id, lockMode);
		}

		public object Load(string entityName, object id, LockMode lockMode)
		{
			return innerSession.Load(entityName, id, lockMode);
		}

		public object Load(Type theType, object id)
		{
			return innerSession.Load(theType, id);
		}

		public T Load<T>(object id, LockMode lockMode)
		{
			return innerSession.Load<T>(id, lockMode);
		}

		public T Load<T>(object id)
		{
			return innerSession.Load<T>(id);
		}

		public object Load(string entityName, object id)
		{
			return innerSession.Load(entityName, id);
		}

		public void Load(object obj, object id)
		{
			innerSession.Load(obj, id);
		}

		public void Replicate(object obj, ReplicationMode replicationMode)
		{
			innerSession.Replicate(obj, replicationMode);
		}

		public void Replicate(string entityName, object obj, ReplicationMode replicationMode)
		{
			innerSession.Replicate(entityName, obj, replicationMode);
		}

		public object Save(object obj)
		{
			return innerSession.Save(obj);
		}

		public void Save(object obj, object id)
		{
			innerSession.Save(obj, id);
		}

		public object Save(string entityName, object obj)
		{
			return innerSession.Save(entityName, obj);
		}

		public void SaveOrUpdate(object obj)
		{
			innerSession.SaveOrUpdate(obj);
		}

		public void SaveOrUpdate(string entityName, object obj)
		{
			innerSession.SaveOrUpdate(entityName, obj);
		}

		public void Update(object obj)
		{
			innerSession.Update(obj);
		}

		public void Update(object obj, object id)
		{
			innerSession.Update(obj, id);
		}

		public void Update(string entityName, object obj)
		{
			innerSession.Update(entityName, obj);
		}

		public object Merge(object obj)
		{
			return innerSession.Merge(obj);
		}

		public object Merge(string entityName, object obj)
		{
			return innerSession.Merge(entityName, obj);
		}

		public T Merge<T>(T entity) where T : class
		{
			return innerSession.Merge(entity);
		}

		public T Merge<T>(string entityName, T entity) where T : class
		{
			return innerSession.Merge(entityName, entity);
		}

		public void Persist(object obj)
		{
			innerSession.Persist(obj);
		}

		public void Persist(string entityName, object obj)
		{
			innerSession.Persist(entityName, obj);
		}

		public object SaveOrUpdateCopy(object obj)
		{
			return innerSession.SaveOrUpdateCopy(obj);
		}

		public object SaveOrUpdateCopy(object obj, object id)
		{
			return innerSession.SaveOrUpdateCopy(obj, id);
		}

		public void Delete(object obj)
		{
			innerSession.Delete(obj);
		}

		public void Delete(string entityName, object obj)
		{
			innerSession.Delete(entityName, obj);
		}

		public int Delete(string query)
		{
			return innerSession.Delete(query);
		}

		public int Delete(string query, object value, IType type)
		{
			return innerSession.Delete(query, value, type);
		}

		public int Delete(string query, object[] values, IType[] types)
		{
			return innerSession.Delete(query, values, types);
		}

		public void Lock(object obj, LockMode lockMode)
		{
			innerSession.Lock(obj, lockMode);
		}

		public void Lock(string entityName, object obj, LockMode lockMode)
		{
			innerSession.Lock(entityName, obj, lockMode);
		}

		public void Refresh(object obj)
		{
			innerSession.Refresh(obj);
		}

		public void Refresh(object obj, LockMode lockMode)
		{
			innerSession.Refresh(obj, lockMode);
		}

		public LockMode GetCurrentLockMode(object obj)
		{
			return innerSession.GetCurrentLockMode(obj);
		}

		public ITransaction BeginTransaction()
		{
			return innerSession.BeginTransaction();
		}

		public ITransaction BeginTransaction(IsolationLevel isolationLevel)
		{
			return innerSession.BeginTransaction(isolationLevel);
		}

		public ICriteria CreateCriteria<T>() where T : class
		{
			return innerSession.CreateCriteria<T>();
		}

		public ICriteria CreateCriteria<T>(string alias) where T : class
		{
			return innerSession.CreateCriteria<T>(alias);
		}

		public ICriteria CreateCriteria(Type persistentClass)
		{
			return innerSession.CreateCriteria(persistentClass);
		}

		public ICriteria CreateCriteria(Type persistentClass, string alias)
		{
			return innerSession.CreateCriteria(persistentClass, alias);
		}

		public ICriteria CreateCriteria(string entityName)
		{
			return innerSession.CreateCriteria(entityName);
		}

		public ICriteria CreateCriteria(string entityName, string alias)
		{
			return innerSession.CreateCriteria(entityName, alias);
		}

		public IQueryOver<T, T> QueryOver<T>() where T : class
		{
			return innerSession.QueryOver<T>();
		}

		public IQueryOver<T, T> QueryOver<T>(Expression<Func<T>> alias) where T : class
		{
			return innerSession.QueryOver(alias);
		}

		public IQueryOver<T, T> QueryOver<T>(string entityName) where T : class
		{
			return innerSession.QueryOver<T>(entityName);
		}

		public IQueryOver<T, T> QueryOver<T>(string entityName, Expression<Func<T>> alias) where T : class
		{
			return innerSession.QueryOver(entityName, alias);
		}

		public IQuery CreateQuery(string queryString)
		{
			return innerSession.CreateQuery(queryString);
		}

		public IQuery CreateFilter(object collection, string queryString)
		{
			return innerSession.CreateFilter(collection, queryString);
		}

		public IQuery GetNamedQuery(string queryName)
		{
			return innerSession.GetNamedQuery(queryName);
		}

		public ISQLQuery CreateSQLQuery(string queryString)
		{
			return innerSession.CreateSQLQuery(queryString);
		}

		public void Clear()
		{
			innerSession.Clear();
		}

		public object Get(Type clazz, object id)
		{
			return innerSession.Get(clazz, id);
		}

		public object Get(Type clazz, object id, LockMode lockMode)
		{
			return innerSession.Get(clazz, id, lockMode);
		}

		public object Get(string entityName, object id)
		{
			return innerSession.Get(entityName, id);
		}

		public T Get<T>(object id)
		{
			return innerSession.Get<T>(id);
		}

		public T Get<T>(object id, LockMode lockMode)
		{
			return innerSession.Get<T>(id, lockMode);
		}

		public string GetEntityName(object obj)
		{
			return innerSession.GetEntityName(obj);
		}

		public IFilter EnableFilter(string filterName)
		{
			return innerSession.EnableFilter(filterName);
		}

		public IFilter GetEnabledFilter(string filterName)
		{
			return innerSession.GetEnabledFilter(filterName);
		}

		public void DisableFilter(string filterName)
		{
			innerSession.DisableFilter(filterName);
		}

		public IMultiQuery CreateMultiQuery()
		{
			return innerSession.CreateMultiQuery();
		}

		public ISession SetBatchSize(int batchSize)
		{
			return innerSession.SetBatchSize(batchSize);
		}

		public ISessionImplementor GetSessionImplementation()
		{
			return innerSession.GetSessionImplementation();
		}

		public IMultiCriteria CreateMultiCriteria()
		{
			return innerSession.CreateMultiCriteria();
		}

		public ISession GetSession(EntityMode entityMode)
		{
			return innerSession.GetSession(entityMode);
		}

		public EntityMode ActiveEntityMode
		{
			get { return innerSession.ActiveEntityMode; }
		}

		public FlushMode FlushMode
		{
			get { return innerSession.FlushMode; }
			set { innerSession.FlushMode = value; }
		}

		public CacheMode CacheMode
		{
			get { return innerSession.CacheMode; }
			set { innerSession.CacheMode = value; }
		}

		public ISessionFactory SessionFactory
		{
			get { return innerSession.SessionFactory; }
		}

		public IDbConnection Connection
		{
			get { return innerSession.Connection; }
		}

		public bool IsOpen
		{
			get { return innerSession.IsOpen; }
		}

		public bool IsConnected
		{
			get { return innerSession.IsConnected; }
		}

		public bool DefaultReadOnly
		{
			get { return innerSession.DefaultReadOnly; }
			set { innerSession.DefaultReadOnly = value; }
		}

		public ITransaction Transaction
		{
			get { return innerSession.Transaction; }
		}

		public ISessionStatistics Statistics
		{
			get { return innerSession.Statistics; }
		}

		public bool IsTypeMapped(Type t)
		{
			return SessionFactory.GetClassMetadata(t) != null;
		}

		// Table mappings follow
		public IQueryable<DataLayer.Department> Department
		{
			get { return innerSession.Query<DataLayer.Department>(); }
		}

		public IQueryable<DataLayer.Store> Store
		{
			get { return innerSession.Query<DataLayer.Store>(); }
		}
	}
}
