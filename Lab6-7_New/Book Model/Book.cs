using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_7_New.Book_Model
{
    [Serializable]
    public class Book
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
        public string Type { get; set; }
        public int Rate { get; set; }
        public string Sale { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public Book(string name,string author,int price,int count,string type,string description)
        {
            
            Name = name;
            Author = author;
            Price = price;
            Count = count;
            Type = type;
            Description = description;
        }
        public Book() { }
    }
}
