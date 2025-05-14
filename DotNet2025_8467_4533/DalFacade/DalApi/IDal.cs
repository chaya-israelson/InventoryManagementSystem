

namespace DalApi;

public interface IDal
{
    IClient Client { get; }
    ISale Sale { get; }
    IProduct Product { get; }
}
