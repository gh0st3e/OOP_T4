using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_WPF.Insert
{
    public class NewBook
    {
        public int ID { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
       
        public int Price { get; set; }
        public int Count { get; set; }
        public int Sold { get; set; }

        public NewBook(int id, string image, string name, string author, int price, int count, int sold)
        {
            ID = id;
            Image = image;
            Name = name;
            Author = author;
            Price = price;
            Count = count;
            
            Sold = sold;
        }
    }
}
