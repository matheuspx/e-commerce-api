namespace API_CRUD.Models;

public enum Genre
{
    Others = 0,
    Food = 1,
    Clothes = 2,
    Books = 3,
}
public class ProductModel
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public Genre Genre { get; set; }
    public int CompanyId { get; set; }
}

