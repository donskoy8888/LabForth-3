public class User
{
    private string username;
    private string password;
    private List<Order> purchaseHistory;

    public string Username
    {
        get { return username; }
        set { username = value; }
    }
    public string Password
    {
        get { return password; }
        set { password = value; }
    }
    public List<Order> PurchaseHistory
    {
        get { return purchaseHistory; }
        set { purchaseHistory = value; }
    }
}