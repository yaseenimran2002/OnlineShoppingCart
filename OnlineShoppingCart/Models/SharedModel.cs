namespace OnlineShoppingCart.Models
{
    public class SharedModel
    {
        public SharedModel()
        {
            id = Path.GetRandomFileName().Replace(".","");
        }
        public string id { get; set; }
        public DateTime DbEntryTime { get; set; }
        public DateTime LastModifiedTime { get; set; }
    }
}