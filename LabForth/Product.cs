public class Product
{
    private string name;
    private double price;
    private string description;
    private string category;
    private double rating;
    private int availableQuantity;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public double Price
    {
        get { return price; }
        set { price = value; }
    }
    public string Description
    {
        get { return description; }
        set { description = value; }
    }
    public string Category
    {
        get { return category; }
        set { category = value; }
    }
    public double Rating
    {
        get { return rating; }
        set { rating = value; }
    }
    public int AvailableQuantity
    {
        get { return availableQuantity; }
        set { availableQuantity = value; }
    }
}