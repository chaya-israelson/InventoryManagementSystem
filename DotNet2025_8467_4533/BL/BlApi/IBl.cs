

namespace BlApi;

public interface IBl
{
    public IClient client {  get;  }
    public IOrder order { get; }
    public IProduct product { get; }
    public ISale  sale { get; }

}
