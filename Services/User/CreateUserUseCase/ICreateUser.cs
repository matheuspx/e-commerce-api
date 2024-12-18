using API_CRUD.DTO.User;
using API_CRUD.Models;
namespace API_CRUD.Services.User.CreateUserUseCase;
public interface ICreateUser
{
    void AddUser(UserModel userModel);
}

