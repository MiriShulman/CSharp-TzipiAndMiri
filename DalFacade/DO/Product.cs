namespace DO;

public record Product
   (
       int identity,
       string? name = null,
       double? price = null,
       int? amount = null,
       Category? c = null
   )

{
    public Product() : this(0, "", 0, 0, null)
    {

    }
}