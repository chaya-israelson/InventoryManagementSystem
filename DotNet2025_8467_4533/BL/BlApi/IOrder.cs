

namespace BlApi;
using BO;
public interface IOrder
{
    public List<SaleInProduct> AddProductToOrder(Order order, int IdProduct, int count);
    public void CalcTotalPriceForProduct(ProductInOrder obj);
    public void CalcTotalPrice(Order obj);
    public void DoOrder(Order obj);
    public void SearchSaleForProduct(int IdProduct, bool FavoriteClient);

}
