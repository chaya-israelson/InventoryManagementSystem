

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
        try
        {
            return _dal.Sale.Read(s=>filter(s.Convert())).Convert();

        }
        catch
        {
            throw new Exception();
        }
    }

    public List<BO.Sale?> ReadAll(Func<BO.Sale, bool>? filter = null)
    {
        try
        { 
            if (filter == null)
                return _dal.Sale.ReadAll().Select(s=>s.Convert()).ToList();
            else
                return _dal.Sale.ReadAll(s=>filter(s.Convert())).Select(s=>s.Convert()).ToList();

        }
        catch
        {
            throw new Exception();
        }
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
