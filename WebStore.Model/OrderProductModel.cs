namespace WebStore.Model;
public class OrderProductModel
{
    OrderModel Order {get; set;}
    ProductModel Product{get; set;}
    int Quantity {get; set;}
}
