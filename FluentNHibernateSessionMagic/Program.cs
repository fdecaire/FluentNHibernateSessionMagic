using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentNHibernateSessionMagic
{
	class Program
	{
		static void Main(string[] args)
		{
			using (var db = MSSQLSessionFactory.OpenSession())
			{
				var query = (from d in db.Department select d).ToList();

				foreach (var item in query)
				{
					Console.WriteLine(item.name);
				}

				Console.ReadKey();
			}
		}
	}
}
