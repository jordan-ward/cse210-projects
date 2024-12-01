public class Product
{
    private string _productName;
    private int _productId;
    private double _price;
    private int _quantity;

    public Product (string productName, int productId, double price, int quantity)
    {
        _productName = productName;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }
    public double TotalUnitCost()
    {
        double cost = _price * _quantity; 
        return cost;
    }
    public string PackingInfo()
    {
        return $"Product: {_productName} \nID: {_productId}";
    }
}