using DalApi;
using DO;
using System.Xml.Serialization;

namespace Dal;

internal class SaleImplementation : ISale
{
    const string filePath = @"..\xml\sales.xml";
    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Sale>));
    public List<Sale> LoadList()
    {
        List<Sale> sales;
        using (StreamReader sr = new StreamReader(filePath))
        {
            sales= xmlSerializer.Deserialize(sr) as List<Sale>;
        }
        if(sales!=null)
            return sales;
        throw new Exception();
    }
    public int Create(Sale item)
    {
        List<Sale> sales = LoadList();
        int Id = Config.idSale;
        item = item with { IdSale = Id };
        sales.Add(item);
        using (StreamWriter sw = new StreamWriter(filePath))
        {
            xmlSerializer.Serialize(sw, sales);
        }
        return Id;
    }

    public void Delete(int id)
    {
        List<Sale> sales = LoadList();
        sales.Remove(Read(id));
        using (StreamWriter sw = new StreamWriter(filePath))
        {
            xmlSerializer.Serialize(sw, sales);
        }
    }

    public Sale? Read(int id)
    {
        Sale sale = LoadList().FirstOrDefault(sale => sale.IdSale== id);
        return sale;
    }

    public Sale? Read(Func<Sale, bool> filter)
    {
        Sale sale = LoadList().FirstOrDefault(filter);
        return sale;
    }

    public List<Sale?> ReadAll(Func<Sale, bool>? filter = null)
    {
        
          List<Sale?> sales=LoadList();
          if(filter!= null){
               if(sales==null)
                   throw new Exception();
              else
                   sales=sales.Where(filter).ToList();
          }
          if(sales==null)
            throw new Exception();
          return sales;
         
    }

    public void Update(Sale item)
    {
        List<Sale> sales = LoadList();
        Delete(item.IdSale);
        sales.Add(item);
        using (StreamWriter sw = new StreamWriter(filePath))
        {
            xmlSerializer.Serialize(sw, sales);
        }
    }
}
