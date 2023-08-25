using Microsoft.EntityFrameworkCore;
using Platform.Professionals.Entity;

namespace Platform.Context {
    public class ProfessionalsContext : DbContext{
        public ProfessionalsContext() {
        }

        public ProfessionalsContext(DbContextOptions<ProfessionalsContext> options) : base(options) {

        }

        public DbSet<Therapist> Therapist { get; set; }
    }
}
