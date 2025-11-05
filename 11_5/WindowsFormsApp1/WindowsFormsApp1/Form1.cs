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

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "點餐內容";
            string drink = "";
            string sandwitch = "";
            if (radioButton8.Checked)
            {
                drink = "咖啡 ";
            }
            else if (radioButton9.Checked)
            {
                drink = "紅茶 ";
            }
            else if (radioButton10.Checked)
            {
                drink = "奶茶 ";
            }
            else if (radioButton11.Checked)
            {
                drink = "果汁 ";
            }
            else
            {
                drink = "";
            }
            if (radioButton1.Checked)
            {
                sandwitch = "果醬三明治";
            }
            else if(radioButton3.Checked)
                {
                sandwitch = "火腿三明治";

            }
            else if(radioButton4.Checked)
            {
                sandwitch = "鮪魚三明治";
            }
            else
            {
                sandwitch = "";
            }
            message = drink + sandwitch;
            MessageBox.Show(message);
        }
    }
}
