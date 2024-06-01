public class Product
{
    private string _name;
    private int _productId;
    private decimal _price;
    private int _quantity;

    public string Name { get => _name; set => _name = value; }
    public int ProductId { get => _productId; set => _productId = value; }
    public decimal Price { get => _price; set => _price = value; }
    public int Quantity { get => _quantity; set => _quantity = value; }

    public decimal TotalCost()
    {
        return _price * _quantity;
    }
}
