namespace CommerceSystem.DataAccess.Services;

public class Product
{
    public long ProductId  { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public int StockQuantity { get; set; }
    public string ImageLink { get; set; }
    public List<CartProduct> Products { get; set; }
}
