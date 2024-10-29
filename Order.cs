using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBasket;
namespace ByteBasket
{
    internal class Order
    {
        public Guid OrderID { get; set; }
        List<Product> Products { get; set; }
        Customer CustomerName { get; set; }
        DateTime OrderDate  { get; set; }
        double TotalPrice { get; set; }
        public Delivery delivery { get; set; }
        public Order(List<Product> products, Guid orderID, Customer customerName, DateTime orderDate, Delivery userDelivery)
        {
            Products = products;
            OrderID = orderID;
            CustomerName = customerName;
            OrderDate = orderDate;
            delivery = userDelivery;
        }
        public void PrintOrder()
        {
            for (int i = 0; i < Products.Count; i++)
            {
                TotalPrice += Products[i].ProductPrice;
            }
            Console.WriteLine($"Hej {CustomerName.Name}! Din order med id {OrderID} innehåller:");
            foreach (var product in Products)
            {
                Console.WriteLine(product.ProductName);
            }
            Console.WriteLine($"Orderdatum: {OrderDate.ToShortDateString()}");
            Console.WriteLine($"Totalpris: {TotalPrice} kr");
        }
        public void HandleDelivery()
        {
            Console.WriteLine($"Order");
            delivery.DisplayDeliveryDetails();
        }


        
    }
}
