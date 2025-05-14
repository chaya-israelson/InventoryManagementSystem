

using BlApi;
using BO;

namespace BlImplementation;

internal class SaleImplementation : ISale
{
    private DalApi.IDal _dal = DalApi.Factory.Get;

    public int Create(BO.Sale item)
    {
        try
        {
           return _dal.Sale.Create(item.Convert());
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
             _dal.Sale.Delete(id);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    public BO.Sale? Read(int id)
    {
        try
        {
            return _dal.Sale.Read(id).Convert();
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    public BO.Sale? Read(Func<BO.Sale, bool> filter)
    {
        throw new NotImplementedException();
    }

    public List<BO.Sale?> ReadAll(Func<BO.Sale, bool>? filter = null)
    {
        throw new NotImplementedException();
    }

    public void Update(BO.Sale item)
    {
        try
        {
             _dal.Sale.Update(item.Convert());
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }
}
