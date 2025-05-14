using DalApi;
using DO;
using Tools;
using System.Reflection;
namespace DelTest;


internal class Program
{
    static readonly IDal s_dal = DalApi.Factory.Get;

    static void Main(string[] args)
    {
        Initalization.initialize();
        Start();
    }

    private static void Start()
    {
        Console.WriteLine("Welcome to the \"For Traveler\" store");
        int choice = printMainMenu();
        while (choice != 0)
        {
            switch (choice)
            {
                case 1:
                    ProductMenu();
                    break;
                case 2:
                    SaleMenu();
                    break;
                case 3:
                    ClientMenu();
                    break;
                case 4:
                    LogManager.DeleteOldDir();
                    break;
                default:

                    Console.WriteLine("Invalid value received! Try again");
                    break;
            }
            choice = printMainMenu();
        }
    }

    // פונ' המציגה את התפריט הראשי
    private static int printMainMenu()
    {
        Console.WriteLine("For product press 1");
        Console.WriteLine("For sale press 2");
        Console.WriteLine("For client press 3");
        Console.WriteLine("For clean the log folder press 4");
        Console.WriteLine("To exit press 0");
        int selection;
        if (!int.TryParse(Console.ReadLine(), out selection))
            selection = -1;
        return selection;
    }
    // ...פונ' המציגה תפריט לפעולות
    public static int printSubMenu(string entity)
    {
        Console.WriteLine($"To create {entity} press 1");
        Console.WriteLine($"To delete {entity} press 2");
        Console.WriteLine($"To update {entity} press 3");
        Console.WriteLine($"To read {entity} press 4");
        Console.WriteLine($"To read all {entity}s press 5");
        Console.WriteLine("to return press 0");
        int selection;
        if (!int.TryParse(Console.ReadLine(), out selection))
            selection = -1;
        return selection;
    }
    static void ProductMenu()
    {
        int choice = printSubMenu("product");
        while (choice != 0)
        {
            switch (choice)
            {
                case 1:
                    try
                    {
                        int id = s_dal.Product.Create(newProduct(0));
                        Console.WriteLine("id: " + id);
                    }
                    catch { Console.WriteLine("Item exsist"); }
                    break;
                case 2:
                        Delete<Product>(s_dal.Product, "product");
                    break;
                case 3:
                    try
                    {
                        Console.WriteLine("Enter product code to update");
                        int id = int.Parse(Console.ReadLine());
                        if(s_dal.Product.Read(id)!=null)
                            s_dal.Product.Create(newProduct(id));
                        else
                            Console.WriteLine("Product does not exist");
                    }
                    catch { LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "----------Product does not exist");
                        Console.WriteLine("Product does not exist"); 
                    }
                    break;
                case 4:
                    Read<Product>(s_dal.Product, "product");
                    break;
                case 5:
                    ReadAll<Product>(s_dal.Product);
                    break;
                default :
                    Console.WriteLine("your selection is wrong");
                    break;
            }
            choice = printSubMenu("product");
        }
    }
    static void ClientMenu()
    {
        int choice = printSubMenu("cliant");
        while (choice != 0)
        {
            switch (choice)
            {
                case 1:
                    try
                    {
                         s_dal.Client.Create(newClient());
                    }
                    catch {
                        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "----------Item exsist");
                        Console.WriteLine("Item exsist"); }
                    break;
                case 2:
                    Delete<Client>(s_dal.Client, "client");
                    break;
                case 3:
                    try
                    {
                        Console.WriteLine("Enter client code to update");
                        int id = int.Parse(Console.ReadLine());
                        if (s_dal.Client.Read(id) != null)
                            s_dal.Client.Create(newClient());
                        else
                            Console.WriteLine("Cliant does not exist");
                    }
                    catch
                    {
                        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "----------Cliant does not exist");

                        Console.WriteLine("Cliant does not exist"); }
                    break;
                case 4:
                    Read<Client>(s_dal.Client, "cliant");
                    break;
                case 5:
                    ReadAll<Client>(s_dal.Client);
                    break;
                default:
                    Console.WriteLine("your selection is wrong");
                    break;
            }
            choice = printSubMenu("cliant");
        }
    }
    static void SaleMenu()
    {
        int choice = printSubMenu("sale");
        while (choice != 0)
        {
            switch (choice)
            {
                case 1:
                    try
                    {
                        int id = s_dal.Sale.Create(newSale(0));
                        Console.WriteLine("id: " + id);
                    }
                    catch
                    {
                        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "----------Item exsist");

                        Console.WriteLine("Item exsist"); }
                    break;
                case 2:
                    Delete<Sale>(s_dal.Sale, "sale");
                    break;
                case 3:
                    try
                    {
                        Console.WriteLine("Enter sale code to update");
                        int id = int.Parse(Console.ReadLine());
                        if (s_dal.Sale.Read(id) != null)
                            s_dal.Sale.Create(newSale(id));
                    }
                    catch
                    {
                        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "----------Sale does not exist");

                        Console.WriteLine("Sale does not exist"); }
                    break;
                case 4:
                    Read<Sale>(s_dal.Sale, "sale");
                    break;
                case 5:
                    ReadAll<Sale>(s_dal.Sale);
                    break;
                default:
                    Console.WriteLine("your selection is wrong");
                    break;
            }
            choice = printSubMenu("sale");
        }
    }
    static Product newProduct(int id)
    {
        try
        {
            Console.WriteLine("Enter product details\nNameProduct, Category Number between 1 and 5,Price ,QuantityInStock ");
            string NameProduct = Console.ReadLine();
            categories Category = (categories)int.Parse(Console.ReadLine());
            double Price = double.Parse(Console.ReadLine());
            int QuantityInStock = int.Parse(Console.ReadLine());
            return new Product(id, NameProduct, Category, Price, QuantityInStock);
        }
        catch
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "----------Incorrect data entered!");

            Console.WriteLine("Incorrect data entered!\n try again");
            return newProduct(id);
        }
        
    }
    static Client newClient()
    {
        try
        {
            Console.WriteLine("Enter product details\ntz, Name, Addres ,Phon");
            int tz = int.Parse(Console.ReadLine());
            string Name = Console.ReadLine();
            string Addres = Console.ReadLine();
            string Phon = Console.ReadLine();
            return new Client(tz, Name, Addres, Phon);
        }
        catch
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "----------Incorrect data entered!");

            Console.WriteLine("Incorrect data entered!\n try again");
            return newClient();
        }

    }
    static Sale newSale(int id)
    {
        try
        {
            Console.WriteLine("Enter product details\n IdProduct, Caunt,TotalPrice ,AllCustomers,StartDate,EndDate ");
            int IdProduct = int.Parse(Console.ReadLine());
            int Caunt = int.Parse(Console.ReadLine());
            double TotalPrice = double.Parse(Console.ReadLine());
            bool AllCustomers = bool.Parse(Console.ReadLine());
            DateTime StartDate= DateTime.Parse(Console.ReadLine());
            DateTime EndDate = DateTime.Parse(Console.ReadLine());
            return new Sale(id, IdProduct, Caunt, TotalPrice, AllCustomers, StartDate, EndDate);
        }
        catch
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "----------Incorrect data entered!");

            Console.WriteLine("Incorrect data entered!\n try again");
            return newSale(id);
        }

    }
    public static void Delete<T>(ICrud<T> crud, string entity)
    {
        Console.WriteLine($"Enter {entity} id");
        try
        {
            int id = int.Parse(Console.ReadLine());
            crud.Delete(id);
        }
        catch
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "----------The id is not valid");

            Console.WriteLine("The id is not valid, please try again");
            Delete<T>(crud, entity);
        }
    }
    public static void Read<T>(ICrud<T> crud, string entity)
    {
        try
        {
            Console.WriteLine("Enter product code to update");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine(crud.Read(id).ToString());
        }
        catch
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "----------Product does not exist");

            Console.WriteLine("Product does not exist");
            Read<T>(crud, entity);
        }
    }
    public static void ReadAll<T>(ICrud<T> crud)
    {
        foreach (var item in crud.ReadAll())
        {
            Console.WriteLine(item);
        }
    }

}