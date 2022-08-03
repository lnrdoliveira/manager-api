using Manager.Domain.Entities;
using Manager.Infra.Interfaces;

namespace Manager.Infra.Interface{
    public interface IUserRepository : IBaseRepository<User>{
        Task<User> GetByEmail(string email);
        Task<List<User>> SearchByEmail(string email);
         Task<List<User>> SearchByName(string name);

    }
}