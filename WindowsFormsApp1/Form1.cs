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

        private void button1_Click(object sender, EventArgs e)
        {
            float A, B;
            float Total;
            float Average;
            A=int.Parse(textBox1.Text);
            B=int.Parse(textBox2.Text);
            Total = A + B;
            textBox3.Text=Total.ToString();
            Average = Total / 2;
            textBox4.Text=Average.ToString("f1");
            if(Average>=60)
            {
                textBox5.Text = "及格";
            }
            else
            {
                textBox5.Text = "不及格";
            }

        }
    }
}
