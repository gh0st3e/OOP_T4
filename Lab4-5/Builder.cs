using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    abstract class VideoBuilder
    {
        
        public Video Video { get; private set; }
        public void CreateVideo()
        {
            Video = new Video();
        }
        public abstract void SetMemory();
        public abstract void SetExtraCooler();
        public abstract void SetDirectX();
    }

    class VideoCreator
    {
        public Video Create(VideoBuilder breadBuilder)
        {
            breadBuilder.CreateVideo();
            breadBuilder.SetMemory();
            breadBuilder.SetExtraCooler();
            breadBuilder.SetDirectX();
            return breadBuilder.Video;
        }
    }
    // строитель для мощной видеокарты
    class HighVideo : VideoBuilder
    {
        public override void SetMemory()
        {
            this.Video.memory = new VideoMemory { Memory = 4 };
        }

        public override void SetExtraCooler()
        {
            this.Video.secondCooler = new SecondCooler();
        }

        public override void SetDirectX()
        {
            this.Video.directX = new DirectX { Version="v.12"};
        }

        
    }
    // строитель для слабой видеокарты
    class LowVideo : VideoBuilder
    {
        public override void SetMemory()
        {
            this.Video.memory = new VideoMemory { Memory = 2 };
        }

        public override void SetExtraCooler()
        {
            //Нет второго куллера
        }

        public override void SetDirectX()
        {
            this.Video.directX = new DirectX { Version = "v.9" };
        }
    }

    class CustomVideo : VideoBuilder
    {
        public int V_Memory;
        public string V_Version;
        public CustomVideo(int memory,string version)
        {
            V_Memory = memory;
            V_Version = version;
        }

        public override void SetMemory()
        {
            this.Video.memory = new VideoMemory { Memory = V_Memory };
        }

        public override void SetExtraCooler()
        {
            //Нет второго куллера
        }

        public override void SetDirectX()
        {
            this.Video.directX = new DirectX { Version = V_Version };
        }
    }
}
