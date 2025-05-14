
namespace BO;

public class Product
{
    public int IdProduct { get; }
    public string? NameProduct { get; set; }
    public categories? Category { get; set; }
    public double? Price { get; set; }
    public int QuantityInStock { get; set; }
    public List<SaleInProduct>? ProductsSaleList { get; set; }
    public Product(int IdProduct, string NameProduct,categories Category,double Price,int QuantityInStock) 
    {
        this.IdProduct = IdProduct;
        this.NameProduct = NameProduct;
        this.Category = Category;
        this.Price = Price;
        this.QuantityInStock = QuantityInStock;
        this.ProductsSaleList = new List<SaleInProduct>();
    }
    public override string ToString() => this.ToStringProperty();

}
