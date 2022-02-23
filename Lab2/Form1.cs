using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Text.Json;
using System.ComponentModel.DataAnnotations;

namespace Lab2
{
    
    public partial class Form1 : Form
    {
        int actionBack = 0;
        int actionForward = 0;
        public ITLab ITLab;
        public Form1()
        {
            InitializeComponent();
            Computer_Type.SelectedItem = "Ноутбук";
            Type_OZU.SelectedItem = "DDR4";
            TypeHD.SelectedItem = "HDD";
            ProcCount.SelectedItem = "1";
            MemoryCount.SelectedItem = "1 ГБ";
            DirectX.SelectedItem = "v. 9";
            ITLab = new ITLab();

        }

        private void Add_Click(object sender, EventArgs e) // Добавить
        {
            ComputerValidation computerValidation = new ComputerValidation();
            if (Processor.Text.Equals(""))
            {
                MessageBox.Show("Введите название процессора");
            }
            
            try
            {
                Random rnd = new Random();
                Computer computer = new Computer
                {
                    
                    ComputerType = Computer_Type.Text,

                    Proc = new Proc
                    {

                        ProcName = Processor.Text,
                        ProcP = ProcCreator.Text,
                        ProcCount = int.Parse(ProcCount.Text)
                    },
                    Video = new Video
                    {
                        VideoName = Video_Name.Text,
                        VideoMemory = MemoryCount.Text,
                        DirectX = DirectX.Text
                    },
                    SizeOZU = int.Parse(SizeOZU.Text),
                    TypeOZU = Type_OZU.Text,
                    SizeHD = int.Parse(SizeHD.Text),
                    TypeHD = TypeHD.Text,
                    Date = Date.Value,
                    Price = rnd.Next(2300, 10000)
                    
                };
                //computerValidation.IsValid(computer);
                //ComputerValidation.Validate(computer);
                
                if(ComputerValidation.Validate(computer)==true)
                {
                    dataGridView1.Rows.Add(computer.ComputerType, computer.Proc, computer.Video, computer.SizeOZU, computer.TypeOZU, computer.SizeHD, computer.TypeHD, computer.Date);
                    ITLab.Computers.Add(computer);
                    Status.Text = Date.Value.ToString() + " кол-во созданных объектов: " + ITLab.Computers.Count;
                    statusStrip1.Items.Add(Date.Value.ToString() + " кол-во созданных объектов: " + ITLab.Computers.Count);
                }
                
            }
            catch
            {
                MessageBox.Show("Заполните все данные корректно");
            }

            
            
        }

        private void Save_Click(object sender, EventArgs e)
        {
            Status.Text = Date.Value.ToString() + " кол-во созданных объектов: " + ITLab.Computers.Count;
            statusStrip1.Items.Add(Date.Value.ToString() + " кол-во созданных объектов: " + ITLab.Computers.Count);
            if (ITLab.Computers.Count==0)
            {
                MessageBox.Show("Нельзя сохранять ничего :((((");
            }
            else
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ITLab));
                using (FileStream stream = new FileStream("Computers.xml", FileMode.OpenOrCreate))
                {
                    serializer.Serialize(stream, ITLab);
                }
            }
            
        }

        private void Open_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            XmlSerializer serializer = new XmlSerializer(typeof(ITLab));
            using (FileStream stream = new FileStream("Computers.xml", FileMode.Open))
            {
                ITLab = serializer.Deserialize(stream) as ITLab;
            }
            foreach (Computer computer in ITLab.Computers)
            {
                
                dataGridView1.Rows.Add(computer.ComputerType, computer.Proc, computer.Video, computer.SizeOZU, computer.TypeOZU, computer.SizeHD, computer.TypeHD, computer.Date);
               
            }
            Status.Text = Date.Value.ToString() + " кол-во созданных объектов: " + ITLab.Computers.Count;
            
            statusStrip1.Items.Add(Date.Value.ToString() + " кол-во созданных объектов: " + ITLab.Computers.Count);
            actionBack = 2;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void размерОЗУToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear(); 
            IEnumerable<Computer> ordered = ITLab.Computers.OrderBy(p => p.SizeOZU);
            foreach (Computer computer in ordered)
            {
                dataGridView1.Rows.Add(computer.ComputerType, computer.Proc, computer.Video, computer.SizeOZU, computer.TypeOZU, computer.SizeHD, computer.TypeHD, computer.Date);
            }
        }

        private void размерДискаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            IEnumerable<Computer> ordered = ITLab.Computers.OrderBy(p => p.SizeHD);
            foreach (Computer computer in ordered)
            {
                dataGridView1.Rows.Add(computer.ComputerType, computer.Proc, computer.Video, computer.SizeOZU, computer.TypeOZU, computer.SizeHD, computer.TypeHD, computer.Date);
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Здесь был Леонов Денис Игоревич. Вообще мне нужно учить Go, но предстоящий курсач не дает мне этого делать(");
        }

        private void поискToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ITLab));
            using (FileStream stream = new FileStream("ComputersforSearch.xml", FileMode.OpenOrCreate))
            {
                serializer.Serialize(stream, ITLab);
            }
            Search search = new Search();
            search.ShowDialog(this);
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            if (actionBack == 1)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.Rows.Count-2);
                actionBack = 0;
            }
            if(actionBack==2)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.Rows.Count-2);
                dataGridView1.Rows.RemoveAt(dataGridView1.Rows.Count-2);
                actionBack = 0;
            }
        }
    }
    public class ComputerValidation : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            Computer computer = value as Computer;
            if (computer.SizeHD%2==1)
            {
                ErrorMessage = "Такой памяти диска быть не может";
                return false;
            }
            else if (computer.SizeOZU % 2 == 1)
            {
                ErrorMessage = "Такой памяти ОЗУ быть не может";
                return false;
            }
            return true;
        }

        public static bool Validate(Computer computer)
        {
            var results = new List<ValidationResult>();
            var context = new ValidationContext(computer);
            if(!Validator.TryValidateObject(computer,context,results,true))
            {
                foreach(var error in results)
                {
                    MessageBox.Show(error.ErrorMessage);
                }
                return false;
            }
            else
            {
                MessageBox.Show("Все хорошо");
                return true;
            }
        }
    }
    
}
