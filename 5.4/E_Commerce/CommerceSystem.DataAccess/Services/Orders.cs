namespace CommerceSystem.DataAccess.Services;

public class Orders
{
    public long OrderId { get; set; }
    public long CustomerId { get; set; }
    public DateTime CreateAt { get; set; }
    public decimal TotalAmount { get; set; }
    public decimal Discount { get; set; }
    public decimal DiscountPercentage { get; set; }
    public decimal ServicePrice { get; set; }
    public int StatusId { get; set; }
}
