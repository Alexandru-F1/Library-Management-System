using Microsoft.EntityFrameworkCore;

namespace Model
{
	public class BookContext : DbContext
	{
		private readonly string connectionString;
		public DbSet<Book> Books { get; set; }

		public BookContext(string connectionString)
		{
			this.connectionString = connectionString;
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(connectionString);
		}
	}
}
