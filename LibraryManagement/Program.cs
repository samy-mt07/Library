using Library.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace LibraryManagement
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var configuration = new ConfigurationBuilder()
              .SetBasePath(AppContext.BaseDirectory)
              .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
              .Build();

            var connectionString = configuration.GetConnectionString("DefaultConnection");

            var options = new DbContextOptionsBuilder<BibliothequeDbContext>()
                .UseSqlServer(connectionString)
                .Options;

            Application.Run(new Form1());
        }
    }
}