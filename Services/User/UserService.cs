using API_CRUD.DataAcess;
using API_CRUD.DTO.User;
using API_CRUD.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_CRUD.Services.User;
public class UserService : IUserService
{
    private readonly AppDbContext _context;
    public UserService(AppDbContext context)
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
    public void CreateUser(UserModel user)
    {
        _context.Users.Add(user); // adiciona na linha _users um usuario cadastrado
        _context.SaveChanges();
    }
}

