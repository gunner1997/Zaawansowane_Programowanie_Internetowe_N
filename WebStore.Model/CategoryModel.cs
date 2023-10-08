namespace WebStore.Model;
public class CategorytModel
{
    int id {get; set;}
    string Name {get; set;}
    string Tag {get; set;}
    IList<ProductModel> Products {get; set;}
}