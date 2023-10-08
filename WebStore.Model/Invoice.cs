namespace WebStore.Model;

public class Invoice{
    public Customer Customer { get; set; }

    public IList<Order> Order { get; set; }

    public OrderProduct OrderProduct { get; set; }

    public Product Product { get; set; }

}