using AutoMapper;
using HealthCareApp.ProfessionalsApi.Configs;
using Microsoft.EntityFrameworkCore;
using Platform.Context;

namespace HealthCareApp.ProfessionalsApi.StartUp {
    public static class Configuration {
        public static void ConfigureDatabases(WebApplicationBuilder builder) {
            var connectionstring = builder.Configuration.GetConnectionString("Service");
            builder.Services.AddDbContext<GeneralContext>(options => {
                options.UseSqlServer(connectionstring, x => x.MigrationsAssembly("Platform.Context"));
            });

            connectionstring = builder.Configuration.GetConnectionString("Professionals");
            builder.Services.AddDbContext<ProfessionalsContext>(options => {
                options.UseSqlServer(connectionstring, x => x.MigrationsAssembly("Platform.Context"));
            });
        }


        public static void RegisterMaps(WebApplicationBuilder builder) {
            IMapper mapper = MappingConfig.RegisterMaps().CreateMapper();
            builder.Services.AddSingleton(mapper);
            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }

    }
}
