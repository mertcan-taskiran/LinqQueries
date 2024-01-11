using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ConsoleApp.Data.EfCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

// public class CustomerDemo
// {
//     public CustomerDemo()
//     {
//         Orders = new List<OrderDemo>();
//     }
//     public string CustomerId { get; set; }
//     public string Name { get; set; }
//     public int OrderCount { get; set; }
//     public List<OrderDemo> Orders { get; set; }
// }

// public class OrderDemo
// {
//     public int OrderId { get; set; }
//     public decimal Total { get; set; }
//     public List<ProductDemo> Products { get; set; }
// }

// public class ProductDemo
// {
//     public int ProductId { get; set; }
//     public string Name { get; set; }
//     public decimal Price { get; set; }
// }

class Program
{
    static void Main()
    {
        // Working with a Single Table

        // using (var db = new NorthwindContext())
        // {

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

        // }

        // Working with Multiple Tables

        // using (var db = new NorthwindContext())
        // {
            
        //     var customers = db.Customers
        //         .Where(i => i.CustomerId=="LAUGB")
        //         .Select(i => new CustomerDemo {
        //             CustomerId = i.CustomerId,
        //             Name = i.ContactName,
        //             OrderCount = i.Orders.Count(),
        //             Orders = i.Orders.Select(o => new OrderDemo {
        //                 OrderId = o.OrderId,
        //                 Total = (decimal)o.OrderDetails.Sum(od => od.Quantity * od.UnitPrice),
        //                 Products = o.OrderDetails.Select(p => new ProductDemo {
        //                     ProductId = p.ProductId,
        //                     Name = p.Product.ProductName,
        //                     Price = p.UnitPrice
        //                 }).ToList()
        //             }).ToList()
        //         })
        //         .OrderBy(i => i.OrderCount)
        //         .ToList();

        //     foreach (var customer in customers)
        //     {
        //         Console.WriteLine($"Id: {customer.CustomerId} - Name: {customer.Name} - Count: {customer.OrderCount}");
        //         foreach (var order in customer.Orders)
        //         {
        //             Console.WriteLine($"OrderId: {order.OrderId} - Total: {order.Total}");
        //             foreach (var p in order.Products)
        //             {
        //                 Console.WriteLine($"Product Id: {p.ProductId} - Product Name: {p.Name} - Product Price: {p.Price}");
        //             }
        //         }
        //     }

        // }
    }
}
