

namespace BlApi;
using BO;
public interface IClient
{
    public int Create(Client item);
    public Client? Read(int id);
    Client? Read(Func<Client, bool> filter);
    List<Client?> ReadAll(Func<Client, bool>? filter = null);
    public void Update(Client item);
    public void Delete(int id);
    public bool ExistingClient(Client item);
}
