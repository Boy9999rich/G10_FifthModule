namespace CommerceSystem.DataAccess.Services;

public class OrderProduct
{
    public long OrderProductId { get; set; }
    public long OrderId { get; set; }
    public long ProductId { get; set; }
    public decimal Quantity { get; set; }
    public decimal PriceAtPurchase { get; set; }

}
