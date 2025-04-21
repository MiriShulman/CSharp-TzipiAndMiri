
namespace DO;

public record Customer
(
    int id,
    string? name = "",
    string? address = "",
    string? phone = null
)
{
    public Customer() : this(0)
    {

    }
}