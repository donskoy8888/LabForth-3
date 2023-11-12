public class Shop : ISearchable
{
    private List<Product> products;
    private List<User> users;
    private List<Order> orders;

    public Shop()
    {
        products = new List<Product>();
        users = new List<User>();
        orders = new List<Order>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public void RegisterUser(User user)
    {
        users.Add(user);
    }

    public void PlaceOrder(User user, List<Product> selectedProducts, List<int> quantities)
    {
        if (selectedProducts.Count != quantities.Count)
        {
            Console.WriteLine("Error: Number of products and quantities do not match.");
            return;
        }

        Order newOrder = new Order
        {
            Products = selectedProducts,
            Quantities = quantities,
            TotalPrice = CalculateTotalPrice(selectedProducts, quantities),
            Status = "Processing"
        };

        user.PurchaseHistory.Add(newOrder);
        orders.Add(newOrder);

        UpdateProductQuantities(selectedProducts, quantities);

        Console.WriteLine("Order placed successfully!");
    }

    private double CalculateTotalPrice(List<Product> selectedProducts, List<int> quantities)
    {
        double totalPrice = 0;
        for (int i = 0; i < selectedProducts.Count; i++)
        {
            totalPrice += selectedProducts[i].Price * quantities[i];
        }
        return totalPrice;
    }

    private void UpdateProductQuantities(List<Product> selectedProducts, List<int> quantities)
    {
        for (int i = 0; i < selectedProducts.Count; i++)
        {
            int index = products.FindIndex(p => p.Name == selectedProducts[i].Name);
            if (index != -1)
            {
                products[index].AvailableQuantity -= quantities[i];
            }
        }
    }

    public List<Product> Search(string criteria)
    {
        return products.Where(p =>
            p.Name.Contains(criteria, StringComparison.OrdinalIgnoreCase) ||
            p.Category.Contains(criteria, StringComparison.OrdinalIgnoreCase) ||
            p.Description.Contains(criteria, StringComparison.OrdinalIgnoreCase))
            .ToList();
    }
}