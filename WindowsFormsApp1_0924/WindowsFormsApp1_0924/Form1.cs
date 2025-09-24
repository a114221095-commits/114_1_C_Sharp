using System;
using System.Windows.Forms;

namespace WindowsFormsApp1_0924
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += Button1_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 預設選取自強號
            radioButton1.Checked = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // 無需實作
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // 取得公里數
            if (!double.TryParse(textBox1.Text, out double km) || km <= 0)
            {
                MessageBox.Show("請輸入正確的公里數");
                return;
            }

            double rate = 0;

            // 判斷車種
            if (radioButton1.Checked)
            {
                rate = 2.27; // 自強號
            }
            else if (radioButton2.Checked)
            {
                rate = 1.75; // 莒光號
            }
            else if (radioButton3.Checked)
            {
                rate = 1.46; // 復興號
            }
            else
            {
                MessageBox.Show("請選擇車種");
                return;
            }

            double price = km * rate;

            // 優待票打5折
            if (checkBox1.Checked)
            {
                price *= 0.5;
            }

            // 去回票乘2再打9折
            if (checkBox2.Checked)
            {
                price = price * 2 * 0.9;
            }

            // 無條件進位
            price = Math.Ceiling(price);

            MessageBox.Show($"票價為：{price:0} 元");
        }
    }
}
