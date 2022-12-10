using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using MyInvestmentApp.Data.Models;
using static System.Net.Mime.MediaTypeNames;


namespace MyInvestmentApp.Data
{
    public class MyInvestmentAppDBContext : DbContext
    {
        public MyInvestmentAppDBContext(DbContextOptions<MyInvestmentAppDBContext> context) : base(context)

        {

        }

        public DbSet<InvestmentCalc> investmentCalcs { get; set; }

        public DbSet<Contact> contacts { get; set; }
    }
    public class MyInvestmentAppFactory : IDesignTimeDbContextFactory<MyInvestmentAppDBContext>

    {

        public MyInvestmentAppDBContext CreateDbContext

          (string[] args)

        {

            var optionsBuilder = new DbContextOptionsBuilder<MyInvestmentAppDBContext>();

            optionsBuilder.UseSqlite("Data Source = test.db");

            return new MyInvestmentAppDBContext

              (optionsBuilder.Options);

        }

    }
}
