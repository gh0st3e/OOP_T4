using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    interface MemoryType
    {
        public string getMemory();
    }

    class DDR3 : MemoryType
    {
        public string getMemory()
        {
            return "DDR3";
        }
    }
    class DDR4 : MemoryType
    {
        public string getMemory()
        {
            return "DDR4";
        }
    }
    
}
