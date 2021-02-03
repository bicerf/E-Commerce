using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetByUnitPrice(40,100))
            {
                Console.WriteLine(product.ProductName);
            }
            Console.WriteLine("---------2 numaralı categoryid e sahip ürünler-----------------");

            foreach (var product in productManager.GetAllByCategoryId(3))
            {
                Console.WriteLine(product.ProductName);


            }
            Console.WriteLine("---------Stoktaki sayıya göre sıralanan ürünler-----------------");

            foreach (var product in productManager.GetByUnitsInStock(30,60))
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
