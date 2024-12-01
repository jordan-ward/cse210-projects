public class Customer
{
    private string _customerName;

    public Customer(string customerName)
    {
        _customerName = customerName;
    }    
    public bool IsInUsa(bool InUsa)
    {
        return InUsa;
    }
    public string DisplayCustomerName()
    {
        string customerName = _customerName;
        return $"{customerName}";
    }

}