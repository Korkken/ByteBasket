//create list and order based on Order.cs
using ByteBasket;
Customer customer = new Customer("Kalle anka", "hehehe@gmail.com", "0701234567", "bollgatan 3");
List<Product> productList = new List<Product>
{
    new Product("Product A", 10, 2, "bananer"),
    new Product("Product B", 15, 1, "kycklingar"),
    new Product("Product C", 8, 3, "ananaser")
}; // your list of products


ExpressDelivery delivery = new ExpressDelivery(005, customer.Address, "order skickad", DateTime.Now);
Order order = new Order(productList, Guid.NewGuid(), customer, DateTime.Now, delivery);

order.PrintOrder();

order.HandleDelivery();
Customer customer2 = new Customer("Kalle anka", "hehehe@gmail.com", "0701234567", "bollgatan 3");
List<Product> productList2 = new List<Product>
{
    new Product("Product A", 10, 2, "bananer"),
    new Product("Product B", 15, 1, "kycklingar"),
    new Product("Product C", 8, 3, "ananaser")
}; // your list of products


ExpressDelivery delivery2 = new ExpressDelivery(005, customer.Address, "order skickad", DateTime.Now);
Order order2 = new Order(productList, Guid.NewGuid(), customer, DateTime.Now, delivery);


Console.ReadLine();

