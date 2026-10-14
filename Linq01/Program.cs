
using LINQ.DataSources;
using LINQ.Models;

namespace Linq01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            //var SeafoodProducts = Source.ProductList.Where(p => p.Category == "Seafood");

            //foreach (var product in SeafoodProducts)
            //{
            //    Console.WriteLine($"Product Name :{product.ProductName},Price :{product.UnitPrice}");
            //}

            #endregion

            #region Question02
            //var names = Source.ProductList.Select(p => p.ProductName);

            //foreach(var name in names)
            //{
            //    Console.WriteLine(name);
            //}
            #endregion

            #region Question03
            //var cheapProducts = Source.ProductList.Where(p => p.UnitPrice >= 10 && p.UnitPrice <= 30);

            //foreach(var product in cheapProducts)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion

            #region Question04

            //var InStockCondimentsProducts = Source.ProductList.Where(p => p.UnitsInStock > 0 && p.Category == "Condiments");

            //foreach(var product in InStockCondimentsProducts)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion

            #region Question05
            //var products = Source.ProductList.Select
            //(p => new { 
            //Name =p.ProductName, Price = p.UnitPrice ,
            //StockStatus = p.UnitsInStock > 0 ? "Available":"Out of stock " 
            //});

            //foreach(var product in products)
            //{
            //    Console.WriteLine($"Product Name :{product.Name},Price :{product.Price},Stock Status :{product.StockStatus}");
            //}

            #endregion
        }
    }
}
