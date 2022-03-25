using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_7_New.Sort
{
    class Sort
    {
        public static void SortByPrice()
        {
            int index = 0;
            var SortedByPrice = from i in MainWindow.MainForm.books
                                orderby i.Price
                                select i;
            foreach (Book_Model.Book book in SortedByPrice)
            {
                MainWindow.MainForm.books[index] = book;
                index++;
            }
            MainWindow.MainForm.ShowLibrary();
        }

        public static void SortByCount()
        {
            int index = 0;
            var SortedByPrice = from i in MainWindow.MainForm.books
                                orderby i.Count
                                select i;
            foreach (Book_Model.Book book in SortedByPrice)
            {
                MainWindow.MainForm.books[index] = book;
                index++;
            }
            MainWindow.MainForm.ShowLibrary();
        }
    }
}
