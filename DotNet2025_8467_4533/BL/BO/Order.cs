

namespace BO;

public class Order
{
    public bool FavoriteClient { get; set; }
    public List<ProductInOrder> ListProduct { get; set; }
    public double TotalPrice { get; set; }
    public Order(bool FavoriteClient, List<ProductInOrder> ListProduct,double TotalPrice)
    {
        this.FavoriteClient = FavoriteClient;
        this.ListProduct = ListProduct;
        this.TotalPrice = TotalPrice;
    }

}
