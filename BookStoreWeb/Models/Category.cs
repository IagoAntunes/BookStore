namespace BookStoreWeb.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime CreatedDataTime { get; set; } = DateTime.Now;

    }
}
