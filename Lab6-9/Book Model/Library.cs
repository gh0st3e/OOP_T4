using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_7_New.Book_Model
{
    [Serializable]
    public class Library
    {
        public List<Book_Model.Book> Books { get; set; }
        public Library()
        {
            Books = new List<Book_Model.Book>();
        }
    }
}
