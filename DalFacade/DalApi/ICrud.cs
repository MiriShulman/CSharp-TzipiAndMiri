
namespace DalApi;

public interface ICrud<T>
{
    int Create(T item); //Creates new entity object in DAL
    T? Read(int id); //Reads entity object by its ID 
    List<T> ReadAll(Func<T, bool>? filter = null); //stage 1 only, Reads all entity objects and stage 2
    void Update(T? item); //Updates entity object
    void Delete(int id); //Deletes an object by its Id
    T? Read(Func<T, bool> filter); //stage 2
}
