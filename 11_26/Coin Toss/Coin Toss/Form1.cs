using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Coin_Toss
{
    public partial class Form1 : Form
    {
        private Random random = new Random();           // 單一 Random 實例
        private int headsCount = 0;
        private int tailsCount = 0;
        private List<string> history = new List<string>();

        public Form1()
        {
            InitializeComponent();
            UpdateCounts();
            UpdateHistoryListBox();
        }

        private void tossButton_Click(object sender, EventArgs e)
        {
            int sideUP = random.Next(2); // 產生 0 或 1

            if (sideUP == 0)
            {
                // Display Heads
                headsPictureBox.Visible = true;
                tailsPictureBox.Visible = false;

                headsCount++;
                history.Add($"Heads - {DateTime.Now:T}");
            }
            else
            {
                // Display Tails
                headsPictureBox.Visible = false;
                tailsPictureBox.Visible = true;

                tailsCount++;
                history.Add($"Tails - {DateTime.Now:T}");
            }

            UpdateCounts();
            UpdateHistoryListBox();
        }

        private void UpdateCounts()
        {
            headsLabel.Text = $"Heads: {headsCount}";
            tailsLabel.Text = $"Tails: {tailsCount}";
        }

        private void UpdateHistoryListBox()
        {
            // 顯示最新的紀錄在最上方（反向迭代）
            historyListBox.BeginUpdate();
            historyListBox.Items.Clear();
            for (int i = history.Count - 1; i >= 0; i--)
            {
                historyListBox.Items.Add(history[i]);
            }
            historyListBox.EndUpdate();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
