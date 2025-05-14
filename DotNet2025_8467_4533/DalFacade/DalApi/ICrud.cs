
namespace DalApi;

public interface ICrud<T>
{
    public int Create(T item);
    public T? Read(int id);
    T? Read(Func<T, bool> filter); 
    List<T?> ReadAll(Func<T, bool>? filter = null); 
    public void Update(T item);
    public void Delete(int id);
}
