
using DO;

namespace Dal;

internal static class DataSource
{
    internal static List<Client>? Clients= new List<Client>();
    internal static List<Product>? Products = new List<Product>();
    internal static List<Sale>? Sales = new List<Sale>();
    internal static class Config
    {
        //Product
        internal const int begin_Product = 1000000;
        private static int idProduct= begin_Product;


        public static int IdProduct => idProduct++;


        //Sale
        internal const int begin_Sale = 100;
        private static int idSale= begin_Sale;


        public static int IdSale => idSale++;

    }
}
