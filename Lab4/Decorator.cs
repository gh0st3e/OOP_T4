using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    class ComputerDecorator : Computer
    {

        public ComputerDecorator(Proc p, Video v, IOZUType o) : base(p, v, o)
        {

        }


        public override string ToString()
        {

            return "Компьютер с процессором " + Proc.ToString() + " и видеокартой GEForce: " + Video.ToString() + " и типом оперативной памяти: " + TypeOZU.OZU();
        }
    }
    class GameComputer : ComputerDecorator
    {
        public GameComputer(Proc p, Video v, IOZUType o) : base(p, v, o)
        {

        }
        public override string ToString()
        {

            return "Игровой Компьютер с процессором " + Proc.ToString() + " и видеокартой GEForce: " + Video.ToString() + " и типом оперативной памяти: " + TypeOZU.OZU() + " и подсветкой";
        }
    }
}
