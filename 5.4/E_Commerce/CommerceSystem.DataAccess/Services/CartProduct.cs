namespace CommerceSystem.DataAccess.Services;

public class CartProduct
{
    public long CartProductId { get; set; }
    public long CartId { get; set; }
    public long ProductId { get; set; }
    public int Quantity { get; set; }
    public Cart Cart { get; set; }
    public Product Products { get; set; }
}
