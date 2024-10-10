namespace IdentityProject.WebAPI.Models
{
    public sealed class Role : Entity
    {
        public string Name { get; set; }
        public List<User> Users { get; set; } //tabloları (user) birbirine bağladık foreginkey primary key tarzı
    }
}