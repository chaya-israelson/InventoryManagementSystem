

using BlApi;
using BO;

namespace BlImplementation;

internal class ProductImplementation : IProduct
{
    private DalApi.IDal _dal = DalApi.Factory.Get;

    public int Create(BO.Product item)
    {
        try
        {
            return _dal.Product.Create(item.Convert());
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    public void Delete(int id)
    {
        try
        {
            _dal.Product.Delete(id);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    public void PreferredClient(int IdProduct, bool PreferredClient)
    {
        try
        {
            _dal.Product.Delete(IdProduct);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    public BO.Product? Read(int id)
    {
        try
        {
           return _dal.Product.Read(id).Convert();
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    public BO.Product? Read(Func<BO.Product, bool> filter)
    {
        throw new NotImplementedException();
    }

    public List<BO.Product?> ReadAll(Func<BO.Product, bool>? filter = null)
    {
        throw new NotImplementedException();
    }

    public void Update(BO.Product item)
    {
        try
        {
            _dal.Product.Update(item.Convert());
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }
}
