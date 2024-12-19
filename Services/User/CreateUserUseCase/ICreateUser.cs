using API_CRUD.DTO.User;
using API_CRUD.Models;
namespace API_CRUD.Services.User.CreateUserUseCase;
public interface ICreateUser
{
    UserCreateDTO AddUser(UserModel userModel);
}

