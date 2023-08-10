namespace OnlineShoppingCart.Models
{
    public class EmailSubscriber:SharedModel
    {
        public string Email { get; set; }

        public string IsSubscribed { get; set; }    
    }
}
