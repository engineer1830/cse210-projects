using System;

public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool IsInUSA()
    {
        string countryLower = _country.ToLower();

        if (countryLower == "usa" ||
            countryLower == "us" ||
            countryLower == "united states" ||
            countryLower == "united states of america")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetAddress()
    {
        return $"{_street}\n{_city}\n{_state}\n{_country}";
    }
}