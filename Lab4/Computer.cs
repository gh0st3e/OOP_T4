using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    //Protoype
    interface IFigure
    {
        IFigure Clone();
    }
    class Computer : IFigure
    {
        public Proc Proc;
        public Video Video;
        public IOZUType TypeOZU { get; set; }

        public Computer(Proc proc,Video video, IOZUType OZU)
        {
            Proc = proc;
            Video = video;
            TypeOZU = OZU;
        }
        

        public IFigure Clone()
        {
            return new Computer(this.Proc, this.Video, this.TypeOZU);
        }

        
        public string OZU()
        {
            TypeOZU.OZU();
            return TypeOZU.OZU();
        }

        public override string ToString()
        {
            return Proc.ToString() + " " + Video.ToString() + " " + TypeOZU.OZU();
        }
    }
}
