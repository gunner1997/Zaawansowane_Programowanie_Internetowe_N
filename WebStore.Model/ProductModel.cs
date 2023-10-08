namespace WebStore.Model;
public class ProductModel
{
    string Category {get; set;}
    string Description{get; set;}
    int id {get; set;}
    byte [] ImageBytes {get; set;}
    string Name {get; set;}
    decimal Price {get; set;}
    SupplierModel Supplier {get; set;}
    float Weight {get; set;}
    IList<OrderProductModel> Orders {get; set;}
    IList<ProductStockModel> ProductStocks {get; set;}
}