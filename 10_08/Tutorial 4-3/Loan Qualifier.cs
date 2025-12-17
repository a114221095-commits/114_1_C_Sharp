using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        private decimal total;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //decimal total;
            total = total + 5;
            label3.Text = total.ToString();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //decimal total;
            total = total + 10;
            label3.Text = total.ToString();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //decimal total;
            total = total + 25;
            label3.Text = total.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //decimal total;
            total = total + 50;
            label3.Text = total.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
