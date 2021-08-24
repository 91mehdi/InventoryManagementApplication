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
    public partial class FormProducts : Form
    {
        public FormProducts()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("data source = (local); initial catalog = InventoryManagementApplication; integrated security = true");
        SqlCommand command = new SqlCommand();

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FormProducts_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            BindingSource bindingSource = new BindingSource();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT GroupName FROM GroupsTable", connection);
            sqlDataAdapter.Fill(dataTable);
            bindingSource.DataSource = dataTable;
            cmb_group.DataSource = bindingSource;
            cmb_group.DisplayMember = "GroupName";
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            command.Connection = connection;
            command.Parameters.Clear();
            command.CommandText = "INSERT INTO ProductsTable(ProductName, GroupName, ProductSerial, ProductUnit, ProductInfo) VALUES (@P_NAME, @G_NAME, @P_SERIAL, @P_UNIT, @P_INFO)";
            //command.Parameters.AddWithValue("@P_CODE", txt_code.Text);
            command.Parameters.AddWithValue("@P_NAME", txt_name.Text);
            command.Parameters.AddWithValue("@G_NAME", cmb_group.Text);
            command.Parameters.AddWithValue("@P_SERIAL", txt_serial.Text);
            command.Parameters.AddWithValue("@P_UNIT", txt_unit.Text);
            command.Parameters.AddWithValue("@P_INFO", txt_info.Text);

            if (!(connection.State == ConnectionState.Open))
            {
                connection.Open();
            }
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("اطلاعات ذخیره شد");
        }

        private void btn_scan_Click(object sender, EventArgs e)
        {
            SqlDataReader sqlDataReader;
            command = new SqlCommand();
            command.Connection = connection;
            command.Parameters.Clear();
            command.CommandText = "SELECT * FROM ProductsTable WHERE ProductCode=@P_CODE";
            command.Parameters.AddWithValue("@P_CODE", txt_code.Text);

            if (!(connection.State == ConnectionState.Open))
            {
                connection.Open();
            }

            sqlDataReader = command.ExecuteReader();
            if (sqlDataReader.Read())
            {
                txt_code.Text = sqlDataReader["ProductCode"].ToString();
                txt_name.Text = sqlDataReader["ProductName"].ToString();
                cmb_group.Text = sqlDataReader["GroupName"].ToString();
                txt_serial.Text = sqlDataReader["ProductSerial"].ToString();
                txt_unit.Text = sqlDataReader["ProductUnit"].ToString();
                txt_info.Text = sqlDataReader["ProductInfo"].ToString();

            }
            else
            {
                MessageBox.Show(" برای کد وارد شده اطلاعاتی پیدا نشد");
                txt_code.Focus();
                txt_code.Text = "";
            }

            connection.Close();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            command.Connection = connection;
            command.Parameters.Clear();
            command.CommandText = "UPDATE ProductsTable SET ProductCode='" + txt_code.Text + "',ProductName='" + txt_name.Text + "',GroupName='" + cmb_group.Text + "',ProductSerial='" + txt_serial.Text + "',ProductUnit='" + txt_unit.Text + "' WHERE ProductInfo=" + txt_info.Text;

            if (!(connection.State == ConnectionState.Open))
            {
                connection.Open();
            }
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("اطلاعات ویرایش شد");
            txt_code.Text = txt_name.Text = cmb_group.Text = txt_serial.Text = txt_unit.Text = txt_info.Text = "";
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
