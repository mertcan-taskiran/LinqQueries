using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ConsoleApp.Data.EfCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var db = new NorthwindContext())
            {
                //Tüm müşteri kayıtları ***************************************
                // var customers = db.Customers.ToList();
                // foreach (var c in customers)
                // {   
                //     Console.WriteLine(c.ContactName);
                // }

                //Tüm müşteri kayıtlarının ad ve soyadı ***********************
                // var customers = db.Customers.Select(c => new {
                //     c.ContactName
                // });
                // foreach (var c in customers)
                // {   
                //     Console.WriteLine(c.ContactName);
                // }

                //New Yorkta yaşayan müşterileri isim sırasına göre getir *****
                // var customers = db.Customers.Where(i => i.City == "New York").Select(s => new{s.ContactName}).ToList();
                // foreach (var c in customers)
                // {   
                //     Console.WriteLine(c.ContactName);
                // }

                //En son eklenen 5 ürün **********************
                // var products = db.Products.OrderByDescending(i => i.ProductId).Take(5);
                // foreach (var p in products)
                // {   
                //     Console.WriteLine(p.ProductName);
                // }

                //Fiyatı 10 ile 30 arasında olan ürünlerin isim, fiyat bilgisi ********
                // var products = db.Products
                // .Where(i => i.UnitPrice > 10 && i.UnitPrice < 30)
                // .Select(i=> new {
                //     i.ProductName,
                //     i.UnitPrice
                // }).ToList();
                // foreach (var p in products)
                // {   
                //     Console.WriteLine(p.ProductName + " " +p.UnitPrice);
                // }

                //İçinde "coffee" geçen ürün isimleri
                // var products = db.Products.Where(i => i.ProductName.Contains("coffee"));
                // foreach (var p in products)
                // {   
                //     Console.WriteLine(p.ProductName);
                // }

                //En pahalı ve en ucuz ürün fiyatı
                // var minProduct = db.Products
                //     .Where(i=>i.UnitPrice == (db.Products.Min(a => a.UnitPrice)))
                //     .FirstOrDefault();
                // var maxProduct = db.Products
                //     .Where(i=>i.UnitPrice == (db.Products.Max(a => a.UnitPrice)))
                //     .FirstOrDefault();

                // Console.WriteLine($"Name: {minProduct.ProductName} - Price: {minProduct.UnitPrice}");
                // Console.WriteLine($"Name: {maxProduct.ProductName} - Price: {maxProduct.UnitPrice}");

            }
        }
    }
}