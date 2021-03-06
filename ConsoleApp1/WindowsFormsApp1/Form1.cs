using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }



        private void button1_Click(object sender, EventArgs e)
        {
            string a, b, s;
            double num1, num2, num;
            a = textBox3.Text;
            b = textBox4.Text;
            num1 = double.Parse(a);
            num2 = double.Parse(b);
            s = comboBox2.Text;
            switch (s)
            {

                case "＋":
                    num = num1 + num2;
                    break;
                case "－":
                    num = num1 - num2;
                    break;
                case "×":
                    num = num1 * num2;
                    break;
                case "÷":
                    num = num1 / num2;
                    break;
                default:
                    Console.WriteLine("please input the right num！");
                    return;
            }
            string m = Convert.ToString(num);
            label5.Text = m;
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
