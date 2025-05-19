
namespace DO;

public record Product
    (int    IdProduct,
    string? NameProduct,
    categories? Category,
    double? Price,
    int QuantityInStock)
{
    // מה עם מספר רץ
    public Product() : this(0, null ,null, null, 0) { }
}
