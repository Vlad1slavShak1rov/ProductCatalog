using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatalogProduct
{
    public partial class Tables : UserControl
    {
        public Tables()
        {
            InitializeComponent();
            
        }

        [Browsable(true)]
        public string NameProduct
        {
            get => name_product.Text;
            set => name_product.Text = value;
        }

        [Browsable(true)]
        public string DescriptionProduct
        {
            get => description_product.Text;
            set => description_product.Text = value;
        }

        [Browsable(true)]
        public string ProducerProduct
        {
            get => producer_product.Text;
            set => producer_product.Text = value;
        }

        [Browsable(true)]
        public string PriceProduct
        {
            get => price_product.Text;
            set => price_product.Text = value;
        }

        [Browsable(true)]
        public string CountProduct
        {
            get => count_product.Text;
            set => count_product.Text = value;
        }

        [Browsable(true)]
        public Image Image
        {
            get
            {
                return PictureBoxProduct.Image;
            }
            set => PictureBoxProduct.Image = value;
        }
    }
}
