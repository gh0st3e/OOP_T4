using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    abstract class ProcFactory
    {
        public abstract Generation CreateGeneration();
        public abstract Power CreatePower();
    }
    //абстрактный класс - мощность
    abstract class Power
    {
        public abstract void Proc_Power();
    }
    // абстрактный класс поколения
    abstract class Generation
    {
        public abstract void Proc_Generation();
    }

    // класс низкая мощность
    class LowPower : Power
    {
        public override void Proc_Power()
        {
            Console.WriteLine("Low Power");
        }
        public override string ToString()
        {
            return "low power";
        }
    }
    // класс высокая мощность
    class HighPower : Power
    {
        public override void Proc_Power()
        {
            Console.WriteLine("High Power");
        }
        public override string ToString()
        {
            return "high power";
        }
    }
    // класс новое поколение
    class ModernGeneration : Generation
    {
        public override void Proc_Generation()
        {
            Console.WriteLine("Modern Generation");
        }
        public override string ToString()
        {
            return "modern generation";
        }
    }
    // класс старое поколение
    class OldGeneration : Generation
    {
        public override void Proc_Generation()
        {
            Console.WriteLine("Old Generation");
        }
        public override string ToString()
        {
            return "old generation";
        }
    }
    // класс абстрактной фабрики
    
    // Фабрика создания процессора старого поколения и низкой мощностью
    class OldLowProc : ProcFactory
    {
        public override Generation CreateGeneration()
        {
            return new OldGeneration();
        }

        public override Power CreatePower()
        {
            return new LowPower();
        }
    }
    // Фабрика создания процессора нового поколения и с высокой мощностью
    class ModernHighProcessor : ProcFactory
    {
        public override Generation CreateGeneration()
        {
            return new ModernGeneration();
        }

        public override Power CreatePower()
        {
            return new HighPower();
        }
    }
    // клиент - сам процессор
    class Proc
    {
        private Power power;
        private Generation generation;
        public string Name;
        public Proc(string name,ProcFactory factory)
        {
            power = factory.CreatePower();
            generation = factory.CreateGeneration();
            Name = name;
        }
        public void Generation()
        {
            generation.Proc_Generation();
        }
        public void Power()
        {
            power.Proc_Power();
            
            
        }
        public override string ToString()
        {
            return "Название: " + Name +  " Мощность: " + power.ToString() + " Поколение: " + generation.ToString();
        }
    }
}
