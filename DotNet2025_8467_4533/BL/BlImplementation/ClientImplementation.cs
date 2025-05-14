using BlApi;
using BO;
using Tools;

namespace BlImplementation;

internal class ClientImplementation : IClient
{
    private DalApi.IDal _dal = DalApi.Factory.Get;
    public int Create(BO.Client item)
    {
        try
        {
            return _dal.Client.Create(item.Convert());
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
            _dal.Client.Delete(id);
        }
        catch (Exception e) { throw new Exception(e.Message); }
    }

    public bool ExistingClient(BO.Client item)
    {
        try
        {
           if( Read(item.Id)!=null)
                return true;
           return false;
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    public BO.Client? Read(int id)
    {
        try
        {
            return _dal.Client.Read(id).Convert();
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    public BO.Client? Read(Func<BO.Client, bool> filter)
    {
        try
        {
            return _dal.Client.Read(c=>filter(c.Convert())).Convert();
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    public List<BO.Client?> ReadAll(Func<BO.Client, bool>? filter = null)
    {
        try
        {
            if(filter==null)
                return _dal.Client.ReadAll().Select(c=>c.Convert()).ToList();
            return _dal.Client.ReadAll().Select(c=>c.Convert()).Where(filter).ToList();
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    public void Update(BO.Client item)
    {
        try
        {
             _dal.Client.Update(item.Convert());
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }
}
