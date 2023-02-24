public class Person
{
    protected string _name;
    protected string _email;

    Address getAddress = new Address();

    string homeAddress = getAddress.OutputAsLabel();

    public Person(string name, string email)
    {
        _email = email;
        _name = name;
    }

    public void ShowEmails()
    {
        Console.WriteLine($"{_name}: {_email}");
    }
}