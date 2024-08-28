using Eco.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eco.Data.EF
{
    public class DBContext : DbContext
    {
       

        // OnConfiguring is used to configure the database to be used for this context
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string conString = @"Server=./MSSQLSERVER;Database=EcoManageDB;Encrypt=false;Trusted_Connection=True;Integrated Security=true;";
                optionsBuilder.UseSqlServer(conString);
            }
        }

        // Define DbSet properties for your entities
        public DbSet<Users> Users { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<SystemRecords> SystemRecords { get; set; }
        public DbSet<SalaryRate> SalaryRate { get; set; }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<BookThanks> BookThanks { get; set; }
        public DbSet<EmployeesRecords> EmployeesRecords { get; set; }
    }


}

