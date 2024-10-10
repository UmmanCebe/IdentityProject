
using IdentityProject.WebAPI.Contexts;
using IdentityProject.WebAPI.Models;
using IdentityProject.WebAPI.Repositories.Abstracts;

namespace IdentityProject.WebAPI.Repositories.Concretes
{
    public class EfRoleRepository : IRoleRepository
    {
        private readonly MsSqlContext _context;

        public EfRoleRepository(MsSqlContext context)
        {
            _context = context;
        }

        public Role Add(Role user)
        {
            _context.Roles.Add(user);
            _context.SaveChanges();
            return user;
        }

        public Role Delete(int id)
        {
            Role? role = _context.Roles.Find(id);
            _context.Roles.Remove(role);
            return role;
        }

        public List<Role> GetAll()
        {
            return _context.Roles.ToList();
        }

        public Role GetById(int id)
        {
            Role? role = _context.Roles.SingleOrDefault(r => r.Id == id);
            return role;
        }

        public Role Update(Role user)
        {
            _context.Roles.Update(user);
            _context.SaveChanges();
            return user;
        }
    }
}
