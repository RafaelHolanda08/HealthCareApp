using Common.DTOs.Base;

namespace Platform.Base.Repositories {
    public interface IRepository {

        Task<BaseDTO> FindById(long id);
    }
}
