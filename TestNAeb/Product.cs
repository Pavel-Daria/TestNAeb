using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNAeb
{
    public class Product
    {
        
        public Product()
        { }
          
        public int Id { get; set; }
        public string Articul { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string Point { get; set; }
        public int Discount { get; set; }
        public string Deliver { get; set; }
        public string Category { get; set; }
        public int nowDiscount { get; set; }
        public string Description { get; set; }
        public string Maker { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }

        public Product(string image, string name, string description, string maker, int price, int count)
        {
            Image = image;
            Name = name;
            Description = description;
            Maker = maker;
            Price = price;
            Count = count;
        }
    }
}
