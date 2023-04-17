using Conference.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conference.Repositories
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Person> People { get; set; } = null!;
        public DbSet<Report> Reports { get; set; } = null!;
        public DbSet<Meeting> Meetings { get; set; } = null!;

        public DatabaseContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;user=root;password=root;database=conference", new MySqlServerVersion(new Version(8, 0, 30)));
        }
    }
}
