using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Proc> Processors = new List<Proc>();
        List<Video> Videos = new List<Video>();

        List<Computer> Computers = new List<Computer>();

        private void AF_Pattern_Click(object sender, EventArgs e)
        {

            Proc AMD = new Proc("AMD",new OldLowProc());
            AMD.Generation();
            AMD.Power();

            MessageBox.Show(AMD.ToString());

            Processors.Add(AMD);
            
            
        }

        private void AF2_Click(object sender, EventArgs e)
        {
            Proc Intel = new Proc("Intel", new ModernHighProcessor());
            Intel.Generation();
            Intel.Power();

            MessageBox.Show(Intel.ToString());

            Processors.Add(Intel);
            
        }

        private void Builder1_Click(object sender, EventArgs e)
        {
            // содаем объект производителя
            VideoCreator videoCreator = new VideoCreator();
            // создаем билдер для мощной видеокарты
            VideoBuilder builder = new HighVideo();
            // создаем
            Video HighVideo = videoCreator.Create(builder);
            MessageBox.Show(HighVideo.ToString());

            Videos.Add(HighVideo);
        }

        private void Builder2_Click(object sender, EventArgs e)
        {
            // содаем объект производителя
            VideoCreator videoCreator = new VideoCreator();
            // создаем билдер для слабой видеокарты
            VideoBuilder builder = new LowVideo();
            // создаем
            Video LowVideo = videoCreator.Create(builder);
            MessageBox.Show(LowVideo.ToString());

            Videos.Add(LowVideo);
        }

        private void Singlton_Click(object sender, EventArgs e)
        {
            SingletonForm form1_info = SingletonForm.getInstance(this.BackColor, this.Font, this.Size);
            MessageBox.Show(form1_info.ToString(), "Информация об форме");

        }

        private void AddNewItem_Click(object sender, EventArgs e)
        {
            Proc AMD = new Proc("AMD", new OldLowProc());
            VideoCreator videoCreator = new VideoCreator();
            // создаем билдер для мощной видеокарты
            VideoBuilder builder = new HighVideo();
            // создаем
            Video HighVideo = videoCreator.Create(builder);

            Computer computer = new Computer(AMD,HighVideo, new DDR3OZU());
            Computers.Add(computer);
            FieldForProc.Text += computer.ToString() + Environment.NewLine + Environment.NewLine;
            
            
            //computer = new ComputerDecorator(computer.Proc, computer.Video, computer.TypeOZU);
            computer.TypeOZU = new DDR4OZU();
            //Computers.Add(computer);
            //FieldForProc.Text += computer.ToString() + Environment.NewLine + Environment.NewLine;

            computer = new GameComputer(computer.Proc, computer.Video, computer.TypeOZU);
            Computers.Add(computer);
            FieldForProc.Text += computer.ToString() + Environment.NewLine + Environment.NewLine;
        }

        private void Clone_Click(object sender, EventArgs e)
        {
            try
            {
                Computer computer = Computers.Last<Computer>();
                computer.Clone();
                Computers.Add(computer);
                FieldForProc.Text += computer.ToString() + Environment.NewLine;
            }
            catch
            {
                MessageBox.Show("Не существует объекта для клонирования");
            }
        }

        private void CreateVidFromBuilder_Click(object sender, EventArgs e)
        {
            try
            {
                // содаем объект производителя
                VideoCreator videoCreator = new VideoCreator();
                // создаем билдер для мощной видеокарты
                VideoBuilder builder = new CustomVideo(int.Parse(VidMem.Text), DirectX.Text);
                // создаем
                Video CustomVideo = videoCreator.Create(builder);
                MessageBox.Show(CustomVideo.ToString());

                Videos.Add(CustomVideo);
            }
            catch
            {
                MessageBox.Show("Введите память в int");
            }
        }
    }
}
