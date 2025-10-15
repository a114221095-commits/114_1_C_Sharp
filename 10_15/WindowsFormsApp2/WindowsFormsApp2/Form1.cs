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
            const decimal basehour = 40m;
            const decimal overtime = 1.5m;
            decimal hourworked;
            decimal hourlypayrate;
            decimal grosspay;

            try 
            {
                hourworked = decimal.Parse(textBox1.Text);
                hourlypayrate = decimal.Parse(textBox2.Text);
            if (hourworked <= basehour)
            {
                grosspay = hourworked * hourlypayrate;
            }
            else
            {
                grosspay = (basehour * hourlypayrate) + ((hourworked - basehour) * hourlypayrate * overtime);
            }
                label4.Text = grosspay.ToString("C");
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values for hours worked and hourly pay rate.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);



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
    }
}
