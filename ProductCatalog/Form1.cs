using CatalogProduct;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.VisualBasic.Logging;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Windows.Forms;
using DataBase;
namespace ProductCatalog
{
    public partial class Form1 : Form
    {
        AddProduct product = new AddProduct();
        int TotalData = 0;
        public Form1(string login)
        {
            InitializeComponent();
            InitData();
            ComboBoxProduce.Text = "Все производители";
            SortComboBox.Text = "Не сортировать";
            hello.Text = $"Приветствую, {login}";
            product.DataTransferEvent += AddProductEvent;
        }
        private void AddProductEvent(object sender, DataEventArgs e)
        {
            Tables table = new Tables();


            table.NameProduct = e.NameBox;
            table.DescriptionProduct = e.DescriptionBox;
            table.ProducerProduct = e.ProducerBox;
            table.PriceProduct = e.PriceBox.ToString() + " $";
            table.CountProduct = e.CountBox.ToString() + " шт.";
            if (e.ImagePath == string.Empty) table.Image = Image.FromFile("C:\\pic\\def_pic.png");
            else table.Image = Image.FromFile(e.ImagePath);

            AddProducerToComboBox(e.ProducerBox);
            PanelProduct.Controls.Clear();
            InitData();
            TotalData = PanelProduct.Controls.Count;
            label3.Text = $"Загружено {TotalData} из {TotalData}";
        }



        private void InitData()
        {

            using (var productDataBase = new ProductDataBase())
            {
                var products = productDataBase.products.ToList();
                foreach (var product in products)
                {
                    var table = CreateProductTable(product);
                    if (!ComboBoxProduce.Items.Contains(product.ProduceProduct))
                        ComboBoxProduce.Items.Add(product.ProduceProduct);
                    PanelProduct.Controls.Add(table);
                }
            }
            TotalData = PanelProduct.Controls.Count;
            label3.Text = $"Загружено {TotalData} из {TotalData}";
        }

        private void UpdatePanel(object sender, EventArgs e) => Filtration();

        private void Filtration()
        {
            int current_counter = 0;

            using (var productDataBase = new ProductDataBase())
            {
                PanelProduct.Controls.Clear();
                if (ComboBoxProduce.Text == "Все производители")
                {
                    InitData();
                    return;
                }

                var products = productDataBase.products
                    .Where(p => p.ProduceProduct == ComboBoxProduce.Text)
                    .ToList();

                foreach (var product in products)
                {
                    current_counter++;
                    var table = CreateProductTable(product);
                    PanelProduct.Controls.Add(table);
                }
                label3.Text = $"Загружено {current_counter} из {TotalData}";
            }
        }
        private Tables CreateProductTable(Product product)
        {
            Tables table = new Tables
            {
                NameProduct = product.NameProduct,
                DescriptionProduct = product.Description,
                ProducerProduct = product.ProduceProduct,
                PriceProduct = product.Price.ToString() + " $",
                CountProduct = product.Count.ToString() + " шт.",
                Image = string.IsNullOrEmpty(product.Image) ?
                        Image.FromFile("C:\\pic\\def_pic.png") :
                        Image.FromFile(product.Image)
            };
            if (table.CountProduct == "0 шт.") table.BackColor = Color.Gray;
            else table.BackColor = Color.LightSkyBlue;
            return table;
        }

        private void CheckFilterAndSort()
        {
            string query = SearchBox.Text.ToLower();

            if (query == string.Empty && SortComboBox.Items[0] == SortComboBox.Text)
            {
                PanelProduct.Controls.Clear();
                InitData(); return;
            }


            int current_counter = 0;

            if (!string.IsNullOrEmpty(query) || SortComboBox.Items[0] != SortComboBox.Text)
            {
                PanelProduct.Controls.Clear();
                var prods = Sort();

                List<Product> filteredProducts = new List<Product>();

                foreach (var product in prods)
                {
                    bool matchesName = product.NameProduct.ToLower().StartsWith(query);

                    if ((matchesName && product.ProduceProduct.Contains(ComboBoxProduce.Text)) ||
                        (ComboBoxProduce.Text == "Все производители" && matchesName))
                    {
                        filteredProducts.Add(product);
                    }
                }


                foreach (var product in filteredProducts)
                {
                    current_counter++;
                    var table = CreateProductTable(product);
                    PanelProduct.Controls.Add(table);
                }

                label3.Text = $"Загружено {current_counter} из {TotalData}";


            }

        }

        private void AddProducerToComboBox(string producer)
        {
            if (!ComboBoxProduce.Items.Contains(producer))
            {
                ComboBoxProduce.Items.Add(producer);
            }
        }

        private List<Product> Sort()
        {
            using (var productDataBase = new ProductDataBase())
            {
                if (SortComboBox.Text == SortComboBox.Items[0].ToString())
                {
                    return productDataBase.products.ToList();
                }
                else if (SortComboBox.Text == SortComboBox.Items[1].ToString())
                {
                    return productDataBase.products.OrderBy(p => p.NameProduct).ToList();
                }
                else if (SortComboBox.Text == SortComboBox.Items[2].ToString())
                {
                    return productDataBase.products.OrderByDescending(p => p.NameProduct).ToList();
                }
                else
                {
                    return productDataBase.products.ToList();
                }
            }
        }


        private void SortProduct(object sender, EventArgs e)
        {
            CheckFilterAndSort();
        }


        private void CheckSearchBox(object sender, KeyEventArgs e) => CheckFilterAndSort();
        private void KeyPressCombox(object sender, KeyPressEventArgs e) => e.Handled = true;

        private void Add_Product_Click(object sender, EventArgs e) => product.ShowDialog();

        private void ExitClick(object sender, EventArgs e)
        {
            this.Close();
            (new EnterToProgramm()).Show();
        }
    }
}
