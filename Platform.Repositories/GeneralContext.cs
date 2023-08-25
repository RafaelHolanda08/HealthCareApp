using Microsoft.EntityFrameworkCore;
using Platform.Base.Entities;


namespace Platform.Context {
    public class GeneralContext : DbContext {
        public GeneralContext() {
        }

        public GeneralContext(DbContextOptions<GeneralContext> options) : base(options) {

        }

        public DbSet<Address> Address { get; set; }
       
    }
}