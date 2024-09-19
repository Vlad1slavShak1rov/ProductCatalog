namespace ProductCatalog
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PanelProduct = new FlowLayoutPanel();
            Add_Product = new Button();
            label1 = new Label();
            label2 = new Label();
            ComboBoxProduce = new ComboBox();
            label3 = new Label();
            hello = new Label();
            SearchBox = new TextBox();
            label4 = new Label();
            SortComboBox = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // PanelProduct
            // 
            PanelProduct.AutoScroll = true;
            PanelProduct.Location = new Point(0, 168);
            PanelProduct.Name = "PanelProduct";
            PanelProduct.Size = new Size(903, 427);
            PanelProduct.TabIndex = 0;
            // 
            // Add_Product
            // 
            Add_Product.Font = new Font("Segoe UI", 14F);
            Add_Product.Location = new Point(753, 83);
            Add_Product.Name = "Add_Product";
            Add_Product.Size = new Size(141, 41);
            Add_Product.TabIndex = 1;
            Add_Product.Text = "Добавить";
            Add_Product.UseVisualStyleBackColor = true;
            Add_Product.Click += Add_Product_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(725, 133);
            label1.Name = "label1";
            label1.Size = new Size(144, 32);
            label1.TabIndex = 2;
            label1.Text = "Количество";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(129, 133);
            label2.Name = "label2";
            label2.Size = new Size(97, 32);
            label2.TabIndex = 3;
            label2.Text = "Товары";
            // 
            // ComboBoxProduce
            // 
            ComboBoxProduce.FormattingEnabled = true;
            ComboBoxProduce.Items.AddRange(new object[] { "Все производители" });
            ComboBoxProduce.Location = new Point(0, 51);
            ComboBoxProduce.Name = "ComboBoxProduce";
            ComboBoxProduce.Size = new Size(191, 28);
            ComboBoxProduce.TabIndex = 4;
            ComboBoxProduce.TextChanged += UpdatePanel;
            ComboBoxProduce.KeyPress += KeyPressCombox;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 104);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 5;
            label3.Text = "counter items";
            // 
            // hello
            // 
            hello.AutoSize = true;
            hello.Font = new Font("Segoe UI", 10F);
            hello.Location = new Point(703, 10);
            hello.Name = "hello";
            hello.Size = new Size(47, 23);
            hello.TabIndex = 7;
            hello.Text = "hello";
            // 
            // SearchBox
            // 
            SearchBox.Location = new Point(450, 51);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(200, 27);
            SearchBox.TabIndex = 8;
            SearchBox.KeyUp += CheckSearchBox;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(476, 12);
            label4.Name = "label4";
            label4.Size = new Size(148, 20);
            label4.TabIndex = 9;
            label4.Text = "Поиск по названию";
            // 
            // SortComboBox
            // 
            SortComboBox.FormattingEnabled = true;
            SortComboBox.Items.AddRange(new object[] { "Не сортировать", "Сортировать по возрастанию", "Сортировать по убыванию" });
            SortComboBox.Location = new Point(192, 51);
            SortComboBox.Name = "SortComboBox";
            SortComboBox.Size = new Size(252, 28);
            SortComboBox.TabIndex = 10;
            SortComboBox.TextChanged += SortProduct;
            SortComboBox.KeyPress += KeyPressCombox;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 8);
            label5.Name = "label5";
            label5.Size = new Size(120, 40);
            label5.TabIndex = 11;
            label5.Text = "Фильтрация по\r\nпроизводителю";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(227, 12);
            label6.Name = "label6";
            label6.Size = new Size(188, 20);
            label6.TabIndex = 12;
            label6.Text = "Сортировка по названию";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 607);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(SortComboBox);
            Controls.Add(label4);
            Controls.Add(SearchBox);
            Controls.Add(hello);
            Controls.Add(label3);
            Controls.Add(ComboBoxProduce);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Add_Product);
            Controls.Add(PanelProduct);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel PanelProduct;
        private Button Add_Product;
        private Label label1;
        private Label label2;
        private ComboBox ComboBoxProduce;
        private Label label3;
        private Label hello;
        private TextBox SearchBox;
        private Label label4;
        private ComboBox SortComboBox;
        private Label label5;
        private Label label6;
    }
}
