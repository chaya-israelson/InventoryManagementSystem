using DO;
using DalApi;
using System.Linq;
using System.Reflection;
using Tools;

namespace Dal;

internal class Productimplementation: IProduct
{
   public int Create(Product item)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "start");
        if (DataSource.Products.Contains(item))
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "This product exists!!");
            throw new DalKeyNotFoundException("This product exists!!");
        }
        DataSource.Products.Add(item with { IdProduct = DataSource.Config.IdProduct} );
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "finish");
        return item.IdProduct;

    }
    public Product? Read(int id)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "start");
        Product product = null;
        foreach (var item in DataSource.Products)
        {
            if (item.IdProduct == id)
                product = item;
        }
        if (product == null)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "product not Exist!");
            throw new DalKeyNotFoundException("product not Exist!");
        }
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "finish");

        return product;
    }
    public Product? Read(Func<Product, bool> filter)
    {
        return DataSource.Products.FirstOrDefault(filter);
    }
    List<Product?> ICrud<Product>.ReadAll(Func<Product, bool>? filter)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "start");
        if (filter == null)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "finish");
            return DataSource.Products!.Where(t=>t==t).ToList()!;
        }
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "finish");
        return DataSource.Products!.Where(filter).ToList()!;
    }
    public void Update(Product item)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "start");
        try
        {
            Product product = Read(item.IdProduct);
            Delete(item.IdProduct);
            Create(item);
        }
        catch (DalKeyNotFoundException ex)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "product not Exist!");
            throw ex;
        }
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "finish");

    }
    public void Delete(int id)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "start");
        try
        {
            Product product = Read(id);
            DataSource.Products.Remove(product);
        }
        catch (DalKeyNotFoundException ex)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "product not Exist!");
            throw ex;
        }
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "finish");
    }


}
