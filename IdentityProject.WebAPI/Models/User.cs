using IdentityProject.WebAPI.Models.Dtos.Users.Request;

namespace IdentityProject.WebAPI.Models
{
    public sealed class User : Entity
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }


        public int RoleId { get; set; }
        public Role Role { get; set; } //tabloları birbirine bağladık foreginkey primary key tarzı

        public static explicit operator User(AddUserRequestDto dto)
        {
            return new User
            {
                Email = dto.Email,
                UserName = dto.UserName,
                Password = dto.Password,
                Phone = dto.Phone,
                RoleId = dto.RoleId,
            };
        }
    }
}