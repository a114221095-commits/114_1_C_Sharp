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
            string message = "";
            if (checkBox1.Checked)
            {
                message += "夏威夷\n";
            }
            else if (checkBox2.Checked)
            {
                message += message + "綜合海鮮\n";
            }
            else if(checkBox4.Checked)
            {
                message +=message + "義士火腿\n";
            }
            if(message=="")
            {
                message = "請選擇一種餐點"; 
            } 
            MessageBox.Show(message,"你選擇的披薩口味是");
        }
    }
}
