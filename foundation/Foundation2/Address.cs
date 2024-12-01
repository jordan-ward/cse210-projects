public class Address
{
    private static string _address;
    private static string _city;
    private static string _state;
    private static string _country;

    public Address (string address, string city, string state, string country)
    {
        _address = address;
        _state = state;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool InUsa(string GetCountry)
    {
        string country = GetCountry.ToUpper();
        if (country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }        
    }

    public static string DisplayAll()
    {
        return $"{_address}\n {_city}, {_state},\n {_country}";
    }
}