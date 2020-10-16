using OnlineElearningSystem.Entity;

using System.Data.Entity;


namespace OnlineElearningSystem.DAL
{
	public class UserDetailDB: DbContext
	{
		public UserDetailDB() : base("DBConnectionString")
		{
		}

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<UserDetail>()
			.MapToStoredProcedures(p => p.Insert(sp => sp.HasName("sp_InsertDetails"))
			.Update(sp => sp.HasName("sp_UpdateDetails"))
			.Delete(sp => sp.HasName("sp_DeleteDetails"))
			);
		}
		
		public DbSet<UserDetail> userDetails { get; set; }
		public DbSet<Category> categories { get; set; }
		public DbSet<Course> Courses { get; set; }
		public DbSet<Topic> Topics { get; set; }
		public DbSet<Link> Links { get; set; }
	}
}

