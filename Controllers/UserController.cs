using API_CRUD.DTO.User;
using API_CRUD.Models;
using API_CRUD.Services.User;
using Microsoft.AspNetCore.Mvc;

namespace API_CRUD.Controllers;
[Route("api/[controller]")]
[ApiController]

public class UserController : ControllerBase
{
    private readonly IUserService _userService;
    public UserController(IUserService userService)
    {
        _userService = userService;
    }
    [HttpGet]
    public IActionResult GetAll()
    {
        var users = _userService.GetAllUsers();
        return Ok(users);
    }
    [HttpPost]
    public UserCreateDTO CreateUser([FromBody] UserModel user)
    {
        _userService.CreateUser(user);
        return new UserCreateDTO 
        {
            Id = user.Id 
        };
    }
}
