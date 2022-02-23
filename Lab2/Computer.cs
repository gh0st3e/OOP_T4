using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Lab2
{
    [Serializable]
    [ComputerValidation]
    public class Computer
    {
        public string ComputerType { get; set; }
        public Proc Proc { get; set; }
        public Video Video { get; set; }
       [Required]
        public virtual int SizeOZU { get; set; }
        public string TypeOZU { get; set; }
        public int SizeHD { get; set; }
        public string TypeHD { get; set; }
        public DateTime Date { get; set; }
        public int Price { get; set; }
        

    }
}
