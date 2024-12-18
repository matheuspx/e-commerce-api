using API_CRUD.DataAcess;
using API_CRUD.DTO.User;
using API_CRUD.Models;

namespace API_CRUD.Services.User.UserGetAllUseCase;

public class UserGetAll : IUserGetAll
{
    private readonly AppDbContext _context;
    public UserGetAll(AppDbContext context)
    {
        _context = context;
    }
    public List<UserDTO> GetAllUsers()
    {
        var users = _context.Users.ToList();
        return users.Select(users => new UserDTO
        { 
        Id = users.Id,  
        Name = users.Name,  
        Email = users.Email,       
        }).ToList();
    }
}