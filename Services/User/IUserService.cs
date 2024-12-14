using API_CRUD.DTO.User;
using API_CRUD.Models;

namespace API_CRUD.Services.User;

public interface IUserService
{
    List<UserDTO> GetAllUsers();
    void CreateUser(UserModel userModel);
}

