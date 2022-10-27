namespace Front_To_Back.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        //public Category? Categor { get; set; }
        public int CategoryID { get; set; }


        public override string ToString()
        {
            return $"{Id} {Name} {Image} {Price}";
        }
    }
}
