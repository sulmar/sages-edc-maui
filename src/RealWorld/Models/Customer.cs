namespace Models;

public class Customer : BaseEntity
{    
    public string FirstName { get; set; }
    public Address ShippingAddress { get; set; }
}
