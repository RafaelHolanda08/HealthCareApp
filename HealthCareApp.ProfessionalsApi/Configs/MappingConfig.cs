using AutoMapper;
using Common.DTOs;
using Platform.Professionals.Entity;

namespace HealthCareApp.ProfessionalsApi.Configs {
    public static class MappingConfig {

        public static MapperConfiguration RegisterMaps() {

            var mappingconfig = new MapperConfiguration(config => {
                config.CreateMap<TherapistDTO, Therapist>();
                config.CreateMap<Therapist, TherapistDTO>();
            });

            return mappingconfig;



        }
    }
}
