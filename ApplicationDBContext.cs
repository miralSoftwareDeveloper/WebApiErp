using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using WebApiGresol.Model;

namespace WebApiGresol
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
          
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json")
                   .Build();
                var connectionString = configuration.GetConnectionString("ERPGresol");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }



        public DbSet<Expense> Expenses { set; get; }
        public DbSet<ExpenseCategories> ExpenseCategories { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<ThirdParty> ThirdParties { get; set; }
        public DbSet<Todo> Todos { get; set; }
        public DbSet<TravelExpense> TravelExpenses { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Visit> Visits { get; set; }
    }
}
