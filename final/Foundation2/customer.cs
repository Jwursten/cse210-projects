public class Customer
{
    private string name;
    private Address address;

    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    public string Name { get { return this.name; } }
    public Address Address { get { return this.address; } }

    public bool IsInUSA()
    {
        return this.address.IsInUSA();
    }
}