namespace BlApi;

public interface IBL
{
    public IProduct Product { get; }
    public ICustomer Customer { get; }
    public ISale Sale { get; }
    public IOrder Order { get; }
}
