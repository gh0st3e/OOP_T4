using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13_2.Models
{
    public class Course
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Hours { get; set; }
        public string Teacher { get; set; }
        public int CountOfPeople { get; set; }

        public Course() { }

        public Course(int id,string name,int hours,string teacher,int countofpeople)
        {
            ID = id;
            Name = name;
            Hours = hours;
            Teacher = teacher;
            CountOfPeople = countofpeople;
        }
    }
}
