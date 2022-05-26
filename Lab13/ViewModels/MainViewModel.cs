using Lab13_2.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13_2.ViewModels
{
    class MainViewModel : ViewModelBase
    {
        public ObservableCollection<CourseViewModel> CoursesList { get; set; }

        #region Constructor

        public MainViewModel(List<Course> courses)
        {
            CoursesList = new ObservableCollection<CourseViewModel>(courses.Select(b => new CourseViewModel(b)));
        }

        #endregion
    }
}
