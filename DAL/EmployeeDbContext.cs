using EmployeeData.Models.DBEntities;
//using EmployyeData.Models.DBEntities;
using Microsoft.EntityFrameworkCore;

namespace EmployeeData.DAL
{
	public class EmployeeDbContext : DbContext
	{
		public EmployeeDbContext(DbContextOptions options) : base(options)
		{
		}

		public DbSet<Employee> Employees { get; set; }
	}
}
