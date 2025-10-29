using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // 綁定事件（使用 Designer 中的控制項名稱）
            this.Load += Form1_Load;
            this.button1.Click += ButtonCheck_Click;
            // label3 Designer 有綁 Click 事件，保留對應方法以避免編譯錯誤
            this.label3.Click += label3_Click;

            // 套用視覺樣式
            ApplyVisualStyle();
        }

        private void ApplyVisualStyle()
        {
            // 將表單與控制項字型統一為 22F（保留現有字型 family）
            var font22 = new Font(this.Font.FontFamily, 22F, FontStyle.Regular);
            this.Font = font22;

            // 背景與間距
            this.BackColor = Color.FromArgb(245, 249, 252);
            this.Padding = new Padding(8);

            // Label（帳號/密碼）
            if (this.label1 != null) this.label1.Font = new Font(font22.FontFamily, 22F, FontStyle.Bold);
            if (this.label2 != null) this.label2.Font = new Font(font22.FontFamily, 22F, FontStyle.Bold);

            // TextBox（帳號/密碼）
            if (this.textBox1 != null)
            {
                this.textBox1.Font = font22;
                this.textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            }
            if (this.textBox2 != null)
            {
                this.textBox2.Font = font22;
                this.textBox2.UseSystemPasswordChar = true;
                this.textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            }

            // Button
            if (this.button1 != null)
            {
                this.button1.Font = font22;
                this.button1.BackColor = Color.FromArgb(0, 120, 215);
                this.button1.ForeColor = Color.White;
                this.button1.FlatStyle = FlatStyle.Flat;
                this.button1.FlatAppearance.BorderSize = 0;
                this.button1.Cursor = Cursors.Hand;
            }

            // 結果 Label (label3)
            if (this.label3 != null)
            {
                this.label3.Font = font22;
                this.label3.BorderStyle = BorderStyle.Fixed3D;
                this.label3.TextAlign = ContentAlignment.MiddleLeft;
                this.label3.BackColor = SystemColors.Window;
                this.label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                this.label3.Text = string.Empty;
            }

            // 設定 Enter 鍵觸發按鈕
            this.AcceptButton = this.button1;

            // 根據目前 ClientSize 調整欄位寬度（保險處理）
            if (this.ClientSize.Width > 0)
            {
                if (this.textBox1 != null) this.textBox1.Width = Math.Max(240, this.ClientSize.Width - 180);
                if (this.textBox2 != null) this.textBox2.Width = Math.Max(240, this.ClientSize.Width - 180);
                if (this.label3 != null) this.label3.Width = Math.Max(300, this.ClientSize.Width - 60);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 再次保證所有控制項字型為 22F（保險）
            var font22 = new Font(this.Font.FontFamily, 22F, FontStyle.Regular);
            foreach (Control c in this.Controls)
            {
                c.Font = font22;
            }

            // 初始化結果欄位
            if (this.label3 != null)
            {
                this.label3.Text = string.Empty;        
                this.label3.ForeColor = Color.Black;
            }
        }

        private void ButtonCheck_Click(object sender, EventArgs e)
        {
            var account = (this.textBox1 != null) ? this.textBox1.Text.Trim() : string.Empty;
            var password = (this.textBox2 != null) ? this.textBox2.Text : string.Empty;

            if (string.IsNullOrEmpty(account))
            {
                if (this.label3 != null)
                {
                    this.label3.ForeColor = Color.DarkOrange;
                    this.label3.Text = "請輸入帳號";
                }
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                if (this.label3 != null)
                {
                    this.label3.ForeColor = Color.DarkOrange;
                    this.label3.Text = "請輸入密碼";
                }
                return;
            }

            // 範例驗證（示範用途）
            if (account == "admin" && password == "password")
            {
                if (this.label3 != null)
                {
                    this.label3.ForeColor = Color.Green;
                    this.label3.Text = "登入成功";
                }
            }
            else
            {
                if (this.label3 != null)
                {
                    this.label3.ForeColor = Color.Red;
                    this.label3.Text = "帳號或密碼錯誤";
                }
            }
        }

        // Designer 在 label3 加了 Click 事件，實作空的 handler 避免編譯錯誤
        private void label3_Click(object sender, EventArgs e)
        {
            // 可留空或加入調試用途
        }
    }
}