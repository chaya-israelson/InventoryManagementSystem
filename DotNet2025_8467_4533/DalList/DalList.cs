
using DalApi; 
namespace Dal;

internal sealed class DalList:IDal
{
    public static DalList Instance { get; } = new DalList();
    private DalList() { }
    public IClient Client=>new Clientimplementation();
    public ISale Sale =>new Saleimplementation();
    public IProduct Product => new Productimplementation();
}
