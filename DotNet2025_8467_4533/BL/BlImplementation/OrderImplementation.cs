

using BlApi;
using BO;

namespace BlImplementation;

internal class OrderImplementation : IOrder
{
    private DalApi.IDal _dal = DalApi.Factory.Get;
    public List<BO.SaleInProduct> AddProductToOrder(BO.Order order, int IdProduct, int count)
    {
        try
        {
            BO.Product product = _dal.Product.Read(IdProduct).Convert();
            BO.ProductInOrder productInOrder = order.ListProduct.FirstOrDefault(p => p.IdProduct == IdProduct);
  
            if (productInOrder!=null)
            {
                if (count > product.QuantityInStock)
                    throw new Exception("חסר במלאי");
                if (productInOrder.Count + count < 0)
                    throw new Exception("פעולה לא חוקית");
                productInOrder.Count += count;
                product.QuantityInStock -= count;// בכל מקרה לא משמעותי לנו למסך...
                return product.ProductsSaleList;
            }
            else
            {
                if ( count > product.QuantityInStock)
                    throw new Exception("חסר במלאי");
                if (count < 0)
                    throw new Exception("פעולה לא חוקית");
                BO.ProductInOrder pio = new ProductInOrder(product.IdProduct, product.NameProduct, product.Price ?? 0, product.ProductsSaleList, count, product.Price ?? 0);
                SearchSaleForProduct(pio, order.FavoriteClient);
                CalcTotalPriceForProduct(pio);
                CalcTotalPrice(order);
                order.ListProduct.Add(pio);
                return pio.ListSales;

            }

        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
      
    
    }
    
    public void CalcTotalPrice(BO.Order order)
    {
         foreach(ProductInOrder product in order.ListProduct)
        {
            order.TotalPrice += product.FinalPrice;
        }
    }

    public void CalcTotalPriceForProduct(BO.ProductInOrder product)
    {
        int count = product.Count;
        List<BO.SaleInProduct>sales= new List<BO.SaleInProduct>();
        foreach (BO.SaleInProduct item in product.ListSales)
        {
            if (count == 0)
            {   
                break;
            }
            if (count < item.Count)
                continue;
            else
            {
                product.FinalPrice+=(count/item.Count)*item.Price;
                count-=count/item.Count;
                sales.Add(item);
            }

        }
        product.FinalPrice += product.BasePrice * count;
        product.ListSales=sales;
    }

    public void DoOrder(BO.Order order)
    {
        BO.Product pro;
        foreach (BO.ProductInOrder p in order.ListProduct)
        {
           pro=_dal.Product.Read(p.IdProduct).Convert();
           pro.QuantityInStock-=p.Count;
            _dal.Product.Update(pro.Convert());
        }
    }
    public void SearchSaleForProduct(BO.ProductInOrder product, bool favorite)
    {
        List<DO.Sale> sales = _dal.Sale.ReadAll();
        List<DO.Sale> sale2;
        if(favorite)
            sale2=sales.Where(s=>s.IdProduct==product.IdProduct&&s.EndDate>=DateTime.Now&&s.StartDate<=DateTime.Now&&s.Count <=product.Count).ToList();
        else
            sale2=sales.Where(s=>s.IdProduct==product.IdProduct&& s.EndDate >= DateTime.Now && s.StartDate <= DateTime.Now && s.Count <= product.Count&&s.AllCustomers==true).ToList();
        List<BO.SaleInProduct> saleInPro =sale2.Select(x=>new BO.SaleInProduct(x.IdSale,x.Count,x.TotalPrice??0,x.AllCustomers??true)).ToList();
        saleInPro.OrderBy((x => x.Price));
        product.ListSales=saleInPro;
    }

    public void SearchSaleForProduct(int IdProduct, bool FavoriteClient)
    {
        throw new NotImplementedException();
    }
}
