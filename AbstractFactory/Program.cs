using AbstractFactory;
using AbstractFactory.Factories;
using AbstractFactory.Interfaces;

var customer = new Customer();
var customerVIP = new Customer { Orders = new int[50] };

IVIPShoppingFactory factory1 = GetFactory(customer);
IVIPShoppingFactory factory2 = GetFactory(customerVIP);

var shoppingCart1 = new ShoppingCart(factory1);
Console.WriteLine("Shopping cart 1");
shoppingCart1.PasserCommande();

var shoppingCart2 = new ShoppingCart(factory2);
Console.WriteLine("Shopping cart 2");
shoppingCart2.PasserCommande();

IVIPShoppingFactory GetFactory(Customer c)
{
    if (c.Orders.Length > 20)
        return new VIPShoppingFactory();
    return new StandardShoppingFactory();
}