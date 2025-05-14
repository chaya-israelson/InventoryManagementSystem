

namespace DO;

public record Sale
    (int IdSale,
    int IdProduct,
    int Count,
    double? TotalPrice,
    bool? AllCustomers,
    DateTime? StartDate,
    DateTime? EndDate)
{
    // מה עם מספר רץ
    public Sale() : this( 0,0,0,0,null,null,null) { }
}
