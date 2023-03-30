public class Address
{
    private string street;
    private string city;
    private string state;
    private string country;

    public Address(string street, string city, string state, string country)
    {
        this.street = street;
        this.city = city;
        this.state = state;
        this.country = country;
    }

    public bool IsInUSA()
    {
        return this.country == "USA";
    }

    public override string ToString()
    {
        return $"{this.street}\n{this.city}, {this.state} {this.country}";
    }
}