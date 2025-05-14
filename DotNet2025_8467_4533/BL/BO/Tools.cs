using System.Collections;
using System.Reflection;
using System.Text;

namespace BO;

internal static class Tools
{

    public static string ToStringProperty<T>(this T obj)
    {
        if (obj == null)
            return "null";

        StringBuilder result = new StringBuilder();
        Type type = typeof(T);
        PropertyInfo[] properties = type.GetProperties();

        foreach (PropertyInfo property in properties)
        {
            var value = property.GetValue(obj);
            if (value is IEnumerable enumerable && !(value is string))
            {
                result.AppendLine($"{property.Name}: [{string.Join(", ", enumerable.Cast<object>().Select(x => x.ToString()))}]");
            }
            else
            {
                result.AppendLine($"{property.Name}: {value}");
            }
        }

        return result.ToString();
    }
    public static BO.Client Convert(this DO.Client obj)
    {
        return new BO.Client(obj.Id, obj.Name!, obj.Addres!, obj.Phon!);
    }
    public static DO.Client Convert(this BO.Client obj)
    {
        return new DO.Client(obj.Id, obj.Name, obj.Addres, obj.Phon);
    }
    public static BO.Product Convert(this DO.Product obj)
    {
        return new BO.Product(obj.IdProduct, obj.NameProduct!,(BO.categories)( obj.Category), obj.Price??0, obj.QuantityInStock);
    }
    public static DO.Product Convert(this BO.Product obj)
    {
        return new DO.Product(obj.IdProduct,obj.NameProduct, (DO.categories)(obj.Category), obj.Price,obj.QuantityInStock);
    }
    public static BO.Sale Convert(this DO.Sale obj)
    {
        return new BO.Sale(obj.IdSale, obj.IdProduct, obj.Count, obj.TotalPrice??0, obj.AllCustomers??false, obj.StartDate??DateTime.Now, obj.EndDate??DateTime.Now);

    }
    public static DO.Sale Convert(this BO.Sale obj)
    {
        return new DO.Sale(obj.IdSale, obj.IdProduct, obj.Count, obj.TotalPrice, obj.AllCustomers, obj.StartDate, obj.EndDate);

    }
}
