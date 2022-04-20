using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_7_New.Patterns
{
    public class Memento
    {
        public ObservableCollection<Book_Model.Book> BookList = new ObservableCollection<Book_Model.Book>();
        public Memento(ObservableCollection<Book_Model.Book> state)
        {
            if (state != null)
            {
                foreach (Book_Model.Book x in state)
                {
                    this.BookList.Add(x);
                }
            }
            else if (state == null)
                this.BookList.Clear();
        }
    }

    public class Caretaker
    {
        public Stack<Memento> History { get; private set; }
        public Caretaker()
        {
            History = new Stack<Memento>();
        }
    }

    public class BookCollections
    {
        public ObservableCollection<Book_Model.Book> BookList { get; set; }
        public void RestoreState(Memento memento)
        {
            BookList = memento.BookList;
        }
        public Memento SaveState()
        {
            return new Memento(BookList);
        }
    }
}
