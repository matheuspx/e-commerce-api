namespace API_CRUD.Models;
public enum OrderStatus
{
    Avaliable = 0,
    InProgress = 1,
    Canceled = 2,   
    Finished = 3,
}
public enum PaymentMethod
{
    Pix = 0,
    Money = 1,
    Debit = 2,
    Credit = 3,
}
public class OrderModel
{
    public int Id { get; set; }
    public DateTime OrderDate { get; set; }
    public  OrderStatus OrderStatus { get; set; }
    public PaymentMethod PaymentMethod {  get; set; }
    public int Price { get; set; }
    public int UserId { get; set; }
    public int ProductId { get; set; }
    public string ProductName { get; set; } = string.Empty;
    public string ProductDescription { get; set; } = string.Empty;
    public decimal ProductPrice { get; set; }

}

