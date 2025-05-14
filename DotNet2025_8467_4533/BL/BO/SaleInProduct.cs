

namespace BO;

public class SaleInProduct
{
    public int IdSail { get; set; }
    public int Count { get; set; }
    public double Price { get; set; }
    public bool AllCustomers { get; set; }
    public SaleInProduct(int IdSale, int Count, double Price, bool AllCustomers)
    {
        this.IdSail = IdSale;
        this.Count = Count;
        this.Price = Price;
        this.AllCustomers = AllCustomers;
    }

}
