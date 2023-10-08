namespace WebStore.Model;
public class OrderModel
{
    CustomerModel Customer {get; set;}
    DateTime DeliveryDate{get; set;}
    int id {get; set;}
    DateTime OrderDate{get; set;}
    decimal TotalAmount{get;}
    long TrackingNumber {get; set;}
    IList<OrderProductModel> Products {get; set;}

}