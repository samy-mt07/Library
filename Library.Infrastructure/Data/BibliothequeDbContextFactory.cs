using Library.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Library.Infrastructure.Data
{
    public class BibliothequeDbContextFactory : IDesignTimeDbContextFactory<BibliothequeDbContext>
    {
        public BibliothequeDbContext CreateDbContext(string[] args)
        {
            var connectionString =
                "Server=localhost;Database=BibliothequeDb;Trusted_Connection=True;TrustServerCertificate=True;";

            var optionsBuilder = new DbContextOptionsBuilder<BibliothequeDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new BibliothequeDbContext(optionsBuilder.Options);
        }
    }
}
