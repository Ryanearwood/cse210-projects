public class Order
{
    private string _customerName;
    private string _address;
    private List<string> _videoTitles;

    public string CustomerName { get => _customerName; set => _customerName = value; }
    public string Address { get => _address; set => _address = value; }
    public List<string> VideoTitles { get => _videoTitles; set => _videoTitles = value; }
}
