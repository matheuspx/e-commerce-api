using API_CRUD.Models;
using API_CRUD.Services;
using Microsoft.AspNetCore.Mvc;

namespace API_CRUD.Controllers;
[Route("api/[controller]")]
[ApiController]

public class UserController : ControllerBase
{
    private readonly UserService _userService;
    public UserController ()
    { 
        _userService = new UserService ();
    }
    [HttpGet]
    public IActionResult GetAll()
    {
        var users = _userService.GetAllUsers();
        return Ok(users);
    }
}

