

namespace BlApi;
using BO;
public interface IProduct
{
    public int Create(Product item);
    public Product? Read(int id);
    Product? Read(Func<Product, bool> filter);
    List<Product?> ReadAll(Func<Product, bool>? filter = null);
    public void Update(Product item);
    public void Delete(int id);
    public void PreferredClient(int IdProduct,bool PreferredClient);
}
