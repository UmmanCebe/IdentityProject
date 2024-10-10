namespace IdentityProject.WebAPI.Models.Dtos.Users.Response
{
    public class UserResponseDto
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string RoleName { get; set; }


        public static implicit operator UserResponseDto(User user)
        {
            return new UserResponseDto
            {
                Email = user.Email,
                Password = user.Password,
                Phone = user.Phone,
                UserName = user.UserName,
                RoleName = user.Role.Name
            };
        }
    }
}
