

using DalApi;

namespace Dal;

internal sealed class DalXml : IDal
{

    private static DalXml instance= new DalXml();
   
    public static DalXml Instance
    {
        get 
        {
            return instance; 
        }
    }

    private DalXml() { }

    IClient IDal.Client => new ClientImplementation();

    ISale IDal.Sale => new SaleImplementation();

    IProduct IDal.Product => new ProductImplementation();

   
}
