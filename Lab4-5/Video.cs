using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    class VideoMemory
    {
        // сколько памяти
        public int Memory { get; set; }
    }
    // второй куллер
    class SecondCooler
    { }
    // версия DirectX
    class DirectX
    {
        public string Version { get; set; }
    }

    class Video
    {
        
        // память
        public VideoMemory memory { get; set; }
        // второй куллер
        public SecondCooler secondCooler { get; set; }
        // версия DirectX
        public DirectX directX { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            
            if (memory != null)
                sb.Append("Видеопамять: "+memory.Memory + "\n");
            if (secondCooler != null)
                sb.Append(" Два куллера \n");
            if (directX != null)
                sb.Append(" Версия DirectX: " + directX.Version + " \n");
            return sb.ToString();
        }
    }
}
