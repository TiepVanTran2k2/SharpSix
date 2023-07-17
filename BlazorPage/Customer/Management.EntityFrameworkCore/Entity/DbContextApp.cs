using Management.Domain.Entity.Role;
using Management.Domain.Entity.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.EntityFrameworkCore.Entity
{
    public class DbContextApp : DbContext
    {
        protected readonly IConfiguration Configuration;
        public DbContextApp(IConfiguration configuration, DbContextOptions<DbContextApp> options) : base(options)
        {
            Configuration = configuration;
        }
        public DbSet<User> User { get; set; }
        public DbSet<Role> Role { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("Default"));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DbContextApp).Assembly);
        }
    }
}
