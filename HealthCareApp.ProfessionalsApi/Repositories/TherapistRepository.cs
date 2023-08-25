using Common.DTOs;
using Common.DTOs.Base;
using Platform.Base.Repositories;
using Platform.Context;

namespace HealthCareApp.ProfessionalsApi.Repositories {
    public class TherapistRepository : IPersonRepository<TherapistDTO> {

        private readonly GeneralContext _generalContext;
        private readonly ProfessionalsContext _professionalsContext;
        Task<TherapistDTO> IPersonRepository<TherapistDTO>.Create(TherapistDTO dto) {
            throw new NotImplementedException();
        }

        Task<bool> IPersonRepository<TherapistDTO>.Delete(long id) {
            throw new NotImplementedException();
        }

        Task<IEnumerable<TherapistDTO>> IPersonRepository<TherapistDTO>.FindAll() {
            throw new NotImplementedException();
        }

        Task<BaseDTO> IRepository.FindById(long id) {
            throw new NotImplementedException();
        }

        Task<TherapistDTO> IPersonRepository<TherapistDTO>.Update(TherapistDTO dto) {
            throw new NotImplementedException();
        }
    }
}
