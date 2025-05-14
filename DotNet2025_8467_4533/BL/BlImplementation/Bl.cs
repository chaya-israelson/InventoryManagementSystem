

using BlApi;

namespace BlImplementation;

internal class Bl : IBl
{
    public IClient client =>new ClientImplementation();

    public IOrder order =>  new OrderImplementation();

    public IProduct product => new ProductImplementation();

    public ISale sale =>  new SaleImplementation();
}
