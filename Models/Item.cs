namespace SProject.Models
{
    public class Item
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public double price { get; set; }

        public Item(int id, string name, string description, double price){
            this.id = id;
            this.name = name;
            this.description = description;
            this.price = price;
        }
    }
}