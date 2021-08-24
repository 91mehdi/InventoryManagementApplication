using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InventoryManagementApplication
{
    public partial class FormProductsReport : Form
    {
        public FormProductsReport()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("data source = (local); initial catalog = InventoryManagementApplication; integrated security = true");
        SqlCommand command = new SqlCommand();

        void ShowReports()
        {
            DataSet dataSet = new DataSet();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = new SqlCommand();
            //DataGridView dataGridView = new DataGridView();
            sqlDataAdapter.SelectCommand.Connection = connection;
            sqlDataAdapter.SelectCommand.CommandText = "SELECT * FROM ProductsTable";
            sqlDataAdapter.Fill(dataSet, "ProductsTable");

            dataGridView.DataSource = dataSet;
            dataGridView.DataMember = "ProductsTable";
            dataGridView.Columns[0].HeaderText = "کد";
            dataGridView.Columns[1].HeaderText = "گروه کالا";
            dataGridView.Columns[2].HeaderText = "نام کالا";
            dataGridView.Columns[3].HeaderText = "سریال کالا";
            dataGridView.Columns[4].HeaderText = "واحد";
            dataGridView.Columns[5].HeaderText = "توضیحات";
            dataGridView.Columns[5].Width = 300;
            dataGridView.Columns[3].Width = 200;
        }

        private void FormProductsReport_Load(object sender, EventArgs e)
        {
            ShowReports();
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {
            DataSet dataSet = new DataSet();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = new SqlCommand();
            //DataGridView dataGridView = new DataGridView();
            sqlDataAdapter.SelectCommand.Connection = connection;
            sqlDataAdapter.SelectCommand.CommandText = "SELECT * FROM ProductsTable WHERE ProductName LIKE '%'+@P_NAME+ '%'";
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@P_NAME", txt_name.Text + '%');
            sqlDataAdapter.Fill(dataSet, "ProductsTable");
            dataGridView.DataSource = dataSet;
            dataGridView.DataMember = "ProductsTable";

            dataGridView.Columns[0].HeaderText = "کد";
            dataGridView.Columns[1].HeaderText = "گروه کالا";
            dataGridView.Columns[2].HeaderText = "نام کالا";
            dataGridView.Columns[3].HeaderText = "سریال کالا";
            dataGridView.Columns[4].HeaderText = "واحد";
            dataGridView.Columns[5].HeaderText = "توضیحات";
            dataGridView.Columns[5].Width = 300;
            dataGridView.Columns[3].Width = 200;

        }

        private void cmb_group_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet dataSet = new DataSet();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = new SqlCommand();
            //DataGridView dataGridView = new DataGridView();
            sqlDataAdapter.SelectCommand.Connection = connection;
            sqlDataAdapter.SelectCommand.CommandText = "SELECT * FROM ProductsTable WHERE GroupName LIKE '%'+@G_NAME+ '%'";
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@G_NAME", cmb_group.Text + '%');
            sqlDataAdapter.Fill(dataSet, "ProductsTable");
            dataGridView.DataSource = dataSet;
            dataGridView.DataMember = "ProductsTable";
            
            dataGridView.Columns[0].HeaderText = "کد";
            dataGridView.Columns[1].HeaderText = "گروه کالا";
            dataGridView.Columns[2].HeaderText = "نام کالا";
            dataGridView.Columns[3].HeaderText = "سریال کالا";
            dataGridView.Columns[4].HeaderText = "واحد";
            dataGridView.Columns[5].HeaderText = "توضیحات";
            dataGridView.Columns[5].Width = 300;
            dataGridView.Columns[3].Width = 200;
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            int P_CODE = int.Parse(dataGridView.CurrentRow.Cells[0].Value.ToString());
            command.Connection = connection;
            command.Parameters.Clear();
            command.CommandText = "DELETE FROM ProductsTable WHERE ProductCode=@P_CODE";
            command.Parameters.AddWithValue("@P_CODE", P_CODE);

            if (!(connection.State == ConnectionState.Open))
            {
                connection.Open();
            }
            command.ExecuteNonQuery();
            connection.Close();
            ShowReports();
            MessageBox.Show("اطلاعات حذف شد");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
