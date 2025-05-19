using DalApi;
using DO;
using System.Xml.Linq;
namespace Dal;


internal class ClientImplementation : IClient
{
    const string filePath = @"..\xml\clients.xml";
/*    const string CLIENTS = "clients";
*/    const string CLIENT = "client";
    const string ID = "Id";
    const string NAME = "Name";
    const string ADDRES = "Addres";
    const string PHON = "Phon";

    public int Create(Client item)
    {
        XElement ClientXml=XElement.Load(filePath);
        ClientXml.Add(new XElement(CLIENT,
            new XElement(ID,item.Id),
            new XElement(NAME,item.Name),
            new XElement(ADDRES,item.Addres),
            new XElement(PHON,item.Phon)));
        ClientXml.Save(filePath);
        return item.Id;
    }

    public void Delete(int id)
    {
        XElement ClientXml = XElement.Load(filePath);
        ClientXml.Descendants(ID).FirstOrDefault(Id => Id.Value == id.ToString()).Parent.Remove();
        ClientXml.Save(filePath);
    }

    public Client? Read(int id)
    {
        Client Client = ReadAll().FirstOrDefault(c =>c.Id == id);
        return Client;
    }

    public Client? Read(Func<Client, bool> filter)
    {
         Client client = ReadAll().FirstOrDefault(filter);
        return client;
        
    }

    public List<Client?> ReadAll(Func<Client, bool>? filter = null)
    {
        XElement ClientXml = XElement.Load(filePath);
        List<Client?> clients = new List<Client?>();

           clients= ClientXml.Descendants(CLIENT)
                    .Select(c => new Client(
                    int.Parse(c.Element(ID)!.Value),
                    c.Element(NAME)!.Value,
                    c.Element(ADDRES)!.Value,
                    c.Element(PHON)!.Value
                    ) ).ToList()!;
        if(filter != null)
            return clients.Where(filter).ToList();
        return clients;   
    }

    public void Update(Client item)
    {
        XElement ClientXml = XElement.Load(filePath);

        XElement client = ClientXml.Descendants(ID).FirstOrDefault(id => int.Parse(id.Value) == item.Id).Parent;
        client.Element(NAME).SetValue(item.Name);
        client.Element(ADDRES).SetValue(item.Addres);
        client.Element(PHON).SetValue(item.Phon);
    }
}


