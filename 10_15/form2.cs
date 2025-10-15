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
            const decimal minimum_salary = 1200000;
            const int minimum_years = 2;
            decimal salary;
            int yearsonjob;
            try
            {
                salary = decimal.Parse(textBox1.Text);
                yearsonjob = int.Parse(textBox2.Text);

                if (salary < minimum_salary)
                {
                    label4.Text = "不符合資格:未達收入最低標準";
                }
                else if (yearsonjob < minimum_years)
                {
                    label4.Text = "不符合資格:年資未達收入標準";
                }
                else
                {
                    label4.Text = "符合資格";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label4.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
