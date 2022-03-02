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

        public Computer BuildComputer()
        {
            string[] Types = new string[4] { "Ноутбук", "Стационарный компьютер", "Сервер", "Рабочая станция" };
            string[] TypesOZU = new string[2] { "DDR3", "DDR4" };
            string[] TypesHD = new string[2] { "SSD", "HDD" };
            int[] SizeOZU = new int[7] { 1, 2, 4, 8, 16, 32, 64 };
            int[] SizeHD = new int[4] { 128, 256, 512, 1024 };

            Computer BComputer = new Computer();
            BComputer.ComputerType = Types[new Random().Next(0, Types.Length)];
            BComputer.Proc = BuildProc();
            BComputer.Video = BuildVideo();
            BComputer.SizeOZU = SizeOZU[new Random().Next(0, SizeOZU.Length)];
            BComputer.TypeOZU = TypesOZU[new Random().Next(0, TypesOZU.Length)];
            BComputer.SizeHD = SizeHD[new Random().Next(0, SizeHD.Length)];
            BComputer.TypeHD = TypesHD[new Random().Next(0, TypesHD.Length)];
            BComputer.Date = DateTime.Now;
            BComputer.Price = 0;
            return BComputer;
        }
        public Proc BuildProc()
        {
            Proc proc = new Proc();
            proc.ProcName = "Pentium";
            proc.ProcCount = 2;
            proc.ProcP = "Pen";
            return proc;
        }
        public Video BuildVideo()
        {
            Video video = new Video();
            video.VideoName = "Radeon";
            video.VideoMemory = "2";
            video.DirectX = "v.11";
            return video;
        }

    }
}
