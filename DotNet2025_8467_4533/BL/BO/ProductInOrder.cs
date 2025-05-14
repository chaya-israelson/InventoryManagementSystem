

namespace BO;

public class ProductInOrder
{
    public int IdProduct { get; set; }
    public string NameProduct { get; set; }
    public double BasePrice { get; set; }
    public List<SaleInProduct>? ListSales { get; set; }
    public int Count { get; set; }
    public double FinalPrice { get; set; }
    public ProductInOrder(int IdProduct,string NameProduct,double BasePrice, List<SaleInProduct> ListSales,int count, double FinalPrice) 
    {
        this.IdProduct = IdProduct;
        this.NameProduct = NameProduct;
        this.BasePrice = BasePrice;
        this.ListSales = ListSales;
        this.Count = count;
        this.FinalPrice = FinalPrice;
    }
}
