using BO;
namespace BlApi
{
    public interface ISale
    {
        int Create(Sale Sale); //Creates new entity object in DAL
        Sale? Read(int id); //Reads entity object by its ID 
        List<Sale> ReadAll(Func<Sale, bool>? filter = null); //stage 1 only, Reads all entity objects and stage 2
        void Update(Sale item); //Updates entity object
        void Delete(int id); //Deletes an object by its Id
        Sale? Read(Func<Sale, bool> filter); //stage 2
    }
}

