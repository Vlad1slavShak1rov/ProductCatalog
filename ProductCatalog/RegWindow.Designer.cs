namespace ProductCatalog
{
    partial class RegWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            PassBoxOne = new TextBox();
            PassBoxTwo = new TextBox();
            Enter = new Button();
            CheckPass = new CheckBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(91, 24);
            label1.Name = "label1";
            label1.Size = new Size(162, 32);
            label1.TabIndex = 0;
            label1.Text = "Регистрация";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(142, 130);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 1;
            label2.Text = "Логин";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(142, 199);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 2;
            label3.Text = "Пароль";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(100, 260);
            label4.Name = "label4";
            label4.Size = new Size(150, 20);
            label4.TabIndex = 3;
            label4.Text = "Повторение пароля";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(91, 153);
            textBox1.MaxLength = 15;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(162, 27);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += CheckBoxLog;
            // 
            // PassBoxOne
            // 
            PassBoxOne.Location = new Point(91, 222);
            PassBoxOne.Name = "PassBoxOne";
            PassBoxOne.Size = new Size(162, 27);
            PassBoxOne.TabIndex = 5;
            PassBoxOne.TextChanged += CheckPassBox;
            // 
            // PassBoxTwo
            // 
            PassBoxTwo.Location = new Point(91, 283);
            PassBoxTwo.Name = "PassBoxTwo";
            PassBoxTwo.Size = new Size(162, 27);
            PassBoxTwo.TabIndex = 6;
            PassBoxTwo.TextChanged += Check;
            // 
            // Enter
            // 
            Enter.Location = new Point(117, 355);
            Enter.Name = "Enter";
            Enter.Size = new Size(111, 32);
            Enter.TabIndex = 7;
            Enter.Text = "Регистрация";
            Enter.UseVisualStyleBackColor = true;
            Enter.Click += SignUp;
            // 
            // CheckPass
            // 
            CheckPass.AutoSize = true;
            CheckPass.Location = new Point(266, 225);
            CheckPass.Name = "CheckPass";
            CheckPass.Size = new Size(95, 24);
            CheckPass.TabIndex = 8;
            CheckPass.Text = "Показать";
            CheckPass.UseVisualStyleBackColor = true;
            CheckPass.CheckedChanged += HideShow;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(91, 323);
            label5.Name = "label5";
            label5.Size = new Size(173, 20);
            label5.TabIndex = 9;
            label5.Text = "Пароли не совпадают!";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.ForeColor = SystemColors.HotTrack;
            label6.Location = new Point(143, 390);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 10;
            label6.Text = "Войти";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 186);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 11;
            label7.Text = "label7";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(27, 112);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 12;
            label8.Text = "label8";
            // 
            // RegWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(373, 450);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(CheckPass);
            Controls.Add(Enter);
            Controls.Add(PassBoxTwo);
            Controls.Add(PassBoxOne);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "RegWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegWindow";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox PassBoxOne;
        private TextBox PassBoxTwo;
        private Button Enter;
        private CheckBox CheckPass;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}