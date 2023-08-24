using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Platform.Base.Entities;


namespace Platform.Repositories {
    public class GeneralContext : DbContext {
        public GeneralContext() {
        }

        public GeneralContext(DbContextOptions<GeneralContext> options) : base(options) {

        }

        public DbSet<Address> Address { get; set; }
       
    }
}