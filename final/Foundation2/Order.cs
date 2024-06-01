public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public List<Product> Products { get => _products; set => _products = value; }
    public Customer Customer { get => _customer; set => _customer = value; }

    public decimal TotalCost()
    {
        decimal totalCost = _products.Sum(p => p.TotalCost());
        totalCost += _customer.LivesInUSA() ? 5 : 35;
        return totalCost;
    }

    public string PackingLabel()
    {
        return string.Join("\n", _products.Select(p => $"{p.Name} ({p.ProductId})"));
    }

    public string ShippingLabel()
    {
        return $"{_customer.Name}\n{_customer.Address}";
    }
}
