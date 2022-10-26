namespace Front_To_Back.Models
{
    public class Categories
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public Products? Products { get; set; }
        public override string ToString()
        {
            return $"{Id} {Name}";
        }
    }
}
