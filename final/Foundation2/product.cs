public class Product
{
    private string name;
    private string productId;
    private decimal price;
    private int quantity;

    public Product(string name, string productId, decimal price, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.price = price * quantity;
        this.quantity = quantity;
    }

    public string Name { get { return this.name; } }
    public string ProductId { get { return this.productId; } }
    public decimal Price { get { return this.price; } }
}