

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
        try
        {
            return _dal.Product.Read(p=>filter(p.Convert())).Convert();
        }
        catch
        {
            throw new Exception();
        }
    }

    public List<BO.Product?> ReadAll(Func<BO.Product, bool>? filter = null)
    {
        try
        {
            if(filter == null)
                return _dal.Product.ReadAll().Select(p=>p.Convert()).ToList();
            else
                return _dal.Product.ReadAll(p=>filter(p.Convert())).Select(p=>p.Convert()).ToList();
        }
        catch
        {
            throw new Exception();
        }
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
