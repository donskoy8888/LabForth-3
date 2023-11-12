public class Order
{
    private List<Product> products;
    private List<int> quantities;
    private double totalPrice;
    private string status;

    public List<Product> Products
    {
        get { return products; }
        set { products = value; }
    }
    public List<int> Quantities
    {
        get { return quantities; }
        set { quantities = value; }
    }
    public double TotalPrice
    {
        get { return totalPrice; }
        set { totalPrice = value; }
    }
    public string Status
    {
        get { return status; }
        set { status = value; }
    }
}