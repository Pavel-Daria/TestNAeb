
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnEntrance_Click(object sender, EventArgs e)
        {
            if (LoginDataWorker.CheckIsLogin(txtLogin.Text, txtPass.Text))
            {
                Form productsForm = new ProductsForm();
                productsForm.ShowDialog();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
