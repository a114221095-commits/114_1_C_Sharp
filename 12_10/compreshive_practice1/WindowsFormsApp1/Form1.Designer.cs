namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelGivenName;
        private System.Windows.Forms.Label labelQuiz1;
        private System.Windows.Forms.Label labelQuiz2;
        private System.Windows.Forms.Label labelQuiz3;

        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxGivenName;
        private System.Windows.Forms.TextBox textBoxQuiz1;
        private System.Windows.Forms.TextBox textBoxQuiz2;
        private System.Windows.Forms.TextBox textBoxQuiz3;

        private System.Windows.Forms.Button buttonShowMax;
        private System.Windows.Forms.Button buttonExit;

        private System.Windows.Forms.Label labelResult;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelGivenName = new System.Windows.Forms.Label();
            this.labelQuiz1 = new System.Windows.Forms.Label();
            this.labelQuiz2 = new System.Windows.Forms.Label();
            this.labelQuiz3 = new System.Windows.Forms.Label();
            this.textBoxGivenName = new System.Windows.Forms.TextBox();
            this.textBoxQuiz1 = new System.Windows.Forms.TextBox();
            this.textBoxQuiz2 = new System.Windows.Forms.TextBox();
            this.textBoxQuiz3 = new System.Windows.Forms.TextBox();

            this.buttonShowMax = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();

            this.labelResult = new System.Windows.Forms.Label();

            this.SuspendLayout();
            // 
            // Common font
            // 
            var commonFont = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            // 基本位置參數
            int labelX = 30;
            int textX = 140;
            int startY = 20;
            int gapY = 60;
            System.Drawing.Size textSize = new System.Drawing.Size(220, 46);

            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = commonFont;
            this.labelSurname.Location = new System.Drawing.Point(labelX, startY + 0 * gapY);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(40, 36);
            this.labelSurname.TabIndex = 0;
            this.labelSurname.Text = "姓";
            // 
            // labelGivenName
            // 
            this.labelGivenName.AutoSize = true;
            this.labelGivenName.Font = commonFont;
            this.labelGivenName.Location = new System.Drawing.Point(labelX, startY + 1 * gapY);
            this.labelGivenName.Name = "labelGivenName";
            this.labelGivenName.Size = new System.Drawing.Size(40, 36);
            this.labelGivenName.TabIndex = 2;
            this.labelGivenName.Text = "名";
            // 
            // textBoxGivenName
            // 
            this.textBoxGivenName = new System.Windows.Forms.TextBox();
            this.textBoxGivenName.Location = new System.Drawing.Point(textX, startY + 1 * gapY - 4);
            this.textBoxGivenName.Name = "textBoxGivenName";
            this.textBoxGivenName.Size = textSize;
            this.textBoxGivenName.Size = textSize;
                this.textBoxGivenName.TabIndex = 3;
            // 
            // labelQuiz1
            // 
            this.labelQuiz1.AutoSize = true;
            this.labelQuiz1.Font = commonFont;
            this.labelQuiz1.Location = new System.Drawing.Point(labelX, startY + 2 * gapY);
            this.labelQuiz1.Name = "labelQuiz1";
            this.labelQuiz1.Size = new System.Drawing.Size(88, 36);
            this.labelQuiz1.TabIndex = 4;
            this.labelQuiz1.Text = "小考1";
            // 
            // textBoxQuiz1
            // 
            this.textBoxQuiz1.Font = commonFont;
            this.textBoxQuiz1.Location = new System.Drawing.Point(textX, startY + 2 * gapY - 4);
            this.textBoxQuiz1.Name = "textBoxQuiz1";
            this.textBoxQuiz1.Size = textSize;
            this.textBoxQuiz1.TabIndex = 5;
            // 
            // labelQuiz2
            // 
            this.labelQuiz2.AutoSize = true;
            this.labelQuiz2.Font = commonFont;
            this.labelQuiz2.Location = new System.Drawing.Point(labelX, startY + 3 * gapY);
            this.labelQuiz2.Name = "labelQuiz2";
            this.labelQuiz2.Size = new System.Drawing.Size(88, 36);
            this.labelQuiz2.TabIndex = 6;
            this.labelQuiz2.Text = "小考2";
            // 
            // textBoxQuiz2
            // 
            this.textBoxQuiz2.Font = commonFont;
            this.textBoxQuiz2.Location = new System.Drawing.Point(textX, startY + 3 * gapY - 4);
            this.textBoxQuiz2.Name = "textBoxQuiz2";
            this.textBoxQuiz2.Size = textSize;
            this.textBoxQuiz2.TabIndex = 7;
            // 
            // labelQuiz3
            // 
            this.labelQuiz3.AutoSize = true;
            this.labelQuiz3.Font = commonFont;
            this.labelQuiz3.Location = new System.Drawing.Point(labelX, startY + 4 * gapY);
            this.labelQuiz3.Name = "labelQuiz3";
            this.labelQuiz3.Size = new System.Drawing.Size(88, 36);
            this.labelQuiz3.TabIndex = 8;
            this.labelQuiz3.Text = "小考3";
            // 
            // textBoxQuiz3
            // 
            this.textBoxQuiz3.Font = commonFont;
            this.textBoxQuiz3.Location = new System.Drawing.Point(textX, startY + 4 * gapY - 4);
            this.textBoxQuiz3.Name = "textBoxQuiz3";
            this.textBoxQuiz3.Size = textSize;
            this.textBoxQuiz3.TabIndex = 9;
            // 
            // buttonShowMax
            // 
            this.buttonShowMax.Font = commonFont;
            this.buttonShowMax.Location = new System.Drawing.Point(textX + textSize.Width + 30, startY + 2 * gapY - 6);
            this.buttonShowMax.Name = "buttonShowMax";
            this.buttonShowMax.Size = new System.Drawing.Size(260, 56);
            this.buttonShowMax.TabIndex = 10;
            this.buttonShowMax.Text = "顯示最高分";
            this.buttonShowMax.UseVisualStyleBackColor = true;
            this.buttonShowMax.Click += new System.EventHandler(this.buttonShowMax_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = commonFont;
            this.buttonExit.Location = new System.Drawing.Point(textX + textSize.Width + 30, startY + 3 * gapY - 6);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(260, 56);
            this.buttonExit.TabIndex = 11;
            this.buttonExit.Text = "離開";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelResult
            // 
            this.labelResult.Font = commonFont;
            this.labelResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelResult.Location = new System.Drawing.Point(labelX, startY + 5 * gapY);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(600, 70);
            this.labelResult.TabIndex = 12;
            this.labelResult.Text = "";
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxSurname.Location = new System.Drawing.Point(textX, startY + 0 * gapY - 4);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = textSize;
            this.textBoxSurname.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonShowMax);

            this.Controls.Add(this.textBoxQuiz3);
            this.Controls.Add(this.labelQuiz3);

            this.Controls.Add(this.textBoxQuiz2);
            this.Controls.Add(this.labelQuiz2);

            this.Controls.Add(this.textBoxQuiz1);
            this.Controls.Add(this.labelQuiz1);

            this.Controls.Add(this.textBoxGivenName);
            this.Controls.Add(this.labelGivenName);

            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.labelSurname);

            this.Font = commonFont;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}