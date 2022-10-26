namespace Front_To_Back.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string Image { get; set; }
        public string Price { get; set; }

        public override string ToString()
        {
            return $"{Id} {Name} {Image} {Price}";
        }
        public Categories? Categories { get; set; }
    }
}
