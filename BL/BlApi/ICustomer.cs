using BO;
namespace BlApi
{
    public interface ICustomer
    {
        int Create(Customer Customer); //Creates new entity object in DAL
        Customer? Read(int id); //Reads entity object by its ID 
        List<Customer> ReadAll(Func<Customer, bool>? filter = null); //stage 1 only, Reads all entity objects and stage 2
        void Update(Customer item); //Updates entity object
        void Delete(int id); //Deletes an object by its Id
        Customer? Read(Func<Customer, bool> filter); //stage 2
        bool IsCustomerExist (int id);//return if this customer exist
    }
}
