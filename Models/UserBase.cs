namespace API_CRUD.Models;
//id name email password cpf/cnpj endereço 
public class UserBase
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty; // nao pode retornar
    public string Address { get; set; } = string.Empty;

}

