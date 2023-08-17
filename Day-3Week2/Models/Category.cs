namespace Day_3Week2.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        // Other properties...
        public List<Product> Products { get; set; }
    }
}
