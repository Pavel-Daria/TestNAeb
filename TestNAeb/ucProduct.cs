using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TestNAeb
{
    public partial class ucProduct : UserControl
    {
        private Product _product;

        public ucProduct(Product product)
        {
            InitializeComponent();

            _product = product;
            LoadData();
        }

        public void LoadData()
        {
            txtName.Text = _product.Name;
            txtDescription.Text = _product.Description;
            txtMaker.Text = _product.Maker;
            txtPrice.Text = _product.Price.ToString();
            txtCount.Text = _product.Count.ToString();

            string imageFromDirectory;

            if (_product.Image != null)
            {
                imageFromDirectory = _product.Image;
            } 
            else
            {
                imageFromDirectory = "picture.png";
            }

            //string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"{imageFromDirectory}");
            //pctImage.Image = Image.FromFile(path);
        }

        private void ucProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
