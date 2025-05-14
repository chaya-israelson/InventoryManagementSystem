


using System.Xml.Linq;

namespace Dal;

internal static class Config
{
    const string filePath = @"..\xml\data-config.xml";


    const string IDPRODUCT = "idProduct";
    const string IDSALE = "idSale";

    public static int ProductId
    {
        get
        {
            XElement products = XElement.Load(filePath);
            int num;
            if (!int.TryParse(products.Element(IDPRODUCT).Value, out num))
                throw new Exception("");
            products.Element(IDPRODUCT).SetValue(num + 1);
            products.Save(filePath);
            return num+1;
        }


    }


    public static int idSale
    {
        get
        {
            XElement sales = XElement.Load(filePath);
            int num;
            if (!int.TryParse(sales.Element(IDSALE).Value, out num))
                throw new Exception("");
            sales.Element(IDSALE).SetValue(num + 1);
            sales.Save(filePath);
            return num+1;
        }

    }


}
