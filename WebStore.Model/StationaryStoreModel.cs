namespace WebStore.Model;
public class StationaryStoreModel
{
    int id {get; set;}
    string Name {get; set;}
    AddressModel Address {get; set;}
    IList<StationeryStoreEmpolyeeModel> Employees {get; set;}
}