using API_CRUD.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_CRUD.Services;
public class UserService
{
    private readonly List<UserModel> _users;
    public UserService()
    {
        _users = new List<UserModel>
        {
            new UserModel  { Id = 1, Name = "Alice Smith", Email = "alice@example.com", Password = "123456", CPF = "12332343312", Address = "Rua dos bobos n0" },
            new UserModel  { Id = 2, Name = "Bob Johnson", Email = "bob@example.com", Password = "password", CPF = "12311331jj2", Address = "Rua dos bobos n0" },
            new UserModel  { Id = 3, Name = "Charlie Brown", Email = "charlie@example.com", Password = "qwerty", CPF = "123113ghg312", Address = "Rua dos bobos n0" }
        };
    }
   public IEnumerable<UserModel> GetAllUsers()
    {
        return _users;
    }
}

