using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TestNAeb
{
    public partial class ProductsForm : Form
    {
        private List<Product> _products;

        private int _totalProducts;
        private int _currentProducts;

        public ProductsForm()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            txtName.Text = AuthorizedUser.FIO;

            flowProducts.Controls.Clear();
            _products = ProductsDataWorker.GetProductsListing();

            FillFilters();
            FillFlow();

            _totalProducts = _products.Count;
            txtTotal.Text = _totalProducts.ToString();
        }

        public void FillFilters()
        {
            List<string> filters = ProductsDataWorker.GetMakers();

            foreach(string filter in filters)
            {
                cmbFilter.Items.Add(filter);
            }
        }

        public void FillFlow()
        {
            foreach (Product product in _products)
            {
                UserControl ucProduct = new ucProduct(product);
                flowProducts.Controls.Add(ucProduct);
            }

            _currentProducts = _products.Count;
            txtCurrentProducts.Text = _currentProducts.ToString();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            flowProducts.Controls.Clear();
            _products = ProductsDataWorker.GetProductListSearched(txtSearch.Text);

            FillFlow();
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowProducts.Controls.Clear();
            _products = ProductsDataWorker.GetProductListFiltered(cmbFilter.Text);

            FillFlow();
        }

        private void cmbSorting_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowProducts.Controls.Clear();
            _products = ProductsDataWorker.GetProductListSorted(cmbSorting.Text);

            FillFlow();
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Products a = new Products();
            a.Show();
        }
    }
}
