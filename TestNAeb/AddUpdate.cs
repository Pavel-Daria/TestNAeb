using System;
using TestNAeb.BaseData;
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
    
    public partial class AddUpdate : Form
    {
        private int clientId;
        public AddUpdate(int id)
        {
            InitializeComponent();
            this.clientId = id;
        }
        
        private void AddUpdate_Load(object sender, EventArgs e)
        {
            Product client =BaseData.BaseData.GetClientById(clientId);
            TextBoxId.Text = client.Articul;
            NameBox.Text = client.Name;
        }
    }
}
