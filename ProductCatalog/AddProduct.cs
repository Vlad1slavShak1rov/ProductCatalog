using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ScrollBar;

namespace ProductCatalog
{
    public partial class AddProduct : Form
    {
        string WayToPic = "Pictures\\";
        public event EventHandler<DataEventArgs> DataTransferEvent;
        public AddProduct()
        {
            InitializeComponent();
        }

        private void CheckCout(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) { e.Handled = true; }
        }

        private void AddButtonClick(object sender, EventArgs e)
        {
            decimal Price = 0;
            string Name = NameBox.Text;
            string Description = DescriptionBox.Text;
            string Producer = ProducerBox.Text;
            using var db = new ProductDataBase();

            if (string.IsNullOrWhiteSpace(PriceBox.Text) || !decimal.TryParse(PriceBox.Text, out decimal price))
            {
                MessageBox.Show("Введите цену!");
                return;
            }
            else Price = decimal.Parse(PriceBox.Text);


            if (!string.IsNullOrWhiteSpace(Name) && !string.IsNullOrWhiteSpace(Description)
                && !string.IsNullOrWhiteSpace(Producer) && CheckDataBase(Name, Producer))
            {
                db.products.Add(new Product
                {
                    NameProduct = Name,
                    Description = Description,
                    Price = Price,
                    ProduceProduct = Producer,
                    Count = int.Parse(CountBox.Text),
                    Image = WayToPic
                });
                db.SaveChanges();

                DataEventArgs dataEventArgs = new DataEventArgs(Name, Description, Producer, Price, int.Parse(CountBox.Text), WayToPic);

                DataTransferEvent?.Invoke(this, dataEventArgs);
                NameBox.Text = DescriptionBox.Text = ProducerBox.Text = PriceBox.Text = CountBox.Text = null;
                PictureBoxAdd.Image = null;
                MessageBox.Show("Успешно!");
                this.Close();

            }
            else MessageBox.Show("У вас есть незаполненные поля!");
        }


        private void AddPicture_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif|All Files|*.*";
                openFileDialog.Title = "Выберите изображение";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imageName = Path.GetFileName(openFileDialog.FileName);
                    string projectDirectory = Directory.GetCurrentDirectory() + "\\Pictures";
                    string destinationPath = Path.Combine(projectDirectory, imageName);
                    WayToPic = projectDirectory + "\\" + imageName;
                    File.Copy(imageName, destinationPath, true);
                    PictureBoxAdd.Image = Image.FromFile(destinationPath);
                }
            }

        }

        private bool CheckDataBase(string NameProduct, string Produce)
        {
            using (var productDataBase = new ProductDataBase())
            {
                var products = productDataBase.products.ToList();
                Product productData = null;
                foreach (var product in products)
                {
                    if(product.NameProduct.ToLower() == NameProduct.ToLower() && 
                        product.ProduceProduct.ToLower() == Produce.ToLower())
                    {
                        productData = product;
                        break;
                    }
                }


                if (productData != null)
                {
                    if (productData.Count > 0)
                    {
                        MessageBox.Show("Этот элемент уже есть на складе!");
                        return false;
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Этот элемент есть на складе, но его количество" +
                            "равно нулю.\nДобавить?", "Внимание!", MessageBoxButtons.OKCancel);
                        if (result == DialogResult.OK)
                        {
                            productDataBase.products.Remove(productData);
                            productDataBase.SaveChanges();
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    return true;
                }
            }
        }


    }


    public class DataEventArgs : EventArgs
    {
        public string NameBox { get; set; }
        public string DescriptionBox { get; set; }
        public string ProducerBox { get; set; }
        public decimal PriceBox { get; set; }
        public int CountBox { get; set; }
        public string ImagePath { get; set; }
        public DataEventArgs(string NameBox, string DescriptionBox, string ProducerBox, decimal PriceBox, int count, string image_path)
        {
            this.NameBox = NameBox;
            this.DescriptionBox = DescriptionBox;
            this.ProducerBox = ProducerBox;
            this.PriceBox = PriceBox;
            CountBox = count;
            ImagePath = image_path;
        }
    }
}
