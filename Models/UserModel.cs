namespace API_CRUD.Models;
//id name email password cpf/cnpj endereço 
public class UserModel : UserBase
{
   public string CPF { get; set; } = string.Empty;
}

