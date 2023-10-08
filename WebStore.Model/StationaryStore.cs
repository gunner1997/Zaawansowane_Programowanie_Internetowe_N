namespace WebStore.Model;
public class StationaryStore 
{
   public string Name {get;set;}
   public Address Address {get;set;}
   
   public IList<StationaryStoreEmployee> Employees {get;set;}    

}
