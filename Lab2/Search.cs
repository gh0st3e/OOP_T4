using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Xml.Serialization;
using System.IO;

namespace Lab2
{
    public partial class Search : Form
    {
        public ITLab ITLab;
        public Search()
        {
            
            InitializeComponent();
            dataGridView1.Show();
        }

        private void Find_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            Regex r1 = new Regex(Regular.Text);
            ITLab itlab = null;
            XmlSerializer serializer = new XmlSerializer(typeof(ITLab));
            using (FileStream stream = new FileStream("ComputersforSearch.xml", FileMode.Open))
            {
                itlab = serializer.Deserialize(stream) as ITLab;
            }

            foreach (Computer computer in itlab.Computers)
            {
                if (r1.IsMatch(computer.Proc.ProcName))
                {
                    dataGridView1.Rows.Add(computer.ComputerType, computer.Proc, computer.Video, computer.SizeOZU, computer.TypeOZU, computer.SizeHD, computer.TypeHD, computer.Date);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ITLab));
            using (FileStream stream = new FileStream("SearchResult.xml", FileMode.OpenOrCreate))
            {
                serializer.Serialize(stream, ITLab);
            }
        }

        private void Regular_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                dataGridView1.Hide();
            }
            else
            {
                dataGridView1.Show();
            }
        }
    }
}
