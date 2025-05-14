

namespace BlApi;
using BO;
public interface ISale
{
    public int Create(Sale item);
    public Sale? Read(int id);
    Sale? Read(Func<Sale, bool> filter);
    List<Sale?> ReadAll(Func<Sale, bool>? filter = null);
    public void Update(Sale item);
    public void Delete(int id);
}
