using FluentNHibernate.Mapping;
using System;

namespace FluentNHibernateSessionMagic.DataLayer
{
	public partial class Department
	{
		public virtual int id { get; set; }
		public virtual string name { get; set; }
	}

	public class DepartmentMap : ClassMap<Department>
	{
		public DepartmentMap()
		{
			Table("sampledata..department");
			Id(u => u.id).GeneratedBy.Identity().Not.Nullable();
			Map(u => u.name).CustomSqlType("varchar (50)").Length(50).Nullable();
		}
	}
}