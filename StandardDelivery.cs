using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBasket;
namespace ByteBasket
{
    internal class StandardDelivery : Delivery
    {
        public StandardDelivery(int deliveryID, string deliveryAddress, string deliveryStatus, DateTime deliveryDate, Order userOrder)
            :base(deliveryID, deliveryAddress, deliveryStatus, deliveryDate)
        {
            deliveryDate =  DateTime.Now.AddDays(5);
        }
        
        public override async void DisplayDeliveryDetails()
        {
            
            Console.WriteLine($"kommer att levereras till {DeliveryAddress} den {DeliveryDate.ToShortDateString()}.");
            await Task.Delay(3000);
            Console.WriteLine($"Din leverans har anlänt till {DeliveryAddress}");

        }
    }
}
