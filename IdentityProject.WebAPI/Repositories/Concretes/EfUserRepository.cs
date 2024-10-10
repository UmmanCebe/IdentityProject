using IdentityProject.WebAPI.Contexts;
using IdentityProject.WebAPI.Models;
using IdentityProject.WebAPI.Repositories.Abstracts;
using Microsoft.EntityFrameworkCore;

namespace IdentityProject.WebAPI.Repositories.Concretes
{
    public class EfUserRepository : IUserRepository
    {
        private readonly MsSqlContext _context;
        public EfUserRepository(MsSqlContext context)
        {
            _context = context;
        }

        public User Add(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();

            return user;
        }

        public User Delete(int id)
        {
            User? user = _context.Users.SingleOrDefault(u => u.Id == id);
            _context.Users.Remove(user);
            _context.SaveChanges();
            return user;
        }

        public List<User> GetAll()
        {
            return _context.Users
                .Include(x=>x.Role)
                .ToList();
        }

        public List<User> GetAllByUserNameContains(string text)
        {
            List<User> users = _context.Users.
                Where(x => x.UserName.Contains(text, StringComparison.OrdinalIgnoreCase))
                .ToList();
            return users;
        }

        public User GetByEmail(string email)
        {
            User? user = _context.Users.SingleOrDefault(u => u.Email == email);
            return user;
        }

        public User GetById(int id)
        {
            User? user = _context.Users.Find(id);
            return user;
        }

        public User Update(User user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
            return user;
        }
    }
}