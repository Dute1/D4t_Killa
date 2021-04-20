using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace classwork7
{
    public partial class Form1 : Form
    {

        private Graphics graphics;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label1_Click_1(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }


        private void button1_Click(object sender, EventArgs e)
        {
            if (graphics == null) graphics = this.CreateGraphics();
            else graphics.Clear(BackColor);
            drawCayleyTree(int.Parse(this.textBox1.Text), 400, 310, double.Parse(this.textBox2.Text), -Math.PI / 2);
            
        }

        void drawCayleyTree(int n ,double x0,double y0,double leng,double th)
        {
            if (n == 0) return;
            
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);
            drawLine(x0, y0, x1, y1,this.comboBox1.Text);

            drawCayleyTree(n - 1, x1, y1, double.Parse(textBox3.Text) * leng, th + double.Parse(this.textBox5.Text) * Math.PI / 180);
            drawCayleyTree(n - 1, x1, y1, double.Parse(textBox4.Text) * leng, th - double.Parse(this.textBox6.Text) * Math.PI / 180);
            
        }

        void drawLine(double x0,double y0, double x1, double y1,string penColor)
        {
            if(penColor == "黑")
                graphics.DrawLine(Pens.Black, (int)x0, (int)y0, (int)x1, (int)y1);
            else if(penColor == "红")
                graphics.DrawLine(Pens.Red, (int)x0, (int)y0, (int)x1, (int)y1);
            else
                graphics.DrawLine(Pens.Blue, (int)x0, (int)y0, (int)x1, (int)y1);
        }

    }
}
