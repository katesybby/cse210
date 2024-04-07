 using System;

public class Order
{
    private Customer _customer;   //inherited
    private List<Product> _products;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public double CalculateShipping()
    {
        double shippingCost = _customer.IsUSA() ? 5 : 35;
        return shippingCost;
    }

    public double CalculateTotalPrice()
    {
        double totalCost = 0;

        foreach (Product product in _products)
        {
            totalCost += product.CalculatePrice();
        }
        
        totalCost += CalculateShipping();

        return totalCost;
    }

    public string GeneratePackingLabel()
    {
        string packingLabel = "\n\x1b[1mPACKING LABEL:\x1b[0m\n";   //\x1b[1mTEXT\x1b[0m

        foreach (Product product in _products)
        {
            packingLabel += $"{product.GetName(), -25} ({product.GetProductId()})\n";   //'-25' = basically tab
        }

        return packingLabel;
    }

    public string GenerateShippingLabel()
    {
        string shippingLabel = "\n\x1b[1mSHIPPING LABEL:\x1b[0m\n";

        shippingLabel += _customer.GetName() + "\n" + _customer.GetFullAddress() + "\n";

        return shippingLabel;
    }

    public string GenerateTotalCost()
    {
        string totalCost = "\n\x1b[1mPRODUCTS:\x1b[0m\n";

        foreach (Product product in _products)
        {
            totalCost += $"{product.GetName()}: ${product.GetPrice()}, x{product.GetQuantity()} = ${product.CalculatePrice()}\n";
        }

        totalCost += "\n\x1b[1mShipping Cost:\x1b[0m $" + CalculateShipping() + "\n";
        totalCost += "\x1b[1mTotal Cost:\x1b[0m $" + CalculateTotalPrice();

        return totalCost;
    }

    public void DisplayResults()
    {
        string shippingLabel = GenerateShippingLabel();
        string packingLabel = GeneratePackingLabel();
        string totalCost = GenerateTotalCost();

        Console.WriteLine(shippingLabel);
        Console.WriteLine(packingLabel);
        Console.WriteLine(totalCost);
    }
}
