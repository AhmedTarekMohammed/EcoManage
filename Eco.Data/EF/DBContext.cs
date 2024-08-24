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
        // Constructor for DBContext with options
        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {
        }

        // OnConfiguring is used to configure the database to be used for this context
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //string conString = @"Server=./SQLEXPRESS;Database=EcoManage;Encrypt=false;Trusted_Connection=True;";
                optionsBuilder.UseSqlServer("Server=localhost;Database=EcoManageDB;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }

        // Define DbSet properties for your entities
        public DbSet<Users> Users { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<SystemRecords> SystemRecords { get; set; }
    }


}

