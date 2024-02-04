using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Nadin.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Nadin.Dal
{
    public class NadinDbContex : DbContext
    {
 
        public NadinDbContex(DbContextOptions<NadinDbContex> options)
           : base(options)
        {

        }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<User> users { get; set; }
        public virtual DbSet<Role> roles { get; set; }
        public virtual DbSet<RefreshToken> refreshTokens { get; set; }
        public virtual DbSet<GroupModel> groupModels { get; set; }
        public virtual DbSet<UserLogin> usersLogin { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\mssqllocaldb;Database=CwkSocial;Trusted_Connection=True;MultipleActiveResultSets=true;");
}
        public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<NadinDbContex>(options =>
                options.UseSqlServer(configuration.GetConnectionString("Default")));
        }


    }
}

