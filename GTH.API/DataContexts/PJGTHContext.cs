using GTH.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GTH.API.DataContexts
{
	public class PJGTHContext : DbContext
	{
		public PJGTHContext(DbContextOptions<PJGTHContext> opt) : base(opt) { }

		public DbSet<Usuario> Usuarios { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
		}
	}
}
