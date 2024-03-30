using System;
using System.Diagnostics.Contracts;

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
        string packingLabel = "Packing Label:\n";

        foreach (Product product in _products)
        {
            packingLabel += product.GetName() + " - " + product.GetProductId() + "\n";
        }

        return packingLabel;
    }

    public string GenerateShippingLabel()
    {
        string shippingLabel = "Shipping Label:\n";
        shippingLabel += _customer.GetName() + "\n" + _customer.GetFullAddress();

        return shippingLabel;
    }

    public string GenerateTotalCost()
    {
        string totalCost = "\nProducts\n";
        double totalPrice = CalculateTotalPrice();

        foreach (Product product in _products)
        {
            totalCost += product.GetName() + product.GetProductId() + product.GetPrice() + product.GetQuantity() + product.CalculatePrice() + "\n";
        }

        totalCost += "Shipping Cost: $" + CalculateShipping() + "\n";
        totalCost += "Total Cost: $" + CalculateTotalPrice();

        return totalCost;
    }

    public void DisplayResults()
    {
        string packingLabel = GeneratePackingLabel();
        string shippingLabel = GenerateShippingLabel();
        string totalCost = GenerateTotalCost();

        Console.WriteLine(packingLabel);
        Console.WriteLine(shippingLabel);
        Console.WriteLine(totalCost);
    }
}
