public class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer)
    {
        this.products = new List<Product>();
        this.customer = customer;
    }

    public void AddProduct(Product product)
    {
        this.products.Add(product);
    }

    public decimal CalculateTotalCost()
    {
        decimal total = 0;
        foreach (Product product in this.products)
        {
            total += product.Price;
        }
        if (this.customer.Address.IsInUSA())
        {
            total += 5; // USA shipping cost
        }
        else
        {
            total += 35; // non-USA shipping cost
        }
        return total;
    }

    public string GetPackingLabel()
    {
        string label = "";
        foreach (Product product in this.products)
        {
            label += $"{product.Name} (id: {product.ProductId})\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        string label = $"{this.customer.Name}\n{this.customer.Address.ToString()}";
        return label;
    }
}