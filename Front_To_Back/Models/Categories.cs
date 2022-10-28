namespace Front_To_Back.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public Product? Products { get; set; }
        public override string ToString()
        
        {
            return $"{Id} {Name}";
        }
    }
}
