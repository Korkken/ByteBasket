using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBasket
{
    abstract class Delivery
    {
        public int DeliveryID { get; set; }
        public string DeliveryAddress { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string DeliveryStatus { get; set; }
        public Order UserOrder { get; set; }
        public Delivery(int deliveryID, string deliveryAddress, string deliveryStatus, DateTime deliveryDate)
        {
            DeliveryID = deliveryID;
            DeliveryAddress = deliveryAddress;
            DeliveryStatus = deliveryStatus;
            DeliveryDate = deliveryDate;
        }
        public abstract void DisplayDeliveryDetails();
        
    }
}
