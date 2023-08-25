using Common.DTOs.Base;

namespace Platform.Base.Repositories {
    public interface IPersonRepository<PersonDTO> : IRepository {
        Task<IEnumerable<PersonDTO>> FindAll();

        Task<PersonDTO> Create(PersonDTO dto);
        Task<PersonDTO> Update(PersonDTO dto);
        Task<bool> Delete(long id);

    }
}
