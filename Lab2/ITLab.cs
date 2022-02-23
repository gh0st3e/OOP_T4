using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    [Serializable]
    public class ITLab
    {
        public List<Computer> Computers { get; set; }
       
        
        public Proc Proc { get; set; }
        
        public Video Video { get; set; }
        public ITLab()
        {
            Proc = new Proc();
            Video = new Video();
            Computers = new List<Computer>();
        }
    }
}
