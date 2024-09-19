namespace CatalogProduct
{
    partial class Tables
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            PictureBoxProduct = new PictureBox();
            panel1 = new Panel();
            price_product = new Label();
            producer_product = new Label();
            description_product = new Label();
            name_product = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            count_product = new Label();
            ((System.ComponentModel.ISupportInitialize)PictureBoxProduct).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // PictureBoxProduct
            // 
            PictureBoxProduct.Location = new Point(3, 3);
            PictureBoxProduct.Name = "PictureBoxProduct";
            PictureBoxProduct.Size = new Size(292, 255);
            PictureBoxProduct.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBoxProduct.TabIndex = 0;
            PictureBoxProduct.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(price_product);
            panel1.Controls.Add(producer_product);
            panel1.Controls.Add(description_product);
            panel1.Controls.Add(name_product);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Segoe UI", 12F);
            panel1.Location = new Point(301, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(478, 138);
            panel1.TabIndex = 1;
            // 
            // price_product
            // 
            price_product.AutoSize = true;
            price_product.Font = new Font("Segoe UI", 12F);
            price_product.Location = new Point(72, 101);
            price_product.Name = "price_product";
            price_product.Size = new Size(133, 28);
            price_product.TabIndex = 7;
            price_product.Text = "price_product";
            // 
            // producer_product
            // 
            producer_product.AutoSize = true;
            producer_product.Font = new Font("Segoe UI", 12F);
            producer_product.Location = new Point(169, 73);
            producer_product.Name = "producer_product";
            producer_product.Size = new Size(170, 28);
            producer_product.TabIndex = 6;
            producer_product.Text = "producer_product";
            // 
            // description_product
            // 
            description_product.AutoSize = true;
            description_product.Font = new Font("Segoe UI", 12F);
            description_product.Location = new Point(117, 44);
            description_product.Name = "description_product";
            description_product.Size = new Size(188, 28);
            description_product.TabIndex = 5;
            description_product.Text = "description_product";
            // 
            // name_product
            // 
            name_product.AutoSize = true;
            name_product.Font = new Font("Segoe UI", 12F);
            name_product.Location = new Point(227, 12);
            name_product.Name = "name_product";
            name_product.Size = new Size(138, 28);
            name_product.TabIndex = 4;
            name_product.Text = "name_product";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(3, 101);
            label4.Name = "label4";
            label4.Size = new Size(63, 28);
            label4.TabIndex = 3;
            label4.Text = "Цена:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(3, 73);
            label3.Name = "label3";
            label3.Size = new Size(160, 28);
            label3.TabIndex = 2;
            label3.Text = "Производитель:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(3, 44);
            label2.Name = "label2";
            label2.Size = new Size(108, 28);
            label2.TabIndex = 1;
            label2.Text = "Описание:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(3, 12);
            label1.Name = "label1";
            label1.Size = new Size(228, 28);
            label1.TabIndex = 0;
            label1.Text = "Наименования товара: ";
            // 
            // panel2
            // 
            panel2.Controls.Add(count_product);
            panel2.Location = new Point(804, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(138, 138);
            panel2.TabIndex = 2;
            // 
            // count_product
            // 
            count_product.AutoSize = true;
            count_product.Font = new Font("Segoe UI", 12F);
            count_product.Location = new Point(-2, 49);
            count_product.Name = "count_product";
            count_product.Size = new Size(140, 28);
            count_product.TabIndex = 0;
            count_product.Text = "count_product";
            // 
            // Tables
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(PictureBoxProduct);
            Name = "Tables";
            Size = new Size(929, 261);
            ((System.ComponentModel.ISupportInitialize)PictureBoxProduct).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox PictureBoxProduct;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label description_product;
        private Label name_product;
        private Label label4;
        private Label label3;
        private Label price_product;
        private Label producer_product;
        private Panel panel2;
        private Label count_product;
    }
}
