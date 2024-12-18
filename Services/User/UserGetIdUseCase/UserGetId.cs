using API_CRUD.DataAcess;
using API_CRUD.DTO.User;
using API_CRUD.Models;

namespace API_CRUD.Services.User.UserGetAllUseCase;

public class UserGetId : IUserGetId
{
    private readonly AppDbContext _context;
    public UserGetId(AppDbContext context)
    {
        _context = context;
    }
    public UserDTO GetId(int id)
    {
        var user = _context.Users.FirstOrDefault(x => x.Id == id);
        return new UserDTO
        {
            Id = user?.Id ?? 0,
            Name = user?.Name ?? string.Empty,
            Email = user?.Email ?? string.Empty
            
        };
    }
}