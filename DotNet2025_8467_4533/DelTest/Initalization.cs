
using DO;
using DalApi;
namespace DelTest;

public static class Initalization
{
    private static IDal s_dal;
    public static void initialize()
    {
        s_dal = DalApi.Factory.Get;
        createClient(s_dal);
        createProduct();
        createSale(s_dal);
    }
    private static void createProduct()
    {
        s_dal.Product.Create(new Product(0, "shirt", categories.Clothing, 102.9, 4));
        s_dal.Product.Create(new Product(0, "running shoes", categories.Footwear, 500,6));
        s_dal.Product.Create(new Product(0, "grill", categories.CampingEquipment, 769, 3));
        s_dal.Product.Create(new Product(0, "ropes", categories.ClimbingEquipment, 80.9, 21));
        s_dal.Product.Create(new Product(0, "panniers", categories.AncillaryEquipment, 135.85, 9));
    }
    private static void createSale(IDal dal)
    {
        s_dal.Sale.Create(new Sale(0, 12345,2, 99, true, DateTime.Now, DateTime.Now));
        s_dal.Sale.Create(new Sale(0, 12346, 5, 199, true, DateTime.Now, DateTime.Now));
        s_dal.Sale.Create(new Sale(0, 12347, 3, 399, false, DateTime.Now, DateTime.Now));

    }
    private static void createClient(IDal dal)
    {
        s_dal.Client.Create(new Client(21374, "Shoshi", "Rashi", "0527695236"));
        s_dal.Client.Create(new Client(21375, "Racheli", "Rashbi", "0556726780"));
        s_dal.Client.Create(new Client(21376, "Sari", "Rambam", "05567239854"));
        s_dal.Client.Create(new Client(21377, "Tamar", "Ramban", "0527623698"));
        s_dal.Client.Create(new Client(21378, "Neomi", "Maharil", "0583279654"));
    }
}
