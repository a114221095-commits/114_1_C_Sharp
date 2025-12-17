using System;
using System.Drawing;
using System.Windows.Forms;

namespace CupsToOuncesConverter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            SetupUI();
        }

        private void SetupUI()
        {
            // 表單基本設定
            this.Text = "Cups to Fluid Ounces Converter";
            this.Size = new Size(400, 250);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            // 設置縮放（150% 比例）
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.Font = new Font("Segoe UI", 10.5F);

            CreateControls();
        }

        private void CreateControls()
        {
            // 標題標籤
            Label titleLabel = new Label
            {
                Text = "Cups to Fluid Ounces Converter",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = Color.DarkBlue,
                Location = new Point(20, 20),
                AutoSize = true
            };

            // Cups 標籤
            Label cupsPromptLabel = new Label
            {
                Text = "Cups:",
                Location = new Point(50, 70),
                AutoSize = true
            };

            // Cups 輸入文本框 - 修改名稱
            TextBox cupsTextBox = new TextBox
            {
                Name = "cupsTextBox",  // 改為 cupsTextBox
                Location = new Point(120, 67),
                Size = new Size(100, 25),
                TextAlign = HorizontalAlignment.Right
            };

            // Fluid Ounces 標籤
            Label ouncesPromptLabel = new Label
            {
                Text = "Fluid Ounces:",
                Location = new Point(20, 110),
                AutoSize = true
            };

            // 顯示盎司的標籤 - 修改名稱
            Label ouncesLabel = new Label
            {
                Name = "ouncesLabel",  // 改為 ouncesLabel
                Text = "0.00",
                Location = new Point(120, 107),
                Size = new Size(100, 25),
                BorderStyle = BorderStyle.Fixed3D,
                TextAlign = ContentAlignment.MiddleRight
            };

            // 單位標籤
            Label unitLabel = new Label
            {
                Text = "ounces",
                Location = new Point(225, 110),
                AutoSize = true
            };

            // 轉換按鈕
            Button convertButton = new Button
            {
                Name = "convertButton",
                Text = "Convert",
                Location = new Point(100, 160),
                Size = new Size(80, 35),
                BackColor = Color.SteelBlue,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10, FontStyle.Bold)
            };

            // 退出按鈕
            Button exitButton = new Button
            {
                Text = "Exit",
                Location = new Point(200, 160),
                Size = new Size(80, 35),
                BackColor = Color.LightGray,
                Font = new Font("Segoe UI", 10, FontStyle.Regular)
            };

            // 事件處理
            convertButton.Click += convertButton_Click;
            exitButton.Click += (s, e) => this.Close();
            cupsTextBox.KeyPress += CupsTextBox_KeyPress;

            // 將控制項加入表單
            Controls.AddRange(new Control[]
            {
                titleLabel,
                cupsPromptLabel,
                cupsTextBox,      // 使用修改後的名稱
                ouncesPromptLabel,
                ouncesLabel,      // 使用修改後的名稱
                unitLabel,
                convertButton,
                exitButton
            });
        }

        // 轉換按鈕點擊事件 - 已更新控制項名稱
        private void convertButton_Click(object sender, EventArgs e)
        {
            // 使用新的控制項名稱
            TextBox cupsTextBox = (TextBox)Controls.Find("cupsTextBox", true)[0];
            Label ouncesLabel = (Label)Controls.Find("ouncesLabel", true)[0];

            if (double.TryParse(cupsTextBox.Text, out double cups))
            {
                double ounces = cups * 8.0;
                ouncesLabel.Text = ounces.ToString("F2");  // 更新 ouncesLabel
            }
            else
            {
                MessageBox.Show("請輸入有效的數字作為杯數", "輸入錯誤",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                cupsTextBox.Focus();
                cupsTextBox.SelectAll();
            }
        }

        // 只允許數字和小數點輸入
        private void CupsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            // 允許數字、小數點、控制鍵
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // 只允許一個小數點
            if (e.KeyChar == '.' && textBox.Text.Contains("."))
            {
                e.Handled = true;
            }

            // 只允許一個負號，且只能在最前面
            if (e.KeyChar == '-' && (textBox.Text.Length > 0 || textBox.Text.Contains("-")))
            {
                e.Handled = true;
            }
        }
    }
}
