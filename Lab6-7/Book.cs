using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_7
{
   
    public class Book
    {
        public int ID { get; set; }
        
        public string Name { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
        public string Description { get; set; }

        

        public Book() { }
        public Book(string name, string author, int price, int count, string description)
        {
            ID = MainWindow.Form1.books.Count;
            
            Name = name;
            Author = author;
            Price = price;
            Count = count;
            Description = description;
        }
        
    }
}
