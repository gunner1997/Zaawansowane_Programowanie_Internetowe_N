namespace WebStore.Model;

public class StationaryStoreEmployee : User{
    public IList<StationaryStore> store { get; set; }
}