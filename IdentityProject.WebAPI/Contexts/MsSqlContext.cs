using IdentityProject.WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace IdentityProject.WebAPI.Contexts
{
    public class MsSqlContext : DbContext
    {
        public MsSqlContext(DbContextOptions opt):base(opt)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Docker kurulu olanlar
            //optionsBuilder.UseSqlServer("Server= localhost,1433; Database= Indentity_db; User= sa; Password= admin123456789; TrustServerCertificate = true;");

            //Visula Studio içerisinden local olarak
            optionsBuilder.UseSqlServer(@"Server= (localdb)\MSSQLLocalDB; Database= Indentity1_db; Trusted_Connection = true;");
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}