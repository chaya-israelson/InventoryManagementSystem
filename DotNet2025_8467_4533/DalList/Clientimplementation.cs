
namespace Dal;
using Tools;
using System.Reflection;
using DO;
using DalApi;


internal class Clientimplementation : IClient
{

    public int Create(Client item)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "start");
        if (DataSource.Clients.Where(c => c.Id == item.Id).FirstOrDefault() == null)
            throw new DalKeyNotFoundException("A client with the same ID already exists!");
        DataSource.Clients.Add(item);

        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "finish");
        return item.Id;
    }

    /*    private void with(object value)
        {
            throw new Exception();
        }*/

    public Client? Read(int id)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "start");

        Client client = null;

        foreach (var item in DataSource.Clients)
        {
            if (item.Id == id)
                client = item;
        }
        if (client == null)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "Id not Exist!");
            throw new DalKeyNotFoundException("Id not Exist!");
        }
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "finish");
        return client;

    }
   public Client? Read(Func<Client, bool> filter)
    {
        return DataSource.Clients.FirstOrDefault(filter);
    }
    List<Client?> ICrud<Client>.ReadAll(Func<Client, bool>? filter)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "start");
        if (filter == null)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "finish");
            return DataSource.Clients!.Where(t=>t==t).ToList()!;
        }
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "finish");
        return DataSource.Clients!.Where(filter).ToList()!;
    }

/*    public List<Client>? ReadAll()
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "start");
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "finish");

        return DataSource.Clients;
    }*/

    public void Update(Client item)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "start");

        Client client = Read(item.Id);
        try
        {
            Delete(item.Id);
            Create(item);
        }
        catch (DalKeyNotFoundException ex)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "Id not Exist!");
            throw ex;
        }
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "finish");

    }
    public void Delete(int id)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "start");
        try
        {
            Client client = Read(id);
            DataSource.Clients.Remove(client);
        }
        catch (DalKeyNotFoundException ex)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "Id not Exist!");
            throw ex;
        }
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "finish");
    }

}