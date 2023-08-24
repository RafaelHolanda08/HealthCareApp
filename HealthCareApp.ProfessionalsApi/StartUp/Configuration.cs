using Microsoft.EntityFrameworkCore;
using Platform.Repositories;

namespace HealthCareApp.ProfessionalsApi.StartUp {
    public static class Configuration {
        public static void ConfigureDatabases(WebApplicationBuilder builder) {
            var connectionstring = builder.Configuration.GetConnectionString("Service");
            builder.Services.AddDbContext<GeneralContext>(options => {
                options.UseSqlServer(connectionstring, x=>x.MigrationsAssembly("Platform.Repositories"));
            });
        }
    }
}
