namespace CommerceSystem.DataAccess.Services;

public class Payment
{
    public long PaymentId { get; set; }
    public long OrderId { get; set; }
    public string PaymentMethod { get; set; }

}
