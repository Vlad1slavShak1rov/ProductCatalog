namespace ProductCatalog
{
    partial class EnterToProgramm
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
            loginBox = new TextBox();
            passBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            label4 = new Label();
            button2 = new Button();
            CheckPass = new CheckBox();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(47, 33);
            label1.Name = "label1";
            label1.Size = new Size(251, 32);
            label1.TabIndex = 0;
            label1.Text = "Добро пожаловать!";
            // 
            // loginBox
            // 
            loginBox.Location = new Point(88, 168);
            loginBox.MaxLength = 15;
            loginBox.Name = "loginBox";
            loginBox.Size = new Size(165, 27);
            loginBox.TabIndex = 1;
            loginBox.TextChanged += CheckLoginBox;
            // 
            // passBox
            // 
            passBox.Location = new Point(88, 247);
            passBox.Name = "passBox";
            passBox.Size = new Size(163, 27);
            passBox.TabIndex = 2;
            passBox.TextChanged += CheckBoxPass;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(141, 145);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 3;
            label2.Text = "Логин";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(141, 224);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 4;
            label3.Text = "Пароль";
            // 
            // button1
            // 
            button1.Location = new Point(125, 318);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "Войти";
            button1.UseVisualStyleBackColor = true;
            button1.Click += EnterPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 359);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 6;
            // 
            // button2
            // 
            button2.Location = new Point(118, 353);
            button2.Name = "button2";
            button2.Size = new Size(110, 29);
            button2.TabIndex = 7;
            button2.Text = "Регистрация";
            button2.UseVisualStyleBackColor = true;
            button2.Click += RegisterClick;
            // 
            // CheckPass
            // 
            CheckPass.AutoSize = true;
            CheckPass.Location = new Point(115, 278);
            CheckPass.Name = "CheckPass";
            CheckPass.Size = new Size(115, 24);
            CheckPass.TabIndex = 9;
            CheckPass.Text = "Посмотреть";
            CheckPass.UseVisualStyleBackColor = true;
            CheckPass.CheckedChanged += HideShowPass;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(75, 88);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 10;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 205);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 11;
            label6.Text = "label6";
            // 
            // EnterToProgramm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 473);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(CheckPass);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(passBox);
            Controls.Add(loginBox);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "EnterToProgramm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Учёт продуктов ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox loginBox;
        private TextBox passBox;
        private Label label2;
        private Label label3;
        private Button button1;
        private Label label4;
        private Button button2;
        private CheckBox CheckPass;
        private Label label5;
        private Label label6;
    }
}