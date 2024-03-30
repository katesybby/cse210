using System;

class Program
{
    static void Main(string[] args)
    {
        //ORDER 1 ----------------------------------------------------------------------------
        Address address1 = new Address("123 Main Street", "Anytown", "CA", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        List<Product> productList1 = new List<Product>();

        Product product101 = new Product("Smartphone", 101, 499.99, 1);
        Product product102 = new Product("Laptop", 102, 899.99, 1);
        Product product103 = new Product("Wireless Earbuds", 103, 79.99, 2);

        productList1.Add(product101);
        productList1.Add(product102);
        productList1.Add(product103);

        Order order1 = new Order(productList1, customer1);

        Console.WriteLine("Order Number: 1");
        order1.DisplayResults();   
        Console.WriteLine();


        //ORDER 2 ----------------------------------------------------------------------------
        Address address2 = new Address("456 Elm Street", "Othertown", "NY", "USA");
        Customer customer2 = new Customer("Jane Doe", address2);
        List<Product> productList2 = new List<Product>();

        Product product201 = new Product("Coffee Maker", 201, 59.99, 1);
        Product product202 = new Product("Toaster", 202, 34.99, 1);

        productList2.Add(product201);
        productList2.Add(product202);

        Order order2 = new Order(productList2, customer2);

        Console.WriteLine("Order Number: 2");
        order2.DisplayResults();   
        Console.WriteLine();


        //ORDER 3 ----------------------------------------------------------------------------
        Address address3 = new Address("789 Beach Blvd", "Sunnyville", "QLD", "Australia");
        Customer customer3 = new Customer("Joe Johnson", address3);
        List<Product> productList3 = new List<Product>();

        Product product301 = new Product("Gaming Console", 301, 399.99, 1);
        Product product302 = new Product("Controller", 302, 59.99, 2);
        Product product303 = new Product("Game", 303, 29.05, 3);

        productList3.Add(product301);
        productList3.Add(product302);
        productList3.Add(product303);

        Order order3 = new Order(productList3, customer3);

        Console.WriteLine("Order Number: 3");
        order3.DisplayResults();   
        Console.WriteLine();
    }
}