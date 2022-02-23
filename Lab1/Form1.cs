using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pol.SelectedItem = "Мужчина";
        }

      

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int.Parse(textBox2.Text);
            }
            catch
            {
                textBox2.Text = "";
            }
            
        }
        
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int.Parse(textBox3.Text);
            }
            catch
            {
                textBox3.Text = "";
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int.Parse(textBox4.Text);
            }
            catch
            {
                textBox4.Text = "";
            }
        }

  
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox2.Text=="" || textBox3.Text=="" || textBox4.Text=="" )
            {
                textBox1.Text = "Неверные данные";
            }
            else if(int.Parse(textBox2.Text)<1 || int.Parse(textBox2.Text) > 120)
            {
                MessageBox.Show("Не бывает таких людей");
            }
            else if(int.Parse(textBox3.Text) < 40 || int.Parse(textBox3.Text) > 250)
            {
                MessageBox.Show("Не бывает таких людей");
            }
            else if (int.Parse(textBox3.Text) < 2 || int.Parse(textBox3.Text) > 500)
            {
                MessageBox.Show("Не бывает таких людей");
            }
            else
            {
                double result = Math.Round(6.25 * double.Parse(textBox3.Text) + 10 * double.Parse(textBox4.Text) - double.Parse(textBox2.Text) * 5);
                double ind = Math.Round(double.Parse(textBox4.Text) / double.Parse(textBox3.Text) / double.Parse(textBox3.Text) * 10000);
                if (ind < 18.4) textBox7.Text = "Недобор веса";
                else if (ind > 18.5 && ind < 24.9) textBox7.Text = "Норма";
                else textBox7.Text = "Лишний вес";

                if (pol.SelectedItem.ToString() == "Мужчина")
                {
                    result += 5;
                    textBox1.Text = result.ToString();
                    textBox5.Text = (result-343).ToString();
                    textBox6.Text = (result + 417).ToString();
                }
                else if (pol.SelectedItem.ToString() == "Женщина")
                {
                    result -= 161;
                    textBox1.Text = result.ToString();
                    textBox5.Text = (result - 343).ToString();
                    textBox6.Text = (result + 417).ToString();
                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
