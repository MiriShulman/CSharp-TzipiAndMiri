
namespace DalApi;

public interface IDal
{
    Icustomer customer { get; }
    Isale sale { get; }
    Iproduct product { get; }

}
