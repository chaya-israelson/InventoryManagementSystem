

namespace BO;

public class Sale
{
    public int IdSale { get; }
    public int IdProduct { get; set; }
    public int Count { get; set; }
    public double? TotalPrice { get; set; }
    public bool? AllCustomers { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public Sale(int IdSale, int IdProduct, int Count , double TotalPrice, bool AllCustomers, DateTime StartDate, DateTime EndDate) 
    { 
        this.IdSale = IdSale;
        this.IdProduct = IdProduct;
        this.Count = Count;
        this.TotalPrice = TotalPrice;
        this.AllCustomers = AllCustomers;
        this.StartDate = StartDate;
        this.EndDate = EndDate;
    }   
}