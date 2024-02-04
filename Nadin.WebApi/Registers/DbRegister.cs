
using Microsoft.EntityFrameworkCore;
using Nadin.Dal;

namespace Nadin.WebApi.Registers
{
    public class DbRegister : IWebApplicationbuilder
    {
        public void RegisterBuilder(WebApplicationBuilder builder)
        {
            var cs = builder.Configuration.GetConnectionString("Default");
            builder.Services.AddDbContext<NadinDbContex>(options =>
            {
                options.UseSqlServer(cs);
            });
        }
    }
}
