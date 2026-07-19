using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Broadway", "New York City", "NY", "USA");
        Address address2 = new Address("455 Oak Ridge Dr", "Phoenix", "AZ", "USA");
        Address address3 = new Address("782 Pine Hollow Rd", "Seattle", "WA", "USA");
        Address address4 = new Address("90 Riverbend Ave", "Chicago", "IL", "USA");
        Address address5 = new Address("612 Maple Grove Ln", "Atlanta", "GA", "USA");
        Address address6 = new Address("14 Queen's Way", "London", "Greater London", "United Kingdom");
        Address address7 = new Address("88 Sakura Blvd", "Tokyo", "Tokyo Prefecture", "Japan");
        Address address8 = new Address("230 Rue de Lyon", "Paris", "Île-de-France", "France");
        Address address9 = new Address("55 Avenida del Sol", "Madrid", "Madrid", "Spain");
        Address address10 = new Address("19 Harbourfront Rd", "Sydney", "NSW", "Australia");

        Customer customer1 = new Customer("Jesse Thompson", address1);
        Customer customer2 = new Customer("Sunrise Home Builders", address2);
        Customer customer3 = new Customer("Emily Carter", address3);
        Customer customer4 = new Customer("Windy City Logistics", address4);
        Customer customer5 = new Customer("Peachtree Consulting Group", address5);
        Customer customer6 = new Customer("Oliver Kensington", address6);
        Customer customer7 = new Customer("Sakura Tech Industries", address7);
        Customer customer8 = new Customer("Marie Dubois", address8);
        Customer customer9 = new Customer("Sol y Mar Imports", address9);
        Customer customer10 = new Customer("Harbourfront Marine Services", address10);

        Order order1 = new Order(customer1);
        Order order2 = new Order(customer2);
        Order order3 = new Order(customer3);
        Order order4 = new Order(customer4);
        Order order5 = new Order(customer5);
        Order order6 = new Order(customer6);
        Order order7 = new Order(customer7);
        Order order8 = new Order(customer8);
        Order order9 = new Order(customer9);
        Order order10 = new Order(customer10);

        Product p1 = new Product("Laptop", "LAP123", 999.99, 1);
        Product p2 = new Product("Wireless Mouse", "MOU457", 24.99, 3);
        Product p3 = new Product("Desk Lamp", "LAM882", 39.50, 2);
        Product p4 = new Product("USB-C Charger", "CHR219", 18.75, 6);
        Product p5 = new Product("Noise-Canceling Headphones", "HDP564", 129.99, 4);
        Product p6 = new Product("Portable SSD", "SSD731", 89.49, 5);

        // Order 1
        order1.AddProduct(p1);
        order1.AddProduct(p4);

        // Order 2
        order2.AddProduct(p3);

        // Order 3
        order3.AddProduct(p2);
        order3.AddProduct(p5);
        order3.AddProduct(p6);

        // Order 4
        order4.AddProduct(p6);
        order4.AddProduct(p1);

        // Order 5
        order5.AddProduct(p4);
        order5.AddProduct(p2);
        order5.AddProduct(p3);

        // Order 6
        order6.AddProduct(p5);

        // Order 7
        order7.AddProduct(p1);
        order7.AddProduct(p2);
        order7.AddProduct(p3);
        order7.AddProduct(p4);

        // Order 8
        order8.AddProduct(p6);
        order8.AddProduct(p5);

        // Order 9
        order9.AddProduct(p3);
        order9.AddProduct(p1);

        // Order 10
        order10.AddProduct(p2);
        order10.AddProduct(p4);
        order10.AddProduct(p6);

        List<Order> orders = new List<Order>()
        {
            order1, order2, order3, order4, order5, order6, order7, order8, order9, order10
        };

        foreach (Order order in orders)
        {
            Console.WriteLine("Packing Label:");
            Console.WriteLine(order.GetPackingLabel());

            Console.WriteLine("Shipping Label:");
            Console.WriteLine(order.GetShippingLabel());

            Console.WriteLine($"Total Cost: ${order.GetTotalCost():N2}");
            Console.WriteLine("----------------------------------------");
        }
    }
}