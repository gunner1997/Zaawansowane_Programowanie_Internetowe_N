namespace WebStore.Model;

public class Customer : User
{
    public IList<Address> BillingAddress { get; set; }

    public IList<Order> Orders { get; set; }

    public string ShippingAddress { get; set; }
} 