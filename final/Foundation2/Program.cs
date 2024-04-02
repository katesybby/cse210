using System;

class Program
{
    static void Main(string[] args)
    {
        //generate random order number
        Random random = new Random();
        int orderNumber1 = random.Next(100000, 999999);
        int orderNumber2 = random.Next(100000, 999999);
        int orderNumber3 = random.Next(100000, 999999);

        //ORDER 1 ----------------------------------------------------------------------------
        Address address1 = new Address("123 Main Street", "Anytown", "CA", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        List<Product> electronicOrder = new List<Product>();

        Product smartphone = new Product("Ultraphone 1000", 101, 499.99, 1);
        Product laptop = new Product("Super Sleek Laptop", 102, 899.99, 1);
        Product wirelessEarbuds = new Product("Airpods Pro Max", 103, 79.99, 2);

        electronicOrder.Add(smartphone);
        electronicOrder.Add(laptop);
        electronicOrder.Add(wirelessEarbuds);

        Order order1 = new Order(electronicOrder, customer1);

        Console.WriteLine($"------- Order Number: {orderNumber1} -------");
        order1.DisplayResults();   
        Console.WriteLine();


        //ORDER 2 ----------------------------------------------------------------------------
        Address address2 = new Address("456 Elm Street", "Othertown", "NY", "USA");
        Customer customer2 = new Customer("Jane Doe", address2);
        List<Product> kitchenOrder = new List<Product>();

        Product coffeeMaker = new Product("Morning Brew Magic", 201, 59.99, 1);
        Product toaster = new Product("Toasty the Toaster", 202, 34.99, 1);

        kitchenOrder.Add(coffeeMaker);
        kitchenOrder.Add(toaster);

        Order order2 = new Order(kitchenOrder, customer2);

        Console.WriteLine($"------- Order Number: {orderNumber2} -------");
        order2.DisplayResults();   
        Console.WriteLine();


        //ORDER 3 ----------------------------------------------------------------------------
        Address address3 = new Address("789 Beach Blvd", "Sunnyville", "QLD", "Australia");
        Customer customer3 = new Customer("Joe Johnson", address3);
        List<Product> gamingOrder = new List<Product>();

        Product console = new Product("Supercharged Gaming Console", 301, 399.99, 1);
        Product controller = new Product("Pro Gamer Controller", 302, 59.99, 2);
        Product videoGame = new Product("Epic Adventure Quest", 303, 29.05, 3);

        gamingOrder.Add(console);
        gamingOrder.Add(controller);
        gamingOrder.Add(videoGame);

        Order order3 = new Order(gamingOrder, customer3);

        Console.WriteLine($"------- Order Number: {orderNumber3} -------");
        order3.DisplayResults();   
        Console.WriteLine();
    }
}

//----------------------------------------------------------------------------------------------
//Exceeding Requirements:
//1. Added descriptive names for variables and methods (i.e. electronicOrder instead of productList1)
//2. Added creative product names and descriptions
//3. Randomized order number
//4. Gorgeous output formatting
