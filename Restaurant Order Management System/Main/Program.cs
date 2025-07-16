using Restaurant_Order_Management_System.Core;
using Restaurant_Order_Management_System.Entities;
using System;

namespace Restaurant_Order_Management_System.Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Restaurant restaurant = new Restaurant();

            restaurant.AddMenuItem(new MenuItem(1, "Pizza", 100m));
            restaurant.AddMenuItem(new MenuItem(2, "Burger", 80m));
            restaurant.AddMenuItem(new MenuItem(3, "Juice", 30m));
            restaurant.AddMenuItem(new MenuItem(4, "Pasta", 90m));
            restaurant.AddMenuItem(new MenuItem(5, "Salad", 50m));
            restaurant.AddMenuItem(new MenuItem(6, "Steak", 200m));
            restaurant.AddMenuItem(new MenuItem(7, "Ice Cream", 40m));
            restaurant.AddMenuItem(new MenuItem(8, "Coffee", 25m));

            restaurant.ShowMenu();
            Console.WriteLine();

            restaurant.AddPerson(new Chef(1, "Ali", "0123456789", "Italian Food"));
            restaurant.AddPerson(new Chef(2, "Mona", "0129998888", "Grill"));
            restaurant.AddPerson(new Waiter(3, "Sara", "0112233445", 3000m));
            restaurant.AddPerson(new Waiter(4, "Omar", "0101122334", 2800m));
            Customer customer1 = new Customer(5, "Fadi", "0100000000", "Cairo");
            Customer customer2 = new Customer(6, "Lina", "0105556666", "Alexandria");
            restaurant.AddPerson(customer1);
            restaurant.AddPerson(customer2);

            Console.WriteLine("People in Restaurant:");
            foreach (var person in restaurant.Persons)
            {
                person.GetRole();
            }

            Console.WriteLine();

            Order order1 = new Order(1, DateOnly.FromDateTime(DateTime.Now));
            order1.OrderItems.Add(new OrderItem(restaurant.MenuItems[0], 2)); 
            order1.OrderItems.Add(new OrderItem(restaurant.MenuItems[2], 3)); 
            restaurant.PlaceOrder(order1);

            Order order2 = new Order(2, DateOnly.FromDateTime(DateTime.Now));
            order2.OrderItems.Add(new OrderItem(restaurant.MenuItems[4], 1)); 
            order2.OrderItems.Add(new OrderItem(restaurant.MenuItems[6], 2)); 
            restaurant.PlaceOrder(order2);

            Order order3 = new Order(3, DateOnly.FromDateTime(DateTime.Now));
            order3.OrderItems.Add(new OrderItem(restaurant.MenuItems[5], 1)); 
            order3.OrderItems.Add(new OrderItem(restaurant.MenuItems[7], 2)); 
            order3.OrderItems.Add(new OrderItem(restaurant.MenuItems[3], 1)); 
            restaurant.PlaceOrder(order3);

            Console.WriteLine("\nAll Orders:");
            restaurant.ShowOrders();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
