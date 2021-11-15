using C19QuizForKids.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C19QuizForKids.Context
{
    public class MySqlContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public MySqlContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to mysql with connection string from app settings
            var connectionString = Configuration.GetConnectionString("WebApiDatabase");
            options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Ranking> Ranking { get; set; }
    }
}
