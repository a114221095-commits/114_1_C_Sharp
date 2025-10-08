using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        // 建構函式，初始化表單元件
        public Form1()
        {
            InitializeComponent();
        }

        // label1 的點擊事件，目前未實作任何功能
        private void label1_Click(object sender, EventArgs e)
        {

        }

        // button2 的點擊事件，關閉表單
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // button1 的點擊事件，計算三個分數的平均值
        private void button1_Click(object sender, EventArgs e)
        {
            double test1, test2, test3;

            try
            {
                // 從 textBox1 取得分數並轉為 double
                test1 = double.Parse(textBox1.Text);
                // 從 textBox2 取得分數並轉為 double
                test2 = double.Parse(textBox2.Text);
                // 從 textBox3 取得分數並轉為 double
                test3 = double.Parse(textBox3.Text);
                // 計算三個分數的平均值
                double average = (test1 + test2 + test3) / 3.0;
                label5.Text = average.ToString("F2");

            }
            catch (Exception ex)
            {
                MessageBox.Show("例外發生", ex.Message);
            }
        }
        // button3 的點擊事件，清空三個輸入框
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            label5.Text = "";
        }
    }
}
