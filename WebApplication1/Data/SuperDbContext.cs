using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WebApplication1.Model;

namespace WebApplication1.Data
{
	public class SuperDbContext:DbContext
	{
		public SuperDbContext(DbContextOptions<SuperDbContext> options) : base(options)
		{

		}
		public DbSet<Superdata> ServicesDetails { get; set; }
	}
}
