using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    public class Proc
    {

        public string ProcName { get; set; }

        public string ProcP { get; set; }
        public int ProcCount { get; set; }

        public override string ToString()
        {
            return "Процессор: " + ProcName + " Производитель: " + ProcP + " Кол-во ядер: " + ProcCount;
        }
    }
}
