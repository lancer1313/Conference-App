using Conference.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conference.Repositories
{
    /// <summary>
    /// Контекст базы данных
    /// </summary>
    public class DatabaseContext : DbContext
    {
        /// <summary>
        /// Таблица участников
        /// </summary>
        public DbSet<Person> People { get; set; } = null!;
        /// <summary>
        /// Таблица докладов
        /// </summary>
        public DbSet<Report> Reports { get; set; } = null!;
        /// <summary>
        /// Таблица собраний
        /// </summary>
        public DbSet<Meeting> Meetings { get; set; } = null!;

        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public DatabaseContext()
        {
            Database.EnsureCreated();
        }

        /// <summary>
        /// Метод конфигурации контекста базы данных
        /// </summary>
        /// <param name="optionsBuilder">Объект с опциями создания контекста</param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var dbPath = Path.Combine(appDataPath, "Conference", "conference.db");
            optionsBuilder.UseSqlite($"Data Source={dbPath}");
            //optionsBuilder.UseSqlite("Data Source=conference.db");
        }
    }
}
