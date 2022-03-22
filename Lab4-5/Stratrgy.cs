using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    interface IOZUType
    {
        string OZU();
    }
    
    class DDR4OZU : IOZUType
    {
        public string OZU()
        {
            return "DDR4";
        }
    }

    class DDR3OZU : IOZUType
    {
        public string OZU()
        {
            return "DDR3";
        }
    }
    
}
