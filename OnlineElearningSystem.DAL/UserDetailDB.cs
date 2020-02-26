using OnlineElearningSystem.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineElearningSystem.DAL
{
	public class UserDetailDB: DbContext
	{
		public UserDetailDB():base("DBConnectionString")
		{

		}
		public DbSet<UserDetail> userDetails { get; set; }
	}
}
