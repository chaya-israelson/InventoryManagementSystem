using DO;
using DalApi;
using System.Reflection;
using Tools;

namespace Dal;

internal class Saleimplementation: ISale
{
    public int Create(Sale item)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "start");
        if (DataSource.Sales.Contains(item))
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "This sale exists!");
            throw new DalKeyNotFoundException("This sale exists!");
        }
        DataSource.Sales.Add(item with{ IdSale = DataSource.Config.IdSale} );
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "finish");
        return item.IdSale;
    }
    public Sale? Read(int id)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "start");
        Sale sale = null;
        foreach (var item in DataSource.Sales)
        {
            if (item.IdSale == id)
                sale = item;
        }
        if (sale == null)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "sale not Exist!");
            throw new DalKeyNotFoundException("sale not Exist!");
        }
            
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "finish");

        return sale;
    }
    public Sale? Read(Func<Sale, bool> filter)
    {
        return DataSource.Sales.FirstOrDefault(filter);
    }
    List<Sale?> ICrud<Sale>.ReadAll(Func<Sale, bool>? filter)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "start");
        if (filter == null)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "finish");
            return DataSource.Sales!.Where(t=>t==t).ToList()!;
        }
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "finish");
        return DataSource.Sales!.Where(filter).ToList()!;

    }


    public void Update(Sale item)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "start");
        try
        {
            Sale sale = Read(item.IdSale);
            Delete(item.IdSale);
            Create(item);
        }
        catch (DalKeyNotFoundException ex) 
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "sale not Exist!");
            throw ex;

        }
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "finish");

    }
    public void Delete(int id)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "start");
        try
        {
            Sale sale = Read(id);
            DataSource.Sales.Remove(sale);
        }
        catch (DalKeyNotFoundException ex) {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "sale not Exist!");
            throw ex; }
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "finish");
    }
}
