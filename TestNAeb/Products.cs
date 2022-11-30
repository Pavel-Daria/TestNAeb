using System;
using TestNAeb.BaseData;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestNAeb
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            pooulateGrid();
        }
        private void pooulateGrid()
        {
            dataGridView1.Columns.Clear();
            using(SqlConnection conn = new SqlConnection(Connection.connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM products";
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                conn.Close();
            }

            DataGridViewButtonColumn update = new DataGridViewButtonColumn
            {
                Name = "Update",
                Text = "Обновить",
                HeaderText = "Обновить",
                UseColumnTextForButtonValue = true
            };
            dataGridView1.Columns.Add(update);

            DataGridViewButtonColumn delete = new DataGridViewButtonColumn()
            {
                Name = "Delete",
                Text = "Удалить",
                HeaderText = "Удалить",
                UseColumnTextForButtonValue = true
            };
            dataGridView1.Columns.Add(delete);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Update"].Index && e.RowIndex >= 0)
            {
                int n = int.Parse(dataGridView1.CurrentRow.Cells[12].Value.ToString());
                if (new AddUpdate(n).ShowDialog() == DialogResult.Cancel)
                {
                    pooulateGrid();
                }

            }
            if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                int n = int.Parse(dataGridView1.CurrentRow.Cells[12].Value.ToString());
                BaseData.BaseData.DeleteClientById(n);
                pooulateGrid();
            }
        }
    }
}
