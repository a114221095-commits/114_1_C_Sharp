using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    // 定義主視窗 Form1，繼承自 Form 類別
    public partial class Form1 : Form
    {
        // 建構函式，初始化元件
        public Form1()
        {
            InitializeComponent(); // 初始化表單元件
        }

        // 按下 button2 時執行，關閉視窗
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); // 關閉目前視窗
        }

        // 按下 button1 時執行，計算折扣後價格
        private void button1_Click(object sender, EventArgs e)
        {
            decimal originalPrice;      // 原價
            decimal discountPercent;    // 折扣百分比
            decimal salePrice;          // 折扣後價格

            // 取得原價輸入值並轉為 decimal
            originalPrice = decimal.Parse(textBox1.Text);

            // 取得折扣百分比輸入值並轉為 decimal
            discountPercent = decimal.Parse(textBox2.Text);

            // 計算折扣後價格
            salePrice = originalPrice - (originalPrice * discountPercent / 100);
            // 將 label6 = salePrice.ToString(); 改為 label6.Text = salePrice.ToString();
            label6.Text = salePrice.ToString("C");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
