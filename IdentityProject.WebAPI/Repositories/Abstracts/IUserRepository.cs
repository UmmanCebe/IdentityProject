using IdentityProject.WebAPI.Models;

namespace IdentityProject.WebAPI.Repositories.Abstracts
{
    public interface IUserRepository:IEntityRepository<User>
    {
        User GetByEmail(string email);
        List<User> GetAllByUserNameContains(string text);
    }
}