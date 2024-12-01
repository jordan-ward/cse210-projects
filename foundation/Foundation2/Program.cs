using System;

class Program
{
    static void Main(string[] args)
    {
        Customer customer1 = new Customer("Jordan Ward");
        Address address1 = new Address("1234 W 25th St", "Boise", "Idaho", "USA");
        List<Product> productsList1 = new List<Product>();

        Product product1 = new Product("Volleyball", 11345, 25.30, 2);
        Product product2 = new Product("Piano", 92435, 1135.99, 1);
        Product product3 = new Product("3D Printer", 110118, 523.20, 5);

        productsList1.Add(product1);
        productsList1.Add(product2);
        productsList1.Add(product3);

        Order order1 = new Order(productsList1, customer1);

        Console.WriteLine("Order 1: ");
        Console.WriteLine("Packing Label: ");
        Console.WriteLine($"{order1.DisplayPacking}");
        Console.WriteLine("Total Price: ");
        Console.WriteLine($"{order1.DisplayTotal}");
        Console.WriteLine("Shipping Label: ");
        Console.WriteLine($"{order1.DisplayShipping}");
        Console.WriteLine("");


        Customer customer2 = new Customer("Kevin Moore");
        Address address2 = new Address("3659 Brigade Metropolis", "Visak", "Andhra Pradesh", "India");
        List<Product> productsList2 = new List<Product>();

        Product product4 = new Product("Charger", 1125, 10.25, 5);
        Product product5 = new Product("Pen", 34412, 0.25, 1000);
        Product product6 = new Product("Apple", 1597, 2.00, 10);

        productsList2.Add(product4);
        productsList2.Add(product5);
        productsList2.Add(product6);

        Order order2 = new Order(productsList1, customer1);

        Console.WriteLine("Order 2: ");
        Console.WriteLine("Packing Label: ");
        Console.WriteLine($"{order2.DisplayPacking}");
        Console.WriteLine("Total Price: ");
        Console.WriteLine($"{order2.DisplayTotal}");
        Console.WriteLine("Shipping Label: ");
        Console.WriteLine($"{order2.DisplayShipping}");
        Console.WriteLine("");


        Customer customer3 = new Customer("Dallas Martinez");
        Address address3 = new Address("31702 Nira Ln", "Bonsall", "California", "USA");
        List<Product> productsList3 = new List<Product>();

        Product product7 = new Product("Paper", 95201, 0.10, 500);
        Product product8 = new Product("Paint", 8675, 5.30, 7);
        Product product9 = new Product("Screws", 309, 0.12, 5000);

        productsList3.Add(product4);
        productsList3.Add(product5);
        productsList3.Add(product6);

        Order order3 = new Order(productsList1, customer1);

        Console.WriteLine("Order 3: ");
        Console.WriteLine("Packing Label: ");
        Console.WriteLine($"{order3.DisplayPacking}");
        Console.WriteLine("Total Price: ");
        Console.WriteLine($"{order3.DisplayTotal}");
        Console.WriteLine("Shipping Label: ");
        Console.WriteLine($"{order3.DisplayShipping}");
        Console.WriteLine("");

    }
}