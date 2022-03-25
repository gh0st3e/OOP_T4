using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;

namespace Lab6_7_New.Patterns
{
    class ApplicationsViewModel 
    {
        private RelayCommand addBook;
        public RelayCommand AddBook
        {
            get
            {
                return addBook ?? (addBook = new RelayCommand(obj =>
                {
                    CreateBook.CreateBook create = new CreateBook.CreateBook(MainWindow.MainForm.languagePath);
                    create.Show();
                }));
            }
        }

        private RelayCommand sortByPrice;
        public RelayCommand SortByPrice
        {
            get
            {
                return sortByPrice ?? (sortByPrice = new RelayCommand(obj =>
                {
                    Sort.Sort.SortByPrice();
                }));
            }
        }

        private RelayCommand sortByCount;
        public RelayCommand SortByCount
        {
            get
            {
                return sortByCount ?? (sortByCount = new RelayCommand(obj =>
                {
                    Sort.Sort.SortByCount();
                }));
            }
        }

        private RelayCommand saveInXML;
        public RelayCommand SaveInXML
        {
            get
            {
                return saveInXML ?? (saveInXML = new RelayCommand(obj =>
                {
                    MainWindow.MainForm.SaveInXml();
                }));
            }
        }

        private RelayCommand loadFromXML;
        public RelayCommand LoadFromXML
        {
            get
            {
                return loadFromXML ?? (loadFromXML = new RelayCommand(obj =>
                {
                    MainWindow.MainForm.LoadFromXml();
                }));
            }
        }

        private RelayCommand search;
        public RelayCommand Search
        {
            get
            {
                return search ?? (search = new RelayCommand(obj =>
                {
                    MainWindow.MainForm.Seacrh();
                }));
            }
        }

        private RelayCommand changeLanguageToRu;
        public RelayCommand ChangeLanguageToRu
        {
            get
            {
                return changeLanguageToRu ?? (changeLanguageToRu = new RelayCommand(obj =>
                {
                    MainWindow.MainForm.ChangeLanguageToRu();
                }));
            }
        }

        private RelayCommand changeLanguageToEn;
        public RelayCommand ChangeLanguageToEn
        {
            get
            {
                return changeLanguageToEn ?? (changeLanguageToEn = new RelayCommand(obj =>
                {
                    MainWindow.MainForm.ChangeLanguageToEn();
                }));
            }
        }

        private RelayCommand chooseByPrice;
        public RelayCommand ChooseByPrice
        {
            get
            {
                return chooseByPrice ?? (chooseByPrice = new RelayCommand(obj =>
                {
                    MainWindow.MainForm.ChooseByPrice();
                }));
            }
        }

        private RelayCommand chooseByType;
        public RelayCommand ChooseByType
        {
            get
            {
                return chooseByType ?? (chooseByType = new RelayCommand(obj =>
                {
                    MainWindow.MainForm.ChooseByType();
                }));
            }
        }
    }
}
