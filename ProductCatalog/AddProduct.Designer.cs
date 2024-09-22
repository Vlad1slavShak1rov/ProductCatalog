namespace ProductCatalog
{
    partial class AddProduct
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
            label5 = new Label();
            NameBox = new TextBox();
            DescriptionBox = new TextBox();
            ProducerBox = new TextBox();
            AddButton = new Button();
            PictureBoxAdd = new PictureBox();
            AddPicture = new Button();
            CountBox = new NumericUpDown();
            PriceBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)PictureBoxAdd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CountBox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 21);
            label1.Name = "label1";
            label1.Size = new Size(129, 20);
            label1.TabIndex = 0;
            label1.Text = "Название товара";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 57);
            label2.Name = "label2";
            label2.Size = new Size(131, 20);
            label2.TabIndex = 1;
            label2.Text = "Описание товара";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 93);
            label3.Name = "label3";
            label3.Size = new Size(118, 20);
            label3.TabIndex = 2;
            label3.Text = "Производитель";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 135);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 3;
            label4.Text = "Цена";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 175);
            label5.Name = "label5";
            label5.Size = new Size(90, 20);
            label5.TabIndex = 4;
            label5.Text = "Количество";
            // 
            // NameBox
            // 
            NameBox.Location = new Point(146, 21);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(180, 27);
            NameBox.TabIndex = 5;
            // 
            // DescriptionBox
            // 
            DescriptionBox.Location = new Point(146, 54);
            DescriptionBox.Name = "DescriptionBox";
            DescriptionBox.Size = new Size(180, 27);
            DescriptionBox.TabIndex = 6;
            // 
            // ProducerBox
            // 
            ProducerBox.Location = new Point(146, 93);
            ProducerBox.Name = "ProducerBox";
            ProducerBox.Size = new Size(180, 27);
            ProducerBox.TabIndex = 7;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(120, 386);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(94, 29);
            AddButton.TabIndex = 10;
            AddButton.Text = "Добавить";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButtonClick;
            // 
            // PictureBoxAdd
            // 
            PictureBoxAdd.Location = new Point(12, 209);
            PictureBoxAdd.Name = "PictureBoxAdd";
            PictureBoxAdd.Size = new Size(161, 144);
            PictureBoxAdd.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBoxAdd.TabIndex = 11;
            PictureBoxAdd.TabStop = false;
            // 
            // AddPicture
            // 
            AddPicture.Location = new Point(179, 279);
            AddPicture.Name = "AddPicture";
            AddPicture.Size = new Size(136, 36);
            AddPicture.TabIndex = 12;
            AddPicture.Text = "Добавить фото";
            AddPicture.UseVisualStyleBackColor = true;
            AddPicture.Click += AddPicture_Click;
            // 
            // CountBox
            // 
            CountBox.Location = new Point(146, 168);
            CountBox.Name = "CountBox";
            CountBox.Size = new Size(180, 27);
            CountBox.TabIndex = 14;
            // 
            // PriceBox
            // 
            PriceBox.Location = new Point(146, 132);
            PriceBox.Name = "PriceBox";
            PriceBox.Size = new Size(180, 27);
            PriceBox.TabIndex = 15;
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 450);
            Controls.Add(PriceBox);
            Controls.Add(CountBox);
            Controls.Add(AddPicture);
            Controls.Add(PictureBoxAdd);
            Controls.Add(AddButton);
            Controls.Add(ProducerBox);
            Controls.Add(DescriptionBox);
            Controls.Add(NameBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AddProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавить товар";
            ((System.ComponentModel.ISupportInitialize)PictureBoxAdd).EndInit();
            ((System.ComponentModel.ISupportInitialize)CountBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox NameBox;
        private TextBox DescriptionBox;
        private TextBox ProducerBox;
        private Button AddButton;
        private PictureBox PictureBoxAdd;
        private Button AddPicture;
        private NumericUpDown CountBox;
        private TextBox PriceBox;
    }
}