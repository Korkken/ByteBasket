using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBasket
{
    public class Product
    {
        public string ProductName  { get; set; }
        public double ProductPrice { get; set; }
        int ProductQuantity { get; set; }
        string ProductDescription { get; set; }
        public Product(string productName, double productPrice, int productQuantity, string productDescription)
        {
            ProductName = productName;
            ProductPrice = productPrice;
            ProductQuantity = productQuantity;
            ProductDescription = productDescription;
        }

    }
}
