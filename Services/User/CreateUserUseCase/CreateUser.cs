using API_CRUD.DataAcess;
using API_CRUD.DTO.User;
using API_CRUD.Models;

namespace API_CRUD.Services.User.CreateUserUseCase;

public class CreateUser : ICreateUser
{
    private readonly AppDbContext _context;
    public CreateUser(AppDbContext context)
    {
        _context = context;
    }
    public UserCreateDTO AddUser(UserModel user)
    {
        _context.Users.Add(user);
        _context.SaveChanges();

        return new UserCreateDTO
        {
            Id = user.Id,
        };
    }
}

