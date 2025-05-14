

namespace BO;

public class Client
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string? Addres { get; set; }
    public string Phon { get; set; }
    public Client(int id, string name,string addres, string phon)
    {
        Id = id;
        Name = name;
        Addres = addres;
        Phon = phon;
    }
}
