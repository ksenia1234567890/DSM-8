using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace лр8
{
    public partial class Form1 : Form
    {

        public List<Dog> they = new List<Dog>();

        public Form1()
        {
            InitializeComponent();
        }

        // Добавить собаку

        private void button1_Click(object sender, EventArgs e)
        {
            Dog he = new Dog();
            he.Breed = textBox1.Text;
            he.Name = textBox5.Text;
           int ch1= int.Parse(textBox2.Text);
            he.Withers = ch1;
            int ch2 = int.Parse(textBox3.Text);
            he.Age = ch2;
            if(ch2==2 && ch1>=55)
            {
                they.Add(he);
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Введите породу";
            textBox5.Text = "Введите имя";
            textBox2.Text = "Введите высоту холки";
            textBox3.Text = "Введите возраст";
            textBox4.Text = "Здесь отобразится список 2-летних собак с высотой холки не менее 55 см. Нажмите на кнопку";
        }

        // Список собак

        private void button2_Click(object sender, EventArgs e)
        {
            string all = "";
            for(int i=0; i<they.Count; i++)
            {
                all += they[i].Name + ", ";
            }
            textBox4.Text = "Имена собак, которые подошли под описание: " + all;
        }
    }
}
