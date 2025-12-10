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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // 請將此方法加入到 Form1 類別中
        private void btnShowResult_Click(object sender, EventArgs e)
        {
            string surname = textBoxSurname.Text;
            string givenName = textBoxGivenName.Text;
            int quiz1, quiz2, quiz3;

            if (int.TryParse(textBoxQuiz1.Text, out quiz1) &&
                int.TryParse(textBoxQuiz2.Text, out quiz2) &&
                int.TryParse(textBoxQuiz3.Text, out quiz3))
            {
                showResult(surname, givenName, quiz1, quiz2, quiz3);
            }
            else
            {
                MessageBox.Show("成績一律輸入整數", "資料錯誤");
                clearTextBoxes();
            }
        }

        private void showResult(string surname, string givenName, int quiz1, int quiz2, int quiz3)
        {
            int highestScore;

            if (quiz1 >= quiz2 && quiz1 >= quiz3)
            {
                highestScore = quiz1;
            }
            else if (quiz2 >= quiz1 && quiz2 >= quiz3)
            {
                highestScore = quiz2;
            }
            else
            {
                highestScore = quiz3;
            }

            labelResult.Text = string.Format("{0}{1}的最高成績是 {2} 分", givenName, surname, highestScore);
        }

        private void clearTextBoxes()
        {
            // 清除所有輸入框
            textBoxSurname.Clear();
            textBoxGivenName.Clear();
            textBoxQuiz1.Clear();
            textBoxQuiz2.Clear();
            textBoxQuiz3.Clear();
        }

        // 請將此方法加入到 Form1 類別中
        private void buttonShowMax_Click(object sender, EventArgs e)
        {
            // 將 textBoxQuiz1/2/3 改為 textBoxQuiz1/2/3 (已與 Designer 名稱一致)
            int quiz1, quiz2, quiz3;
            if (int.TryParse(textBoxQuiz1.Text, out quiz1) &&
                int.TryParse(textBoxQuiz2.Text, out quiz2) &&
                int.TryParse(textBoxQuiz3.Text, out quiz3))
            {
                int max = Math.Max(quiz1, Math.Max(quiz2, quiz3));
                labelResult.Text = $"最高分：{max}";
            }
            else
            {
                labelResult.Text = "請輸入有效的分數";
            }
        }

        // 請將此方法加入到 Form1 類別中
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
