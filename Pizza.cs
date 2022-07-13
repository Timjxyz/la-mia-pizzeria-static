namespace la_mia_pizzeria_static
{
    public class Pizza
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Img { get; set; }
        public double Price { get; set; }
        public Pizza(string Name, string Img, string Description, double price)
        {
            this.Name = Name;
            this.Img = Img;
            this.Description = Description;
            this.Price = price;
        }
    }
}
