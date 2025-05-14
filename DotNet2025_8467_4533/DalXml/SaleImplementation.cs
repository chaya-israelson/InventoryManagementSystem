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
        using (StreamReader sr = new StreamReader(filePath))
        {
            return (List<Sale>)xmlSerializer.Deserialize(sr);
        }
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
        return LoadList().Where(filter).ToList();
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
