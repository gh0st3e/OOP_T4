using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace Lab11
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> user { get; set; }
        public DbSet<Dormitory> dormitory { get; set; }

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                "server=127.0.0.1;port=8597;user=mysql;password=mysql;database=ef;");
        }
    }
}
