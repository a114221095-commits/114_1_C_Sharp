using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int A, B, T;
            A = int.Parse(textBox1.Text);
            B = int.Parse(textBox2.Text);
            T = A;
            A= B;
            B= T;
            textBox1.Text = A.ToString();
            textBox2.Text = B.ToString();
        }
    }
}
