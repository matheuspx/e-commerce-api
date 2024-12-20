using API_CRUD.DataAcess;

namespace API_CRUD.Services.User.DeleteUser;

public class UserDelete : IUserDelete
{
    private readonly AppDbContext _context;
    public UserDelete(AppDbContext context)
    {
        _context = context;
    }

    public bool DeleteUser(int id)
    {
        // Busca o primeiro usuário na tabela Users cujo Id seja igual ao fornecido.
        // Retorna null caso nenhum usuário seja encontrado.
        var user = _context.Users.FirstOrDefault(u => u.Id == id);


        if (user == null)
            return false;

        _context.Users.Remove(user);
        _context.SaveChanges();

        return true;
    }

}

