﻿using FluentNHibernate.Mapping;
using System;

namespace FluentNHibernateSessionMagic.DataLayer
{
	public partial class Store
	{
		public virtual int id { get; set; }
		public virtual string Name { get; set; }
		public virtual string Address { get; set; }
		public virtual string City { get; set; }
		public virtual string State { get; set; }
		public virtual string Zip { get; set; }
		public virtual string testfield { get; set; }
	}

	public class StoreMap : ClassMap<Store>
	{
		public StoreMap()
		{
			Table("sampledata..Store");
			Id(u => u.id).GeneratedBy.Identity().Not.Nullable();
			Map(u => u.Name).CustomSqlType("varchar (50)").Length(50).Nullable();
			Map(u => u.Address).CustomSqlType("varchar (50)").Length(50).Nullable();
			Map(u => u.City).CustomSqlType("varchar (50)").Length(50).Nullable();
			Map(u => u.State).CustomSqlType("varchar (50)").Length(50).Nullable();
			Map(u => u.Zip).CustomSqlType("varchar (50)").Length(50).Nullable();
			Map(u => u.testfield).CustomType("StringClob").CustomSqlType("text").Length(Int32.MaxValue).Nullable();
		}
	}
}
