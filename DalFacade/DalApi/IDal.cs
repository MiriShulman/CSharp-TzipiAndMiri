
namespace DalApi;

public interface IDal
{
    Icustomer Customer { get; }
    Isale Sale { get; }
    Iproduct Product { get; }

}
