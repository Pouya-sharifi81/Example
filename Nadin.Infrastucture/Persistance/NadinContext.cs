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

namespace Nadin.Infrastucture.Persistance
{
    public class NadinContext : DbContext
    {
        public NadinContext(DbContextOptions<NadinContext> options)
            :base(options) 
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
        public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<NadinContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("Default")));
        }


    }
}
