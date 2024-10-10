using IdentityProject.WebAPI.Models;
using IdentityProject.WebAPI.Repositories.Abstracts;

namespace IdentityProject.WebAPI.Repositories.Concretes
{
    public class DapperUserRepository : IUserRepository
    {
        public User Add(User user)
        {
            throw new NotImplementedException();
        }

        public User Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<User> GetAllByUserNameContains(string text)
        {
            throw new NotImplementedException();
        }

        public User GetByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }

        public User Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}
