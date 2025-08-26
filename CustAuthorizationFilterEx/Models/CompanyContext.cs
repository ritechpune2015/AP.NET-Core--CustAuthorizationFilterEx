using Microsoft.EntityFrameworkCore;

namespace CustAuthorizationFilterEx.Models
{
	public class CompanyContext:DbContext
	{
		public CompanyContext(DbContextOptions<CompanyContext> options):base(options) { }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Product>().HasData(
				 new Product()
				 {
					 ProductID = 1,
					 ProductName = "Mouse",
					 MfgName = "Logitech",
					 Price = 760
				 },
				 new Product()
				 {
					 ProductID = 2,
					 ProductName = "Keyboard",
					 MfgName="Intex",
					 Price=890
				 }
			);

			modelBuilder.Entity<User>().HasData(
				 new User() { 
				  UserID = 1,
				  FirstName="Sunil",
				  LastName="Jadhava",
				  Address="Akurdi Pune", 
				  EmailID="sunil@hotmail.com",
				  MobileNo="987876899",
				  Password="abcd"
				 }
			);
		}
		public DbSet<Product> Products { get; set; }
		public DbSet<User> Users { get; set; }

	}
}
