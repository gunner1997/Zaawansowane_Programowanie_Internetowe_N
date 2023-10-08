namespace WebStore.Model;
public class CustomerModel : UserModel
{
    AddressModel BillingAddress {get; set;}
    IList<OrderModel> Orders{get; set;}
    AddressModel ShippingAddress {get; set;}
}