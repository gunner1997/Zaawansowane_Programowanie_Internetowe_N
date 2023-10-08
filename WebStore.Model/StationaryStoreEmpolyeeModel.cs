namespace WebStore.Model;
public class StationeryStoreEmpolyeeModel : UserModel
{
    StationaryStoreModel StationaryStore {get; set;}
    string Email {get; set;}
}