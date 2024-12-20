using API_CRUD.DTO.User;
using API_CRUD.Models;
using API_CRUD.Services.User;
using API_CRUD.Services.User.CreateUserUseCase;
using API_CRUD.Services.User.DeleteUser;
using Microsoft.AspNetCore.Mvc;

namespace API_CRUD.Controllers;
[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{

    [HttpDelete("{id}")]
    public IActionResult DeleteUser(   
        [FromBody] UserDeleteDTO user,
        [FromServices] IUserDelete useCase)
                                   
    {
        var result = useCase.DeleteUser(user.Id);

        if (!result)
            return NotFound("Usuário não encontrado.");

        return NoContent();
    }

    // Ação para obter um usuário pelo ID
    [HttpGet("{id}")]
    public IActionResult GetId(
        [FromRoute] int id,  // Mudança: agora o ID vem pela URL (via [FromRoute])
        [FromServices] IUserGetId useCase)
    {
        var user = useCase.GetId(id);
        if (user == null)
        {
            return NotFound();  // Caso o usuário não seja encontrado
        }
        return Ok(user);
    }

    // Ação para obter todos os usuários
    [HttpGet]
    public IActionResult GetAll(
        [FromServices] IUserGetAll useCase)
    {
        var users = useCase.GetAllUsers();
        return Ok(users);
    }

    // Ação para criar um usuário
    [HttpPost]
    public UserCreateDTO CreateUser(
        [FromBody] UserModel user,
        [FromServices] ICreateUser useCase)
    {
        useCase.AddUser(user);
        return new UserCreateDTO
        {
            Id = user.Id
        };

    }
}
