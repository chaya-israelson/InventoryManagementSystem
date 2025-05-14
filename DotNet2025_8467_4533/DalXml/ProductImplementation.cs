using DalApi;
using DO;
using System.Xml.Serialization;

namespace Dal;

internal class ProductImplementation : IProduct
{
    const string filePath = @"..\xml\products.xml";



    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Product>));

    public List<Product> LoadList()
    {
        using (StreamReader sr = new StreamReader(filePath))
        {
            return (List<Product>)xmlSerializer.Deserialize(sr);
        }
    }

    public int Create(Product item)
    {
        List<Product> products=LoadList();
        int Id = Config.ProductId;
        item=item with { IdProduct = Id };
        products.Add(item);
        using (StreamWriter sw= new StreamWriter(filePath))
        {
            xmlSerializer.Serialize(sw, products);
        }
       return Id;
    }

    public void Delete(int id)
    {
        List<Product> products = LoadList();
        products.Remove(Read(id));
        using (StreamWriter sw = new StreamWriter(filePath))
        {
            xmlSerializer.Serialize(sw, products);
        }

    }

    public Product? Read(int id)
    {
        Product product = LoadList().FirstOrDefault(product => product.IdProduct == id);
        return product;
    }

    public Product? Read(Func<Product, bool> filter)
    {
        Product product = LoadList().FirstOrDefault(filter);
        return product;
    }

    public List<Product?> ReadAll(Func<Product, bool>? filter = null)
    {
        return LoadList().Where(filter).ToList();
    }

    public void Update(Product item)
    {
        List<Product> products = LoadList();
        Delete(item.IdProduct);
        products.Add(item);
        using (StreamWriter sw = new StreamWriter(filePath))
        {
            xmlSerializer.Serialize(sw, products);
        }
    }
}
