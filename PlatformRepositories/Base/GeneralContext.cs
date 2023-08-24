using Microsoft.EntityFrameworkCore;
using Platform.Base.Entities;
using Platform.Repositories.Base;

namespace Platform.Base.Repository {
    public class GeneralContext:BaseContext {
        public GeneralContext(){
        }

        public GeneralContext(DbContextOptions<BaseContext> options) : base(options) {

        }
        public DbSet<Address> Address { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {

            var builder = WebApplication.CreateBuilder();
            var connection = builder.Configuration.GetConnectionString("SQLServerConnection:Service");
            builder.Services.AddDbContext<BaseContext>(options => {
                options.UseSqlServer(connection);
            });
        }
    }
}
