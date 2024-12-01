public class Order
{
    private static double _totalUnitCost = 0;
    private double _shippingPrice = 35;
    private static List<Product> _products;
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }
 
    public static string ProductsTotalCost()
    {
        double totalCost = 0;

        foreach (Product product in _products)
        {
            _totalUnitCost = product.TotalUnitCost();
            totalCost += _totalUnitCost;
        }

        double allTotalCost = _totalUnitCost;
        string totalProductCost = allTotalCost.ToString();
        return totalProductCost;
    }

    public double ShippingCost(bool IsInUsa)
    {
        if (IsInUsa == true)
        {
            return _shippingPrice = 5;
        }
        return _shippingPrice;
    }

    public string PackingLabel()
    {
        foreach (Product product in _products)
        {
            return $"{product.PackingInfo()}";
        }
        return "";
    }

    public string AddressInfo()
    {
        return $"{Address.DisplayAll()}";
    }

    public string ShippingInfo()
    {
        return $"{_customer}\n{AddressInfo}";
    }
    public void DisplayPacking()
    {
        string packingLabel = PackingLabel();
        Console.WriteLine(packingLabel);
    }

    public void DisplayTotal()
    {
        string total = ProductsTotalCost();
        Console.WriteLine(total);
    }

    public void DisplayShipping()
    {
        string shippingLabel = ShippingInfo();
        Console.WriteLine(shippingLabel);
    }
    
}