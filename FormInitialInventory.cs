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
    public partial class FormInitialInventory : Form
    {
        public FormInitialInventory()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("data source = (local); initial catalog = InventoryManagementApplication; integrated security = true");
        SqlCommand command = new SqlCommand();

        void ShowProductReports()
        {
            DataSet dataSet = new DataSet();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = new SqlCommand();
            //DataGridView dataGridView = new DataGridView();
            sqlDataAdapter.SelectCommand.Connection = connection;
            sqlDataAdapter.SelectCommand.CommandText = "SELECT AddCode, InventoryCode, InventoryName, ProductCode, ProductName, ProductSerial, AddLocation, AddEntity, AddImport, AddExport, AddExist FROM AddTable";
            sqlDataAdapter.Fill(dataSet, "AddTable");
            dataGridViewProduct.DataSource = dataSet;
            dataGridViewProduct.DataMember = "AddTable";

            dataGridViewProduct.Columns[0].HeaderText = "کد";
            dataGridViewProduct.Columns[1].HeaderText = "کد کالا";
            dataGridViewProduct.Columns[2].HeaderText = "نام کالا";
            dataGridViewProduct.Columns[3].HeaderText = "سریال کالا";
            dataGridViewProduct.Columns[4].HeaderText = "فقسه";
            dataGridViewProduct.Columns[5].HeaderText = "موجودی اولیه";
            dataGridViewProduct.Columns[6].HeaderText = "ورودی";
            dataGridViewProduct.Columns[7].HeaderText = "خروجی";
            dataGridViewProduct.Columns[8].HeaderText = "موجودی کل";
            dataGridViewProduct.Columns[2].Width = 300;
            dataGridViewProduct.Columns[3].Width = 200;
        }

        void ShowInventoryReports()
        {
            DataSet dataSet = new DataSet();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = new SqlCommand();
            sqlDataAdapter.SelectCommand.Connection = connection;
            sqlDataAdapter.SelectCommand.CommandText = "SELECT InventoryName FROM InventoriesTable";
            sqlDataAdapter.Fill(dataSet, "InventoriesTable");
            dataGridViewInventory.DataSource = dataSet;
            dataGridViewInventory.DataMember = "InventoriesTable";

            dataGridViewInventory.Columns[0].HeaderText = "نام انبار";
            dataGridViewInventory.Columns[0].Width = 150;
        }

        private void FormInitialInventory_Load(object sender, EventArgs e)
        {
            ShowProductReports();
            ShowInventoryReports();
        }

        private void txt_i_name_TextChanged(object sender, EventArgs e)
        {
            DataSet dataSet = new DataSet();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = new SqlCommand();
            sqlDataAdapter.SelectCommand.Connection = connection;
            sqlDataAdapter.SelectCommand.CommandText = "SELECT InventoryName FROM InventoriesTable WHERE InventoryName LIKE '%'+@I_NAME+ '%'";
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@I_NAME", txt_i_name.Text + '%');
            sqlDataAdapter.Fill(dataSet, "InventoriesTable");
            dataGridViewInventory.DataSource = dataSet;
            dataGridViewInventory.DataMember = "InventoriesTable";

            dataGridViewInventory.Columns[0].HeaderText = "نام انبار";
            dataGridViewInventory.Columns[0].Width = 150;
        }

        private void txt_p_name_TextChanged(object sender, EventArgs e)
        {
            DataSet dataSet = new DataSet();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = new SqlCommand();
            //DataGridView dataGridView = new DataGridView();
            sqlDataAdapter.SelectCommand.Connection = connection;
            sqlDataAdapter.SelectCommand.CommandText = "SELECT AddCode, ProductName, ProductSerial, AddLocation, AddImportو AddExportو AddExist FROM AddTable WHERE ProductName LIKE '%' +@P_NAME+ '%'";
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@P_NAME", txt_p_name.Text + "%");
             
            sqlDataAdapter.Fill(dataSet, "AddTable");
            dataGridViewProduct.DataSource = dataSet;
            dataGridViewProduct.DataMember = "AddTable";

            dataGridViewProduct.Columns[0].HeaderText = "کد";
            dataGridViewProduct.Columns[1].HeaderText = "کد کالا";
            dataGridViewProduct.Columns[2].HeaderText = "نام کالا";
            dataGridViewProduct.Columns[3].HeaderText = "سریال کالا";
            dataGridViewProduct.Columns[4].HeaderText = "فقسه";
            dataGridViewProduct.Columns[5].HeaderText = "موجودی اولیه";
            dataGridViewProduct.Columns[6].HeaderText = "ورودی";
            dataGridViewProduct.Columns[7].HeaderText = "خروجی";
            dataGridViewProduct.Columns[8].HeaderText = "موجودی کل";
            dataGridViewProduct.Columns[2].Width = 300;
            dataGridViewProduct.Columns[3].Width = 200;
        }

        private void dataGridViewProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataSet dataSet = new DataSet();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = new SqlCommand();
            //DataGridView dataGridView = new DataGridView();
            sqlDataAdapter.SelectCommand.Connection = connection;
            sqlDataAdapter.SelectCommand.CommandText = "SELECT AddCode, ProductCode, ProductName, ProductSerial, AddLocation, AddEntity, AddImport, AddExport, AddExist FROM AddTable WHERE InventoryName LIKE '%' +@I_NAME+ '%'";
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@I_NAME", dataGridViewInventory.CurrentRow.Cells[0].Value + "%");

            sqlDataAdapter.Fill(dataSet, "AddTable");
            dataGridViewProduct.DataSource = dataSet;
            dataGridViewProduct.DataMember = "AddTable";

            dataGridViewProduct.Columns[0].HeaderText = "کد";
            dataGridViewProduct.Columns[1].HeaderText = "کد کالا";
            dataGridViewProduct.Columns[2].HeaderText = "نام کالا";
            dataGridViewProduct.Columns[3].HeaderText = "سریال کالا";
            dataGridViewProduct.Columns[4].HeaderText = "فقسه";
            dataGridViewProduct.Columns[5].HeaderText = "موجودی اولیه";
            dataGridViewProduct.Columns[6].HeaderText = "ورودی";
            dataGridViewProduct.Columns[7].HeaderText = "خروجی";
            dataGridViewProduct.Columns[8].HeaderText = "موجودی کل";
            dataGridViewProduct.Columns[2].Width = 300;
            dataGridViewProduct.Columns[3].Width = 200;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            int A_CODE = int.Parse(dataGridViewProduct.CurrentRow.Cells[0].Value.ToString());
            command.Connection = connection;
            command.CommandText = "DELETE FROM AddTable WHERE AddCode=" + A_CODE;
            if (!(connection.State == ConnectionState.Open))
            {
                connection.Open();
            }
            command.ExecuteNonQuery();
            connection.Close();
            ShowProductReports();
            MessageBox.Show("حذف انجام شد");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowProductReports();
        }
    }
}
