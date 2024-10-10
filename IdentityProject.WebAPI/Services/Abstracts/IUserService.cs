using IdentityProject.WebAPI.Models;
using IdentityProject.WebAPI.Models.Dtos.Users.Request;
using IdentityProject.WebAPI.Models.Dtos.Users.Response;

namespace IdentityProject.WebAPI.Services.Abstracts
{
    public interface IUserService
    {
        List<UserResponseDto> GetAllUsers();
        User GetById(int id);
        User Add(AddUserRequestDto dto);
        User Update(User user);
        User Delete(int id);
        User GetByEmail(string email);
    }
}