using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    
    public class Video
    {
        public string VideoName { get; set; }
        public string VideoMemory { get; set; }
        public string DirectX { get; set; }

        public override string ToString()
        {
            return "Видеокарта: " + VideoName + " Память: " + VideoMemory + " DirectX " + DirectX;
        }
    }
}
